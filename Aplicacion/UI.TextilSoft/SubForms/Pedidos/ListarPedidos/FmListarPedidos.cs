using Contracts.Controllers;
using Domain.Entities;
using Domain.GenericEntity;
using Domain.Models;
using FontAwesome.Sharp;
using MailKit.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UI.TextilSoft.Controllers;
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools.FormsTools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI.TextilSoft.SubForms.Pedidos.ListarPedidos
{
    public partial class FmListarPedidos : Form
    {
        private readonly IControllerFactory _factory;
        private bool IsPreviousActive;
        private string LastColumn;
        private int Pagecount, PageIndex, TotalPages;
        private bool FirstTime, isLastPage, isFirstPage;
        private bool MantenerFiltroFechas, DateChanged;
        private IconButton LastIconButton;

        private int IndexBtnPrimero, IndexBtnSegundo, IndexBtnTercero;

        public FmListarPedidos(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }
        public void ObtenerTodosLosPedidosConFiltro(string searchValue)
        {
            try
            {
                var pedidos = _factory.Use<IPedidosController>().ObtenerListaPedidos(Pagecount).List;
                var resultado = pedidos.Where(p =>
                                p.NumeroPedido.ToString().Contains(searchValue) ||
                                p.TotalPago.HasValue && p.TotalPago.Value.ToString().Contains(searchValue) ||
                                p.Fecha.HasValue && p.Fecha.Value.ToString().Contains(searchValue) ||
                                p.Seña.HasValue && p.Seña.Value.ToString().Contains(searchValue) ||
                                p.EstadoPedido.ToString().Contains(searchValue) ||
                                p.AtendidoPor.Contains(searchValue) ||
                                p.Cliente.Contains(searchValue) ||
                                p.ID_Pedido.ToString().Contains(searchValue)
                                ).ToList();
                GrillaPedidos.DataSource = resultado;
                TotalPages = (int)Math.Ceiling(resultado.Count() / (double)Pagecount);
                btnFinal.Text = "..." + TotalPages.ToString();
                PageIndex = 1;

            }
            catch (Exception ex)
            {

            }
        }

        private Expression<Func<ListarPedidosEntity, bool>> Filtro(string nombreFiltro = "Fecha", bool IsNextPage = false)
        {
            Expression<Func<ListarPedidosEntity, bool>> filterExpression = null;
            switch (nombreFiltro)
            {
                case "Fecha":
                    if (MantenerFiltroFechas || IsNextPage && DateChanged)
                    {
                        filterExpression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
                    }
                    break;
                default:
                    // Filtro por defecto
                    filterExpression = x => x.ID_Pedido > 0;
                    break;
            }
            return filterExpression;
        }

        private void FmListarPedidos_Load(object sender, EventArgs e)
        {
            //Select the first item cbox
            DateChanged = false;
            tbMantenerFiltro.Checked = false;
            MantenerFiltroFechas = false;
            FirstTime = true;
            cboxCantidadRegistros.SelectedIndex = 0;
            Pagecount = Convert.ToInt32(cboxCantidadRegistros.SelectedItem);
            PageIndex = 1;

            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;

            string orderBy = "ID_Pedido";
            LastColumn = orderBy;
            var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(), orderBy, IsPreviousActive);
            //Set total pages to btnFinal
            btnFinal.Text = "..." + PedidosPaginado.TotalPages.ToString();
            TotalPages = PedidosPaginado.TotalPages;
            GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
            ListarPedidosEntity entity = new();

            foreach (DataGridViewColumn item in GrillaPedidos.Columns)
            {
                IconButton button = new();
                button.ForeColor = Color.White;
                button.IconChar = IconChar.Sort;
                button.IconColor = Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.IconSize = 18;
                button.Size = new Size(20, 20);
                if (item.Index != GrillaPedidos.Columns.Count - 1) //La primer columna es de index, y la última no tiene una adelante{
                {
                    Point ColumnLocation = GrillaPedidos.GetColumnDisplayRectangle(item.DisplayIndex + 1, false).Location;
                    button.Location = new Point(ColumnLocation.X - 15, ColumnLocation.Y);
                }
                else
                {
                    Point ColumnLocation = GrillaPedidos.GetColumnDisplayRectangle(item.DisplayIndex, false).Location;
                    button.Location = new Point(ColumnLocation.X + 90, ColumnLocation.Y);
                }
                //Add event click
                button.Click += new EventHandler((s, e) => OrdenarGrilla(s, e, item.Name, button));

                GrillaPedidos.Controls.Add(button);
                VerificarPaginas();
            }
            ActualizarBotones();
        }

        public void OrdenarGrilla(object sender, EventArgs e, string ColumnName, IconButton button)
        {
            string orderBy = ColumnName;
            if (LastColumn == ColumnName && !IsPreviousActive)
            {
                IsPreviousActive = true;
                if (button.IconColor == Color.MediumSlateBlue)
                    button.IconColor = Color.White;
                else
                    button.IconColor = Color.MediumSlateBlue;
            }
            else
            {
                if(LastColumn != ColumnName)
                {
                    button.IconColor = Color.MediumSlateBlue;
                    LastIconButton.IconColor = Color.White;
                    IsPreviousActive = false;
                }
                else
                {
                    IsPreviousActive = false;
                    button.IconColor = Color.White;
                }
            }

            LastIconButton = button;
            LastColumn = ColumnName;
            GrillaPedidos.DataSource = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(), orderBy, IsPreviousActive).List.ToList();
        }

        private void fmDateDesde_ValueChanged(object sender, EventArgs e)
        {
            if (fmDateDesde.Value > fmDateHasta.Value || fmDateDesde.Value > DateTime.Now)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de fecha", "La fecha desde no puede ser superior a la fecha hasta o a la fecha actual", centerPosition);
                fmMessageBox.ShowDialog();
                fmDateDesde.Value = fmDateHasta.Value;
                //Sacar un minuto al datetime
                fmDateDesde.Value = fmDateDesde.Value.AddMinutes(-1);
            }
            else
            {
                DateChanged = true;
                //Use Expression func with date
                Expression<Func<ListarPedidosEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
                var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, expression, LastColumn, IsPreviousActive);
                btnFinal.Text = "..." + PedidosPaginado.TotalPages.ToString();
                TotalPages = PedidosPaginado.TotalPages;
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                if (TotalPages > 2)
                {
                    PageIndex = TotalPages;
                    IndexBtnPrimero = TotalPages - 2;
                    IndexBtnSegundo = TotalPages - 1;
                    IndexBtnTercero = TotalPages;
                }
                else
                {
                    IndexBtnPrimero = 1;
                    IndexBtnSegundo = 2;
                    IndexBtnTercero = 3;
                }
                PageIndex = 1;
                VerificarPaginas();
                ActualizarBotones();
            }
        }

        private void fmDateHasta_ValueChanged(object sender, EventArgs e)
        {
            if (fmDateHasta.Value < fmDateDesde.Value)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de fecha", "La fecha hasta no puede ser inferior a la fecha desde", centerPosition);
                fmMessageBox.ShowDialog();
                fmDateHasta.Value = DateTime.Now;
                fmDateHasta.Value = fmDateDesde.Value.AddMinutes(1);
            }
            else
            {
                DateChanged = true;
                //Use Expression func with date
                Expression<Func<ListarPedidosEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
                var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, expression, LastColumn, IsPreviousActive);
                btnFinal.Text = "..." + PedidosPaginado.TotalPages.ToString();
                TotalPages = PedidosPaginado.TotalPages;
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                if (TotalPages > 2)
                {
                    IndexBtnPrimero = TotalPages - 2;
                    IndexBtnSegundo = TotalPages - 1;
                    IndexBtnTercero = TotalPages;
                }
                else
                {
                    IndexBtnPrimero = 1;
                    IndexBtnSegundo = 2;
                    IndexBtnTercero = 3;
                }
                PageIndex = 1;
                VerificarPaginas();
                ActualizarBotones();
            }
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            GrillaPedidos.DataSource = _factory.Use<IPedidosController>().ObtenerPedidos(1, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;
            ActualizarBotones();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            GrillaPedidos.DataSource = _factory.Use<IPedidosController>().ObtenerPedidos(TotalPages, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            if (TotalPages > 2)
            {
                PageIndex = TotalPages;
                IndexBtnPrimero = TotalPages - 2;
                IndexBtnSegundo = TotalPages - 1;
                IndexBtnTercero = TotalPages;
            }
            PageIndex = TotalPages;
            ActualizarBotones();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (PageIndex < TotalPages)
            {
                if (PageIndex == IndexBtnTercero)
                {
                    IndexBtnPrimero++;
                    IndexBtnSegundo++;
                    IndexBtnTercero++;
                }
                PageIndex++;
                GrillaPedidos.DataSource = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            }
            ActualizarBotones();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (PageIndex > 1)
            {
                if (PageIndex == IndexBtnPrimero)
                {
                    IndexBtnPrimero--;
                    IndexBtnSegundo--;
                    IndexBtnTercero--;
                }
                PageIndex--;
                GrillaPedidos.DataSource = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            }
            ActualizarBotones();
        }

        private void GrillaPedidos_DataSourceChanged(object sender, EventArgs e)
        {
            GrillaPedidos.Height = GrillaPedidos.RowTemplate.Height * (GrillaPedidos.Rows.Count + 1);
            panelPaginado.Location = new Point(panelPaginado.Location.X, GrillaPedidos.Location.Y + GrillaPedidos.Height + 10);
        }

        private void cboxCantidadRegistros_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (FirstTime)
            {
                Pagecount = Convert.ToInt32(cboxCantidadRegistros.SelectedItem);
                FirstTime = false;
            }
            else
            {
                Pagecount = Convert.ToInt32(cboxCantidadRegistros.SelectedItem);
                var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(), LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                TotalPages = PedidosPaginado.TotalPages;
                btnFinal.Text = "..." + PedidosPaginado.TotalPages.ToString();
                PageIndex = 1;
                ActualizarBotones();
                VerificarPaginas();
            }

            if (cboxCantidadRegistros.SelectedIndex == 2)
            {
                GrillaPedidos.Height = GrillaPedidos.RowTemplate.Height * (GrillaPedidos.Rows.Count + 1);
                panelPaginado.Location = new Point(panelPaginado.Location.X, GrillaPedidos.Location.Y + GrillaPedidos.Height + 10);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (PageIndex == 1 || btnPrimero.Text.ToString() == "1")
            {
                isFirstPage = true;
                PageIndex = IndexBtnPrimero;
                var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                btnAnterior.Enabled = false;
            }
            if (!isFirstPage)
            {
                IndexBtnPrimero -= 1;
                IndexBtnSegundo -= 1;
                IndexBtnTercero -= 1;
                PageIndex = IndexBtnPrimero;
                var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                btnAnterior.Enabled = true;
            }
            ActualizarBotones();
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            PageIndex = IndexBtnSegundo;
            GrillaPedidos.DataSource = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            ActualizarBotones();
        }

        private void btnTercero_Click(object sender, EventArgs e)
        {
            if (PageIndex == TotalPages || Convert.ToInt32(btnFinal.Text.Replace("...", "")) == TotalPages)
            {
                isLastPage = true;
                PageIndex = IndexBtnTercero;
                var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
            }
            if (!isLastPage)
            {
                IndexBtnPrimero = IndexBtnSegundo;
                IndexBtnSegundo = IndexBtnTercero;
                IndexBtnTercero++;
                PageIndex = IndexBtnTercero;
                var PedidosPaginado = _factory.Use<IPedidosController>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
            }
            ActualizarBotones();
        }

        private void ActualizarBotones()
        {
            btnPrimero.Text = IndexBtnPrimero.ToString();
            btnSegundo.Text = IndexBtnSegundo.ToString();
            btnTercero.Text = IndexBtnTercero.ToString();
            if (PageIndex == TotalPages)
                btnSiguiente.Enabled = false;
            else
                btnSiguiente.Enabled = true;

            if (PageIndex == 1)
                btnAnterior.Enabled = false;
            else
                btnAnterior.Enabled = true;

            if (btnPrimero.Text == PageIndex.ToString())
                btnPrimero.BackColor = Color.FromArgb(40, 40, 40);
            else
                btnPrimero.BackColor = Color.FromArgb(32, 30, 45);

            if (btnSegundo.Text == PageIndex.ToString())
                btnSegundo.BackColor = Color.FromArgb(40, 40, 40);
            else
                btnSegundo.BackColor = Color.FromArgb(32, 30, 45);

            if (btnTercero.Text == PageIndex.ToString())
                btnTercero.BackColor = Color.FromArgb(40, 40, 40);
            else
                btnTercero.BackColor = Color.FromArgb(32, 30, 45);
        }


        private void VerificarPaginas()
        {
            if (TotalPages >= 3)
            {
                btnTercero.Enabled = true;
                btnSegundo.Enabled = true;
            }
            else if (TotalPages < 2)
            {
                btnTercero.Enabled = false;
                btnSegundo.Enabled = false;
            }
            else if (TotalPages < 3)
            {
                btnTercero.Enabled = false;
                btnSegundo.Enabled = true;
            }
        }

        private void tbMantenerFiltro_CheckedChanged(object sender, EventArgs e)
        {
            MantenerFiltroFechas = tbMantenerFiltro.Checked;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            ObtenerTodosLosPedidosConFiltro(searchValue);
        }
    }
}
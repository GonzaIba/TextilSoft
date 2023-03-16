using Contracts.Controllers;
using Domain.Entities;
using Domain.GenericEntity;
using Domain.Models;
using FontAwesome.Sharp;
using MailKit.Search;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections;
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
        public void ObtenerTodosLosPedidosConFiltro(string searchValue, bool EsPedido)
        {
            try
            {
                if (EsPedido)
                {
                    var pedidos = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerListaPedidos(Pagecount, EsPedido).List;
                    var resultado = pedidos.Where(p =>
                                    p.NroPedido.ToString().Contains(searchValue) ||
                                    p.TotalPago.ToString().Contains(searchValue) ||
                                    p.Fecha.ToString().Contains(searchValue) ||
                                    p.Seña.HasValue && p.Seña.Value.ToString().Contains(searchValue) ||
                                    p.EstadoPedido.ToString().Contains(searchValue) ||
                                    p.AtendidoPor.Contains(searchValue) ||
                                    p.Cliente.Contains(searchValue) ||
                                    p.PedidoID.ToString().Contains(searchValue)
                                    ).ToList();
                    GrillaPedidos.DataSource = resultado.Take(Pagecount).ToList();
                    TotalPages = (int)Math.Ceiling(resultado.Count() / (double)Pagecount);
                    btnFinal.Text = "..." + TotalPages.ToString();
                    PageIndex = 1;
                }
                else
                {
                    var pedidos = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerListaPedidos(Pagecount, EsPedido).List;
                    var resultado = pedidos.Where(p =>
                                    p.Fecha.ToString().Contains(searchValue) ||
                                    p.EstadoPedidos.ToString().Contains(searchValue) ||
                                    p.AtendidoPor.Contains(searchValue)
                                    ).ToList();
                    GrillaPedidos.DataSource = resultado.Take(Pagecount).ToList();
                    TotalPages = (int)Math.Ceiling(resultado.Count() / (double)Pagecount);
                    btnFinal.Text = "..." + TotalPages.ToString();
                    PageIndex = 1;

                }

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
                    filterExpression = x => x.PedidoID > 0;
                    break;
            }
            return filterExpression;
        }

        private Expression<Func<ListarPedidosFabricaEntity, bool>> FiltroFabrica(string nombreFiltro = "Fecha", bool IsNextPage = false)
        {
            Expression<Func<ListarPedidosFabricaEntity, bool>> filterExpression = null;
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
                    filterExpression = x => x.PedidoID > 0;
                    break;
            }
            return filterExpression;
        }

        private void FmListarPedidos_Load(object sender, EventArgs e)
        {
            tbEsPedido.Checked = false;
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
                if (LastColumn != ColumnName)
                {
                    button.IconColor = Color.MediumSlateBlue;
                    if (LastIconButton != null)
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
            if (tbEsPedido.Checked)
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(), orderBy, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(), orderBy, IsPreviousActive, tbEsPedido.Checked).List.ToList();
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
                dynamic PedidosPaginado = null;
                if (tbEsPedido.Checked)
                {
                    Expression<Func<ListarPedidosEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, expression, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                }
                else
                {
                    Expression<Func<ListarPedidosFabricaEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, expression, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                }
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
                dynamic PedidosPaginado = null;
                if (tbEsPedido.Checked)
                {
                    Expression<Func<ListarPedidosEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, expression, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                }
                else
                {
                    Expression<Func<ListarPedidosFabricaEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, expression, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                }
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
            if (tbEsPedido.Checked)
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(1, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(1, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;
            ActualizarBotones();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (tbEsPedido.Checked)
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(TotalPages, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(TotalPages, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

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
                if (tbEsPedido.Checked)
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
                else
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

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
                if (tbEsPedido.Checked)
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
                else
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

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
                var PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(), LastColumn, IsPreviousActive, tbEsPedido.Checked);
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
                dynamic PedidosPaginado = null;
                if (tbEsPedido.Checked)
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);

                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                btnAnterior.Enabled = false;
            }
            if (!isFirstPage)
            {
                IndexBtnPrimero -= 1;
                IndexBtnSegundo -= 1;
                IndexBtnTercero -= 1;
                PageIndex = IndexBtnPrimero;
                dynamic PedidosPaginado = null;
                if (tbEsPedido.Checked)
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);

                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                btnAnterior.Enabled = true;
            }
            ActualizarBotones();
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            PageIndex = IndexBtnSegundo;
            if (tbEsPedido.Checked)
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

            ActualizarBotones();
        }

        private void btnTercero_Click(object sender, EventArgs e)
        {
            if (PageIndex == TotalPages || Convert.ToInt32(btnFinal.Text.Replace("...", "")) == TotalPages)
            {
                isLastPage = true;
                PageIndex = IndexBtnTercero;
                dynamic PedidosPaginado = null;
                if (tbEsPedido.Checked)
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);

                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
            }
            if (!isLastPage)
            {
                IndexBtnPrimero = IndexBtnSegundo;
                IndexBtnSegundo = IndexBtnTercero;
                IndexBtnTercero++;
                PageIndex = IndexBtnTercero;
                dynamic PedidosPaginado = null;
                if (tbEsPedido.Checked)
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(IsNextPage: true), LastColumn, IsPreviousActive, tbEsPedido.Checked);

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
            if (txtSearch.Text.Length > 0 && !string.IsNullOrEmpty(txtSearch.Text))
            {
                panelPaginado.Visible = false;
            }
            else
            {
                panelPaginado.Visible = true;
            }
            string searchValue = txtSearch.Text.Trim();
            ObtenerTodosLosPedidosConFiltro(searchValue, tbEsPedido.Checked);
        }

        private void tbEsPedido_CheckedChanged(object sender, EventArgs e)
        {
            CambiarLista();
        }

        private void CambiarLista()
        {
            GrillaPedidos.DataSource = null;
            // Eliminar botones agregados manualmente
            List<System.Windows.Forms.Control> controlesAEliminar = new List<System.Windows.Forms.Control>();

            foreach (System.Windows.Forms.Control control in GrillaPedidos.Controls.Cast<System.Windows.Forms.Control>().ToList())
            {
                if (control is IconButton)
                {
                    controlesAEliminar.Add(control);
                }
            }

            foreach (System.Windows.Forms.Control controlAEliminar in controlesAEliminar)
            {
                GrillaPedidos.Controls.Remove(controlAEliminar);
                controlAEliminar.Dispose();
            }

            GrillaPedidos.Controls.Clear();
            GrillaPedidos.Rows.Clear();
            GrillaPedidos.Columns.Clear();
            GrillaPedidos.Refresh();
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
            if (tbEsPedido.Checked)
            {
                string orderBy = "ID_Pedido";
                LastColumn = orderBy;
                var PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidos(PageIndex, Pagecount, Filtro(), orderBy, IsPreviousActive, tbEsPedido.Checked);
                //Set total pages to btnFinal
                btnFinal.Text = "..." + PedidosPaginado.TotalPages.ToString();
                TotalPages = PedidosPaginado.TotalPages;
                GrillaPedidos.DataSource = ((IEnumerable)PedidosPaginado.List).Cast<object>().ToList();

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
            else
            {
                string orderBy = "ID_PedidosFabrica";
                LastColumn = orderBy;
                var PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidos(PageIndex, Pagecount, FiltroFabrica(), orderBy, IsPreviousActive, tbEsPedido.Checked);
                //Set total pages to btnFinal
                btnFinal.Text = "..." + PedidosPaginado.TotalPages.ToString();
                TotalPages = PedidosPaginado.TotalPages;
                GrillaPedidos.DataSource = PedidosPaginado.List.Cast<object>().ToList();

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
                        button.Location = new Point(ColumnLocation.X + 200, ColumnLocation.Y);
                    }
                    //Add event click
                    button.Click += new EventHandler((s, e) => OrdenarGrilla(s, e, item.Name, button));
                    GrillaPedidos.Controls.Add(button);
                    VerificarPaginas();
                }
                ActualizarBotones();
            }
        }

    }
}
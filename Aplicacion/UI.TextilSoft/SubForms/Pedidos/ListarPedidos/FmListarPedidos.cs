using Contracts.Controllers;
using Domain.Entities;
using FontAwesome.Sharp;
using MailKit.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UI.TextilSoft.Controllers;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Pedidos.ListarPedidos
{
    public partial class FmListarPedidos : Form
    {
        private readonly IPedidosController _pedidosController;
        private bool IsPreviousActive;
        private string LastColumn;
        private int Pagecount, PageIndex, TotalPages;
        private bool FirstTime, isLastPage,isFirstPage;

        private int IndexBtnPrimero, IndexBtnSegundo, IndexBtnTercero;
        
        public FmListarPedidos(IPedidosController pedidosController)
        {
            _pedidosController = pedidosController;
            InitializeComponent();
        }

        private void FmListarPedidos_Load(object sender, EventArgs e)
        {
            //Select the first item cbox
            FirstTime = true;
            cboxCantidadRegistros.SelectedIndex = 0;
            Pagecount = Convert.ToInt32(cboxCantidadRegistros.SelectedItem);
            PageIndex = 1;

            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;

            string orderBy = "ID_Pedido";
            LastColumn = orderBy;
            var PedidosPaginado = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, orderBy, IsPreviousActive);
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
                button.Click += new EventHandler((s, e) => OrdenarGrilla(s, e, item.Name));

                GrillaPedidos.Controls.Add(button);
                VerificarPaginas();
            }
            ActualizarBotones();
        }
        
        public void OrdenarGrilla(object sender, EventArgs e, string ColumnName)
        {
            string orderBy = ColumnName;
            if (LastColumn == ColumnName && !IsPreviousActive)
                IsPreviousActive = true;
            else
                IsPreviousActive = false;

            LastColumn = ColumnName;
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, orderBy, IsPreviousActive).List.ToList();
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
        }

        private void fmDateHasta_ValueChanged(object sender, EventArgs e)
        {
            //Use Expression func with date
            Expression<Func<ListarPedidosEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, expression, LastColumn, IsPreviousActive).List.ToList();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(1, Pagecount, null, LastColumn, IsPreviousActive).List.ToList();
            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;
            ActualizarBotones();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(TotalPages, Pagecount, null, LastColumn, IsPreviousActive).List.ToList();
            if(PageIndex != 1 && PageIndex != 2)
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
                if(PageIndex == IndexBtnTercero)
                {
                    IndexBtnPrimero++;
                    IndexBtnSegundo++;
                    IndexBtnTercero++;
                }
                PageIndex++;
                GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive).List.ToList();
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
                GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive).List.ToList();
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
                var PedidosPaginado = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                TotalPages = PedidosPaginado.TotalPages;
                btnFinal.Text = "..." + PedidosPaginado.TotalPages.ToString();
                PageIndex = 1;
                ActualizarBotones();
                VerificarPaginas();
            }

            if (cboxCantidadRegistros.SelectedIndex == 2)
            {
                GrillaPedidos.Height = GrillaPedidos.RowTemplate.Height * (GrillaPedidos.Rows.Count +1);
                panelPaginado.Location = new Point(panelPaginado.Location.X, GrillaPedidos.Location.Y + GrillaPedidos.Height + 10);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (PageIndex == 1 || btnPrimero.Text.ToString() == "1")
            {
                isFirstPage = true;
                PageIndex = IndexBtnPrimero;
                var PedidosPaginado = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                btnAnterior.Enabled = false;
            }
            if (!isFirstPage)
            {
                IndexBtnPrimero-=1;
                IndexBtnSegundo-=1;
                IndexBtnTercero-=1;
                PageIndex = IndexBtnPrimero;
                var PedidosPaginado = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                btnAnterior.Enabled = true;
            }
            ActualizarBotones();
        }
        
        private void btnSegundo_Click(object sender, EventArgs e)
        {
            PageIndex = IndexBtnSegundo;
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive).List.ToList();
            ActualizarBotones();
        }
        
        private void btnTercero_Click(object sender, EventArgs e)
        {
            if (PageIndex == TotalPages || Convert.ToInt32(btnFinal.Text.Replace("...", "")) == TotalPages)
            {
                isLastPage = true;
                PageIndex = IndexBtnTercero;
                var PedidosPaginado = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive);
                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
            }
            if (!isLastPage)
            {
                IndexBtnPrimero = IndexBtnSegundo;
                IndexBtnSegundo = IndexBtnTercero;
                IndexBtnTercero++;
                PageIndex = IndexBtnTercero;
                var PedidosPaginado = _pedidosController.ObtenerPedidos(PageIndex, Pagecount, null, LastColumn, IsPreviousActive);
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
            if (TotalPages > 3)
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

    }
}
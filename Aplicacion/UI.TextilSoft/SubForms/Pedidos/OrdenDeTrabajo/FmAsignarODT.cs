using Contracts.Controllers;
using Domain.Entities;
using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Factory;

namespace UI.TextilSoft.SubForms.Pedidos.OrdenDeTrabajo
{
    public partial class FmAsignarODT : Form
    {
        private readonly IControllerFactory _factory;
        private bool IsPreviousActive;
        private string LastColumn;
        private int Pagecount, PageIndex, TotalPages;
        private bool FirstTime, isLastPage, isFirstPage;
        private bool MantenerFiltroFechas, DateChanged;
        private IconButton LastIconButton;

        private int IndexBtnPrimero, IndexBtnSegundo, IndexBtnTercero;
        public FmAsignarODT(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
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
                var PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, orderBy, IsPreviousActive, tbEsPedido.Checked);
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
                var PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, orderBy, IsPreviousActive, tbEsPedido.Checked);
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (tbEsPedido.Checked)
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(1, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(1, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;
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
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
                else
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

            }
            ActualizarBotones();
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            PageIndex = IndexBtnSegundo;
            if (tbEsPedido.Checked)
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

            ActualizarBotones();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (PageIndex == 1 || btnPrimero.Text.ToString() == "1")
            {
                isFirstPage = true;
                PageIndex = IndexBtnPrimero;
                dynamic PedidosPaginado = null;
                if (tbEsPedido.Checked)
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);

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
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);

                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
                btnAnterior.Enabled = true;
            }
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
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);

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
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);
                else
                    PedidosPaginado = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked);

                GrillaPedidos.DataSource = PedidosPaginado.List.ToList();
            }
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
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
                else
                    GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

            }
            ActualizarBotones();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            if (tbEsPedido.Checked)
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(TotalPages, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(TotalPages, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

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
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, orderBy, IsPreviousActive, tbEsPedido.Checked).List.ToList();
            else
                GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(PageIndex, Pagecount, orderBy, IsPreviousActive, tbEsPedido.Checked).List.ToList();
        }

        #region helpers
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
        #endregion

        private void FmAsignarODT_Load(object sender, EventArgs e)
        {
            CambiarLista();
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
    }
}

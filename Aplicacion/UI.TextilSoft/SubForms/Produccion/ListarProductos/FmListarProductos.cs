using Contracts.Controllers;
using Domain.Entities;
using FontAwesome.Sharp;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools;
using UI.TextilSoft.Tools.FormsTools;
using static log4net.Appender.ColoredConsoleAppender;

namespace UI.TextilSoft.SubForms.Produccion.ListarProductos
{
    public partial class FmListarProductos : Form
    {
        private readonly IControllerFactory _factory;
        private bool IsPreviousActive;
        private string LastColumn;
        private int Pagecount, PageIndex, TotalPages;
        private bool FirstTime, isLastPage, isFirstPage;
        private IconButton LastIconButton;

        private int IndexBtnPrimero, IndexBtnSegundo, IndexBtnTercero;
        public FmListarProductos(IControllerFactory factory)
        {
            _factory = factory;
            InitializeComponent();
        }


        private void FmListarProductos_Load(object sender, EventArgs e)
        {
            FirstTime = true;
            cboxCantidadRegistros.SelectedIndex = 0;
            Pagecount = Convert.ToInt32(cboxCantidadRegistros.SelectedItem);
            PageIndex = 1;

            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;

            string orderBy = "ID_Producto";
            LastColumn = orderBy;
            var ProductosPaginado = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(), orderBy, IsPreviousActive);
            //Set total pages to btnFinal
            btnFinal.Text = "..." + ProductosPaginado.TotalPages.ToString();
            TotalPages = ProductosPaginado.TotalPages;
            GrillaProductos.DataSource = ProductosPaginado.List.ToList();

            foreach (DataGridViewColumn item in GrillaProductos.Columns)
            {
                IconButton button = new();
                button.ForeColor = System.Drawing.Color.White;
                button.IconChar = IconChar.Sort;
                button.IconColor = System.Drawing.Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.IconSize = 18;
                button.Size = new Size(20, 20);
                if (item.Index != GrillaProductos.Columns.Count - 1) //La primer columna es de index, y la última no tiene una adelante{
                {
                    Point ColumnLocation = GrillaProductos.GetColumnDisplayRectangle(item.DisplayIndex + 1, false).Location;
                    button.Location = new Point(ColumnLocation.X - 15, ColumnLocation.Y);
                }
                else
                {
                    Point ColumnLocation = GrillaProductos.GetColumnDisplayRectangle(item.DisplayIndex, false).Location;
                    button.Location = new Point(ColumnLocation.X + 90, ColumnLocation.Y);
                }
                //Add event click
                button.Click += new EventHandler((s, e) => OrdenarGrilla(s, e, item.Name, button));

                GrillaProductos.Controls.Add(button);
                VerificarPaginas();
            }

            ActualizarBotones();

            foreach (DataGridViewColumn item in GrillaProductos.Columns)
            {
                int index = item.Index;
                if (item.ValueType.Name == "Color")
                {
                    foreach (DataGridViewRow row in GrillaProductos.Rows)
                    {
                        var cell = new DataGridViewCellColor();
                        cell.Value = row.Cells[index].Value;
                        row.Cells[index] = cell;
                    }
                }
            }
        }

        public void ObtenerTodosLosProductosConFiltro(string searchValue)
        {
            try
            {
                var productos = _factory.Use<IProductosController>().ObtenerListaProductos(Pagecount).List;
                var resultado = productos.Where(p =>
                                p.Codigo.ToString().Contains(searchValue) ||
                                //p.Color.Contains(searchValue) ||
                                p.Composicion.Contains(searchValue) ||
                                p.Estampa.Contains(searchValue) ||
                                p.ID_Producto.ToString().Contains(searchValue) ||
                                p.NombreProducto.Contains(searchValue) ||
                                p.Precio.HasValue && p.Precio.Value.ToString().Contains(searchValue) ||
                                p.TallePrenda.Contains(searchValue) ||
                                p.Tejido.Contains(searchValue) ||
                                p.TipoProducto.Contains(searchValue)
                                ).ToList();
                GrillaProductos.DataSource = resultado;
                TotalPages = (int)Math.Ceiling(resultado.Count() / (double)Pagecount);
                btnFinal.Text = "..." + TotalPages.ToString();
                PageIndex = 1;

            }
            catch (Exception ex)
            {

            }
        }

        private Expression<Func<ProductosEntity, bool>> Filtro(string nombreFiltro = "All", bool IsNextPage = false)
        {
            Expression<Func<ProductosEntity, bool>> filterExpression = null;
            switch (nombreFiltro)
            {
                case "All":
                    filterExpression = x => x.ID_Producto > 0;
                    break;
                default:
                    // Filtro por defecto
                    filterExpression = x => x.ID_Producto > 0;
                    break;
            }
            return filterExpression;
        }

        public void OrdenarGrilla(object sender, EventArgs e, string ColumnName, IconButton button)
        {
            string orderBy = ColumnName;
            if (LastColumn == ColumnName && !IsPreviousActive)
            {
                IsPreviousActive = true;
                if (button.IconColor == System.Drawing.Color.MediumSlateBlue)
                    button.IconColor = System.Drawing.Color.White;
                else
                    button.IconColor = System.Drawing.Color.MediumSlateBlue;
            }
            else
            {
                if (LastColumn != ColumnName)
                {
                    button.IconColor = System.Drawing.Color.MediumSlateBlue;
                    if (LastIconButton != null)
                        LastIconButton.IconColor = System.Drawing.Color.White;
                    IsPreviousActive = false;
                }
                else
                {
                    IsPreviousActive = false;
                    button.IconColor = System.Drawing.Color.White;
                }
            }

            LastIconButton = button;
            LastColumn = ColumnName;
            GrillaProductos.DataSource = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(), orderBy, IsPreviousActive).List.ToList();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            GrillaProductos.DataSource = _factory.Use<IProductosController>().ObtenerProductos(1, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            PageIndex = 1;
            IndexBtnPrimero = 1;
            IndexBtnSegundo = 2;
            IndexBtnTercero = 3;
            ActualizarBotones();
        }

        private void btnFinal_Click(object sender, EventArgs e)
        {
            GrillaProductos.DataSource = _factory.Use<IProductosController>().ObtenerProductos(TotalPages, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
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
                GrillaProductos.DataSource = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
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
                GrillaProductos.DataSource = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            }
            ActualizarBotones();
        }

        private void GrillaPedidos_DataSourceChanged(object sender, EventArgs e)
        {
            GrillaProductos.Height = GrillaProductos.RowTemplate.Height * (GrillaProductos.Rows.Count + 1);
            panelPaginado.Location = new Point(panelPaginado.Location.X, GrillaProductos.Location.Y + GrillaProductos.Height + 10);
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
                var ProductosPaginado = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(), LastColumn, IsPreviousActive);
                GrillaProductos.DataSource = ProductosPaginado.List.ToList();
                TotalPages = ProductosPaginado.TotalPages;
                btnFinal.Text = "..." + ProductosPaginado.TotalPages.ToString();
                PageIndex = 1;
                ActualizarBotones();
                VerificarPaginas();
            }

            if (cboxCantidadRegistros.SelectedIndex == 2)
            {
                GrillaProductos.Height = GrillaProductos.RowTemplate.Height * (GrillaProductos.Rows.Count + 1);
                panelPaginado.Location = new Point(panelPaginado.Location.X, GrillaProductos.Location.Y + GrillaProductos.Height + 10);
            }
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (PageIndex == 1 || btnPrimero.Text.ToString() == "1")
            {
                isFirstPage = true;
                PageIndex = IndexBtnPrimero;
                var ProductosPaginado = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaProductos.DataSource = ProductosPaginado.List.ToList();
                btnAnterior.Enabled = false;
            }
            if (!isFirstPage)
            {
                IndexBtnPrimero -= 1;
                IndexBtnSegundo -= 1;
                IndexBtnTercero -= 1;
                PageIndex = IndexBtnPrimero;
                var ProductosPaginado = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaProductos.DataSource = ProductosPaginado.List.ToList();
                btnAnterior.Enabled = true;
            }
            ActualizarBotones();
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            PageIndex = IndexBtnSegundo;
            GrillaProductos.DataSource = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive).List.ToList();
            ActualizarBotones();
        }

        private void btnTercero_Click(object sender, EventArgs e)
        {
            if (PageIndex == TotalPages || Convert.ToInt32(btnFinal.Text.Replace("...", "")) == TotalPages)
            {
                isLastPage = true;
                PageIndex = IndexBtnTercero;
                var ProductosPaginado = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaProductos.DataSource = ProductosPaginado.List.ToList();
            }
            if (!isLastPage)
            {
                IndexBtnPrimero = IndexBtnSegundo;
                IndexBtnSegundo = IndexBtnTercero;
                IndexBtnTercero++;
                PageIndex = IndexBtnTercero;
                var ProductosPaginado = _factory.Use<IProductosController>().ObtenerProductos(PageIndex, Pagecount, Filtro(IsNextPage: true), LastColumn, IsPreviousActive);
                GrillaProductos.DataSource = ProductosPaginado.List.ToList();
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
                btnPrimero.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            else
                btnPrimero.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);

            if (btnSegundo.Text == PageIndex.ToString())
                btnSegundo.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            else
                btnSegundo.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);

            if (btnTercero.Text == PageIndex.ToString())
                btnTercero.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
            else
                btnTercero.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text.Trim();
            ObtenerTodosLosProductosConFiltro(searchValue);
        }

        private void GrillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

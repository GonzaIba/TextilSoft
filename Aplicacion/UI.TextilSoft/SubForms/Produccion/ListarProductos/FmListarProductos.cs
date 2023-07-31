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
        private Dictionary<Point, Tuple<IconButton>> botonesPorCelda = new Dictionary<Point, Tuple<IconButton>>();

        private int IndexBtnPrimero, IndexBtnSegundo, IndexBtnTercero;
        public FmListarProductos(IControllerFactory factory)
        {
            _factory = factory;
            InitializeComponent();
            GrillaProductos.CellPainting += GrillaProductos_CellPainting;
        }

        private async void GrillaProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                Point celda = new Point(e.ColumnIndex, e.RowIndex);
                if (!botonesPorCelda.ContainsKey(celda))
                {
                    //Crear los botones
                    IconButton btnDetalleProducto = new IconButton();
                    btnDetalleProducto.IconChar = IconChar.HandPointUp;
                    btnDetalleProducto.Cursor = Cursors.Hand;
                    btnDetalleProducto.IconColor = System.Drawing.Color.White;
                    btnDetalleProducto.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
                    btnDetalleProducto.FlatAppearance.BorderSize = 0;
                    btnDetalleProducto.FlatStyle = FlatStyle.Flat;
                    btnDetalleProducto.IconSize = 21;
                    btnDetalleProducto.Size = new Size(20, 20);
                    btnDetalleProducto.Click += new EventHandler((s, args) => DetalleProducto(sender, e, btnDetalleProducto)); //Evento click para modificar
                    btnDetalleProducto.Visible = true;
                    btnDetalleProducto.Parent = GrillaProductos;
                    //btnAsignarODT.Text = GrillaPedidos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    //Almacenar los botones en el diccionario
                    botonesPorCelda.Add(celda, new Tuple<IconButton>(btnDetalleProducto));

                    //Obtener los botones de la celda
                    Tuple<IconButton> botones = botonesPorCelda[celda];
                    IconButton buttonModificarCelda = botones.Item1;

                    //Calcular la posición de los botones
                    int x = e.CellBounds.Left + 5;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - buttonModificarCelda.Height) / 2;
                    buttonModificarCelda.Location = new Point(x, y);

                    //Dibujar los botones
                    e.PaintBackground(e.CellBounds, true);
                    e.PaintContent(e.CellBounds);

                    e.Handled = true;
                }
            }
        }

        private void DetalleProducto(object sender, EventArgs e, IconButton btnDetalleProducto)
        {
            try
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                // Obtener la posición del botón en la tabla
                Point botonPosicion = btnDetalleProducto.Location;
                DataGridView.HitTestInfo hitTestInfo = GrillaProductos.HitTest(botonPosicion.X, botonPosicion.Y);

                string codigo = GrillaProductos.Rows[hitTestInfo.RowIndex].Cells["Codigo"].Value.ToString().Trim();
                FmDetalleProductos fmDetalleProducto = new FmDetalleProductos(codigo,_factory);
                fmDetalleProducto.ShowDialog();

                // Eliminar el botón del diccionario también
                Tuple<IconButton> botones = botonesPorCelda[botonesPorCelda.LastOrDefault().Key];
                IconButton buttonAsignarODT = botones.Item1;
                botonesPorCelda.Remove(botonesPorCelda.LastOrDefault().Key);
                buttonAsignarODT.Dispose();
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error", "Ocurrió un error al querer ver el detalle del producto", centerPosition, true);
                fmMessageBox.ShowDialog();
            }
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

            //GrillaProductos.AutoGenerateColumns = false;

            //// Crear la columna personalizada y agregarla a la grilla
            //var colorColumn = new ColorColumn("Color");
            //colorColumn.SetCellTemplate();
            //GrillaProductos.Columns.Add(colorColumn);

            //// Registrar el evento RowPostPaint
            //GrillaProductos.RowPostPaint += GrillaProductos_RowPostPaint;
        }

        public void ObtenerTodosLosProductosConFiltro(string searchValue)
        {
            try
            {
                var productos = _factory.Use<IProductosController>().ObtenerListaProductos(Pagecount).List;
                var resultado = productos.Where(p =>
                                p.Codigo.ToString().Contains(searchValue) ||
                                //p.Color.Contains(searchValue) ||
                                //p.ID_Producto.ToString().Contains(searchValue) ||
                                p.NombreProducto.Contains(searchValue) ||
                                p.Precio.ToString().Contains(searchValue)
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

        private Expression<Func<ProductoGrillaEntity, bool>> Filtro(string nombreFiltro = "All", bool IsNextPage = false)
        {
            Expression<Func<ProductoGrillaEntity, bool>> filterExpression = null;
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

        private void GrillaProductos_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            // Establecer el valor de la celda en la columna de color
            var row = GrillaProductos.Rows[e.RowIndex];
            var value = row.Cells["Color"].Value;
            if (value != null && value is System.Drawing.Color)
            {
                row.Cells["Color"].Style.BackColor = (System.Drawing.Color)value;
            }
        }

        private void GrillaProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //// Busca la columna que contiene valores de tipo Color
            //foreach (DataGridViewColumn column in GrillaProductos.Columns)
            //{
            //    if (column.ValueType == typeof(System.Drawing.Color))
            //    {
            //        // Establece la plantilla de celda DataGridViewCellColor para la columna
            //        var colorCellTemplate = new DataGridViewCellColor();
            //        column.CellTemplate = colorCellTemplate;
            //    }
            //}
        }
        private void Copy_Click(object sender, EventArgs e)
        {
            string value = GrillaProductos.CurrentCell.Value.ToString(); //Obtiene el valor de la celda seleccionada
            Clipboard.SetText(value); //Copia el valor al portapapeles
        }

        private void GrillaProductos_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex == 1) //Verifica si se ha hecho clic derecho en la segunda columna
            {
                GrillaProductos.CurrentCell = GrillaProductos.Rows[e.RowIndex].Cells[e.ColumnIndex]; //Selecciona la celda actual
                ContextMenuStrip menu = new ContextMenuStrip(); //Crea el menú contextual
                ToolStripMenuItem item = new ToolStripMenuItem("Copiar"); //Crea la opción "Copiar"
                item.Click += new EventHandler(Copy_Click); //Agrega un controlador de eventos para la opción "Copiar"
                menu.Items.Add(item); //Agrega la opción "Copiar" al menú contextual
                GrillaProductos.ContextMenuStrip = menu; //Muestra el menú contextual
            }
        }
    }
}

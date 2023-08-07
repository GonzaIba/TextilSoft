using Contracts.Controllers;
using Domain.Entities;
using FontAwesome.Sharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MailKit.Search;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools.FormsTools;

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
        private Dictionary<Point, Tuple<IconButton>> botonesPorCelda = new Dictionary<Point, Tuple<IconButton>>();

        private int IndexBtnPrimero, IndexBtnSegundo, IndexBtnTercero;
        public FmAsignarODT(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
            GrillaPedidos.CellPainting += GrillaPedidos_CellPainting;
        }

        private async void GrillaPedidos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                Point celda = new Point(e.ColumnIndex, e.RowIndex);
                if (!botonesPorCelda.ContainsKey(celda))
                {
                    //Crear los botones
                    IconButton btnAsignarODT = new IconButton();
                    btnAsignarODT.IconChar = IconChar.HandPointUp;
                    btnAsignarODT.Cursor = Cursors.Hand;
                    btnAsignarODT.IconColor = Color.White;
                    btnAsignarODT.BackColor = Color.FromArgb(32, 30, 45);
                    btnAsignarODT.FlatAppearance.BorderSize = 0;
                    btnAsignarODT.FlatStyle = FlatStyle.Flat;
                    btnAsignarODT.IconSize = 21;
                    btnAsignarODT.Size = new Size(20, 20);
                    btnAsignarODT.Click += new EventHandler((s, args) => AsignarODT(sender, e, btnAsignarODT)); //Evento click para modificar
                    btnAsignarODT.Visible = true;
                    btnAsignarODT.Parent = GrillaPedidos;
                    //btnAsignarODT.Text = GrillaPedidos.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                    //Almacenar los botones en el diccionario
                    botonesPorCelda.Add(celda, new Tuple<IconButton>(btnAsignarODT));

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

        private void AsignarODT(object sender, EventArgs e, IconButton btnAsignarODT)
        {
            try
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Crear", "Esta seguro que desea tomar este pedido?", centerPosition, true);
                fmMessageBox.ShowDialog();

                if (fmMessageBox.btnAceptar)
                {
                    // Obtener la posición del botón en la tabla
                    Point botonPosicion = btnAsignarODT.Location;
                    DataGridView.HitTestInfo hitTestInfo = GrillaPedidos.HitTest(botonPosicion.X, botonPosicion.Y);

                    string PedidoID = GrillaPedidos.Rows[hitTestInfo.RowIndex].Cells["PedidoID"].Value.ToString().Trim();

                    //DetallePedidos.Remove(DetallePedidos.Where(x => x.Codigo == Codigo && x.Detalle == Detalle).FirstOrDefault());
                    //GrillaPedidos.Refresh();
                    //GrillaPedidos.DataSource = DetallePedidos.ToList();
                    _factory.Use<IPedidosController<ListarPedidosEntity>>().AsignarODT(Convert.ToInt32(PedidoID), tbEsPedido.Checked);
                    FmMessageBox fmMessageBox2 = new FmMessageBox(Tools.MessageBoxType.Success, "Exito", "Se asignó la ODT correctamente!", centerPosition, false);
                    fmMessageBox2.ShowDialog();

                    if (tbEsPedido.Checked)
                        GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosEntity>>().ObtenerPedidosParaODT(1, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();
                    else
                        GrillaPedidos.DataSource = _factory.Use<IPedidosController<ListarPedidosFabricaEntity>>().ObtenerPedidosParaODT(1, Pagecount, LastColumn, IsPreviousActive, tbEsPedido.Checked).List.ToList();

                    GrillaPedidos.Refresh();
                    // Eliminar el botón del diccionario también
                    Tuple<IconButton> botones = botonesPorCelda[botonesPorCelda.LastOrDefault().Key];
                    IconButton buttonAsignarODT = botones.Item1;
                    botonesPorCelda.Remove(botonesPorCelda.LastOrDefault().Key);
                    buttonAsignarODT.Dispose();
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error", "Ocurrió un error al asignar la ODT", centerPosition, true);
                fmMessageBox.ShowDialog();
            }

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
                btnFinal.Text = "..." + (PedidosPaginado.TotalPages == 0 ? "1" : PedidosPaginado.TotalPages.ToString());
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
                btnFinal.Text = "..." + (PedidosPaginado.TotalPages == 0 ? "1": PedidosPaginado.TotalPages.ToString());
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

        #region Helpers
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
                panelPaginado.Visible = false;
            else
                panelPaginado.Visible = true;

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
                                    p.Fecha.ToString("dd/MM/yyyy HH:mm").Contains(searchValue) ||
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
                                    p.Fecha.ToString("dd/MM/yyyy HH:mm").Contains(searchValue) ||
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

        private void GrillaPedidos_DataSourceChanged(object sender, EventArgs e)
        {
            //foreach (var item in GrillaPedidos.)
            //{

            //}
        }

        private byte[] RellenarPdf(Dictionary<string, string> dicBasico, ref byte[] strFileContent)
        {

            string strFormVacioPath = AppDomain.CurrentDomain.GetData("TempPath-ODT").ToString();
            string strFormLlenoPath = AppDomain.CurrentDomain.GetData("TemplatePath-ODT").ToString();
            //string strFormVacioPath = @"D:\Repositorios-SmartGit\TextilSoft\Templates\Orden-De-Trabajo.pdf" + templateFile;
            //string strFormLlenoPath = @"D:\Repositorios-SmartGit\TextilSoft\Templates\Orden-De-Trabajo1.pdf";

            try
            {
                using (FileStream fileOutput = new FileStream(strFormLlenoPath, FileMode.Create))
                {
                    PdfReader pdfReader = new PdfReader(strFormVacioPath);
                    PdfStamper pdfStamper = new PdfStamper(pdfReader, fileOutput);

                    AcroFields pdfFormFields = pdfStamper.AcroFields;
                    PdfContentByte pdfContentByte = pdfStamper.GetOverContent(1);
                    IDictionary<string, AcroFields.Item> dicFields = pdfFormFields.Fields;

                    foreach (KeyValuePair<string, AcroFields.Item> CollectionItem in dicFields)
                    {
                        if (dicBasico.ContainsKey(CollectionItem.Key))
                        {
                            if (CollectionItem.Key == "imgQrAfip")
                            {
                                byte[] imageArray = File.ReadAllBytes(dicBasico[CollectionItem.Key]);
                                string img = Convert.ToBase64String(imageArray);
                                pdfFormFields.SetField(CollectionItem.Key, img);
                            }
                            else
                            {
                                pdfFormFields.SetField(CollectionItem.Key, dicBasico[CollectionItem.Key]);
                            }
                        }
                    }

                    pdfStamper.FormFlattening = false;
                    pdfStamper.Close();
                    pdfReader.Close();
                    pdfContentByte.ClosePath();
                }

                if (File.Exists(strFormLlenoPath))
                {
                    strFileContent = File.ReadAllBytes(strFormLlenoPath);
                    File.Delete(strFormLlenoPath);
                }

                return strFileContent;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

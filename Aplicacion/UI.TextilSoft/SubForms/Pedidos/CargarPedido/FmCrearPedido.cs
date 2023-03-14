using Contracts.Controllers;
using Domain.Entities;
using FontAwesome.Sharp;
using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UI.TextilSoft.Factory;
using UI.TextilSoft.MainForm;
using UI.TextilSoft.Tools;
using UI.TextilSoft.Tools.ExtensionsControls;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Pedidos.CargarPedido
{
    public partial class FmCrearPedido : Form
    {
        private IControllerFactory _factory;
        private FmTextilSoft _fmTextilSoft;
        private List<DetallePedidosYFabricaEntity> DetallePedidos;
        private int CantidadDisponible = 0;
        public decimal TotalActual = 0;
        private bool EliminandoRegistro = false;
        //Diccionario para almacenar los botones por celda
        private Dictionary<Point, Tuple<IconButton, IconButton>> botonesPorCelda = new Dictionary<Point, Tuple<IconButton, IconButton>>();
        public FmCrearPedido(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
            panelProductos.Enabled = false;
            btnGenerarPedido.Enabled = false;
            DetallePedidos = new List<DetallePedidosYFabricaEntity>();
            dgvProductos.DataSource = DetallePedidos.ToList();
            //dgvProductos.Columns.Add(new CustomButtonColumn("Acciones"));
            //CellPainting
            dgvProductos.CellPainting += dgvProductos_CellPainting;
        }

        private void FmCrearPedido_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtResidencia.Enabled = false;
            txtMail.Enabled = false;
            txtTelefono.Enabled = false;
            txtTotal.Text = "0";
            txtSubtotal.Text = "0";
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length == 8)
            {
                string DNI = txtDNI.Text;
                var Cliente = _factory.UseNew<IClientesController>().ObtenerCliente(DNI);
                if (Cliente is null)
                {
                    MessageBox.Show("El cliente con el dni: " + txtDNI.Text + " No existe, vuelva a ingresarlo porfavor");
                    txtDNI.LimpiarTextbox();
                    panelProductos.Enabled = false;
                }
                else
                {
                    txtNombre.Text = Cliente.Nombre;
                    txtResidencia.Text = Cliente.Residencia;
                    txtApellido.Text = Cliente.Apellido;
                    txtMail.Text = Cliente.Mail;
                    txtTelefono.Text = Cliente.Telefono;
                    panelProductos.Enabled = true;
                }
            }
            else
            {
                panelProductos.Enabled = false;
                txtNombre.LimpiarTextbox();
                txtResidencia.LimpiarTextbox();
                txtApellido.LimpiarTextbox();
                txtMail.LimpiarTextbox();
                txtTelefono.LimpiarTextbox();
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            string guidPattern = @"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$";

            if (Regex.IsMatch(txtCodigo.Text, guidPattern))
            {
                var Producto = _factory.UseNew<IProductosController>().ObtenerProducto(txtCodigo.Text);
                CantidadDisponible = Producto.Stock;
                if (Producto is null)
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "No encontrado", "No se encontró el producto", centerPosition);
                    fmMessageBox.ShowDialog();
                    txtCantidad.Enabled = false;
                    txtDescripcion.Enabled = false;
                    btnAgregarProducto.Enabled = false;
                    txtDNI.LimpiarTextbox();
                }
                else
                {
                    txtCantidad.Enabled = true;
                    txtDescripcion.Enabled = true;
                    btnAgregarProducto.Enabled = true;
                }
            }
            else
            {
                txtCantidad.Enabled = false;
                txtDescripcion.Enabled = false;
                btnAgregarProducto.Enabled = false;
            }
        }

        private void txtDNI_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDNI.Text, "[^0-9]"))
            {
                txtDNI.Text = txtDNI.Text.Remove(txtDNI.Text.Length - 1);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtCantidad.Text == "")
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Validaciones", "Por favor, complete los campos requeridos", centerPosition);
                fmMessageBox.ShowDialog();
            }
            else
            {
                if (btnAgregarProducto.Text == "Agregar Producto")
                {
                    if (Convert.ToInt32(txtCantidad.Text) > CantidadDisponible)
                    {
                        var centerPosition = new Point(this.Width / 2, this.Height / 2);
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de cuentas", "No hay suficiente stock para esa cantidad, solo puede hasta: " + CantidadDisponible.ToString(), centerPosition);
                        fmMessageBox.ShowDialog();
                    }
                    else
                    {
                        var Producto = _factory.UseNew<IProductosController>().ObtenerProducto(txtCodigo.Text);
                        var ProductosConElMismoCódigo = DetallePedidos.Where(x => x.Codigo == Producto.Codigo && x.Detalle == txtDescripcion.Text).ToList();
                        int CantidadTotal = 0, posibleCantidadTotal = 0;

                        ProductosConElMismoCódigo.ForEach(x =>
                        {
                            CantidadTotal += x.Cantidad;
                        });
                        if ((CantidadTotal + Convert.ToInt32(txtCantidad.Text)) > CantidadDisponible)
                        {
                            var centerPosition = new Point(this.Width / 2, this.Height / 2);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de cuentas", "Hay varios productos con el mismo código y superan el stock pedido, solo puede hasta: " + (CantidadDisponible - CantidadTotal).ToString(), centerPosition);
                            fmMessageBox.ShowDialog();
                        }
                        else
                        {
                            var Cantidad = Convert.ToInt32(txtCantidad.Text);
                            DetallePedidos.Add(new DetallePedidosYFabricaEntity
                            {
                                Codigo = Producto.Codigo,
                                Detalle = txtDescripcion.Text,
                                Cantidad = Convert.ToInt32(txtCantidad.Text),
                                PrecioProducto = Producto.Precio,
                                NombreProducto = Producto.NombreProducto
                            });
                            ActualizarTotal();

                            dgvProductos.DataSource = DetallePedidos.ToList();

                            txtCodigo.Enabled = true;
                            txtCodigo.Text = "";
                            txtCantidad.Text = "";
                            txtDescripcion.Text = "";
                            btnAgregarProducto.Text = "Agregar Producto";
                            btnCancelar.Visible = false;
                            txtCodigo.LimpiarTextbox();
                            txtCantidad.LimpiarTextbox();
                            btnGenerarPedido.Enabled = true;
                        }
                    }
                }
                else if (btnAgregarProducto.Text == "Modificar")
                {
                    if (Convert.ToInt32(txtCantidad.Text) > CantidadDisponible)
                    {
                        var centerPosition = new Point(this.Width / 2, this.Height / 2);
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de cuentas", "No hay suficiente stock para esa cantidad, solo puede hasta: " + CantidadDisponible.ToString(), centerPosition);
                        fmMessageBox.ShowDialog();
                    }
                    else
                    {
                        var Producto = _factory.UseNew<IProductosController>().ObtenerProducto(txtCodigo.Text);
                        var ProductosConElMismoCódigo = DetallePedidos.Where(x => x.Codigo == Producto.Codigo && x.Detalle == txtDescripcion.Text).ToList();
                        int CantidadTotal = 0, posibleCantidadTotal = 0;

                        ProductosConElMismoCódigo.ForEach(x =>
                        {
                            CantidadTotal += x.Cantidad;
                        });
                        if ((CantidadTotal + Convert.ToInt32(txtCantidad.Text)) > CantidadDisponible)
                        {
                            var centerPosition = new Point(this.Width / 2, this.Height / 2);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de cuentas", "Hay varios productos con el mismo código y superan el stock pedido, solo puede hasta: " + (CantidadDisponible - CantidadTotal).ToString(), centerPosition);
                            fmMessageBox.ShowDialog();
                        }
                        else
                        {
                            var Cantidad = Convert.ToInt32(txtCantidad.Text);

                            //Select DetallePedidos and update
                            var DetallePedido = DetallePedidos.Where(x => x.Codigo == Producto.Codigo && x.Detalle == txtDescripcion.Text).FirstOrDefault();
                            DetallePedido.Cantidad = Cantidad;
                            DetallePedido.Detalle = txtDescripcion.Text;
                            ActualizarTotal();
                            dgvProductos.DataSource = DetallePedidos.ToList();

                            txtCodigo.Enabled = true;
                            txtCodigo.LimpiarTextbox();
                            txtCantidad.LimpiarTextbox();
                            txtDescripcion.LimpiarTextbox();
                            btnAgregarProducto.Text = "Agregar Producto";
                            btnCancelar.Visible = false;
                        }
                    }
                }
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCantidad.Text, "[^0-9]"))
            {
                toolTipError.Show("Las contraseñas no coinciden", txtCantidad, 0, -20, 2000);
                txtCantidad.Text = txtCantidad.Text.Remove(txtCantidad.Text.Length - 1);
            }
        }

        private void tbMantenerFiltro_CheckedChanged(object sender, EventArgs e)
        {
            EsPedido_EsPedidoFabrica(tbEsPedido.Checked);

        }

        #region Helpers

        private void EsPedido_EsPedidoFabrica(bool estado)
        {
            panelClientes.Enabled = estado;
            txtSubtotal.Visible = estado;
            txtTotal.Visible = estado;
            lblSubTotal.Visible = estado;
            lblTotal.Visible = estado;
            if (!estado)
            {
                panelClientes.Enabled = false;
                panelProductos.Enabled = true;
                //timerSubir.Start();
                //y = Y_Inicial_pnlDetalleProducto;
            }
            else
            {
                panelClientes.Enabled = true;
                if (txtApellido.Text != "")
                    panelProductos.Enabled = true;
                else
                    panelProductos.Enabled = false;
                //timerBajar.Start();
                //y = Y_Inicial_pnlClientes;
            }
        }
        #endregion

        private void timerSubir_Tick(object sender, EventArgs e)
        {

        }

        private async void timerBajar_Tick(object sender, EventArgs e)
        {

        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                string resultado = _factory.Use<IPedidosController>().GenerarPedido(DetallePedidos, tbEsPedido.Checked, Convert.ToInt32(_fmTextilSoft._user.DNI), Convert.ToInt32(txtDNI.Text), Convert.ToDecimal(txtSubtotal.Text), Convert.ToDecimal(txtSeña.Text));
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Error al crear el pedido", "Hubo un error en el sistema, pruebe mas tarde o contacte con el administrador.", centerPosition, true);
                fmMessageBox.ShowDialog();
            }
        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                e.ThrowException = false;
            }
        }

        private void dgvProductos_DataSourceChanged(object sender, EventArgs e)
        {
            if (DetallePedidos.Count > 0)
                btnGenerarPedido.Enabled = true;
            else
                btnGenerarPedido.Enabled = false;
        }

        private async void dgvProductos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0 && !EliminandoRegistro) //solo si es la primer columna y no es el encabezado
            {
                //Verificar si ya existe un botón para esta celda
                Point celda = new Point(e.ColumnIndex, e.RowIndex);
                if (!botonesPorCelda.ContainsKey(celda))
                {
                    //Crear los botones
                    IconButton buttonModificar = new IconButton();
                    buttonModificar.IconChar = IconChar.Edit;
                    buttonModificar.Cursor = Cursors.Hand;
                    buttonModificar.IconColor = Color.White;
                    buttonModificar.BackColor = Color.FromArgb(32, 30, 45);
                    buttonModificar.FlatAppearance.BorderSize = 0;
                    buttonModificar.FlatStyle = FlatStyle.Flat;
                    buttonModificar.IconSize = 23;
                    buttonModificar.Size = new Size(20, 20);
                    buttonModificar.Click += new EventHandler((s, args) => ModificarRegistro(sender, e, buttonModificar)); //Evento click para modificar
                    buttonModificar.Visible = true;
                    buttonModificar.Parent = dgvProductos;

                    IconButton buttonEliminar = new IconButton();
                    buttonEliminar.IconChar = IconChar.TrashAlt;
                    buttonEliminar.Cursor = Cursors.Hand;
                    buttonEliminar.IconColor = Color.White;
                    buttonEliminar.BackColor = Color.FromArgb(32, 30, 45);
                    buttonEliminar.FlatAppearance.BorderSize = 0;
                    buttonEliminar.FlatStyle = FlatStyle.Flat;
                    buttonEliminar.IconSize = 23;
                    buttonEliminar.Size = new Size(20, 20);
                    buttonEliminar.Tag = new Point(dgvProductos.Columns[e.ColumnIndex].DisplayIndex, e.RowIndex);
                    buttonEliminar.Click += new EventHandler((s, args) => EliminarRegistro(sender, e, buttonEliminar)); //Evento click para eliminar
                    buttonEliminar.Visible = true;
                    buttonEliminar.Parent = dgvProductos;

                    //Almacenar los botones en el diccionario
                    botonesPorCelda.Add(celda, new Tuple<IconButton, IconButton>(buttonModificar, buttonEliminar));


                    //Obtener los botones de la celda
                    Tuple<IconButton, IconButton> botones = botonesPorCelda[celda];
                    IconButton buttonModificarCelda = botones.Item1;
                    IconButton buttonEliminarCelda = botones.Item2;

                    //Calcular la posición de los botones
                    int x = e.CellBounds.Left + 5;
                    int y = e.CellBounds.Top + (e.CellBounds.Height - buttonModificarCelda.Height) / 2;
                    buttonModificarCelda.Location = new Point(x, y);

                    x += buttonModificarCelda.Width + 5;
                    y = e.CellBounds.Top + (e.CellBounds.Height - buttonEliminarCelda.Height) / 2;
                    buttonEliminarCelda.Location = new Point(x, y);

                    //Dibujar los botones
                    e.PaintBackground(e.CellBounds, true);
                    e.PaintContent(e.CellBounds);

                    e.Handled = true;
                }
            }
        }


        #region Helpers
        private void ModificarRegistro(object sender, EventArgs e, IconButton btnModificar)
        {
            // Obtener la posición del botón en la tabla
            Point botonPosicion = btnModificar.Location;
            DataGridView.HitTestInfo hitTestInfo = dgvProductos.HitTest(botonPosicion.X, botonPosicion.Y);

            Guid Codigo = (Guid)dgvProductos.Rows[hitTestInfo.RowIndex].Cells["Codigo"].Value;
            var Detalle = dgvProductos.Rows[hitTestInfo.RowIndex].Cells["Detalle"].Value.ToString();
            var Cantidad = Convert.ToInt32(dgvProductos.Rows[hitTestInfo.RowIndex].Cells["Cantidad"].Value);

            txtCodigo.Text = Codigo.ToString();
            txtCodigo.Enabled = false;
            txtCantidad.Text = Cantidad.ToString();
            txtDescripcion.Text = Detalle;

            btnAgregarProducto.Text = "Modificar";
            btnCancelar.Visible = true;
        }

        private void EliminarRegistro(object sender, EventArgs e, IconButton botonEliminar)
        {
            EliminandoRegistro = true;
            var centerPosition = new Point(this.Width / 2, this.Height / 2);
            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Eliminar", "Esta seguro que desea eliminarlo?", centerPosition, true);
            fmMessageBox.ShowDialog();

            if (fmMessageBox.btnAceptar)
            {
                // Obtener la posición del botón en la tabla
                Point botonPosicion = botonEliminar.Location;
                DataGridView.HitTestInfo hitTestInfo = dgvProductos.HitTest(botonPosicion.X, botonPosicion.Y);

                Guid Codigo = (Guid)dgvProductos.Rows[hitTestInfo.RowIndex].Cells["Codigo"].Value;
                var Detalle = dgvProductos.Rows[hitTestInfo.RowIndex].Cells["Detalle"].Value.ToString();

                DetallePedidos.Remove(DetallePedidos.Where(x => x.Codigo == Codigo && x.Detalle == Detalle).FirstOrDefault());
                dgvProductos.Refresh();
                dgvProductos.DataSource = DetallePedidos.ToList();
                dgvProductos.Refresh();
                // Eliminar el botón del diccionario también
                Tuple<IconButton, IconButton> botones = botonesPorCelda[botonesPorCelda.LastOrDefault().Key];
                IconButton buttonModificarCelda = botones.Item1;
                IconButton buttonEliminarCelda = botones.Item2;
                botonesPorCelda.Remove(botonesPorCelda.LastOrDefault().Key);
                //if (botonesPorCelda.ContainsKey(Celda))
                //{
                //    botonesPorCelda.Remove(celda2);
                //}
                ActualizarTotal();
                buttonModificarCelda.Dispose();
                buttonEliminarCelda.Dispose();
            }
            EliminandoRegistro = false;
        }

        private void ActualizarTotal()
        {
            decimal subtotal = 0;
            foreach (var item in DetallePedidos)
            {
                subtotal += item.PrecioProducto * item.Cantidad;
            }
            txtSubtotal.Text = subtotal.ToString();
            txtTotal.Text = (subtotal - Convert.ToDecimal(txtSeña.Text == "" ? 0 : Convert.ToDecimal(txtSeña.Text))).ToString();
            TotalActual = subtotal;
        }

        private void CambiarColorBotonesPorCelda(DataGridViewCellEventArgs e, bool IsFirstColumnSelected)
        {
            // Obtener la posición de la celda y los botones correspondientes
            if (e.RowIndex != -1)
            {
                Point celda = new Point(0, e.RowIndex);
                var botones = botonesPorCelda?[celda];
                var botonModificar = botones.Item1;
                var botonEliminar = botones.Item2;
                if (IsFirstColumnSelected)
                {
                    // Cambiar el color de fondo de los botones
                    botonModificar.BackColor = Color.FromArgb(10, Color.Gray);
                    botonEliminar.BackColor = Color.FromArgb(10, Color.Gray);
                }
                else
                {
                    //dgvProductos.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.FromArgb(100, Color.Blue);
                    // Cambiar el color de fondo de los botones
                    botonModificar.BackColor = Color.FromArgb(32, 30, 45);
                    botonEliminar.BackColor = Color.FromArgb(32, 30, 45);
                }
            }

        }
        #endregion

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cambiar el color de la celda
            if (e.RowIndex == 0 && e.ColumnIndex == 0)
            {
                // Cambiar el color de los botones de la celda
                CambiarColorBotonesPorCelda(e, true);
            }
            else
            {
                CambiarColorBotonesPorCelda(e, false);
            }
        }

        private void FmCrearPedido_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Enabled = true;
            txtCodigo.LimpiarTextbox();
            txtCantidad.LimpiarTextbox();
            txtDescripcion.LimpiarTextbox();
            btnAgregarProducto.Text = "Agregar Producto";
            btnCancelar.Visible = false;
        }

        private void txtSeña_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtSeña.Text, "^[+-]?\\d*\\.?\\d+$"))
                {
                    if(txtSeña.Text == "")
                        ActualizarTotal();
                    else
                    {
                        toolTipError.Show("Solo se permiten numeros comas y puntos", txtSeña, 0, -20, 2000);
                        txtSeña.Text = txtSeña.Text.Remove(txtSeña.Text.Length - 1);
                    }
                }
                else
                    ActualizarTotal();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}

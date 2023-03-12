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
using System.Windows.Forms;
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools;
using UI.TextilSoft.Tools.ExtensionsControls;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Pedidos.CargarPedido
{
    public partial class FmCrearPedido : Form
    {
        private IControllerFactory _factory;
        private List<DetallePedidosYFabricaEntity> DetallePedidos;
        private int CantidadDisponible = 0;
        public FmCrearPedido(IControllerFactory factory)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _factory = factory;
            panelProductos.Enabled = false;
            btnGenerarPedido.Enabled = false;
            DetallePedidos = new();
            dgvProductos.DataSource = DetallePedidos.ToList();
            dgvProductos.Columns.Add(new CustomButtonColumn("Acciones"));
            //CustomButtonColumn customButtonColumn = new CustomButtonColumn();
            //customButtonColumn.HeaderText = "Custom Button Column";
            //customButtonColumn.Name = "customButtonColumn";
            //dgvProductos.Columns.Add(customButtonColumn);
            //dgvProductos.Columns.Add("hola","xd");
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
                var Cliente = _factory.Use<IClientesController>().ObtenerCliente(DNI);
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
                var Producto = _factory.Use<IProductosController>().ObtenerProducto(txtCodigo.Text);
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
                if (Convert.ToInt32(txtCantidad.Text) > CantidadDisponible)
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de cuentas", "No hay suficiente stock para esa cantidad, solo puede hasta: " + CantidadDisponible.ToString(), centerPosition);
                    fmMessageBox.ShowDialog();
                }
                else
                {
                    var Producto = _factory.Use<IProductosController>().ObtenerProducto(txtCodigo.Text);
                    var Cantidad = Convert.ToInt32(txtCantidad.Text);
                    var Precio = Producto.Precio;
                    var Subtotal = Cantidad * Precio;
                    var Total = Subtotal + Convert.ToInt32(txtTotal.Text);
                    txtTotal.Text = Total.ToString();
                    txtTotal.Text = Subtotal.ToString();

                    DetallePedidos.Add(new DetallePedidosYFabricaEntity
                    {
                        Codigo = Producto.Codigo,
                        Detalle = txtDescripcion.Text,
                        Cantidad = Convert.ToInt32(txtCantidad.Text),
                        PrecioProducto = Producto.Precio,
                        NombreProducto = Producto.NombreProducto
                    });

                    dgvProductos.DataSource = DetallePedidos.ToList();

                    txtCodigo.LimpiarTextbox();
                    txtCantidad.LimpiarTextbox();
                    btnGenerarPedido.Enabled = true;
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
            EsPedido_EsPedidoFabrica(tbMantenerFiltro.Checked);

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

        }

        private void dgvProductos_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception is FormatException)
            {
                e.ThrowException = false;
            }
        }
    }
}

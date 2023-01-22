using Contracts.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.SubForms.Pedidos.CargarPedido
{
    public partial class FmCrearPedido : Form
    {
        private IPedidosController _pedidosController;
        private IClientesController _clientesController;
        private IProductosController _productosController;
        public FmCrearPedido(IPedidosController pedidosController, IClientesController clientesController, IProductosController productosController)
        {
            InitializeComponent();
            _pedidosController = pedidosController;
            _clientesController = clientesController;
            _productosController = productosController;
        }

        private void FmCrearPedido_Load(object sender, EventArgs e)
        {
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtResidencia.Enabled = false;
            txtMail.Enabled = false;
            txtTelefono.Enabled = false;
        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (txtDNI.Text.Length == 8)
            {
                string DNI = txtDNI.Text;
                var Cliente = _clientesController.ObtenerCliente(DNI);
                if (Cliente is null)
                {
                    MessageBox.Show("El cliente con el dni: " + txtDNI.Text + " No existe, vuelva a ingresarlo porfavor");
                    txtDNI.Text = "";
                }
                else
                {
                    txtNombre.Text = Cliente.Nombre;
                    txtResidencia.Text = Cliente.Residencia;
                    txtApellido.Text = Cliente.Apellido;
                    txtMail.Text = Cliente.Mail;
                    txtTelefono.Text = Cliente.Telefono;
                }
            }
            else
            {
                txtNombre.Text = "";
                txtResidencia.Text = "";
                txtApellido.Text = "";
                txtMail.Text = "";
                txtTelefono.Text = "";
            }
        }

        private void altoTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length >= 8)
            {
                string CodigoProducto = txtCodigo.Text;
                var Producto = _productosController.ObtenerProducto(CodigoProducto);
                if (Producto is null)
                {
                    MessageBox.Show("El cliente con el dni: " + txtDNI.Text + " No existe, vuelva a ingresarlo porfavor");
                    txtDNI.Text = "";
                }
                else
                {
                    //txtNombre.Text = Cliente.Nombre;
                    //txtResidencia.Text = Cliente.Residencia;
                    //txtApellido.Text = Cliente.Apellido;
                    //txtMail.Text = Cliente.Mail;
                    //txtTelefono.Text = Cliente.Telefono;
                }
            }
        }

        private void txtDNI_Click(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDNI.Text, "[^0-9]"))
            {
                txtDNI.Text = txtDNI.Text.Remove(txtDNI.Text.Length - 1);
            }
        }
    }
}

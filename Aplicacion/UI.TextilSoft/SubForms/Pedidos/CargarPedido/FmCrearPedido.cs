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
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools.ExtensionsControls;

namespace UI.TextilSoft.SubForms.Pedidos.CargarPedido
{
    public partial class FmCrearPedido : Form
    {
        private IControllerFactory _factory;
        public FmCrearPedido(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
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
                var Cliente = _factory.Use<IClientesController>().ObtenerCliente(DNI);
                if (Cliente is null)
                {
                    MessageBox.Show("El cliente con el dni: " + txtDNI.Text + " No existe, vuelva a ingresarlo porfavor");
                    txtDNI.LimpiarTextbox();
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
                txtNombre.LimpiarTextbox();
                txtResidencia.LimpiarTextbox();
                txtApellido.LimpiarTextbox();
                txtMail.LimpiarTextbox();
                txtTelefono.LimpiarTextbox();
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
                var Producto = _factory.Use<IProductosController>().ObtenerProducto(CodigoProducto);
                if (Producto is null)
                {
                    MessageBox.Show("El cliente con el dni: " + txtDNI.Text + " No existe, vuelva a ingresarlo porfavor");
                    txtDNI.LimpiarTextbox();
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

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
        public FmCrearPedido(IPedidosController pedidosController, IClientesController clientesController)
        {
            InitializeComponent();
            _pedidosController = pedidosController;
            _clientesController = clientesController;
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
                int DNI = Convert.ToInt32(txtDNI.Text);
                var Cliente = _clientesController.ObtenerCliente(DNI);
                txtNombre.Text = Cliente.Nombre;
                txtResidencia.Text = Cliente.Residencia;
                txtApellido.Text = Cliente.Apellido;
                txtMail.Text = Cliente.Mail;
                txtTelefono.Text = Cliente.Telefono;
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
    }
}

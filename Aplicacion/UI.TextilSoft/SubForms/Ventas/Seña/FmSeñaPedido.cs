using Contracts.Controllers;
using Domain.Entities;
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
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Ventas.Seña
{
    public partial class FmSeñaPedido : Form
    {
        private readonly IControllerFactory _factory;
        private ClientesEntity clientesEntity;

        public FmSeñaPedido(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
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
                    txtCantidadSeña.Enabled = false;
                    txtCodigoPedido.Enabled = false;
                    btnAgregarSeña.Enabled = false;
                }
                else
                {
                    txtNombre.Text = Cliente.Nombre;
                    txtResidencia.Text = Cliente.Residencia;
                    txtApellido.Text = Cliente.Apellido;
                    txtMail.Text = Cliente.Mail;
                    txtTelefono.Text = Cliente.Telefono;
                    txtCantidadSeña.Enabled = true;
                    txtCodigoPedido.Enabled = true;
                    btnAgregarSeña.Enabled = true;
                    clientesEntity = new ClientesEntity();
                    clientesEntity = Cliente;
                }
            }
            else
            {
                txtCantidadSeña.Enabled = false;
                txtCodigoPedido.Enabled = false;
                btnAgregarSeña.Enabled = false;
                txtCantidadSeña.LimpiarTextbox();
                txtCodigoPedido.LimpiarTextbox();
                txtNombre.LimpiarTextbox();
                txtResidencia.LimpiarTextbox();
                txtApellido.LimpiarTextbox();
                txtMail.LimpiarTextbox();
                txtTelefono.LimpiarTextbox();
            }
        }

        private void btnAgregarSeña_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCantidadSeña.Text))
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error datos faltantes", "Por favor ingrese la cantidad", centerPosition);
                    fmMessageBox.ShowDialog();
                    return;
                }
                var pedido = _factory.UseNew<IPedidosController<ListarPedidosEntity>>().ObtenerPedido(Convert.ToInt32(txtCodigoPedido.Text), clientesEntity);
                if (pedido is null)
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de existencia", "El pedido asociado a ese código no existe!", centerPosition);
                    fmMessageBox.ShowDialog();
                    return;
                }
                _factory.Use<IPedidosController<ListarPedidosEntity>>().AgregarSeña(Convert.ToInt32(pedido.PedidoID), Convert.ToDecimal(txtCantidadSeña.Text));
                var centerPosition2 = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox2 = new FmMessageBox(Tools.MessageBoxType.Success, "Operación exitosa", "Se agregó la seña correctamente!", centerPosition2);
                fmMessageBox2.ShowDialog();
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error al señar", ex.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }
        }
    }
}

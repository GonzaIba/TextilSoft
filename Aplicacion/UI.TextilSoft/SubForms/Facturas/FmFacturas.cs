using AltoControls;
using Contracts.Controllers;
using Domain.Entities;
using Domain.Enum;
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
using UI.TextilSoft.MainForm;
using UI.TextilSoft.Tools.ExtensionsControls;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Facturas
{
    public partial class FmFacturas : Form
    {
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        private ClientesEntity Cliente;
        public FmFacturas(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            //foreach (Control control in this.Controls)
            //{
            //    if (control.Name.Contains("txt") && control.Name != "txtColor")
            //    {
            //        AltoTextBox textBox = (AltoTextBox)control;
            //        if (string.IsNullOrWhiteSpace(textBox.Text) && string.IsNullOrEmpty(textBox.Text))
            //        {
            //            toolTipError.Show("Por favor, complete el campo", textBox, 0, -20, 2000);
            //            textBox.Focus();
            //            return;
            //        }
            //    }
            //}

            try
            {
                if (!string.IsNullOrEmpty(txtCodigoPedido.Text))
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    var detallePedido = _factory.UseNew<IPedidosController<ListarPedidosEntity>>().ObtenerDetallePedido(Convert.ToInt32(txtCodigoPedido.Text));
                    if (detallePedido.Item1 == null && detallePedido.Item2 == null)
                    {
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "No encontrado", "No hay ningún pedido con este código para facturar", centerPosition);
                        fmMessageBox.ShowDialog();
                        return;
                    }

                    GrillaDetallePedido.DataSource = detallePedido.Item1;
                    Cliente = new();
                    Cliente = detallePedido.Item2;
                    txtDNI.Text = detallePedido.Item2.DNI.ToString();
                    txtNombre.Text = detallePedido.Item2.Nombre;
                    txtResidencia.Text = detallePedido.Item2.Residencia;
                    txtApellido.Text = detallePedido.Item2.Apellido;
                    txtMail.Text = detallePedido.Item2.Mail;
                    txtTelefono.Text = detallePedido.Item2.Telefono;
                    txtNota.Enabled = true;
                }
                else
                {
                    txtCodigoPedido.Focus();
                    toolTipError.Show("Por favor, ingrese el código de pedido", txtCodigoPedido, 0, -20, 2000);
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error", ex.Message, centerPosition, true);
                fmMessageBox.ShowDialog();
            }
        }

        private void btnGenerarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Generar factura", "Estas seguro de generar la factura?", centerPosition, true);
                fmMessageBox.ShowDialog();
                var result = fmMessageBox.btnAceptar;
                if (result)
                {
                    _factory.UseNew<IFacturasController>().GenerarFactura(Convert.ToInt32(txtCodigoPedido.Text), txtNota.Text, _fmTextilSoft._usuarioInformacion.DNI);
                    FmMessageBox fmMessageBox2 = new FmMessageBox(Tools.MessageBoxType.Success, "Factura Generada", "Se generó la factura correctamente!", centerPosition);
                    fmMessageBox2.ShowDialog();
                    GrillaDetallePedido.DataSource = null;
                    txtDNI.Text = "";
                    txtNombre.Text = "";
                    txtResidencia.Text = "";
                    txtApellido.Text = "";
                    txtMail.Text = "";
                    txtTelefono.Text = "";
                    txtNota.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error", ex.Message, centerPosition, true);
                fmMessageBox.ShowDialog();
            }
        }
    }
}

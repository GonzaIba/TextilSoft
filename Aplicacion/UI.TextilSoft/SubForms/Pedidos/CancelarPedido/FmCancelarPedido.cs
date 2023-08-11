using AltoControls;
using Contracts.Controllers;
using Domain.Entities;
using Domain.Enum;
using SL.Contracts;
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

namespace UI.TextilSoft.SubForms.Pedidos.CancelarPedido
{
    public partial class FmCancelarPedido : Form
    {
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        private ClientesEntity Cliente;
        public FmCancelarPedido(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            btnCancelarPedido.Enabled = false;
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
        }

        private void btnBuscarPedido_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control.Name.Contains("txt") && control.Name != "txtColor")
                {
                    AltoTextBox textBox = (AltoTextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Text) && string.IsNullOrEmpty(textBox.Text))
                    {
                        toolTipError.Show("Por favor, complete el campo", textBox, 0, -20, 2000);
                        textBox.Focus();
                        return;
                    }
                }
            }

            string DNI = txtDNI.Text;
            Cliente = new();
            Cliente = _factory.UseNew<IClientesController>().ObtenerCliente(DNI);
            if (Cliente is null)
            {
                MessageBox.Show("El cliente con el dni: " + txtDNI.Text + " No existe, vuelva a ingresarlo porfavor");
                txtDNI.LimpiarTextbox();
                return;
            }

            try
            {
                if (!string.IsNullOrEmpty(txtCodigoPedido.Text))
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    var pedido = _factory.UseNew<IPedidosController<ListarPedidosEntity>>().ObtenerPedido(Convert.ToInt32(txtCodigoPedido.Text), Cliente);
                    List<ListarPedidosEntity> listaPedido = new();
                    if (pedido.EstadoPedido == EstadoPedidosEnum.Cancelado)
                    {
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "No encontrado", "Este pedido ya fue cancelado!", centerPosition);
                        fmMessageBox.ShowDialog();
                    }
                    else if (pedido.EstadoPedido == EstadoPedidosEnum.Entregado)
                    {
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "No encontrado", "Este pedido ya fue entregado, no puede cancelarse!", centerPosition);
                        fmMessageBox.ShowDialog();
                    }
                    else if (pedido != null)
                    {
                        listaPedido.Add(pedido);
                        GrillaPedidos.DataSource = listaPedido;
                        btnCancelarPedido.Enabled = true;
                    }
                    else
                    {
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "No encontrado", "No existe ningún pedido asociado a este código", centerPosition);
                        fmMessageBox.ShowDialog();
                    }
                }
                else
                {
                    txtCodigoPedido.Focus();
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error", ex.Message, centerPosition, true);
                fmMessageBox.ShowDialog();
            }
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Cancelar pedido", "Esta seguro de cancelar el pedido?", centerPosition, true);
                fmMessageBox.ShowDialog();
                var result = fmMessageBox.btnAceptar;
                if (result)
                {
                    var pedido = GrillaPedidos.DataSource as List<ListarPedidosEntity>;
                    _factory.UseNew<IPedidosController<ListarPedidosEntity>>().CancelarPedido(pedido.FirstOrDefault().NroPedido, Cliente);
                    FmMessageBox fmMessageBox2 = new FmMessageBox(Tools.MessageBoxType.Success, "Pedido Cancelado", "Se canceló el pedido correctamente!", centerPosition);
                    fmMessageBox2.ShowDialog();
                    GrillaPedidos.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error", "Ocurrió un error fatal al cancelar el pedido. Intente nuevamente mas tarde.", centerPosition, true);
                fmMessageBox.ShowDialog();
            }
        }

        private void txtCodigoPedido_TextChanged(object sender, EventArgs e)
        {
            if (btnCancelarPedido.Enabled)
            {
                GrillaPedidos.DataSource = null;
                btnCancelarPedido.Enabled = false;
            }
        }
    }
}

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
using UI.TextilSoft.Configurations;
using UI.TextilSoft.SubForms.Pedidos.AdministrarPedido;
using UI.TextilSoft.SubForms.Pedidos.CargarPedido;
using UI.TextilSoft.SubForms.Pedidos.ListarPedidos;

namespace UI.TextilSoft.SubForms.Pedidos
{
    public partial class FmPedidos : Form
    {
        private Form activeForm = null;
        private IPedidosController _pedidosController;
        private IClientesController _clientesController;
        private IProductosController _productosController;
        public FmPedidos(IPedidosController pedidosController, IClientesController clientesController, IProductosController productosController)
        {
            InitializeComponent();
            _pedidosController = pedidosController;
            _clientesController = clientesController;
            _productosController = productosController;
        }

        private void AbrirFormHija(Form formhija)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formhija);
                panelContenedor.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();
                if(PerformanceConfiguration.EnabledAnimator)
                    AbrirAnimator();
            }
            else
            {
                activeForm = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formhija);
                panelContenedor.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();
                if (PerformanceConfiguration.EnabledAnimator)
                    AbrirAnimator();
            }
        }

        private async void AbrirAnimator()
        {
            //LogoAnimator.Hide(labelBienvenida);
            await Task.Run(() =>
            {
                panelContenedor.Visible = false;
                PanelAnimator.ShowSync(panelContenedor, true);
            });
        }

        private void btnAdministrarPedido_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmAdministrarPedido());
        }

        private void btnCrearPedido_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new FmCrearPedido(_pedidosController, _clientesController, _productosController));
        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmListarPedidos(_pedidosController));
        }
    }
}

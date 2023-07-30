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
using UI.TextilSoft.Factory;
using UI.TextilSoft.MainForm;
using UI.TextilSoft.SubForms.Pedidos.AdministrarPedido;
using UI.TextilSoft.SubForms.Produccion.ABM_Productos;
using UI.TextilSoft.SubForms.Produccion.GestionarAP;
using UI.TextilSoft.SubForms.Produccion.ListarProductos;

namespace UI.TextilSoft.SubForms.Produccion
{
    public partial class FmProduccion : Form
    {
        private Form activeForm = null;
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmProduccion(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
            InitializeComponent();
        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmListarProductos(_factory));
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
                if (_fmTextilSoft._user.EnableAnimators)
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
                if (_fmTextilSoft._user.EnableAnimators)
                    AbrirAnimator();
            }
        }

        private async void AbrirAnimator()
        {
            await Task.Run(() =>
            {
                panelContenedor.Visible = false;
                PanelAnimator.ShowSync(panelContenedor, true);
            });
        }

        private void btnGestionarAP_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmArmadoProducto(_factory,_fmTextilSoft));
        }

        private void fmCboxABM_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            if (fmCboxABM.SelectedIndex == 0)
            {
                AbrirFormHija(new FmCrearProducto(_factory));
            }
            else if (fmCboxABM.SelectedIndex == 1)
            {
                AbrirFormHija(new FmModificarProducto(_factory));
            }
            else
            {
                AbrirFormHija(new FmEliminarProducto(_factory));
            }
        }
    }
}

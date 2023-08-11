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
using UI.TextilSoft.Factory;
using UI.TextilSoft.MainForm;
using UI.TextilSoft.SubForms.Pedidos.AdministrarPedido;
using UI.TextilSoft.SubForms.Pedidos.CancelarPedido;
using UI.TextilSoft.SubForms.Pedidos.CargarPedido;
using UI.TextilSoft.SubForms.Pedidos.ListarPedidos;
using UI.TextilSoft.SubForms.Pedidos.OrdenDeTrabajo;

namespace UI.TextilSoft.SubForms.Pedidos
{
    public partial class FmPedidos : Form
    {
        private Form activeForm = null;
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmPedidos(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
            InitializeComponent();
        }

        private void AbrirFormHija(Form formhija)
        {
            if (activeForm != null)
            {
                if (formhija is FmCrearPedido)
                {
                    if (_fmTextilSoft.formPedido != null)
                    {
                        _fmTextilSoft.formPedido.Visible = false;
                        _fmTextilSoft.formPedido.BackColor = Color.FromArgb(32, 30, 45);
                        _fmTextilSoft.formPedido.TopLevel = false;
                        _fmTextilSoft.formPedido.FormBorderStyle = FormBorderStyle.None;
                        _fmTextilSoft.formPedido.Dock = DockStyle.Fill;
                        panelContenedor.Controls.Add(_fmTextilSoft.formPedido);
                        panelContenedor.Tag = _fmTextilSoft.formPedido;
                        _fmTextilSoft.formPedido.BringToFront();
                        if (_fmTextilSoft._user.EnableAnimators)
                            AbrirAnimator();
                        else
                            _fmTextilSoft.formPedido.Show();
                    }
                    else
                    {
                        activeForm.Close();
                        _fmTextilSoft.formPedido = formhija;
                        _fmTextilSoft.formPedido.Visible = false;
                        _fmTextilSoft.formPedido.BackColor = Color.FromArgb(32, 30, 45);
                        _fmTextilSoft.formPedido.TopLevel = false;
                        _fmTextilSoft.formPedido.FormBorderStyle = FormBorderStyle.None;
                        _fmTextilSoft.formPedido.Dock = DockStyle.Fill;
                        panelContenedor.Controls.Add(_fmTextilSoft.formPedido);
                        panelContenedor.Tag = _fmTextilSoft.formPedido;
                        _fmTextilSoft.formPedido.BringToFront();
                        if (_fmTextilSoft._user.EnableAnimators)
                            AbrirAnimator();
                        else
                            _fmTextilSoft.formPedido.Show();
                    }
                }
                else
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
                    if (_fmTextilSoft._user.EnableAnimators)
                        AbrirAnimator();
                    else
                        formhija.Show();
                }
            }
            else
            {
                if (formhija is FmCrearPedido)
                {
                    if (_fmTextilSoft.formPedido != null)
                    {
                        _fmTextilSoft.formPedido.Visible = false;
                        _fmTextilSoft.formPedido.BackColor = Color.FromArgb(32, 30, 45);
                        _fmTextilSoft.formPedido.TopLevel = false;
                        _fmTextilSoft.formPedido.FormBorderStyle = FormBorderStyle.None;
                        _fmTextilSoft.formPedido.Dock = DockStyle.Fill;
                        panelContenedor.Controls.Add(_fmTextilSoft.formPedido);
                        panelContenedor.Tag = _fmTextilSoft.formPedido;
                        _fmTextilSoft.formPedido.BringToFront();
                        if (_fmTextilSoft._user.EnableAnimators)
                            AbrirAnimator();
                        else
                            _fmTextilSoft.formPedido.Show();
                    }
                    else
                    {
                        _fmTextilSoft.formPedido = formhija;
                        _fmTextilSoft.formPedido.Visible = false;
                        _fmTextilSoft.formPedido.BackColor = Color.FromArgb(32, 30, 45);
                        _fmTextilSoft.formPedido.TopLevel = false;
                        _fmTextilSoft.formPedido.FormBorderStyle = FormBorderStyle.None;
                        _fmTextilSoft.formPedido.Dock = DockStyle.Fill;
                        panelContenedor.Controls.Add(_fmTextilSoft.formPedido);
                        panelContenedor.Tag = _fmTextilSoft.formPedido;
                        _fmTextilSoft.formPedido.BringToFront();
                        _fmTextilSoft.formPedido.Show();
                        if (_fmTextilSoft._user.EnableAnimators)
                            AbrirAnimator();
                    }
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
                    if (_fmTextilSoft._user.EnableAnimators)
                        AbrirAnimator();
                    else
                        formhija.Show();
                }
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
            AbrirFormHija(new FmAdministrarPedido(_factory));
        }

        private void btnCrearPedido_Click_1(object sender, EventArgs e)
        {
            AbrirFormHija(new FmCrearPedido(_factory, _fmTextilSoft));
        }

        private void lblPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnListarPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmListarPedidos(_factory));
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmAsignarODT(_factory));
        }

        private void btnCancelarPedido_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmCancelarPedido(_factory, _fmTextilSoft));
        }

        private void btnCerrarODT_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmCerrarODT(_factory));
        }
    }
}

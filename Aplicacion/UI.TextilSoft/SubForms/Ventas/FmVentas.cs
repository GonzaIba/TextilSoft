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
using UI.TextilSoft.SubForms.Ventas.Prenda_Devuelta;
using UI.TextilSoft.SubForms.Ventas.Registrar_Venta;
using UI.TextilSoft.SubForms.Ventas.Seña;

namespace UI.TextilSoft.SubForms.Ventas
{
    public partial class FmVentas : Form
    {
        private Form activeForm = null;
        private IControllerFactory _factory;
        private FmTextilSoft _fmTextilSoft;
        public FmVentas(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
        }

        private void btnSeña_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmSeñaPedido(_factory));
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmRegistrarVenta(_factory,_fmTextilSoft));
        }

        private void btnDevolucionPrenda_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmPrendaDevuelta(_factory, _fmTextilSoft));
        }

        private void AbrirFormHija(Form formhija)
        {
            if (activeForm != null)
            {
                if (formhija is FmSeñaPedido)
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
                if (formhija is FmSeñaPedido)
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
    }
}

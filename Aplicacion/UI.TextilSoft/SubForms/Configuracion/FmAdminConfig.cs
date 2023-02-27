using SL.Contracts;
using SL.Domain.Entities;
using SL.Helper.Controllers;
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
using UI.TextilSoft.SubForms.Configuracion.Composite;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmAdminConfig : Form
    {
        private Form activeForm = null;
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        private readonly Usuario _usuario;
        public FmAdminConfig(IControllerFactory factory, Usuario usuario, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _usuario = usuario;
            _fmTextilSoft = fmTextilSoft;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmUsuarios(_factory, _usuario));
        }
        private void btnPatenteFamilia_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmPatenteFamilia(_factory, _usuario,_fmTextilSoft));
        }

        private void AbrirFormHija(Form formhija)
        {
            _fmTextilSoft.subForm = formhija;
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

                //AbrirAnimator();

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

                //AbrirAnimator();

            }
        }

        private void btnConfigCompany_Click(object sender, EventArgs e)
        {
            if (_usuario.IsOwner)
                AbrirFormHija(new FmCompanyConfig(_factory));
            else
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Error de acceso", "Usted no tiene permiso para acceder a esta pantalla", centerPosition);
                fmMessageBox.ShowDialog();
            }
            
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmConfiguracion(_factory,_usuario));
        }
    }
}

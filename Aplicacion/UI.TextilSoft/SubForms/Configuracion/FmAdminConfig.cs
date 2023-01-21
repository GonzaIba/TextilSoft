using SL.Contracts;
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
using UI.TextilSoft.SubForms.Configuracion.Composite;

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmAdminConfig : Form
    {
        private Form activeForm = null;
        private IUsuarioController _usuarioController;
        private IPermisosController _permisosController;
        public FmAdminConfig(IUsuarioController usuarioController, IPermisosController permisosController)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
            _permisosController = permisosController;
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmUsuarios(_usuarioController, _permisosController));
        }
        private void btnPatenteFamilia_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmPatenteFamilia(_usuarioController, _permisosController));
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
    }
}

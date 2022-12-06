using Contracts.Controllers;
using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using SL.Contracts;
using SL.Domain.Entities;
using SL.Domain.Enums;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Configurations.Authentication;
using UI.TextilSoft.Controllers;

namespace UI.TextilSoft.MainForm
{
    public partial class FmLogin : Form
    {
        #region Inyection
        private int cont = 0;
        private readonly IOrdenDeTrabajoController _ordenDeTrabajoController;
        private readonly IProductosController _productosController;
        private readonly IUsuarioController _userController;
        private readonly IProveedoresController _proveedoresController;
        private readonly IProductoProveedorController _productoProveedorController;
        private readonly IPedidosController _pedidosController;
        private readonly ISectorController _sectorController;
        private readonly IClientesController _clientesController;
        private readonly IFacturasController _facturasController;
        private readonly IVentasController _ventasController;
        private readonly IEmpleadosController _empleadosController;
        private readonly IConfiguration _configuration;
        private readonly ICompanyController _companyController;

        //private readonly PasswordConfig _passwordConfig;

        public FmLogin(IUsuarioController userController,
                        IProveedoresController proveedoresController,
                        IClientesController clientesController,
                        IPedidosController pedidosController,
                        ISectorController sectorController,
                        IFacturasController facturasController,
                        IEmpleadosController empleadosController,
                        IVentasController ventasController,
                        IOrdenDeTrabajoController ordenDeTrabajoController,
                        IProductoProveedorController productoProveedorController,
                        IProductosController productosController,
                        IConfiguration configuration,
                        ICompanyController companyController
                        )
        {
            InitializeComponent();
            _proveedoresController = proveedoresController;
            _clientesController = clientesController;
            _ventasController = ventasController;
            _sectorController = sectorController;
            _empleadosController = empleadosController;
            _facturasController = facturasController;
            _ordenDeTrabajoController = ordenDeTrabajoController;
            _productosController = productosController;
            _productoProveedorController = productoProveedorController;
            _pedidosController = pedidosController;
            _configuration = configuration;

            
            _userController = userController;
            _companyController = companyController;
            CheckForIllegalCrossThreadCalls = false;
        }
        #endregion

        private string txtUserNameTextBase;
        private string txtPasswordTextBase;

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(txtUser.Text) || txtUser.Text == txtUserNameTextBase)
            {
                pnlUserNameError.Visible = true;
                lblUserNameError.Text = "El usuario es requerido";
                txtUser.Focus();
                return;
            }
            else if(string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == txtPasswordTextBase)
            {
                pnlPasswordError.Visible = true;
                lblPasswordError.Text = "La contraseña es requerido";
                txtPassword.Focus();
                return;
            }



            Login login = new Login();
            login.Usuario = txtUser.Text;
            login.Contraseña = txtPassword.Text;
            string Result = _userController.LoginUser(login);

            Usuario user = new Usuario();
            IList<Componente> flia = null;

            if (Result == "Ok")
            {
                var usuario = _userController.GetUser(login);
                //_empleadosController.LoginEmpleado(usuario);
                FmTextilSoft fmTextilSoft = new FmTextilSoft(_proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController, _configuration);
                fmTextilSoft.toolStrip1.Tag = login;
                fmTextilSoft.btnPedidos.Enabled = false;
                fmTextilSoft.Show();
            }
            else
            {
                ShowLoginError();
                //MessageBox.Show(Result);
            }
        }
        public void ShowLoginError()
        {
            //this.Opacity = 0;
            lblLoginError.Visible = true;
            timer1.Start();
            //timer2.Start();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pnlPasswordError.Visible = false;
                pnlUserNameError.Visible = false;
                txtUser.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar el usuario");
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtPassword.Text != txtPasswordTextBase)
                {
                    //txtPassword.Text = "";
                    pnlPasswordError.Visible = false;
                    pnlUserNameError.Visible = false;
                    txtPassword.ForeColor = Color.White;
                    txtPassword.PasswordChar = '*';
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar la contraseña");
            }
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == txtUserNameTextBase)
                txtUser.Text = "";
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordTextBase)
                txtPassword.Text = "";
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {
            lblLoginError.Visible = false;
            lblLoginError.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            bool ExistCompany = _companyController.VerifyCompany();

            if (!ExistCompany)
                MessageBox.Show("No existe la compañía");
            else
            {
                try
                {
                    txtUserNameTextBase = txtUser.Text;
                    txtPasswordTextBase = txtPassword.Text;
                    pnlPasswordError.Visible = false;
                    pnlUserNameError.Visible = false;
                    CompanyCustomizeEntity company = _companyController.GetCustomizeCompany();
                    lblCompanyName.Text = company.Name;
                    //Convert Logo to Image
                    byte[] imageBytes = Convert.FromBase64String(company.Logo);
                    MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                    ms.Write(imageBytes, 0, imageBytes.Length);
                    Image image = Image.FromStream(ms, true);
                    picCompanyLogo.Image = image;
                    //picCompanyLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                    //picCompanyLogo.BorderStyle = BorderStyle.Fixed3D;
                    //picCompanyLogo.Size = new Size(200, 200);
                    //picCompanyLogo.Location = new Point(10, 10);
                    //picCompanyLogo.BackColor = Color.Transparent;
                    //picCompanyLogo.Visible = true;
                    //picCompanyLogo.BringToFront();
                    //picCompanyLogo.SendToBack();
                    //picCompanyLogo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    //picCompanyLogo.Dock = DockStyle.Fill;
                    //picCompanyLogo.Padding = new Padding(10);
                    //picCompanyLogo.Margin = new Padding(10);
                }
                catch (Exception ex)
                {
                    
                }            
            }
                
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text.ToString()))
            {
                txtUser.Text = txtUserNameTextBase;
                txtUser.ForeColor = Color.Gray;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text.ToString()))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = txtPasswordTextBase;
                txtPassword.ForeColor = Color.Gray;
            }
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FmRegistrarse fmRecoveryPassword = new FmRegistrarse(_userController, _companyController);
            fmRecoveryPassword.Show();
            //this.Close();
        }

        #region Fade in Labels
        int[] targetColor = { 255, 255, 255 };
        int[] fadeRGB = new int[3];

        void FadeIn()
        {
            fadeRGB[0] = lblLoginError.ForeColor.R;
            fadeRGB[1] = lblLoginError.ForeColor.G;
            fadeRGB[2] = lblLoginError.ForeColor.B;
            if (fadeRGB[0] > targetColor[0])
                fadeRGB[0]--;
            else if (fadeRGB[0] < targetColor[0])
                fadeRGB[0]++;
            if (fadeRGB[1] > targetColor[1])
                fadeRGB[1]--;
            else if (fadeRGB[1] < targetColor[1])
                fadeRGB[1]++;
            if (fadeRGB[2] > targetColor[2])
                fadeRGB[2]--;
            else if (fadeRGB[2] < targetColor[2])
                fadeRGB[2]++;
            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
            {
                //timer1.Stop();
                //timer2.Stop();
            }
            lblLoginError.ForeColor = Color.FromArgb(fadeRGB[0], fadeRGB[1], fadeRGB[2]);
        }
        #endregion
        //int fadingSpeed = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            int fadingSpeed = 3;
            lblLoginError.ForeColor = Color.Black;
            lblLoginError.ForeColor = Color.FromArgb(lblLoginError.ForeColor.R + fadingSpeed, lblLoginError.ForeColor.G + fadingSpeed, lblLoginError.ForeColor.B + fadingSpeed);
            //if (lblLoginError.ForeColor.R >= this.BackColor.R)
            //{
            lblLoginError.ForeColor = this.BackColor;
            timer1.Stop();
            //}
            //FadeIn();
            //this.Refresh();
        }

        private async void FadeIn2()
        {

        }
    }
}

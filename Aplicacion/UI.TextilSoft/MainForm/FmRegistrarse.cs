using Contracts.Controllers;
using Microsoft.Extensions.Configuration;
using SL.Contracts;
using SL.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.SubForms.Proveedores;

namespace UI.TextilSoft.MainForm
{
    public partial class FmRegistrarse : Form
    {
        #region Constructor
        private readonly IPermisosController _permisoController;
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
        private AuthenticationConfig _authenticationConfig;
        private Form Activeform = null;
        private bool UsuarioChecked;
        private bool EmailChecked;
        private bool PasswordChecked;
        private bool DNIChecked;
        

        public FmRegistrarse(IPermisosController permisosController,
                        IUsuarioController userController,
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
            _permisoController = permisosController;
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
            
            _authenticationConfig = _companyController.GetAuthenticationConfig();

            CheckForIllegalCrossThreadCalls = false;

            if(!_authenticationConfig.PasswordConfig.RequireLowercase)
            {
                lblMinuscula.Visible = false;
                minuscula.Visible = false;
            }
            if (!_authenticationConfig.PasswordConfig.RequireUppercase)
            {
                lblMayuscula.Visible = false;
                mayuscula.Visible = false;
            }
            if (!_authenticationConfig.PasswordConfig.RequireDigit)
            {
                lblNumero.Visible = false;
                numero.Visible = false;
            }
            if (!_authenticationConfig.PasswordConfig.RequireNonAlphanumeric)
            {
                lblEspecial.Visible = false;
                carespecial.Visible = false;
            }
            lblMinimo.Text = $"Minimo {_authenticationConfig.PasswordConfig.CountLength} caracteres";
            //Execute event MostrarContraseñaCB checked
            MostrarContraseñaCB.Checked = false;
            MostrarContraseñaCB_CheckedChanged(null, null);


        }
        #endregion
        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Nombre = txtUsuario.Text;
            register.Email = txtMail.Text;
            register.Password = txtPassword.Text;
            register.ConfirmPassword = txtConfirmPassword.Text;

            if (register.Password == register.ConfirmPassword)
            {
                if (_userController.Crearusuario(register, _companyController.GetCurrentCompany()))
                {
                    if (_authenticationConfig.SignInRequireConfirmedAccount)
                    {
                        try
                        {
                            _userController.EnviarConfirmacionEmail(register.Email);
                            MessageBox.Show("Se ha enviado un correo de confirmación a su casilla de correo");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo enviar el correo, inténtelo en la pantalla principal en unos segundos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario registrado correctamente");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario");
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }

        private bool AlgoritmoContraseñaSegura(string password)
        {
            mayuscula.Checked = false; minuscula.Checked = false; numero.Checked = false; carespecial.Checked = false; minimo.Checked = false;

            //Primero validamos la configuración de la compañía
            if (!_authenticationConfig.PasswordConfig.RequireUppercase)
                mayuscula.Checked = true;
            if (!_authenticationConfig.PasswordConfig.RequireLowercase)
                minuscula.Checked = true;
            if (!_authenticationConfig.PasswordConfig.RequireDigit)
                numero.Checked = true;
            if (!_authenticationConfig.PasswordConfig.RequireNonAlphanumeric)
                carespecial.Checked = true;
            
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >= _authenticationConfig.PasswordConfig.CountLength)
                    minimo.Checked = true;
                if (Char.IsUpper(password, i))
                    mayuscula.Checked = true;
                else if (Char.IsLower(password, i))
                    minuscula.Checked = true;
                else if (Char.IsDigit(password, i))
                    numero.Checked = true;
                else
                    carespecial.Checked = true;
            }
            if (mayuscula.Checked && minuscula.Checked && numero.Checked && carespecial.Checked && password.Length >= _authenticationConfig.PasswordConfig.CountLength)
                return true;
            return false;
        }
        private void VerifyAllFieldsChecked()
        {
            if (UsuarioChecked && EmailChecked && PasswordChecked && DNIChecked)
            {
                BtnRegistrarse.Enabled = true;
            }
            else
            {
                BtnRegistrarse.Enabled = false;
            }
        }
        private void VerifySamePassword()
        {
            if (txtConfirmPassword.Text == txtPassword.Text)
            {
                PasswordChecked = true;
                pnlConfirmPassword.BackColor = Color.Green;
            }
            else
            {
                PasswordChecked = false;
                pnlConfirmPassword.BackColor = Color.Red;
                toolTipError.Show("Las contraseñas no coinciden", txtConfirmPassword, 0, -20, 2000);
            }
            VerifyAllFieldsChecked();
        }
        #region txtChanged
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (AlgoritmoContraseñaSegura(txtPassword.Text))
            {
                VerifySamePassword();
                pnlPassword.BackColor = Color.Green;
            }
            else
            {
                pnlPassword.BackColor = Color.Red;
                PasswordChecked = false;
            }


            VerifyAllFieldsChecked();
        }
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            VerifySamePassword();
            VerifyAllFieldsChecked();
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {         
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                if (_userController.ExisteEmail(txtMail.Text))
                {
                    EmailChecked = false;
                    pnlEmail.BackColor = Color.Red;
                    toolTipError.Show("Ya existe un usuario asociado a este Email", txtMail, 0, -20, 2000);
                }
                else
                {
                    pnlEmail.BackColor = Color.Green;
                    EmailChecked = true;
                }
            }
            else
            {
                EmailChecked = false;
                pnlEmail.BackColor = Color.Red;
                //toolTipError.Show("El email ya existe", txtMail, 0, -20, 2000);
            }
            VerifyAllFieldsChecked();
        }
        private void txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDNI.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtDNI, 0, -20, 2000);
                txtDNI.Text = txtDNI.Text.Remove(txtDNI.Text.Length - 1);
            }
            
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDNI.Text, @"^[0-9]{7,8}$"))
            {
                if (_userController.ExisteDNI(Convert.ToInt32(txtDNI.Text)))
                {
                    pnlDNI.BackColor = Color.Red;
                    DNIChecked = false;
                    toolTipError.Show("Ya existe un usuario asociado a este DNI", txtDNI, 0, -20, 2000);
                }
                else
                {
                    pnlDNI.BackColor = Color.Green;
                    DNIChecked = true;
                }
            }
            else
            {
                pnlDNI.BackColor = Color.Red;
                DNIChecked = false;
            }
            VerifyAllFieldsChecked();
        }
        private void txtNumeroTelefono_TextChanged(object sender, EventArgs e)
        {
            VerifyAllFieldsChecked();
            //Validate this type +XX X XX XXXX-XXXX
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNumeroTelefono.Text, @"^\+[0-9]{2}\s[0-9]{1}\s[0-9]{2}\s[0-9]{4}-[0-9]{4}$"))
                pnlTelefono.BackColor = Color.Green;
            else
                pnlTelefono.BackColor = Color.Red;

            //if (System.Text.RegularExpressions.Regex.IsMatch(txtNumeroTelefono.Text, @"^(\+54|54|0)?[0-9]{4}-[0-9]{4}$"))
            //    pnlTelefono.BackColor = Color.Green;
            //else
            //    pnlTelefono.BackColor = Color.Red;
        }
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (_userController.ExisteUsuario(txtUsuario.Text))
            {
                pnlUsuario.BackColor = Color.Red;
                UsuarioChecked = false;
                //Show tooltip Error

                toolTipError.Show("El nombre de usuario ya existe", txtUsuario, 0, -20, 2000);
            }
            else
            {
                pnlUsuario.BackColor = Color.Green;
                UsuarioChecked = true;
            }
            VerifyAllFieldsChecked();
        }
        #endregion

        private void FmRegistrarse_Load(object sender, EventArgs e)
        {
            BtnRegistrarse.Enabled = false;
            pnlEmail.BackColor = Color.FromArgb(30, 30, 30);
            pnlDNI.BackColor = Color.FromArgb(30, 30, 30);
            pnlTelefono.BackColor = Color.FromArgb(30, 30, 30);
            pnlUsuario.BackColor = Color.FromArgb(30, 30, 30);
            pnlPassword.BackColor = Color.FromArgb(30, 30, 30);
            pnlConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void MostrarContraseñaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (!MostrarContraseñaCB.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
        }

        private void btnBackLogin_Click(object sender, EventArgs e)
        {
            //FmLogin fmLogin = new FmLogin(_permisoController, _userController, _proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController, _configuration, _companyController);
            //fmLogin.Show();
            this.Close();
            //pnlRegistrarse.BringToFront();
            //AbrirFormHija(fmLogin);
        }
        private void AbrirFormHija(Form formhija)
        {
            if (Activeform != null)
            {
                Activeform.Close();
                Activeform = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                pnlRegistrarse.Controls.Add(formhija);
                pnlRegistrarse.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                AbrirAnimator();
            }
            else
            {
                Activeform = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                pnlRegistrarse.Controls.Add(formhija);
                pnlRegistrarse.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                AbrirAnimator();
            }
        }
        private void AbrirAnimator()
        {
            //LogoAnimator.Hide(labelBienvenida);
            pnlRegistrarse.Visible = false;
            RegistrarseAnimator.ShowSync(pnlRegistrarse);
        }

        private void minimo_MouseClick(object sender, MouseEventArgs e)
        {
            minimo.Checked = minimo.Checked;
        }

        private void carespecial_CheckedChanged(object sender, EventArgs e)
        {
            minimo.Checked = minimo.Checked;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNumeroTelefono.Text = string.Empty;          
        }
    }
}

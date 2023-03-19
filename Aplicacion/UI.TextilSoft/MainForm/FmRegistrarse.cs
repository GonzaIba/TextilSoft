using AnimatorNS;
using Contracts.Controllers;
using EllipticCurve.Utils;
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
using UI.TextilSoft.Configurations;
using UI.TextilSoft.Factory;
using UI.TextilSoft.SubForms.Proveedores;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.MainForm
{
    public partial class FmRegistrarse : Form
    {
        #region Constructor
        private readonly IControllerFactory _factory;
        private readonly FmLobby _fmLobby;
        private AuthenticationConfig _authenticationConfig;
        private Form Activeform = null;
        private bool UsuarioChecked;
        private bool EmailChecked;
        private bool PasswordChecked;
        private bool DNIChecked;
        

        public FmRegistrarse(IControllerFactory factory,FmLobby fmLobby)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _factory = factory;
            _fmLobby = fmLobby;

            _authenticationConfig = _factory.Use<ICompanyController>().GetAuthenticationConfig();

            //CheckForIllegalCrossThreadCalls = false;
            pnlRegistrarse.Visible = false;

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
            var centerPosition = new Point(this.Width / 2, this.Height / 2);

            if (register.Password == register.ConfirmPassword)
            {
                if (_factory.Use<IUsuarioController>().Crearusuario(register, _factory.Use<ICompanyController>().GetCurrentCompany()))
                {
                    if (_authenticationConfig.SignInRequireConfirmedAccount)
                    {
                        try
                        {
                            LimpiarControler();
                            pnlRegistrarse.BringToFront();
                            _factory.Use<IUsuarioController>().EnviarConfirmacionEmail(register.Email);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Envio exitoso", "Se ha enviado un correo de confirmación a su casilla de correo", centerPosition, false);
                            fmMessageBox.ShowDialog();
                            pnlRegistrarse.BringToFront();
                            AbrirFormHija(new FmIniciarSesion(_factory, _fmLobby));
                        }
                        catch (Exception ex)
                        {
                            _factory.UseNew<IUsuarioController>().EliminarUsuario(register.Nombre,register.Password);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de envío", "No se pudo enviar el correo, vuelva a crear el usuario o contacte con un administrador", centerPosition, false);
                            fmMessageBox.ShowDialog();
                        }
                    }
                    else
                    {
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Registro exitoso", "Usuario registrado correctamente", centerPosition, false);
                        fmMessageBox.ShowDialog();
                    }
                    this.Close();
                }
                else
                {
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error", "Error al registrar el usuario", centerPosition, false);
                    fmMessageBox.ShowDialog();
                }
            }
            else
            {
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Cuidado", "Las contraseñas no coinciden", centerPosition, false);
                fmMessageBox.ShowDialog();
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
                if (_factory.Use<IUsuarioController>().ExisteEmail(txtMail.Text))
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
                if (_factory.Use<IUsuarioController>().ExisteDNI(Convert.ToInt32(txtDNI.Text)))
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
            if (_factory.Use<IUsuarioController>().ExisteUsuario(txtUsuario.Text))
            {
                pnlUsuario.BackColor = Color.Red;
                UsuarioChecked = false;
                //Show tooltip Error

                toolTipError.Show("El nombre de usuario ya existe", txtUsuario, 0, -20, 2000);
            }
            else if(string.IsNullOrEmpty(txtUsuario.Text))
            {
                pnlUsuario.BackColor = Color.Red;
                UsuarioChecked = false;
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
            pnlRegistrarse.Visible = false;
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

        private async void AbrirFormHija(Form formhija)
        {
            if (Activeform != null)
            {
                Activeform.Close();
                Activeform = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(30, 30, 30);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                pnlRegistrarse.Controls.Add(formhija);
                pnlRegistrarse.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();
                if (PerformanceConfiguration.EnabledAnimator)
                    AbrirAnimator();
            }
            else
            {
                Activeform = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(30, 30, 30);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                pnlRegistrarse.Controls.Add(formhija);
                pnlRegistrarse.Tag = formhija;
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
                pnlRegistrarse.Visible = false;
                RegistrarseAnimator.AnimationType = AnimationType.HorizSlide;
                //Set decoration
                RegistrarseAnimator.SetDecoration(pnlRegistrarse, DecorationType.BottomMirror);
                RegistrarseAnimator.ShowSync(pnlRegistrarse);
            });
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
            LimpiarControler();
        }

        private void LimpiarControler()
        {
            txtUsuario.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtConfirmPassword.Text = string.Empty;
            txtMail.Text = string.Empty;
            txtDNI.Text = string.Empty;
            txtNumeroTelefono.Text = string.Empty;
            ChangeColorAllPanels();
        }

        private void ChangeColorAllPanels()
        {
            pnlEmail.BackColor = Color.FromArgb(30, 30, 30);
            pnlDNI.BackColor = Color.FromArgb(30, 30, 30);
            pnlTelefono.BackColor = Color.FromArgb(30, 30, 30);
            pnlUsuario.BackColor = Color.FromArgb(30, 30, 30);
            pnlPassword.BackColor = Color.FromArgb(30, 30, 30);
            pnlConfirmPassword.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void pnlRegistrarse_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBackLogin_Click_1(object sender, EventArgs e)
        {
            LimpiarControler();
            pnlRegistrarse.BringToFront();
            AbrirFormHija(new FmIniciarSesion(_factory, _fmLobby));
        }
    }
}

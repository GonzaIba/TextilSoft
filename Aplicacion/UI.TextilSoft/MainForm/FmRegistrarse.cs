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

namespace UI.TextilSoft.MainForm
{
    public partial class FmRegistrarse : Form
    {
        //Create all controllers
        private readonly IUsuarioController _usuarioController;
        private readonly ICompanyController _companyController;


        //pass by parameter UsuarioController
        public FmRegistrarse(IUsuarioController usuarioController, ICompanyController companyController)
        {
            _usuarioController = usuarioController;
            _companyController = companyController;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRegistrarse_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Nombre = txtUsuario.Text;
            register.Email = txtMail.Text;
            register.Password = txtPassword.Text;
            register.ConfirmPassword = txtConfirmPassword.Text;

            if (register.Password == register.ConfirmPassword)
            {
                if (_usuarioController.CreateUser(register, _companyController.GetCurrentCompany()))
                {
                    MessageBox.Show("Usuario registrado correctamente");
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
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length >= 8)
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
            if (mayuscula.Checked && minuscula.Checked && numero.Checked && carespecial.Checked && password.Length >= 8)
                return true;
            return false;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (AlgoritmoContraseñaSegura(txtPassword.Text))
                BtnRegistrarse.Enabled = true;
            else
                BtnRegistrarse.Enabled = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FmRegistrarse_Load(object sender, EventArgs e)
        {
            BtnRegistrarse.Enabled = false;
            pnlEmail.BackColor = Color.FromArgb(30, 30, 30);
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            //validate email with regex
            if (System.Text.RegularExpressions.Regex.IsMatch(txtMail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                pnlEmail.BackColor = Color.Green;
            }
            else
            {
                pnlEmail.BackColor = Color.Red;
            }
        }
    }
}

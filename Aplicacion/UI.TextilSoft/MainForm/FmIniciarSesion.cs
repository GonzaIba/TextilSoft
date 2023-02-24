using Contracts.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SL.Contracts;
using SL.Domain.Entities;
using SL.Domain.Enums;
using SL.Helper.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Background;
using UI.TextilSoft.Configurations;
using UI.TextilSoft.Controllers;
using UI.TextilSoft.Tools.ExtensionsControls;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.MainForm
{
    public partial class FmIniciarSesion : Form
    {
        #region DI
        private int cont = 0;
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
        private string EmailCodigo;
        public Form Activeform = null;

        private string txtUserNameTextBase;
        private string txtPasswordTextBase;
        public FmIniciarSesion(IPermisosController permisosController,
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
            _companyController = companyController;
            _authenticationConfig = _companyController.GetAuthenticationConfig();

            _userController = userController;
            _companyController = companyController;
            CheckForIllegalCrossThreadCalls = false;

            Activeform = new FmVacio();
            pnlLogin.Visible = false;
            this.Focus();
        }
        #endregion

        private void FmIniciarSesion_Load(object sender, EventArgs e)
        {
            try
            {
                lblLoginError.Visible = false;
                lblLoginError.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);

                ActivarODesactivarCodigo(false);
                txtUserNameTextBase = txtUser.Text;
                txtPasswordTextBase = txtPassword.Text;
                pnlPasswordError.Visible = false;
                pnlUserNameError.Visible = false;
                txtUser.Focus();
            }
            catch (Exception ex)
            {

                throw;
            }

        }
      
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text) || txtUser.Text == txtUserNameTextBase)
            {
                pnlUserNameError.Visible = true;
                lblUserNameError.Text = "El usuario es requerido";
                txtUser.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) || txtPassword.Text == txtPasswordTextBase)
            {
                pnlPasswordError.Visible = true;
                lblPasswordError.Text = "La contraseña es requerido";
                txtPassword.Focus();
                return;
            }

            Login login = new Login();
            login.Usuario = txtUser.Text;
            login.Contraseña = txtPassword.Text;
            var Result = _userController.LoginUser(login);
            Usuario user = new Usuario();
            IList<Componente> flia = null;
            var centerPosition = new Point(this.Width / 2, this.Height / 2);
            if (Result.LoginResultEnum == LoginResultEnum.Ok)
            {
                LoginAplication(login);
            }
            else if (Result.LoginResultEnum == LoginResultEnum.MaximoIntentosAlcanzados)
            {
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Máximos intentos alcanzados", Result.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }
            else if (Result.LoginResultEnum == LoginResultEnum.UsuarioBloqueado || Result.LoginResultEnum == LoginResultEnum.UsuarioNoExiste)
            {
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Usuario Bloqueado", Result.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }
            else if (Result.LoginResultEnum == LoginResultEnum.UsuarioContraseñaIncorrecto)
            {
                //Get center position for this form
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Login Error", Result.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }
            else if (Result.LoginResultEnum == LoginResultEnum.ErrorDeAplicacion)
            {
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de aplicación", Result.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }
            else if (Result.LoginResultEnum == LoginResultEnum.MailSinConfirmar)
            {
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Mail sin confirmar", Result.Message, centerPosition);
                fmMessageBox.ShowDialog();
                ActivarODesactivarCodigo(true);
                EmailCodigo = _userController.ObtenerUsuario(login).Email;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ActivarODesactivarCodigo(false);
                pnlPasswordError.Visible = false;
                pnlUserNameError.Visible = false;
                txtUser.ForeColor = Color.White;
                if (lblLoginError.Visible)
                    lblLoginError.Visible = false;
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
                ActivarODesactivarCodigo(false);
                if (txtPassword.Text != txtPasswordTextBase)
                {
                    //txtPassword.Text = "";
                    pnlPasswordError.Visible = false;
                    pnlUserNameError.Visible = false;
                    txtPassword.ForeColor = Color.White;
                    txtPassword.PasswordChar = '*';
                    if (lblLoginError.Visible)
                        lblLoginError.Visible = false;
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
                txtUser.LimpiarTextbox();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == txtPasswordTextBase)
                txtPassword.LimpiarTextbox();
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

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //pnlLogin.Visible = false;
            //pnlLogin.BringToFront();
            pnlLogin.BringToFront();
            //var r = new FmRegistrarse(_permisoController, _userController, _proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController, _configuration, _companyController);
            //r.ShowDialog();
            AbrirFormHija(new FmRegistrarse(_permisoController, _userController, _proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController, _configuration, _companyController));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var centerPosition = new Point(this.Width / 2, this.Height / 2);
            FmInput fmInput = new FmInput("Ingrese su usuario y email para recuperar su contraseña",
                                            Color.Black,
                                            centerPosition,
                                            null,
                                            _userController.RecuperarContraseña,
                                            "Usuario",
                                            "Email",
                                            "Recuperar"
                                            );
            fmInput.ShowDialog();
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnValidarCodigo_Click(object sender, EventArgs e)
        {
            var centerPosition = new Point(this.Width / 2, this.Height / 2);
            try
            {
                if (!string.IsNullOrEmpty(txtCodigo.Text))
                {
                    Login login = new Login();
                    login.Usuario = txtUser.Text;
                    login.Contraseña = txtPassword.Text;
                    var usuario = _userController.ObtenerUsuario(login);
                    bool EstaVerificado = _userController.ValidarCodigoDeVerificacion(usuario, Convert.ToInt32(txtCodigo.Text));
                    if (EstaVerificado)
                    {
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Verificacion exitosa", "Cuenta verificada! ya puede hacer uso del sistema con normalidad, bienvenido!", centerPosition);
                        fmMessageBox.Show();
                        LoginAplication(login);
                    }
                    else
                    {
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Verificacion fallida", "El codigo ingresado no es correcto, por favor verifique o pida nuevamente un código", centerPosition);
                        fmMessageBox.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Aplicacion error", "Ocurrió un erorr en la aplicación y no se pudo enviar el código", centerPosition);
                fmMessageBox.Show();
            }
        }

        private void lnklblCodigo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var centerPosition = new Point(this.Width / 2, this.Height / 2);
            try
            {
                _userController.EnviarConfirmacionEmail(EmailCodigo);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Codigo enviado", $"Se ha enviado un codigo de verificacion a su correo: {EmailCodigo}, por favor verifique su bandeja de entrada", centerPosition);
                fmMessageBox.Show();
            }
            catch (Exception ex)
            {
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Verificacion fallida", ex.Message, centerPosition);
                fmMessageBox.Show();
            }
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Si es enter o tab que lo envie al txt de contraseña
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                txtPassword.Focus();
            }
        }


        #region Helpers
        private void ActivarODesactivarCodigo(bool estado)
        {
            txtCodigo.Visible = estado;
            pnlCodigo.Visible = estado;
            lblCodigo.Visible = estado;
            btnValidarCodigo.Visible = estado;
            lnklblCodigo.Visible = estado;
            EmailCodigo = string.Empty;
        }

        private void LoginAplication(Login login)
        {
            //Una vez logueamos solo devolvemos el usuario sin los detalles de la compañía, ya que no es parte del negocio interno de la empresa por así decirlo.
            var usuario = _userController.ObtenerUsuarioConPermisos(login);
            //_empleadosController.LoginEmpleado(usuario);
            FmTextilSoft fmTextilSoft = new FmTextilSoft(_userController, _permisoController, _proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController, _configuration, _companyController, this);
            fmTextilSoft.toolStrip1.Tag = usuario;
            if (usuario.IsOwner)
            {
                fmTextilSoft.btnPedidos.Enabled = true;
                fmTextilSoft.btnVentas.Enabled = true;
                fmTextilSoft.btnFacturas.Enabled = true;
                fmTextilSoft.btnReportes.Enabled = true;
                fmTextilSoft.btnProduccion.Enabled = true;
                fmTextilSoft.btnProveedores.Enabled = true;
                fmTextilSoft.btnConfiguracion.Enabled = true;
            }
            else
                AplicandoPermisos(usuario, fmTextilSoft);

            ActivarODesactivarCodigo(false);

            fmTextilSoft.Show();
        }
        #endregion

        #region AbrirForm
        private void AbrirFormHija(Form formhija)
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
                pnlLogin.Controls.Add(formhija);
                pnlLogin.Tag = formhija;
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
                pnlLogin.Controls.Add(formhija);
                pnlLogin.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                if (PerformanceConfiguration.EnabledAnimator)
                    AbrirAnimator();
            }
        }
        private async void AbrirAnimator()
        {
            await Task.Run(() =>
            {
                pnlLogin.Visible = false;
                LoginAnimator.ShowSync(pnlLogin, true);
            });
        }
        #endregion

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

        #region AplicarComposite
        private bool PuedeUsarPedidos = false;
        private bool PuedeUsarVentas = false;
        private bool PuedeUsarFacturas = false;
        private bool PuedeUsarInformes = false;
        private bool PuedeUsarProduccion = false;
        private bool PuedeUsarProveedores = false;
        private bool PuedeUsarConfiguracion = false;

        private void AplicandoPermisos(Usuario usuario, FmTextilSoft fmTextilSoft)
        {
            //Recorrer las familias si contiene
            //Primero separo patenes y familias (Siempre hablando en el nivel 0) (Especificar txt)
            List<Patente> patentes = new List<Patente>();
            List<Familia> familias = new List<Familia>();
            patentes = usuario.Permisos.OfType<Patente>().ToList();
            familias = usuario.Permisos.OfType<Familia>().ToList();
            RecorrerPatentes(patentes);
            RecorrerFamilias(familias);
            if (PuedeUsarProduccion)
                fmTextilSoft.btnProduccion.Enabled = true;
            if (PuedeUsarPedidos)
                fmTextilSoft.btnPedidos.Enabled = true;
            if (PuedeUsarVentas)
                fmTextilSoft.btnVentas.Enabled = true;
            if (PuedeUsarFacturas)
                fmTextilSoft.btnFacturas.Enabled = true;
            if (PuedeUsarInformes)
                fmTextilSoft.btnReportes.Enabled = true;
            if (PuedeUsarProveedores)
                fmTextilSoft.btnProveedores.Enabled = true;
            if (PuedeUsarConfiguracion)
                fmTextilSoft.btnConfiguracion.Enabled = true;
        }

        private void RecorrerFamilias(List<Familia> Listafamilias)
        {
            //Este método será recursivo siempre y cuando alguno de sus hijos sea otra familia.
            //En esta instancia no puede haber dependencia circular ya que es validado previamente en la pantalla de configuración (de admin)
            foreach (var Familias in Listafamilias)
            {
                foreach (var componente in Familias.Hijos)
                {
                    if (componente is Patente)
                    {
                        RecorrerPatentes(new List<Patente>() { (Patente)componente });
                    }
                    else
                    {
                        RecorrerFamilias(new List<Familia>() { (Familia)componente });
                    }
                }
            }
        }

        private void RecorrerPatentes(List<Patente> patentes)
        {
            foreach (Patente patente in patentes)
            {
                //Si es admín que use todo
                //if (componente.Permiso == TipoPermiso.IsAdmin)
                //{
                //    EsAdmin = true;
                //}
                if (patente.Permiso == TipoPermiso.PuedeUsarProduccion)
                {
                    PuedeUsarProduccion = true;
                }
                if (patente.Permiso == TipoPermiso.PuedeUsarPedidos)
                {
                    PuedeUsarPedidos = true;
                }
                if (patente.Permiso == TipoPermiso.PuedeUsarVentas)
                {
                    PuedeUsarVentas = true;
                }
                if (patente.Permiso == TipoPermiso.PuedeUsarFacturas)
                {
                    PuedeUsarFacturas = true;
                }
                if (patente.Permiso == TipoPermiso.PuedeUsarInformes)
                {
                    PuedeUsarInformes = true;
                }
                if (patente.Permiso == TipoPermiso.PuedeUsarProveedores)
                {
                    PuedeUsarProveedores = true;
                }
                if (patente.Permiso == TipoPermiso.PuedeUsarConfiguracion)
                {
                    PuedeUsarConfiguracion = true;
                }
            }
        }

        #endregion
    }
}

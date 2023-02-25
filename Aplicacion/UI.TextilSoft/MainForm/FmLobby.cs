using Contracts.Controllers;
using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Background;
using UI.TextilSoft.Configurations;
using UI.TextilSoft.Controllers;
using UI.TextilSoft.SubForms.Proveedores.Producto_de_proveedores;
using UI.TextilSoft.Tools.ExtensionsControls;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.MainForm
{
    public partial class FmLobby : FmBaseForm
    {
        #region Inyection
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
        private readonly Inicio _inicio;
        private AuthenticationConfig _authenticationConfig;
        private string EmailCodigo;
        public Form Activeform = null;
        private TaskResolver _taskResolver;

        public FmLobby(IPermisosController permisosController,
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
                        ICompanyController companyController,
                        Inicio inicio)
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
            _inicio = inicio;
            CheckForIllegalCrossThreadCalls = false;

            Activeform = new FmVacio();
            pnlLogin.Visible = false;

            this.Focus();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        #endregion

        private void FmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                CompanyCustomizeEntity company = _companyController.GetCustomizeCompany();

                lblCompanyName.Text = company.Name;             
                pnlCompanyLogo.BackColor = company.Color;
                pnlUp.BackColor = company.Color;
                //Convert Logo to Image
                byte[] imageBytes = Convert.FromBase64String(company.Logo);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                picCompanyLogo.Image = image;
                AbrirFormHija(new FmIniciarSesion(_permisoController, _userController, _proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController, _configuration, _companyController,this));
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

        private void pnlLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconPictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Control_MouseDown(sender,e);
        }

        private void lblCompanyName_MouseDown(object sender, MouseEventArgs e)
        {
            base.Control_MouseDown(sender, e);
        }

        private void picCompanyLogo_MouseDown(object sender, MouseEventArgs e)
        {
            base.Control_MouseDown(sender, e);
        }

        #region AbrirForm
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

        private void FmLobby_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

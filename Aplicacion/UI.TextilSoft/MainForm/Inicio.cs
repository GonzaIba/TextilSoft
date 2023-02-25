using Contracts.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
using UI.TextilSoft.Configurations;
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.MainForm
{
    public partial class Inicio : FmBaseForm
    {
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
        private readonly IControllerFactory _controllerFactory;
        private AuthenticationConfig _authenticationConfig;
        public Form Activeform = null;
        public Inicio(IPermisosController permisosController,
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
                        IControllerFactory controllerFactory
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
            _controllerFactory = controllerFactory;

            var result = _controllerFactory.GetController<ICompanyController>();
            var result2 = _controllerFactory.GetController<ICompanyController>();
            var r = result2.GetAuthenticationConfig();
            if(r.PasswordConfig.CountLength == 9)
            {
                
            }

            _userController = userController;
            _companyController = companyController;
            CheckForIllegalCrossThreadCalls = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.TransparencyKey = Color.Red;
            circularProgressBar1.Maximum = 2000;
            circularProgressBar1.Value = 0;
            Task.Delay(2000);
            Start();
        }

        private async Task Start()
        {
            var fmlobby = new FmLobby(_permisoController, _userController, _proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController, _configuration, _companyController, this);
            AbrirFormHija(fmlobby);
            while (circularProgressBar1.Value < 2000)
            {
                circularProgressBar1.Value++;
                circularProgressBar1.Text = Convert.ToString(circularProgressBar1.Value / 20);
            }
            circularProgressBar1.Visible = false;
            if (PerformanceConfiguration.EnabledAnimator)
                await AbrirAnimator(fmlobby);
            else
                fmlobby.Show();

            this.Hide();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
        
        private async void AbrirFormHija(Form formhija)
        {
            Activeform = formhija;
            formhija.BackColor = Color.FromArgb(30, 30, 30);
            formhija.BringToFront();
            formhija.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        private async Task AbrirAnimator(Form formhija)
        {
            await Task.Run(() =>
            {
                LoginAnimator.ShowSync(formhija, true);
            });
        }
    }
}

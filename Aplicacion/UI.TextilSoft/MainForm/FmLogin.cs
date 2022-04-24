using Contracts.Controllers;
using Domain.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using SL.Contracts;
using SL.Domain.Entities;
using SL.Domain.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Controllers;

namespace UI.TextilSoft.MainForm
{
    public partial class FmLogin : Form
    {
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

        public FmLogin( IUsuarioController userController,
                        IProveedoresController proveedoresController,
                        IClientesController clientesController,
                        IPedidosController pedidosController,
                        ISectorController sectorController,
                        IFacturasController facturasController,
                        IEmpleadosController empleadosController,
                        IVentasController ventasController,
                        IOrdenDeTrabajoController ordenDeTrabajoController,
                        IProductoProveedorController productoProveedorController,
                        IProductosController productosController)
        {
            InitializeComponent();
            _userController = userController;
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

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //IdentityUser identityUser = new IdentityUser();
            //identityUser.Email = "gonza10";
            //identityUser.UserName = "Gonzalo";

            //ProveedoresEntity proveedoresEntity = new ProveedoresEntity();
            //proveedoresEntity.Nombre = "Aadsda";
            //proveedoresEntity.DNI = "12325678";
            //proveedoresEntity.Mail = "Bdd21e";
            //_proveedoresController.ObtenerProveedor(proveedoresEntity.DNI);
            
            Login login = new Login();
            login.Usuario = txtUser.Text;
            login.Contraseña = txtPassword.Text;
            string Result =_userController.LoginUser(login);


            Usuario user = new Usuario();
            IList<Componente> flia = null;
            //flia = 
            //user.Permisos.
            //user.Id = 2;
            //user.Permisos.Add
            //    (
            //        new Componente()
            //        {
            //            Id = 1,
            //            Nombre = "Pedidos"
            //        }
            //    ); ;

            if (Result == "Ok")
            {
                //_empleadosController
                FmTextilSoft fmTextilSoft = new FmTextilSoft(_proveedoresController, _clientesController, _pedidosController, _sectorController, _facturasController, _empleadosController, _ventasController, _ordenDeTrabajoController, _productoProveedorController, _productosController);
                fmTextilSoft.toolStrip1.Tag = login;
                fmTextilSoft.Show();
            }
            else
            {
                MessageBox.Show(Result);
            }
        }
    }
}

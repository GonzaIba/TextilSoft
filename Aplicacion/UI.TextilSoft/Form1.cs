using AutoMapper;
using Business.Services;
using Contracts.Controllers;
using Contracts.Repositories;
using Contracts.Services;
using Domain.Entities;
using Domain.Models;
using Infrastructure;
using Infrastructure.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Configuration;
using SL.Helper.Services.Log4net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Controllers;
using UI.TextilSoft.MainForm;

namespace UI.TextilSoft
{
    public partial class Form1 : Form
    {
        private readonly IProveedoresService _proveedoresService;
        private readonly IClientesController _clientesController;
        private readonly IProveedoresController _proveedoresController;
        public IConfiguration Configuration { get; }

        public Form1(IProveedoresService proveedoresService, IProveedoresController proveedoresController, IClientesController clientesController)
        {
            InitializeComponent();
            _proveedoresService = proveedoresService;
            _proveedoresController = proveedoresController;
            _clientesController = clientesController;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = Configuration.GetConnectionString("ConnectionStrings");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNombre.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var resultado = _proveedoresService.GetAll().ToList();
            //TablaTest.DataSource = resultado;
            ClientesEntity clientesEntity = new ClientesEntity();
            clientesEntity.DNI = 32124;
            clientesEntity.FechaNac = DateTime.Now;
            clientesEntity.Nombre = "TEST";
            clientesEntity.Mail = "quecosa";
            _clientesController.CrearCliente(clientesEntity);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProveedoresEntity proveedoresEntity = new ProveedoresEntity();
            proveedoresEntity.DNI = "daaaad";
            proveedoresEntity.FechaNac = DateTime.Now;
            proveedoresEntity.Nombre = "aadsa";
            proveedoresEntity.Mail = "addas";
            _proveedoresController.ActualizarProveedor(proveedoresEntity);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProveedoresEntity proveedoresEntity = new ProveedoresEntity();
            proveedoresEntity.DNI = "423423";
            proveedoresEntity.FechaNac = DateTime.Now;
            proveedoresEntity.Nombre = "aadsa";
            proveedoresEntity.Mail = "addas";
            _proveedoresController.EliminarProveedor(proveedoresEntity);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProveedoresEntity proveedoresEntity = new ProveedoresEntity();
            proveedoresEntity.DNI = "asdasdas";
            proveedoresEntity.Nombre = "aadsa";
            proveedoresEntity.Mail = "addas";
            _proveedoresController.CrearProveedor(proveedoresEntity);
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                //Logger.GenerateLogPerformance("init button 7");
                //Logger.GenerateLog(new Exception("Hola"));
                int cero = 0;
                int diez = 10;
                int numero = diez / cero;
            }
            catch (Exception ex)
            {
                //Logger.GenerateFatalLog(ex.Message, ex);
            }
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //if ((e.KeyData == (Keys.Control | Keys.Q)))
            //{
            //    txtNombre.Visible = !txtNombre.Visible;
            //}
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyData == (Keys.Control | Keys.Q)))
            {
                txtNombre.Visible = !txtNombre.Visible;
            }
        }
    }
}




//esto es lo que teniamos que hacer cada vez que queriamos instanciar un servicio
////_proveedoresService.
//ProveedoresService prov = new ProveedoresService(_unitOfWork1);
//prov.CrearFactura(proveedoresent);
//ApplicationDbContext context = new ApplicationDbContext();
//UnitOfWork UoW = new UnitOfWork(context);
//ProveedoresService proveedoresService = new ProveedoresService(UoW);
//ProveedoresEntity proveedoresent = new ProveedoresEntity();
//proveedoresent.DNI = 10;
//proveedoresent.FechaNac = DateTime.Now;
//proveedoresent.LugarEmpresa = "aca";
//proveedoresent.Nombre = "gonza";
//proveedoresent.Mail = "jeje";
//proveedoresService.CrearFactura(proveedoresent);
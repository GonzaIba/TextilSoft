using Contracts.Controllers;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Factory;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace UI.TextilSoft.SubForms.Produccion.ListarProductos
{
    public partial class FmDetalleProductos : Form
    {
        private readonly IControllerFactory _factory;
        private string _codigo;
        public FmDetalleProductos(string codigo, IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
            _codigo = codigo;
        }

        private void FmDetalleProductos_Load(object sender, EventArgs e)
        {
            var ProductoEntity = _factory.Use<IProductosController>().ObtenerProducto(_codigo);
            txtBolsilloInt.Text = ProductoEntity.BolsilloInterior;
            txtCinturaInt.Text = ProductoEntity.CinturaInterior;
            txtCollareta.Text = ProductoEntity.Collareta;
            txtComposicion.Text = ProductoEntity.Composicion;
            txtForreria.Text = ProductoEntity.Forreria;
            txtLazo.Text = ProductoEntity.Lazo;
            txtDesc.Text = ProductoEntity.NombreProducto;
            txtPrecio.Text = "$" + ProductoEntity.Precio.ToString();
            txtTelaBase.Text = ProductoEntity.TelaBase;
            txtTelaCombinacion.Text = ProductoEntity.TelaCombinacion;
            txtTipoPrenda.Text = ProductoEntity.TipoPrenda;
            txtVivo.Text = ProductoEntity.Vivo;
            txtTalle.Text = ProductoEntity.TallePrenda;
            txtStockProducto.Text = ProductoEntity.Stock.ToString();
            txtCodigo.Text = ProductoEntity.Codigo.ToString();
            if (ProductoEntity?.ImagenPrenda != null)
            {
                byte[] imageBytes = Convert.FromBase64String(ProductoEntity.ImagenPrenda);
                MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                pBoxImagenPrenda.Image = image;
            }

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

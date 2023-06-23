using Contracts.Controllers;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Factory;

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
        }
    }
}

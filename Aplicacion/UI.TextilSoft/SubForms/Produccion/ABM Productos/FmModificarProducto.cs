using Contracts.Controllers;
using Domain.Entities;
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
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Produccion.ABM_Productos
{
    public partial class FmModificarProducto : Form
    {
        private readonly IControllerFactory _factory;
        private int IdProducto;
        public FmModificarProducto(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoProd.Text))
            {
                var producto = _factory.UseNew<IProductosController>().ObtenerProducto(txtCodigoProd.Text);
                if (producto != null)
                {
                    txtNombreProducto.Text = producto.NombreProducto;
                    txtTipoProducto.Text = producto.TipoProducto;
                    txtEstampa.Text = producto.Estampa;
                    txtComposicion.Text = producto.Composicion;
                    txtTalle.Text = producto.TallePrenda;
                    txtTejido.Text = producto.Tejido;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtCantidad.Text = producto.Stock.ToString();
                    IdProducto = producto.ID_Producto;
                    txtColor.BackColor = producto.Color;
                    btnActualizarProducto.Enabled = true;
                }
                else
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "No encontrado", "No existe ningún producto asociado a este código", centerPosition);
                    fmMessageBox.ShowDialog();
                }
            }
            else
            {
                txtCodigoProd.Focus();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                ProductosEntity productosEntity = new ProductosEntity();
                productosEntity.NombreProducto = txtNombreProducto.Text;
                productosEntity.TipoProducto = txtTipoProducto.Text;
                productosEntity.Estampa = txtEstampa.Text;
                productosEntity.Composicion = txtComposicion.Text;
                productosEntity.TallePrenda = txtTalle.Text;
                productosEntity.Tejido = txtTejido.Text;
                productosEntity.Precio = Convert.ToDecimal(txtPrecio.Text);
                productosEntity.Stock = Convert.ToInt32(txtCantidad.Text);
                productosEntity.Color = txtColor.BackColor;
                _factory.UseNew<IProductosController>().ModificarProducto(productosEntity);
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Actualizar Producto", "No se pudo actualizar el producto, inténtelo nuevamente mas tarde o contacte con el administrador", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }
    }
}

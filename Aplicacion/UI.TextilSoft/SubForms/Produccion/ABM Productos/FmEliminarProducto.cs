using Contracts.Controllers;
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
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Produccion.ABM_Productos
{
    public partial class FmEliminarProducto : Form
    {
        private readonly IControllerFactory _factory;
        private int IdProducto;
        public FmEliminarProducto(IControllerFactory factory)
        {
            _factory = factory;
            InitializeComponent();
            btnEliminarProducto.Enabled = false;
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigoProd_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCodigoProd.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtCodigoProd, 0, -20, 2000);
                txtCodigoProd.Text = txtCodigoProd.Text.Remove(txtCodigoProd.Text.Length - 1);
            }
            if (IdProducto != 0)
            {
                txtNombreProducto.Text = string.Empty;
                txtTipoProducto.Text = string.Empty;
                txtEstampa.Text = string.Empty;
                txtComposicion.Text = string.Empty;
                txtTalle.Text = string.Empty;
                txtTejido.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                IdProducto = 0;
                btnEliminarProducto.Enabled = false;
            }
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
                    btnEliminarProducto.Enabled = true;
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

        private void btnEliminarProducto_Click_1(object sender, EventArgs e)
        {
            try
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Eliminar Producto", "Esta seguro de eliminar este producto?", centerPosition, true);
                fmMessageBox.ShowDialog();
                var result = fmMessageBox.btnAceptar;
                if (result)
                {
                    _factory.UseNew<IProductosController>().EliminarProducto(IdProducto);
                    FmMessageBox fmMessageBox2 = new FmMessageBox(Tools.MessageBoxType.Success, "Eliminar Producto", "Se eliminó el producto correctamente!", centerPosition);
                    fmMessageBox2.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Eliminar Producto", "No se puede eliminar este producto", centerPosition, true);
                fmMessageBox.ShowDialog();
                throw;
            }

        }
    }
}

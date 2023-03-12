using AltoControls;
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
    public partial class FmCrearProducto : Form
    {
        private readonly IControllerFactory _factory;
        public FmCrearProducto(IControllerFactory factory)
        {
            _factory = factory;
            InitializeComponent();
            cboxTalles.SelectedIndex = 0;
            cboxTalles.AutoCompleteMode = AutoCompleteMode.None;
        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Control control in this.Controls)
                {
                    if (control.Name.Contains("txt") && control.Name != "txtColor")
                    {
                        AltoTextBox textBox = (AltoTextBox)control;
                        if (string.IsNullOrWhiteSpace(textBox.Text) && string.IsNullOrEmpty(textBox.Text))
                        {
                            toolTipError.Show("Por favor, complete el campo", textBox, 0, -20, 2000);
                            textBox.Focus();
                            return;
                        }
                    }
                }
                ProductosEntity productosEntity = new ProductosEntity();
                productosEntity.NombreProducto = txtNombreProducto.Text;
                productosEntity.TipoProducto = txtTipoProducto.Text;
                productosEntity.Estampa = txtEstampa.Text;
                productosEntity.Composicion = txtComposicion.Text;
                productosEntity.TallePrenda = cboxTalles.SelectedItem.ToString();
                productosEntity.Tejido = txtTejido.Text;
                productosEntity.Precio = Convert.ToDecimal(txtPrecio.Text);
                productosEntity.Stock = Convert.ToInt32(txtCantidad.Text);
                productosEntity.Color = txtColor.BackColor;
                _factory.UseNew<IProductosController>().CrearProducto(productosEntity);
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Crear Producto", "Se creó el producto correctamente!", centerPosition);
                fmMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Crear Producto", "No se pudo crear el producto, inténtelo nuevamente mas tarde o contacte con el administrador", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                txtCantidad.Text = (Convert.ToInt32(txtCantidad.Text) + 1).ToString();
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                if (Convert.ToInt32(txtCantidad.Text) > 0)
                {
                    txtCantidad.Text = (Convert.ToInt32(txtCantidad.Text) - 1).ToString();
                }
                else
                {
                    toolTipError.Show("No puedes seguir restando", btnRestar, 0, -20, 2000);
                }
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            //Validar que no sea negativo el campo txt cantidad
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCantidad.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtCantidad, 0, -20, 2000);
                txtCantidad.Text = txtCantidad.Text.Remove(txtCantidad.Text.Length - 1);
            }
            else if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                var value = Convert.ToInt32(txtCantidad.Text);
                if (value < 0)
                {
                    toolTipError.Show("Por favor, solo ingrese números positivos", txtCantidad, 0, -20, 2000);
                    txtCantidad.Text = txtCantidad.Text.Remove(txtCantidad.Text.Length - 1);
                }
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
                txtColor.BackColor = colorDialog.Color;
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtPrecio.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtCantidad, 0, -20, 2000);
                txtPrecio.Text = txtPrecio.Text.Remove(txtPrecio.Text.Length - 1);
                txtPrecio.Select();
            }
        }
    }
}

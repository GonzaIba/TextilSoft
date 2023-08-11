﻿using AltoControls;
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
            btnActualizarProducto.Enabled = false;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoProd.Text))
            {
                var producto = _factory.UseNew<IProductosController>().ObtenerProducto(txtCodigoProd.Text);
                if (producto != null)
                {
                    btnActualizarProducto.Enabled = true;
                    txtNombreProducto.Text = producto.NombreProducto;
                    txtTalle.Text = producto.TallePrenda;
                    txtPrecio.Text = producto.Precio.ToString();
                    txtCantidad.Text = producto.Stock.ToString();
                    IdProducto = producto.ID_Producto;

                    txtCantidad.Enabled = true;
                    txtCodigoProd.Enabled = true;
                    txtNombreProducto.Enabled = true;
                    txtPrecio.Enabled = true;
                    txtTalle.Enabled = true;
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
                productosEntity.TallePrenda = txtTalle.Text;
                productosEntity.Precio = Convert.ToDecimal(txtPrecio.Text);
                productosEntity.Stock = Convert.ToInt32(txtCantidad.Text);
                _factory.UseNew<IProductosController>().ModificarProducto(productosEntity);
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Actualizar Producto", "No se pudo actualizar el producto, inténtelo nuevamente mas tarde o contacte con el administrador", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void txtCodigoProd_TextChanged(object sender, EventArgs e)
        {
            btnActualizarProducto.Enabled = false;
            txtNombreProducto.Text = "";
            txtTalle.Text = "";
            txtPrecio.Text = "";
            txtCantidad.Text = "";

            txtCantidad.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtPrecio.Enabled = false;
            txtTalle.Enabled = false;
        }
    }
}

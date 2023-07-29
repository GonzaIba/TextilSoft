using AltoControls;
using Contracts.Controllers;
using Domain.Entities;
using Domain.Enum;
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
using UI.TextilSoft.Tools.FormsTools;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace UI.TextilSoft.SubForms.Produccion.ABM_Productos
{
    public partial class FmCrearProducto : Form
    {
        private readonly IControllerFactory _factory;
        private OpenFileDialog _dialog;
        private string file64;
        public FmCrearProducto(IControllerFactory factory)
        {
            _factory = factory;
            InitializeComponent();
            cboxTalles.SelectedIndex = 0;
            cboxTalles.AutoCompleteMode = AutoCompleteMode.None;
        }

        private void FmCrearProducto_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = "0";
            LlenarComboboxs();
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
                //productosEntity.NombreProducto = txtNombreProducto.Text;
                //productosEntity.TipoPrenda = txtTipoProducto.Text;
                //productosEntity.Transfer = txtEstampa.Text;
                //productosEntity.Composicion = txtComposicion.Text;
                productosEntity.TallePrenda = cboxTalles.SelectedItem.ToString();
                productosEntity.Precio = Convert.ToDecimal(txtPrecio.Text);
                productosEntity.Stock = Convert.ToInt32(txtCantidad.Text);
                productosEntity.Color = txtColor.BackColor;
                _factory.UseNew<IProductosController>().CrearProducto(productosEntity);
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Crear Producto", "Se creó el producto correctamente!", centerPosition);
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

        private void btnImagenPrenda_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //If de file is not jpg or png or jpeg then show error
                    if (Path.GetExtension(dialog.FileName) != ".jpg" && Path.GetExtension(dialog.FileName) != ".png" && Path.GetExtension(dialog.FileName) != ".jpeg")
                    {
                        var centerPosition = new Point(this.Width / 2, this.Height / 2);
                        FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de imagen", "Solo se permiten archivos con extensión .jpg .png o .jpeg", centerPosition);
                        fmMessageBox.ShowDialog();
                    }
                    else
                    {
                        _dialog = new OpenFileDialog();
                        _dialog = dialog;
                        //If file is jpg or png or jpeg then save it to the database
                        pBoxImagenPrenda.ImageLocation = dialog.FileName.ToString();
                        string path = Path.Combine(@"~\image");

                        //if (!Directory.Exists(path))
                        //{
                        //    Directory.CreateDirectory(path);
                        //}
                        var fileName = System.IO.Path.GetFileName(dialog.FileName);
                        path = path + fileName;
                        //if (Directory.Exists(dialog.FileName+path))
                        //{
                        //    File.Copy(dialog.FileName, path);
                        //}


                        //Convert file to base 64
                        byte[] imageArray = System.IO.File.ReadAllBytes(dialog.FileName);
                        string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                        file64 = base64ImageRepresentation;
                    }

                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de imagen", "No se pudo cargar el archivo", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }


        private void LlenarComboboxs()
        {
            fmCboxTelaBase.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.TelaBase);
            fmCboxTelaBase.DisplayMember = "Nombre";

            fmCboxTelaCombinacion.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.TelaCombinacion);
            fmCboxTelaCombinacion.DisplayMember = "Nombre";

            fmCboxBolsilloInt.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.BolsilloInterior);
            fmCboxBolsilloInt.DisplayMember = "Nombre";

            fmCboxCinturaInterior.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.CinturaInterior);
            fmCboxCinturaInterior.DisplayMember = "Nombre";

            fmCboxCollareta.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.Collareta);
            fmCboxCollareta.DisplayMember = "Nombre";

            fmCboxLazo.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.Lazo);
            fmCboxLazo.DisplayMember = "Nombre";

            fmCboxVivo.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.Vivo);
            fmCboxVivo.DisplayMember = "Nombre";

            fmCboxForreria.DataSource = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoProductoPorTipo(ArmadoProductoEnum.Forreria);
            fmCboxForreria.DisplayMember = "Nombre";
        }
    }
}

using AltoControls;
using Contracts.Controllers;
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
using UI.TextilSoft.MainForm;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Ventas.Prenda_Devuelta
{
    public partial class FmPrendaDevuelta : Form
    {
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmPrendaDevuelta(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
        }

        private void btnRegistrarDevolucion_Click(object sender, EventArgs e)
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

            var producto = _factory.UseNew<IProductosController>().ObtenerProducto(txtCodigoProducto.Text);
            if (producto is null)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de existencia", "El producto no existe!", centerPosition);
                fmMessageBox.ShowDialog();
                return;
            }

            _factory.UseNew<IProductosController>().RegistrarProductoDefectuoso(producto.ID_Producto, Convert.ToInt32(txtCantidad.Text), txtMotivo.Text, _fmTextilSoft._user.);
        }
    }
}

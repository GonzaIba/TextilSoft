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
using UI.TextilSoft.Tools.ExtensionsControls;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Ventas.Registrar_Venta
{
    public partial class FmRegistrarVenta : Form
    {
        private readonly IControllerFactory _factory;
        public FmRegistrarVenta(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCantidad.Text))
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error datos faltantes", "Por favor ingrese la cantidad", centerPosition);
                    fmMessageBox.ShowDialog();
                    return;
                }
                VentasEntity ventasEntity = new VentasEntity();
                ventasEntity.Cantidad = Convert.ToInt32(txtCantidad.Text);
                ventasEntity.CodigoProducto = txtCodigoProducto.Text;
                _factory.Use<IVentasController>().RegistrarVenta(ventasEntity);
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error al crear", ex.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }

        }
    }
}

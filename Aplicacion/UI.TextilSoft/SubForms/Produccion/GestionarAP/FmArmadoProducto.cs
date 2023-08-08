using Contracts.Controllers;
using Domain.Enum;
using Domain.Models;
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
using UI.TextilSoft.Tools.ExtensionsControls;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Produccion.GestionarAP
{
    public partial class FmArmadoProducto : Form
    {
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmArmadoProducto(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
            _factory = factory;
            _fmTextilSoft = fmTextilSoft;
        }

        private void FmArmadoProducto_Load(object sender, EventArgs e)
        {
            var tipoPrendaValues = Enum.GetValues(typeof(ArmadoProductoEnum));
            fmCboxTipoArmado.DataSource = tipoPrendaValues;
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 8)
            {
                string Codigo = txtCodigo.Text;
                var Armado = _factory.UseNew<IArmadoProductoController>().ObtenerArmadoPorCodigo((ArmadoProductoEnum)fmCboxTipoArmado.SelectedItem, Codigo);
                if (Armado is null)
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Inexistencia", "No existe ningun producto con este código. Por Favor, vuelva a ingresarlo", centerPosition);
                    fmMessageBox.ShowDialog();
                    //MessageBox.Show("No existe ningun producto con este código. Por Favor, vuelva a ingresarlo");
                    txtCodigo.LimpiarTextbox();
                }
                else
                {
                    txtEliminarNombre.Text = Armado.Nombre;
                }
            }
            else
            {
                txtEliminarNombre.LimpiarTextbox();
            }
        }
    }
}

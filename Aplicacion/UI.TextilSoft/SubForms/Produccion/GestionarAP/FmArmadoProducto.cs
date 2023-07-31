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

namespace UI.TextilSoft.SubForms.Produccion.GestionarAP
{
    public partial class FmArmadoProducto : Form
    {
        private readonly IControllerFactory _factory;
        private readonly FmTextilSoft _fmTextilSoft;
        public FmArmadoProducto(IControllerFactory factory, FmTextilSoft fmTextilSoft)
        {
            InitializeComponent();
        }

        private void FmArmadoProducto_Load(object sender, EventArgs e)
        {
            var tipoPrendaValues = Enum.GetValues(typeof(TipoPrendaEnum));

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {
            if (txtD.Text.Length == 8)
            {
                string DNI = txtDNI.Text;
                var Cliente = _factory.UseNew<IClientesController>().ObtenerCliente(DNI);
                if (Cliente is null)
                {
                    MessageBox.Show("El cliente con el dni: " + txtDNI.Text + " No existe, vuelva a ingresarlo porfavor");
                    txtDNI.LimpiarTextbox();
                    panelProductos.Enabled = false;
                }
                else
                {
                    txtNombre.Text = Cliente.Nombre;
                    txtResidencia.Text = Cliente.Residencia;
                    txtApellido.Text = Cliente.Apellido;
                    txtMail.Text = Cliente.Mail;
                    txtTelefono.Text = Cliente.Telefono;
                    panelProductos.Enabled = true;
                }
            }
            else
            {
                panelProductos.Enabled = false;
                txtNombre.LimpiarTextbox();
                txtResidencia.LimpiarTextbox();
                txtApellido.LimpiarTextbox();
                txtMail.LimpiarTextbox();
                txtTelefono.LimpiarTextbox();
            }
        }
    }
}

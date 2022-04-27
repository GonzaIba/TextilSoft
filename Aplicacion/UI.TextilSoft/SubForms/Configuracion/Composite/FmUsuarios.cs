using SL.Contracts;
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

namespace UI.TextilSoft.SubForms.Configuracion.Composite
{
    public partial class FmUsuarios : Form
    {
        private readonly IUsuarioController _usuarioController;
        Usuario seleccion;
        Usuario tmp;
        public FmUsuarios(IUsuarioController usuarioController)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
        }

        private void FmUsuarios_Load(object sender, EventArgs e)
        {
            this.cboUsuarios.DataSource = _usuarioController.ObtenerUsuarios();
            this.cboUsuarios.DisplayMember = "Nombre";

            this.cboFamilias.DataSource = _usuarioController.ObtenerFamilias();
            this.cboFamilias.DisplayMember = "Permiso";
        }
        
        private void btnConfigUsuario_Click_1(object sender, EventArgs e)
        {
            seleccion = (Usuario)this.cboUsuarios.SelectedItem;

            //hago una copia del objeto para no modificr el que esta en el combo.
            tmp = new Usuario();
            tmp.Id = seleccion.Id;
            tmp.Nombre = seleccion.Nombre;

        }
    }
}

using SL.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.MainForm
{
    public partial class FmRegistrarse : Form
    {
        //Create all controllers
        private readonly IUsuarioController _usuarioController;

        //pass by parameter UsuarioController
        public FmRegistrarse(IUsuarioController usuarioController)
        {
            _usuarioController = usuarioController;
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

        }
    }
}

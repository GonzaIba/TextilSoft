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
    }
}

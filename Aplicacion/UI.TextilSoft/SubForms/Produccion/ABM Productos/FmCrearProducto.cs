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

namespace UI.TextilSoft.SubForms.Produccion.ABM_Productos
{
    public partial class FmCrearProducto : Form
    {
        private readonly IControllerFactory _factory;
        public FmCrearProducto(IControllerFactory factory)
        {
            _factory = factory;
            InitializeComponent();
        }

    }
}

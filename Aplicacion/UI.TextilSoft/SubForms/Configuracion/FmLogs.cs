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
using UI.TextilSoft.Factory;

namespace UI.TextilSoft.SubForms.Configuracion
{
    public partial class FmLogs : Form
    {
        private readonly Usuario _usuario;
        private readonly IControllerFactory _factory;
        public FmLogs(Usuario usuario, IControllerFactory factory)
        {
            _usuario = usuario;
            _factory = factory;
            InitializeComponent();
        }

    }
}

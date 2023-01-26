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
using UI.TextilSoft.Controllers;

namespace UI.TextilSoft.SubForms.Pedidos.ListarPedidos
{
    public partial class FmListarPedidos : Form
    {
        private readonly IPedidosController _pedidosController;
        public FmListarPedidos(IPedidosController pedidosController)
        {
            _pedidosController = pedidosController;
            InitializeComponent();
        }

        private void FmListarPedidos_Load(object sender, EventArgs e)
        {
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos();
        }
    }
}

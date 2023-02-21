using Contracts.Controllers;
using Domain.Entities;
using FontAwesome.Sharp;
using MailKit.Search;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using UI.TextilSoft.Controllers;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Pedidos.ListarPedidos
{
    public partial class FmListarPedidos : Form
    {
        private readonly IPedidosController _pedidosController;
        private bool IsPreviousActive;
        private string LastColumn;
        public FmListarPedidos(IPedidosController pedidosController)
        {
            _pedidosController = pedidosController;
            InitializeComponent();
        }

        private void FmListarPedidos_Load(object sender, EventArgs e)
        {
            string orderBy = "ID_Pedido";
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(1, 2, null, orderBy, false);
            ListarPedidosEntity entity = new();
            
            foreach (DataGridViewColumn item in GrillaPedidos.Columns)
            {
                IconButton button = new();
                button.ForeColor = Color.White;
                button.IconChar = IconChar.Sort;
                button.IconColor = Color.White;
                button.FlatAppearance.BorderSize = 0;
                button.FlatStyle = FlatStyle.Flat;
                button.IconSize = 18;
                button.Size = new Size(20, 20);
                if (item.Index != GrillaPedidos.Columns.Count - 1) //La primer columna es de index, y la última no tiene una adelante{
                {
                    Point ColumnLocation = GrillaPedidos.GetColumnDisplayRectangle(item.DisplayIndex + 1, false).Location;
                    button.Location = new Point(ColumnLocation.X - 15, ColumnLocation.Y);
                }
                else
                {
                    Point ColumnLocation = GrillaPedidos.GetColumnDisplayRectangle(item.DisplayIndex, false).Location;
                    button.Location = new Point(ColumnLocation.X + 90, ColumnLocation.Y);
                }
                //Add event click
                button.Click += new EventHandler((s, e) => OrdenarGrilla(s, e, item.Name));

                GrillaPedidos.Controls.Add(button);

            }
        }
        
        public void OrdenarGrilla(object sender, EventArgs e, string ColumnName)
        {
            string orderBy = ColumnName;
            if (LastColumn == ColumnName && !IsPreviousActive)
                IsPreviousActive = true;
            else
                IsPreviousActive = false;

            LastColumn = ColumnName;
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(1, 5, null, orderBy, IsPreviousActive);
        }

        private void fmDateDesde_ValueChanged(object sender, EventArgs e)
        {
            if (fmDateDesde.Value > fmDateHasta.Value || fmDateDesde.Value > DateTime.Now)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de fecha", "La fecha desde no puede ser superior a la fecha hasta o a la fecha actual", centerPosition);
                fmMessageBox.ShowDialog();
                fmDateDesde.Value = fmDateHasta.Value;
                //Sacar un minuto al datetime
                fmDateDesde.Value = fmDateDesde.Value.AddMinutes(-1);
            }
        }

        private void fmDateHasta_ValueChanged(object sender, EventArgs e)
        {
            //Use Expression func with date
            Expression<Func<ListarPedidosEntity, bool>> expression = x => x.Fecha >= fmDateDesde.Value && x.Fecha <= fmDateHasta.Value;
            GrillaPedidos.DataSource = _pedidosController.ObtenerPedidos(1, 5, expression, "Fecha", false);
        }
    }
}
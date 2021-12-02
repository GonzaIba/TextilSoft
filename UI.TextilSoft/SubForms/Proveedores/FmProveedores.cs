using Contracts.Controllers;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.SubForms.Proveedores
{
    public partial class FmProveedores : Form
    {
        private readonly IProveedoresController _proveedoresController;


        public FmProveedores(IProveedoresController proveedoresController)
        {
            InitializeComponent();
            _proveedoresController = proveedoresController;
        }

        private void FmProveedores_Load(object sender, EventArgs e)
        {
            LLenarGridView();
            GrillaProveedores.Columns[0].ReadOnly = true;
        }


        private void LLenarGridView()
        {
            var ListaProveedores = _proveedoresController.LlenarGrillaProveedores();
            GrillaProveedores.DataSource = ListaProveedores;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var ListaProveedores = ListaProveedoresDeGrilla();
            _proveedoresController.ActualizarProveedoresPorGrilla(ListaProveedores);

        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            var ListaProveedores = ListaProveedoresDeGrilla();
            var ListaCambiado = _proveedoresController.VerificarCambios(ListaProveedores);
            if(ListaCambiado.Count == 0)
                LLenarGridView();
            else
            {
                string cadena = string.Join("\n ", ListaCambiado);
                MessageBox.Show($"Cuidado! Tiene cambios sin guardar, son los siguientes: \n {cadena}");
            }             
        }

        private void GrillaProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip my_menu = new ContextMenuStrip();
            int position_xy_mouse_row = GrillaProveedores.HitTest(e.X, e.Y).RowIndex;
            if (GrillaProveedores.SelectedRows.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (position_xy_mouse_row >= 0)
                    {
                        my_menu.Items.Add("Crear Proveedor").Name = "Crear";
                        my_menu.Items.Add("Eliminar Proveedor").Name = "Eliminar";
                    }
                    my_menu.Show(GrillaProveedores, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                }
            }
        }

        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch(e.ClickedItem.Name.ToString())
            {
                case "Eliminar":
                    foreach (DataGridViewRow row in GrillaProveedores.SelectedRows)
                    {
                        int DNI = Convert.ToInt32(GrillaProveedores.Rows[row.Index].Cells[0].Value);
                        var Proveedor = _proveedoresController.ObtenerProveedor(DNI);
                        if(Proveedor != null)
                        {
                            _proveedoresController.EliminarProveedor(Proveedor);
                        }
                    }
                    LLenarGridView();
                    break;
                case "Crear":

                    break;
            }
        }

        private void GrillaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            LLenarGridView();
        }

        private List<ProveedoresEntity> ListaProveedoresDeGrilla()
        {
            List<ProveedoresEntity> listaProveedores = new List<ProveedoresEntity>();
            foreach (DataGridViewRow item in GrillaProveedores.Rows)
            {
                if (!item.IsNewRow)
                    listaProveedores.Add(new ProveedoresEntity
                    {
                        DNI = Convert.ToInt32(item.Cells[0].Value),
                        FechaNac = Convert.ToDateTime(item.Cells[1].Value),
                        LugarEmpresa = item.Cells[2].Value.ToString(),
                        Mail = item.Cells[3].Value.ToString(),
                        Nombre = item.Cells[4].Value.ToString()
                    });
            }
            return listaProveedores;
        }

        private void GrillaProveedores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;

            int DNI = Convert.ToInt32(GrillaProveedores.Rows[row].Cells[0].Value);


            var Proveedor = _proveedoresController.ObtenerProveedor(DNI);

            var ColumnName = GrillaProveedores.Rows[row].Cells[column].OwningColumn.DataPropertyName; // Obtenemos el nombre de la columna de la posicion actual.
            if (Proveedor.GetType().GetProperty(ColumnName)!=null)//Preguntamos Si el nombre de la columna coincide con el nombre de propiedad (ojo por reflexion...).
            {
                var ValorProveedor = Proveedor.GetType().GetProperty(ColumnName).GetValue(Proveedor, null);
                if(ValorProveedor.ToString() == GrillaProveedores.Rows[row].Cells[column].Value.ToString())
                {
                    //Si llegamos a este punto es porque el valor que tenemos en la celda coincide con el de la bdd
                    //Por ende tenemos que dejarlo con estilo normal asi no confunde al usuario
                    Font negritas = new Font("Segoe UI", 9);
                    Color color = Color.Black;

                    GrillaProveedores.Rows[row].Cells[column].Style.Font = negritas;
                    GrillaProveedores.Rows[row].Cells[column].Style.ForeColor = color;
                }
                else
                {
                    //Si llegamos a este punto es porque damos a entender que los valores no coinciden, entonces lo dejamos en negrita
                    Font negritas = new Font("Tahoma", 9, FontStyle.Bold);
                    Color color = Color.Black;

                    GrillaProveedores.Rows[row].Cells[column].Style.Font = negritas;
                    GrillaProveedores.Rows[row].Cells[column].Style.ForeColor = color;
                }

            }
        }





    }
}

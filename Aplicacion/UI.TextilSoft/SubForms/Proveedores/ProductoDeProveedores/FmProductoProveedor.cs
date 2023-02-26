using Contracts.Controllers;
using Domain.Entities;
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

namespace UI.TextilSoft.SubForms.Proveedores.Producto_de_proveedores
{
    public partial class FmProductoProveedor : Form
    {
        private Form Activeform = null;
        private List<ProductosProveedorEntity> prodProveedor;
        private bool LLenandoGrilla = false; //Esta propiedad nos ayuda a saber si se esta llenando la grilla para que no se ejecute un evento (el if)
        private bool CreandoProdProveedor = false;
        private dynamic ValorCelda;
        private readonly IControllerFactory _factory;

        public FmProductoProveedor(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }
        private void PanelProdProveedor_Paint(object sender, PaintEventArgs e)
        {
            LLenarGridView();
            GrillaProductoProveedores.Columns[0].ReadOnly = true;
            PanelProdProveedor.Visible = false;
        }

        private void btnProductoProveedor_Click(object sender, EventArgs e)
        {
            FmProveedores fmProveedores = new FmProveedores(_factory);
            PanelProdProveedor.BringToFront();
            AbrirFormHija(fmProveedores);
        }
        private void AbrirFormHija(Form formhija)
        {
            if (Activeform != null)
            {
                Activeform.Close();
                Activeform = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                PanelProdProveedor.Controls.Add(formhija);
                PanelProdProveedor.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                AbrirAnimator();
            }
            else
            {
                Activeform = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                PanelProdProveedor.Controls.Add(formhija);
                PanelProdProveedor.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                AbrirAnimator();
            }
        }
        private void AbrirAnimator()
        {
            //LogoAnimator.Hide(labelBienvenida);
            PanelProdProveedor.Visible = false;
            ProveedoresAnimator.ShowSync(PanelProdProveedor);
        }

        private void LLenarGridView()
        {
            LimpiarGridView();
            var ListaProductoProveedor = _factory.Use<IProductoProveedorController>().LlenarGrillaProveedores(); ////////
            GrillaProductoProveedores.DataSource = ListaProductoProveedor;
        }
        private void LimpiarGridView()
        {
            GrillaProductoProveedores.DataSource = null;
            GrillaProductoProveedores.Rows.Clear();
            GrillaProductoProveedores.Columns.Clear();
            CreandoProdProveedor = false;
        }

        private void GrillaProductoProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip my_menu = new ContextMenuStrip();
            int position_xy_mouse_row = GrillaProductoProveedores.HitTest(e.X, e.Y).RowIndex;
            if (GrillaProductoProveedores.SelectedRows.Count > 0)
            {
                if (e.Button == MouseButtons.Right)
                {
                    if (position_xy_mouse_row >= 0)
                    {
                        my_menu.Items.Add("Crear Proveedor").Name = "Crear";
                        my_menu.Items.Add("Eliminar Proveedor").Name = "Eliminar";
                    }
                    my_menu.Show(GrillaProductoProveedores, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                }
            }
        }

        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Eliminar":
                    if (CreandoProdProveedor == true)
                    {
                        //GrillaProductoProveedores.Rows.Remove(GrillaProductoProveedores.l);
                    }
                    else
                    {
                        prodProveedor = new List<ProductosProveedorEntity>();
                        foreach (DataGridViewRow row in GrillaProductoProveedores.SelectedRows)
                        {
                            string DNI = GrillaProductoProveedores.Rows[row.Index].Cells[0].Value.ToString();
                            var ProdProveedor = _factory.Use<IProductoProveedorController>().ObtenerProdProveedor(DNI);
                            if (ProdProveedor != null)
                            {
                                prodProveedor.Add(ProdProveedor);
                                _factory.Use<IProductoProveedorController>().EliminarProveedor(ProdProveedor);
                            }
                        }
                    }
                    LLenarGridView();
                    break;
                case "Crear":
                    //var ListaProveedores = ListaProveedoresDeGrilla();
                    LimpiarGridView();
                    //LLenarGridViewSinDatasource(ListaProveedores);

                    GrillaProductoProveedores.CurrentCell = GrillaProductoProveedores.Rows[GrillaProductoProveedores.Rows.Count - 1].Cells[0];
                    GrillaProductoProveedores.BeginEdit(true); //ABRIR LA EDICION DE LA CELDA
                    //GrillaProveedores_CellDoubleClick(sender, new DataGridViewCellEventArgs(1, GrillaProductoProveedores.Rows.Count)); //Activamos el evento para que se posicione sobre la primer celda de la fila nueva
                    GrillaProductoProveedores.Columns[0].ReadOnly = false;
                    CreandoProdProveedor = true;
                    break;
            }
        }

        private void LLenarGridViewSinDatasource(List<ProveedoresEntity> listaProveedores)
        {
            LLenandoGrilla = true;
            ProveedoresEntity proveedor = new ProveedoresEntity();
            foreach (var NombreColumna in proveedor.GetType().GetProperties()) //Recorremos las propiedades del objeto y las agregamos como columnas usando reflection
                GrillaProductoProveedores.Columns.Add(NombreColumna.Name, NombreColumna.Name);

            int Fila = 0;
            foreach (var Proveedor in listaProveedores)//Recorremos la lista de proveedores
            {
                int Celda = 0;
                GrillaProductoProveedores.Rows.Add(); //Cada vez que se recorre un nuevo proveedor es una nueva fila, entonces agregamos
                foreach (var Propiedad in Proveedor.GetType().GetProperties())//Recorremos las propiedades del objeto (nos queda muy generico, si agregamos propiedades no necesitariamos modificar esta parte del codigo)
                {
                    var ValorPropiedad = Propiedad.GetValue(Proveedor); //Obtenemos el valor con el objeto
                    GrillaProductoProveedores.Rows[Fila].Cells[Celda].Value = ValorPropiedad; //Le seteamos el valor a la celda
                    Celda += 1; //Vamos a la siguiente celda;
                }
                Fila += 1;
            }
            //EliminarFilasVacias(); //Eliminamos las filas sobrantes con este metodo
            LLenandoGrilla = false;
            prodProveedor = null;
        }


    }
}

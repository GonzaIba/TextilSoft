using Contracts.Controllers;
using Domain.Entities;
using Microsoft.Extensions.Configuration;
using SL.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Configurations;
using UI.TextilSoft.Factory;
using UI.TextilSoft.SubForms.Proveedores.Producto_de_proveedores;
using UI.TextilSoft.Tools.RegexPatterns;

namespace UI.TextilSoft.SubForms.Proveedores
{
    public partial class FmProveedores : Form
    {
        private readonly IControllerFactory _factory;
        private List<ProveedoresEntity> proveedor;
        private bool LLenandoGrilla = false; //Esta propiedad nos ayuda a saber si se esta llenando la grilla para que no se ejecute un evento (el if)
        private bool CreandoProveedor = false;
        private dynamic ValorCelda;
        public Form Activeform = null;

        public FmProveedores(IControllerFactory factory)
        {
            InitializeComponent();
            _factory = factory;
        }

        private void FmProveedores_Load(object sender, EventArgs e)
        {
            LLenarGridView();
            GrillaProveedores.Columns[0].ReadOnly = true; //
            PanelProveedores.Visible = false;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            var ListaProveedores = ListaProveedoresDeGrilla();
            var ListaAcambiar = _factory.Use<IProveedoresController>().DetectarCambios(ListaProveedores);
            if (ListaAcambiar.Count == 0)
                MessageBox.Show("No tiene cambios para guardar");
            else
            {
                _factory.Use<IProveedoresController>().ActualizarProveedoresPorGrilla(ListaAcambiar);
                LLenarGridView();
            }
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            var ListaProveedores = ListaProveedoresDeGrilla();
            var ListaCambiado = _factory.Use<IProveedoresController>().VerificarCambios(ListaProveedores);
            if (ListaCambiado.Count == 0)
                LLenarGridView();
            else
            {
                string cadena = string.Join("\n ", ListaCambiado);
                //MessageBox.Show($"Cuidado! Tiene cambios sin guardar, son los siguientes: \n {cadena}");

                string message = $"Cuidado! Tiene cambios sin guardar, son los siguientes: \n {cadena} \n\n Desea actualizar de todas formas?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult resultado = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (resultado == DialogResult.Yes)
                {
                    LimpiarGridView();
                    LLenarGridView();
                }
                else if (resultado == DialogResult.No)
                {

                }
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
            switch (e.ClickedItem.Name.ToString())
            {
                case "Eliminar":
                    if (CreandoProveedor == true)
                    {
                        //GrillaProveedores.Rows.Remove(GrillaProveedores.l);
                    }
                    else
                    {
                        proveedor = new List<ProveedoresEntity>();
                        foreach (DataGridViewRow row in GrillaProveedores.SelectedRows)
                        {
                            string DNI = GrillaProveedores.Rows[row.Index].Cells[0].Value.ToString();
                            var Proveedor = _factory.Use<IProveedoresController>().ObtenerProveedor(DNI);
                            if (Proveedor != null)
                            {
                                proveedor.Add(Proveedor);
                                _factory.Use<IProveedoresController>().EliminarProveedor(Proveedor);
                            }
                            else
                                MessageBox.Show("El proveedor que desea eliminar no existe, por favor refresque la grilla");
                        }
                    }
                    LLenarGridView();
                    break;
                case "Crear":
                    var ListaProveedores = ListaProveedoresDeGrilla();
                    LimpiarGridView();
                    LLenarGridViewSinDatasource(ListaProveedores);

                    GrillaProveedores.CurrentCell = GrillaProveedores.Rows[GrillaProveedores.Rows.Count - 1].Cells[0];
                    GrillaProveedores.BeginEdit(true); //ABRIR LA EDICION DE LA CELDA
                    GrillaProveedores_CellDoubleClick(sender, new DataGridViewCellEventArgs(1, GrillaProveedores.Rows.Count)); //Activamos el evento para que se posicione sobre la primer celda de la fila nueva
                    GrillaProveedores.Columns[0].ReadOnly = false;
                    CreandoProveedor = true;
                    break;
            }
        }

        private void btnRejectChanges_Click(object sender, EventArgs e)
        {
            if (proveedor != null)
            {
                foreach (var Proveedor in proveedor)
                {
                    _factory.Use<IProveedoresController>().CrearProveedor(Proveedor);
                }
                LLenarGridView();
                proveedor = null;
            }
            else
                MessageBox.Show("No se encontraron ultimos cambios");
        }


        private void GrillaProveedores_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var row = e.RowIndex;
            var column = e.ColumnIndex;
            try
            {
                ModificandoProveedor(e);
                if (CreandoProveedor == true)
                {
                    GrillaProveedores.AllowUserToAddRows = false;
                }
                else if (LLenandoGrilla == false)
                {
                    if (GrillaProveedores.Rows[row].Cells[column].Value == null)
                        throw new Exception("No se permite celda vacia");

                    string DNI = GrillaProveedores.Rows[row].Cells[0].Value.ToString();
                    var Proveedor = _factory.Use<IProveedoresController>().ObtenerProveedor(DNI);

                    var ColumnName = GrillaProveedores.Rows[row].Cells[column].OwningColumn.Name; // Obtenemos el nombre de la columna de la posicion actual.
                    if (Proveedor.GetType().GetProperty(ColumnName) != null)//Preguntamos Si el nombre de la columna coincide con el nombre de propiedad (ojo por reflexion...).
                    {
                        var ValorProveedor = Proveedor.GetType().GetProperty(ColumnName).GetValue(Proveedor, null);
                        if (ValorProveedor.ToString() == GrillaProveedores.Rows[row].Cells[column].Value.ToString())
                        {
                            //Si llegamos a este punto es porque el valor que tenemos en la celda coincide con el de la bdd
                            //Por ende tenemos que dejarlo con estilo normal asi no confunde al usuario
                            Font negritas = new Font("Segoe UI", 10);
                            Color color = Color.White;

                            GrillaProveedores.Rows[row].Cells[column].Style.Font = negritas;
                            GrillaProveedores.Rows[row].Cells[column].Style.ForeColor = color;
                        }
                        else
                        {
                            //Si llegamos a este punto es porque damos a entender que los valores no coinciden, entonces lo dejamos en negrita
                            Font negritas = new Font("Tahoma", 9, FontStyle.Bold);
                            Color color = Color.Red;

                            GrillaProveedores.Rows[row].Cells[column].Style.Font = negritas;
                            GrillaProveedores.Rows[row].Cells[column].Style.ForeColor = color;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Se restableció su antiguo valor!");
                GrillaProveedores.Rows[row].Cells[column].Value = ValorCelda;
            }
        }

        private void GrillaProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrillaProveedores_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (CreandoProveedor == true) //Si se esta creando un nuevo proveedor no puede salir del foco de la celda
                {
                    var result = EsUltimaFila();
                    if (!result)
                    {
                        string message = "Desea salir del proceso?";
                        string title = "Close Window";
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult resultado = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                        if (resultado == DialogResult.Yes)
                        {
                            ProveedorFinalizado();
                        }
                        else if (resultado == DialogResult.No)
                        {
                            GrillaProveedores.CurrentCell = GrillaProveedores.Rows[GrillaProveedores.Rows.Count - 1].Cells[0];
                            GrillaProveedores.BeginEdit(true); //ABRIR LA EDICION DE LA CELDA
                            GrillaProveedores_CellDoubleClick(sender, new DataGridViewCellEventArgs(1, GrillaProveedores.Rows.Count));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void LLenarGridViewSinDatasource(List<ProveedoresEntity> listaProveedores)
        {
            LLenandoGrilla = true;
            ProveedoresEntity proveedor = new ProveedoresEntity();
            foreach (var NombreColumna in proveedor.GetType().GetProperties()) //Recorremos las propiedades del objeto y las agregamos como columnas
                GrillaProveedores.Columns.Add(NombreColumna.Name, NombreColumna.Name);

            int Fila = 0;
            foreach (var Proveedor in listaProveedores)//Recorremos la lista de proveedores
            {
                int Celda = 0;
                GrillaProveedores.Rows.Add(); //Cada vez que se recorre un nuevo proveedor es una nueva fila, entonces agregamos
                foreach (var Propiedad in Proveedor.GetType().GetProperties())//Recorremos las propiedades del objeto (nos queda muy generico, si agregamos propiedades no necesitariamos modificar esta parte del codigo)
                {
                    var ValorPropiedad = Propiedad.GetValue(Proveedor); //Obtenemos el valor con el objeto
                    GrillaProveedores.Rows[Fila].Cells[Celda].Value = ValorPropiedad; //Le seteamos el valor a la celda
                    Celda += 1; //Vamos a la siguiente celda;
                }
                Fila += 1;
            }
            //EliminarFilasVacias(); //Eliminamos las filas sobrantes con este metodo
            LLenandoGrilla = false;
            proveedor = null;
        }


        private bool EsUltimaFila()
        {
            if (GrillaProveedores.CurrentRow == null)
                return false;

            var lastRow = GrillaProveedores.Rows[GrillaProveedores.Rows.Count - 1];

            if (GrillaProveedores.CurrentRow == lastRow)
                return true;
            else
                return false;
        }

        private List<ProveedoresEntity> ListaProveedoresDeGrilla()
        {
            List<ProveedoresEntity> listaProveedores = new List<ProveedoresEntity>();
            foreach (DataGridViewRow item in GrillaProveedores.Rows)
            {
                if (!item.IsNewRow)
                    listaProveedores.Add(new ProveedoresEntity
                    {
                        DNI = item.Cells[0].Value.ToString(),
                        FechaNac = Convert.ToDateTime(item.Cells[1].Value),
                        LugarEmpresa = item.Cells[2].Value.ToString(),
                        Mail = item.Cells[3].Value.ToString(),
                        Nombre = item.Cells[4].Value.ToString()
                    });
            }
            return listaProveedores;
        }

        private void ProveedorFinalizado()
        {
            LimpiarGridView();
            LLenarGridView();
            GrillaProveedores.Columns[0].ReadOnly = true;
            CreandoProveedor = false;
            GrillaProveedores.AllowUserToAddRows = true;
        }


        private void LLenarGridView()
        {
            LimpiarGridView();
            var ListaProveedores = _factory.Use<IProveedoresController>().LlenarGrillaProveedores();
            GrillaProveedores.DataSource = ListaProveedores;
        }

        private void LimpiarGridView()
        {
            GrillaProveedores.DataSource = null;
            GrillaProveedores.Rows.Clear();
            GrillaProveedores.Columns.Clear();
            CreandoProveedor = false;
        }

        private void ModificandoProveedor(DataGridViewCellEventArgs e)
        {
            try
            {


                var Fila = e.RowIndex;
                int FilaCompleta = 0;

                var DNI = GrillaProveedores.Rows[Fila].Cells[0].Value;
                var Fecha = GrillaProveedores.Rows[Fila].Cells[1].Value;
                var LugarEmpresa = GrillaProveedores.Rows[Fila].Cells[2].Value;
                var Mail = GrillaProveedores.Rows[Fila].Cells[3].Value;
                var Nombre = GrillaProveedores.Rows[Fila].Cells[4].Value;


                #region DNI
                if (DNI != null && CreandoProveedor == true)
                {
                    if (!ProveedorPattern.CuitMatch(DNI.ToString()))
                    {
                        MessageBox.Show("El DNI ingresado no tiene el formato válido");
                        GrillaProveedores.CurrentCell = GrillaProveedores.Rows[GrillaProveedores.Rows.Count - 1].Cells[0];
                    }
                    DNI = DNI.ToString().Replace("-", "").Replace(" ", "");
                    var Proveedor = _factory.Use<IProveedoresController>().ObtenerProveedor(DNI.ToString());
                    if (Proveedor != null)
                    {
                        MessageBox.Show("Ese proveedor ya existe");
                    }
                    FilaCompleta++;
                }
                #endregion

                #region Fecha
                if (Fecha != null)
                {
                    Fecha = ProveedorPattern.DateMatch(Fecha.ToString());
                    FilaCompleta++;
                }
                #endregion

                #region Lugar Empresa
                if (LugarEmpresa != null)
                {
                    var resultadoEmpresa = ProveedorPattern.LugarMatch(LugarEmpresa.ToString());
                    FilaCompleta++;
                }
                #endregion

                #region Mail
                if (Mail != null)
                {
                    var resultadoMail = ProveedorPattern.MailMatch(Mail.ToString());
                    FilaCompleta++;
                }
                #endregion

                #region Nombre
                if (Nombre != null)
                {
                    var resultadoNombre = ProveedorPattern.LugarMatch(Nombre.ToString());
                    FilaCompleta++;
                }
                #endregion

                #region FilaCompleta
                if (FilaCompleta == GrillaProveedores.Columns.Count && CreandoProveedor == true)
                {
                    //si entro a este flujo estariamos dando a entender que paso por todas las validaciones de regex y podemos crear el proveedor
                    ProveedoresEntity proveedoresEntity = new ProveedoresEntity();
                    proveedoresEntity.DNI = DNI.ToString();
                    proveedoresEntity.FechaNac = Convert.ToDateTime(Fecha);
                    proveedoresEntity.LugarEmpresa = LugarEmpresa.ToString();
                    proveedoresEntity.Nombre = Nombre.ToString();
                    proveedoresEntity.Mail = Mail.ToString();
                    _factory.Use<IProveedoresController>().CrearProveedor(proveedoresEntity);
                    ProveedorFinalizado();
                }
                #endregion
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private void UnaComilla(string texto)
        //{
        //    Regex.Match(texto,@"""")
        //}


        private void AbrirAnimator()
        {
            //LogoAnimator.Hide(labelBienvenida);
            PanelProveedores.Visible = false;
            ProveedoresAnimator.ShowSync(PanelProveedores);
        }

        private void GrillaProveedores_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            ValorCelda = GrillaProveedores[e.ColumnIndex, e.RowIndex].Value;
        }

        private void GrillaProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnProductoProveedor_Click(object sender, EventArgs e)
        {
            FmProductoProveedor fmProductoProveedor = new FmProductoProveedor(_factory);
            PanelProveedores.BringToFront();
            AbrirFormHija(fmProductoProveedor);
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
                PanelProveedores.Controls.Add(formhija);
                PanelProveedores.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                if (PerformanceConfiguration.EnabledAnimator)
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
                PanelProveedores.Controls.Add(formhija);
                PanelProveedores.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                if (PerformanceConfiguration.EnabledAnimator)
                    AbrirAnimator();
            }
        }

        private void GrillaProveedores_DataSourceChanged(object sender, EventArgs e)
        {

        }


        //private void GrillaProveedores_RowErrorTextChanged(object sender, DataGridViewRowEventArgs e)
        //{

        //}
    }
}


























//private bool Chocaron() //Este metodo permite saber si dos controles se chocan o esta una encima de la otra(en este caso dos grillas)
//{
//    Rectangle myRectangle_A = new Rectangle();
//    Rectangle myRectangle_B = new Rectangle();

//    myRectangle_A.X = this.GrillaProveedores.Left;
//    myRectangle_A.Y = this.GrillaProveedores.Top;
//    myRectangle_A.Width = this.GrillaProveedores.Width;
//    myRectangle_A.Height = this.GrillaProveedores.Height;

//    myRectangle_B.X = this.GridViewAddRow.Left;
//    myRectangle_B.Y = this.GridViewAddRow.Top;
//    myRectangle_B.Width = this.GridViewAddRow.Width;
//    myRectangle_B.Height = this.GridViewAddRow.Height;
//    if (myRectangle_A.IntersectsWith(myRectangle_B))
//        return true;
//    else
//        return false;
//}

//private void EliminarFilasVacias()
//{
//    //obtenemos la cantidad de columnas del DGV
//    int columnas = GrillaProveedores.Columns.Count;

//    //Recorremos las filas
//    foreach (DataGridViewRow fila in GrillaProveedores.Rows)
//    {
//        int vacios = 0;
//        for (int i = 0; i < columnas; i++)
//        {
//            if (Convert.ToString(fila.Cells[i].Value) == string.Empty)
//            {
//                vacios++;
//            }
//        }

//        if (vacios == columnas)
//        {
//            GrillaProveedores.Rows.RemoveAt(fila.Index);
//        }
//    }
//}


/////////////////////////////////////////Viejo modo de crear proveedor//////////////////////////////////////
////La grilla al estar enlazada con un origen de datos se dificulta a la hora de agregar una fila nueva...
//bool chocaron = true;
//int Y = GrillaProveedores.Location.Y;
//GridViewAddRow.Location = GrillaProveedores.Location;
//while (chocaron == true)
//{
//    chocaron = Chocaron();
//    if(chocaron)
//    {
//        //Si los dos controles chocan vamos moviendo la grilla para abajo
//        Y+= 1;
//        GridViewAddRow.Location = new Point(GrillaProveedores.Location.X, Y);
//    }
//}
//foreach(var columna in GrillaProveedores.Columns)
//{
//    GridViewAddRow.Columns.Add("", "");
//}
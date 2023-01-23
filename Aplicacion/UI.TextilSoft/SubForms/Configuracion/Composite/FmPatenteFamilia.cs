using SL.Contracts;
using SL.Domain.Entities;
using SL.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.TextilSoft.Tools.ExtensionsControls;
using System.Windows.Forms;
using UI.TextilSoft.Tools;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Configuracion.Composite
{
    public partial class FmPatenteFamilia : Form
    {
        #region Properties, Lists and DI
        
        private List<Patente> ListaPatentes;
        private List<Familia> ListaFamilias;

        //Utilizo estas propiedades porque cuando actualizo los combobox tengo que seleccionar como estaba previamente...
        private int SeleccionCboPatentes;
        private int SeleccionCboFamilias;

        private readonly IUsuarioController _usuarioController;
        private readonly IPermisosController _permisosController;
        private readonly Size _sizeFmTextilSoft;
        private readonly Usuario _usuario;
        Familia seleccion;

        public FmPatenteFamilia(IUsuarioController usuarioController, IPermisosController permisosController, Size sizeFmTextilSoft, Usuario usuario)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
            _permisosController = permisosController;
            _sizeFmTextilSoft = sizeFmTextilSoft;
            _usuario = usuario;
            CheckForIllegalCrossThreadCalls = false;

            //Se carga las listas
            CargarListasEnMemoria();
            //10000000
            //Este timer se ejecuta cada cierto tiempo
            Timer timer1 = new Timer();
            timer1.Interval = 1000000;
            timer1.Tick += new System.EventHandler(timer_Tick);
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RotateBtn();
            //LoadForm();
            Refresh();
        }
        #endregion

        private void FmPatenteFamilia_Load(object sender, EventArgs e)
        {
            //var user = _usuarioController.ObtenerUsuariosCompletos();

            
            LoadForm();
            btnRefresh.Visible = false;
            lblRefresh.Visible = false;       
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)this.cboFamilias.SelectedItem ?? ListaFamilias?.GetRange(cboFamilias.SelectedIndex == -1 ? 0 : cboFamilias.SelectedIndex, ListaFamilias.Count)?.FirstOrDefault() ?? throw new Exception("Ocurrió un error...");
            seleccion = tmp;
            MostrarFamilia();
        }


        private void MostrarFamilia(bool init = false)
        {
            this.treeConfigurarFamilia.Nodes.Clear();
            //if(init)//Aca vamos a buscar a la familia a la bdd xq esta vacia...

            TreeNode root = new TreeNode(seleccion.Nombre);
            root.Tag = seleccion;
            treeConfigurarFamilia.Nodes.Add(root);//Aca agregamos a la familia pero todavia no se muestran sus patentes... (HELP: FamiliaSinHijosUI.png)

            IList<Componente> flia = seleccion.Hijos;

            foreach (var item in flia)
            {
                MostrarEnTreeView(root, item);
            }
            
            treeConfigurarFamilia.ExpandAll();
        }

        private void MostrarEnTreeView(TreeNode tn, Componente c)
        {
            TreeNode n = new TreeNode(c.Nombre);
            n.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos) //Si el Componente que ingresa es una familia recorremos una recursividad hasta que no tenga mas hijos 
                {
                    MostrarEnTreeView(n, item);
                }
        }

        private void btnAgregarPatentes_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccion != null)
                {
                    var patente = (Patente)cboPatentes.SelectedItem;
                    if (patente != null)
                    {
                        var esta = _permisosController.Existe(seleccion, patente.Id);
                        if (esta)
                        {
                            var centerPosition = new Point(this.Width / 2, this.Height / 2);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Operación inválida", "Ya existe la patente indicada", centerPosition);
                            fmMessageBox.ShowDialog();
                        }
                        else
                        {
                            if(patente.Permiso == TipoPermiso.EsAdmin && _usuario.IsOwner)
                                seleccion.AgregarHijo(patente);
                            else if(patente.Permiso == TipoPermiso.EsAdmin && !_usuario.IsOwner)
                            {
                                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Operación inválida", "Usted no tiene permisos para asignar rol Administrador", centerPosition);
                                fmMessageBox.ShowDialog();
                            }
                            else
                                seleccion.AgregarHijo(patente);
                            
                            MostrarFamilia(false);
                        }
                    }
                }
                else
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Operación inválida", "Debe agregar una familia previamente", centerPosition);
                    fmMessageBox.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnCrearPatente_Click(object sender, EventArgs e)
        {
            try
            {
                Patente p = new Patente()
                {
                    Nombre = this.txtCrearPatente.Text,
                    Permiso = (TipoPermiso)this.cboPermisos.SelectedItem
                };

                _permisosController.CrearPermiso(p);
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private bool ValidarSiExistePermiso(Familia componente)
        {
            foreach (var hijo in componente.Hijos)
            {
                if (hijo is Familia)
                    return ValidarSiExistePermiso((Familia)hijo);

                return false;
            }
            return false;
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                if (seleccion != null)
                {
                    var familia = (Familia)cboFamilias.SelectedItem;
                    if (familia != null)
                    {
                        var esta = _permisosController.Existe(seleccion, familia.Id);
                        if (esta)
                            MessageBox.Show("ya existe la familia indicada");
                        else
                        {
                            if (!_permisosController.ValidarPermisosRepetidos(seleccion, familia))
                                seleccion.AgregarHijo(familia);
                            else
                            {
                                
                            }

                            //repo.FillFamilyComponents(familia);

                            MostrarFamilia(false);
                        }


                    }
                }
                else
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Operación inválida", "Debe agregar una familia previamente", centerPosition);
                    fmMessageBox.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboPatentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Patente = (Patente)this.cboPatentes.SelectedItem;
            txtPatente.Text = Patente.Permiso.ToString();
        }

        private void btnGuardarConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                var test = seleccion ?? throw new Exception("No hay familia seleccionada");
                _permisosController.GuardarFamilia(seleccion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void LoadForm()
        {
            cboFamilias.Items.Clear();
            cboPatentes.Items.Clear();


            foreach (var item in ListaFamilias)
            {
                cboFamilias.Items.Add(item);
            }
            foreach (var item in ListaPatentes)
            {
                cboPatentes.Items.Add(item);
            }
            this.cboPatentes.DisplayMember = "Nombre";
            this.cboFamilias.DisplayMember = "Nombre";

            this.cboPermisos.DataSource = GetAllPermission();

            cboFamilias.SelectedIndex = SeleccionCboFamilias;
            cboPatentes.SelectedIndex = SeleccionCboPatentes;
        }


        private List<TipoPermiso> GetAllPermission()
        {
            List<TipoPermiso> Permisos = new List<TipoPermiso>();
            var PermisosArray = Enum.GetValues(typeof(TipoPermiso));
            Permisos.AddRange(PermisosArray.Cast<TipoPermiso>());
            Permisos.RemoveAll(x => x == TipoPermiso.SinPermisos || x == TipoPermiso.EsFamilia || x == TipoPermiso.EsAdmin);
            return Permisos;
            //Removemos SinPermisos porque no puede setearle ese permiso a una patente, en realidad es un filtro de la bdd...
            //Removemos EsFamilia porque ya hay una solapa donde se puede crear y modificar...
        }


        private async void RotateBtn()
        {
            try
            {
                btnRefresh.Visible = true;
                lblRefresh.Visible = true;
                Refresh();
                FmTools fmTools = new FmTools(_sizeFmTextilSoft.Width, _sizeFmTextilSoft.Height, Color.Blue, Location);


                await Task.Run(() =>
                {
                    // Usamos BeginInvoke para evitar el bloqueo y excepción de subprocesos cruzados ilegales
                    this.BeginInvoke(new Action(() =>
                    {
                        fmTools.ShowDialog();
                    }));

                    CargarListasEnMemoria(); //Cargamos en memoria (Listas) los datos y mostramos la animación del botón
                    for (int i = 0; i < 1000; i = i + 5)
                    {
                        this.btnRefresh.Rotation = i;
                        System.Threading.Thread.Sleep(1);
                    }
                    LoadForm(); //Los datos en memoria los pasamos a los combobox

                }).ContinueWith(new Action<Task>(task =>
                {
                    // No es necesario usar BeginInvoke aca
                    // porque se llamó a ContinueWith con TaskScheduler.FromCurrentSynchronizationContext()
                    fmTools.Close();
                }), TaskScheduler.FromCurrentSynchronizationContext()); ;

                Refresh();
                btnRefresh.Visible = false;
                lblRefresh.Visible = false;
            }
            catch (Exception ex)
            {

                throw;
            }

        }



        private void CargarListasEnMemoria()
        {
            ListaFamilias = _usuarioController.ObtenerFamilias().ToList();
            ListaPatentes = _permisosController.ObtenerPermisos().ToList();
            ListaPatentes.RemoveAll(x => x.Permiso == TipoPermiso.EsAdmin);

            //Guardamos en una variable la ubicacion int del combobox
            SeleccionCboFamilias = this.cboFamilias.SelectedIndex;
            SeleccionCboPatentes = this.cboPatentes.SelectedIndex;
        }

        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            if(txtCrearFamilia.Text != null && !String.IsNullOrEmpty(txtCrearFamilia.Text))
            {
                Familia p = new Familia()
                {
                    Nombre = this.txtCrearFamilia.Text,
                    Permiso = TipoPermiso.EsFamilia
                };

                _permisosController.CrearPermiso(p);
                CargarListasEnMemoria();
                LoadForm();
            }
            else
            {
                txtCrearFamilia.Focus();
                toolTipError.Show("Por favor ingrese un nombre",txtCrearFamilia, 0, -20, 2000);
            }
        }

        private void treeConfigurarFamilia_MouseClick(object sender, MouseEventArgs e)
        {
            ContextMenuStrip my_menu = new ContextMenuStrip();
            int position_xy_mouse_row = Convert.ToInt32(treeConfigurarFamilia.HitTest(e.X, e.Y).Location);
                if (e.Button == MouseButtons.Right)
                {
                    if (position_xy_mouse_row >= 0)
                    {
                        my_menu.Items.Add("Eliminar").Name = "Eliminar";
                    }
                    my_menu.Show(treeConfigurarFamilia, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                }
        }

        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Eliminar":
                    Componente c = (Componente)treeConfigurarFamilia.SelectedNode.Tag;
                    seleccion.EliminarHijo(c);
                    treeConfigurarFamilia.Nodes.Remove(treeConfigurarFamilia.SelectedNode);
                    break;
            }
        }
    }
}

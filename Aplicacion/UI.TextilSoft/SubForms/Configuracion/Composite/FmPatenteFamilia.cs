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

namespace UI.TextilSoft.SubForms.Configuracion.Composite
{
    public partial class FmPatenteFamilia : Form
    {
        #region Properties, Lists and DI
        private List<Patente> ListaPatentes;
        private List<Familia> ListaFamilias;
        private readonly IUsuarioController _usuarioController;
        private readonly IPermisosController _permisosController;
        Familia seleccion;
        Usuario tmp;

        public FmPatenteFamilia(IUsuarioController usuarioController, IPermisosController permisosController)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
            _permisosController = permisosController;
            CheckForIllegalCrossThreadCalls = false;
            //var timer = new System.Timers.Timer(TimeSpan.FromMinutes(1).TotalMilliseconds); // Se ejecutara cada 10 minutos
            //timer.Elapsed += async (sender, e) =>
            //{
            //    LoadForm();
            //};
            //timer.tick += new EventHandler(timer_Tick);
            //timer.Start();

            //Se carga las listas
            CargarListasEnMemoria();

            //Este timer se ejecuta cada cierto tiempo
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 30000;//20 secs
            timer1.Tick += new System.EventHandler(timer_Tick);
            timer1.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //refresh here...
            RotateBtn();
            //LoadForm();
            Refresh();
        }
        #endregion

        private void FmPatenteFamilia_Load(object sender, EventArgs e)
        {
            LoadForm();
            btnRefresh.Visible = false;
            lblRefresh.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            var tmp = (Familia)this.cboFamilias.SelectedItem;
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
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos) //Si el Componente que ingresa es una familia recorremos una recursividad hasta que no tenga mas hijos 
                {
                    MostrarEnTreeView(n, item);
                }

        }

        private void btnAgregarPatentes_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearPatente_Click(object sender, EventArgs e)
        {
            Patente p = new Patente()
            {
                Nombre = this.txtCrearPatente.Text,
                Permiso = (TipoPermiso)this.cboPermisos.SelectedItem

            };

            _permisosController.CrearPermiso(p);
        }









        

        private void LoadForm()
        {
            //this.cboPatentes.DataSource = ListaPatentes;
            //this.cboPatentes.DisplayMember = "Nombre";

            //this.cboFamilias.DataSource = ListaFamilias;
            //this.cboFamilias.DisplayMember = "Nombre";

            //this.cboPermisos.DataSource = GetAllPermission();
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
        }


        private List<TipoPermiso> GetAllPermission()
        {
            List<TipoPermiso> Permisos = new List<TipoPermiso>();
            var PermisosArray = Enum.GetValues(typeof(TipoPermiso));
            Permisos.AddRange(PermisosArray.Cast<TipoPermiso>());
            Permisos.RemoveAll(x => x == TipoPermiso.SinPermisos || x == TipoPermiso.EsFamilia);
            return Permisos;
            //Removemos SinPermisos porque no puede setearle ese permiso a una patente, en realidad es un filtro de la bdd...
            //Removemos EsFamilia porque ya hay una solapa donde se puede crear y modificar...
        }


        private async void RotateBtn()
        {
            btnRefresh.Visible = true;
            lblRefresh.Visible = true;
            await Task.Run(() =>
            {
                CargarListasEnMemoria(); //Cargamos en memoria (Listas) los datos y mostramos la animación del botón
                for (int i = 0; i < 1000; i=i+5)
                {
                    this.btnRefresh.Rotation = i;
                    System.Threading.Thread.Sleep(1);
                }
                LoadForm(); //Los datos en memoria los pasamos a los combobox
            });
            Refresh();
            btnRefresh.Visible = false;
            lblRefresh.Visible = false;
        }



        private void CargarListasEnMemoria()
        {
            ListaFamilias = _usuarioController.ObtenerFamilias().ToList();
            ListaPatentes = _permisosController.ObtenerPermisos().ToList();
        }
        
    }
}

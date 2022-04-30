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
using System.Windows.Forms;

namespace UI.TextilSoft.SubForms.Configuracion.Composite
{
    public partial class FmPatenteFamilia : Form
    {
        #region Properties and DI
        private readonly IUsuarioController _usuarioController;
        private readonly IPermisosController _permisosController;
        Familia seleccion;
        Usuario tmp;

        public FmPatenteFamilia(IUsuarioController usuarioController, IPermisosController permisosController)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
            _permisosController = permisosController;
        }
        #endregion

        private void FmPatenteFamilia_Load(object sender, EventArgs e)
        {
            this.cboPatentes.DataSource = _permisosController.ObtenerPermisos();
            this.cboPatentes.DisplayMember = "Nombre";

            this.cboFamilias.DataSource = _usuarioController.ObtenerFamilias();
            this.cboFamilias.DisplayMember = "Nombre";

            this.cboPermisos.DataSource = GetAllPermission();
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
        
    }
}

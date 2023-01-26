﻿using Domain.Entities;
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
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.SubForms.Configuracion.Composite
{
    public partial class FmUsuarios : Form
    {
        private readonly IUsuarioController _usuarioController;
        private readonly IPermisosController _permisosController;
        private readonly Usuario _usuario;
        //UserList
        private List<Usuario> ListaUsuarios;
        Usuario seleccion;
        Usuario tmp;
        public FmUsuarios(IUsuarioController usuarioController, IPermisosController permisosController, Usuario usuario)
        {
            InitializeComponent();
            _usuarioController = usuarioController;
            _permisosController = permisosController;
            _usuario = usuario;
        }

        private void FmUsuarios_Load(object sender, EventArgs e)
        {
            this.cboUsuarios.DataSource = _usuarioController.ObtenerTodosLosUsuarioConPermisos();
            this.cboUsuarios.DisplayMember = "Nombre";
            ListaUsuarios = (List<Usuario>)this.cboUsuarios.DataSource;

            this.cboFamilias.DataSource = _usuarioController.ObtenerFamilias();
            this.cboFamilias.DisplayMember = "Nombre";

            this.cboPatentes.DataSource = _permisosController.ObtenerPermisos();
            this.cboPatentes.DisplayMember = "Nombre";

        }
        
        private void btnConfigUsuario_Click_1(object sender, EventArgs e)
        {
            if (ListaUsuarios.Count == 0)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Operación inválida", "No hay usuarios para configurar!", centerPosition);
                fmMessageBox.ShowDialog();
            }
            else
            {
                seleccion = (Usuario)this.cboUsuarios.SelectedItem ?? ListaUsuarios?.GetRange(cboUsuarios.SelectedIndex == -1 ? 0 : cboUsuarios.SelectedIndex, ListaUsuarios.Count)?.FirstOrDefault() ?? throw new Exception("Ocurrió un error...");

                //hago una copia del objeto para no modificr el que esta en el combo.
                tmp = new Usuario();
                tmp.Id = seleccion.Id;
                tmp.Nombre = seleccion.Nombre;
                tmp.Email = seleccion.Email;
                tmp.DNI = seleccion.DNI;
                tmp.IsOwner = seleccion.IsOwner;
                tmp.Permisos.AddRange(seleccion.Permisos);

                MostrarPermisos(tmp);
            }
        }


        void MostrarPermisos(Usuario u)
        {
            this.treeViewUsuarios.Nodes.Clear();
            TreeNode root = new TreeNode(u.Nombre);

            foreach (var item in u.Permisos)
            {
                LlenarTreeView(root, item);
            }

            this.treeViewUsuarios.Nodes.Add(root);
            this.treeViewUsuarios.ExpandAll();
        }
        void LlenarTreeView(TreeNode padre, Componente c)
        {
            TreeNode hijo = new TreeNode(c.Nombre);
            hijo.Tag = c;
            padre.Nodes.Add(hijo);

            foreach (var item in c.Hijos)
            {
                LlenarTreeView(hijo, item);
            }
        }

        private void btnAgregarPatente_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios.Count == 0)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Operación inválida", "No hay usuarios para configurar!", centerPosition);
                fmMessageBox.ShowDialog();
            }
            else
            {
                if (tmp != null)
                {
                    var patente = (Patente)cboPatentes.SelectedItem;
                    if (patente != null)
                    {
                        var esta = false;

                        foreach (var item in tmp.Permisos)
                        {
                            if (_permisosController.Existe(item, patente.Id) || patente.Permiso == item.Permiso)
                            {
                                esta = true;
                                break;
                            }
                        }
                        if (esta)
                        {
                            var centerPosition = new Point(this.Width / 2, this.Height / 2);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Operación Inválida", "El usuario ya tiene la patente indicada", centerPosition);
                            fmMessageBox.ShowDialog();
                        }
                        else
                        {
                            if (patente.Permiso == TipoPermiso.EsAdmin && _usuario.IsOwner)
                                tmp.Permisos.Add(patente);
                            else if (patente.Permiso == TipoPermiso.EsAdmin && !_usuario.IsOwner)
                            {
                                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Operación inválida", "Usted no tiene permisos para asignar rol Administrador", centerPosition);
                                fmMessageBox.ShowDialog();
                            }
                            else
                                tmp.Permisos.Add(patente);

                            MostrarPermisos(tmp);
                        }
                    }
                }
                else
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Operación Inválida", "Por favor seleccione el usuario", centerPosition);
                    fmMessageBox.ShowDialog();
                }
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
                _permisosController.GuardarPermisos(tmp);
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Guardado con éxito", "Se guardó el usuario correctamente", centerPosition);
                fmMessageBox.ShowDialog();
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Success, "Error del sistema", ex.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void btnAgregarFamilia_Click(object sender, EventArgs e)
        {
            if (ListaUsuarios.Count == 0)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Operación inválida", "No hay usuarios para configurar!", centerPosition);
                fmMessageBox.ShowDialog();
            }
            else
            {
                if (tmp != null)
                {
                    var flia = (Familia)cboFamilias.SelectedItem;
                    if (flia != null)
                    {
                        var esta = false;
                        //verifico que ya no tenga el permiso. TODO: Esto debe ser parte de otra capa.
                        foreach (var item in tmp.Permisos)
                        {
                            if (_permisosController.Existe(item, flia.Id))
                            {
                                esta = true;
                            }
                        }

                        if (esta)
                        {
                            var centerPosition = new Point(this.Width / 2, this.Height / 2);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Operación Inválida", "El usuario ya tiene la familia indicada", centerPosition);
                            fmMessageBox.ShowDialog();
                        }
                        else
                        {
                            {
                                //permisosRepo.FillFamilyComponents(flia);

                                tmp.Permisos.Add(flia);
                                MostrarPermisos(tmp);
                            }
                        }
                    }
                }
                else
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Warning, "Operación Inválida", "Por favor seleccione el usuario", centerPosition);
                    fmMessageBox.ShowDialog();
                }
            }        
        }

        private void treeViewUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            //Validar si un nodo fue seleccionado
            if (this.treeViewUsuarios.SelectedNode != null)
            {
                ContextMenuStrip my_menu = new ContextMenuStrip();
                int position_xy_mouse_row = (int)treeViewUsuarios.HitTest(e.X, e.Y).Location;
                //Seleccionar el nodo segun la ubicacion
                this.treeViewUsuarios.SelectedNode = this.treeViewUsuarios.GetNodeAt(e.X, e.Y);
                if (e.Button == MouseButtons.Right)
                {
                    if (position_xy_mouse_row >= 0)
                    {
                        my_menu.Items.Add("Quitar Permiso").Name = "Eliminar";
                    }
                    my_menu.Show(treeViewUsuarios, new Point(e.X, e.Y));

                    my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_ItemClicked);
                }
            }
        }
        private void my_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                switch (e.ClickedItem.Name.ToString())
                {
                    case "Eliminar":
                        //Get object selected from node
                        var nodo = treeViewUsuarios.SelectedNode;
                        var componente = (Componente)nodo.Tag;
                        if (nodo.Parent.Tag is Familia && componente is not Familia) //Si es una patente adentro de una familia no podemos eliminarla.
                        {
                            var centerPosition = new Point(this.Width / 2, this.Height / 2);
                            FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error validación", "No puedes quitar un permiso de una familia. Si usted desea eso vaya al apartado de Patentes/Familias", centerPosition);
                            fmMessageBox.ShowDialog();
                        }
                        else
                        {
                            ////Primero lo eliminamos de la base
                            //string Result = _usuarioController.QuitarPermiso(tmp, componente);
                            //if (Result == "Ok")
                            //{
                            //    //Eliminamos el objeto de la lista
                                tmp.Permisos.Remove(componente);
                                //Lo eliminamos de la vista treenode
                                treeViewUsuarios.Nodes.Remove(nodo);
                            //}
                            //else
                            //    MessageBox.Show(Result);
                        }
                    break;
                }
            }
            catch (Exception ex)
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error del sistema", ex.Message, centerPosition);
                fmMessageBox.ShowDialog();
            }

        }
    }
}

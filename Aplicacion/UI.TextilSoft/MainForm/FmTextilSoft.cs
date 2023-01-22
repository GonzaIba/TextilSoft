using Contracts.Controllers;
using FontAwesome.Sharp;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Extensions.Configuration;
using SL.Contracts;
using SL.Domain.Entities;
using SL.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.SubForms.Configuracion;
using UI.TextilSoft.SubForms.Pedidos;
using UI.TextilSoft.SubForms.Proveedores;
using UI.TextilSoft.Tools;

namespace UI.TextilSoft.MainForm
{
    public partial class FmTextilSoft : Form
    {
        #region Variables
        private Form activeForm = null;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Random random;
        private bool FuePresionado = false;
        private bool BotonPresionado = false;
        private int tempIndex = 0;
        private int cont = 0;
        private bool ThreadActivated = false;
        //Posicion del label bienvenida
        private int x = -100, y = 76;
        //Sonido Abrir Formulario
        SoundPlayer player = new SoundPlayer();
        #endregion

        #region DI
        //----------------------- DI -------------------
        private readonly IUsuarioController _usuarioController;
        private readonly IPermisosController _permisosController;
        private readonly IClientesController _clientesController;
        private readonly IProveedoresController _proveedoresController;
        private readonly IProductosController _productosController;
        private readonly IProductoProveedorController _productoProveedorController;
        private readonly IPedidosController _pedidosController;
        private readonly IVentasController _ventasController;
        private readonly ISectorController _sectorController;
        private readonly IOrdenDeTrabajoController _ordenDeTrabajoController;
        private readonly IEmpleadosController _empleadosController;
        private readonly IFacturasController _facturasController;
        private readonly IConfiguration _configuration;
        private readonly ICompanyController _companyController;

        public FmTextilSoft(IUsuarioController usuarioController,
                             IPermisosController permisosController,
                             IProveedoresController proveedoresController,
                             IClientesController clientesController,
                             IPedidosController pedidosController,
                             ISectorController sectorController,
                             IFacturasController facturasController,
                             IEmpleadosController empleadosController,
                             IVentasController ventasController,
                             IOrdenDeTrabajoController ordenDeTrabajoController,
                             IProductoProveedorController productoProveedorController,
                             IProductosController productosController,
                             IConfiguration configuration,
                             ICompanyController companyController
                             )
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            random = new Random();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelBotones.Controls.Add(leftBorderBtn);

            _usuarioController = usuarioController;
            _permisosController = permisosController;
            _proveedoresController = proveedoresController;
            _clientesController = clientesController;
            _ventasController = ventasController;
            _sectorController = sectorController;
            _empleadosController = empleadosController;
            _facturasController = facturasController;
            _ordenDeTrabajoController = ordenDeTrabajoController;
            _productosController = productosController;
            _productoProveedorController = productoProveedorController;
            _pedidosController = pedidosController;
            _configuration = configuration;
            _companyController = companyController;
        }
        #endregion

        private Usuario _user
        {
            get
            {
                Usuario data = (Usuario)toolStrip1.Tag;
                return data;
            }
        }


        private void FmTextilSoft_Load(object sender, EventArgs e)
        {
            try
            {
                toolStrip1.Renderer = new ToolStripRenderCustom();
                timer1.Start();
                timer2.Start();
                toolStripLabel1.Text = "Hola " + _user?.Nombre + "!";
                //this.TraducirFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Sound Form
        private void SonidoForm()
        {

        }
        private void SonidoEnter()
        {
            //new System.Threading.Thread(() =>
            //{
            //    var c1 = new System.Windows.Media.MediaPlayer();
            //    c1.Open(new System.Uri(@"" + ApplicationSettingsForm.GetInstance.MouseEnterSound));
            //    c1.Play();
            //    //Esto lo puedes utilizar si deseas que se repita infinitamente el sonido.
            //    c1.MediaEnded += MediaPlayer_Loop;
            //}).Start();

            //new System.Threading.Thread(() =>
            //{
            //    var c2 = new System.Windows.Media.MediaPlayer();
            //    c2.Open(new System.Uri(@"" + ApplicationSettingsForm.GetInstance.MouseEnterSound));
            //    c2.Play();
            //}).Start();

            //void MediaPlayer_Loop(object sender, EventArgs e)
            //{
            //    MediaPlayer player = sender as MediaPlayer;
            //    if (player == null)
            //        return;

            //    player.Position = new TimeSpan(0);
            //    player.Play();
            //}
        }
        #endregion

        #region AbrirFormularios
        private async void AbrirAnimator()
        {
            //LogoAnimator.Hide(labelBienvenida);
            await Task.Run(() =>
            {
                panelContenedor.Visible = false;
                PanelAnimator.ShowSync(panelContenedor,true);
            });
        }

        private async void AbrirFormHija(Form formhija)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                activeForm = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formhija);
                panelContenedor.Tag = formhija;
                formhija.BringToFront();
                formhija.Show();

                //Si EnabledAnimator esta en true ejecutar el metodo
                if (Convert.ToBoolean(_configuration["Application:Performance:EnabledAnimator"]))
                    AbrirAnimator();

                timer1.Dispose();
                timer2.Dispose();
            }
            else
            {
                activeForm = formhija;
                formhija.Visible = false;
                formhija.BackColor = Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formhija);
                panelContenedor.Tag = formhija;
                formhija.BringToFront();
                //formhija.Show();

                if (Convert.ToBoolean(_configuration["Application:Performance:EnabledAnimator"]))
                    AbrirAnimator();

                timer1.Dispose();
                timer2.Dispose();
            }
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmPedidos(_pedidosController,_clientesController,_productosController));
            BotonPresionado = true;
            btnPedidos.Enabled = false;
            ActivateButton(sender);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BotonPresionado = true;
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BotonPresionado = true;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BotonPresionado = true;
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BotonPresionado = true;
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirFormHija(new FmProveedores(_proveedoresController, _productoProveedorController));
            BotonPresionado = true;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BotonPresionado = true;
            if (_user.IsAdmin)
                AbrirFormHija(new FmAdminConfig(_usuarioController, _permisosController,_companyController));
            else
                AbrirFormHija(new FmConfiguracion());
        }
        #endregion

        #region Timers
        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                this.Refresh();
                x++;
                if (x >= 200)
                {
                    x = 1;
                    timer1.Stop();
                }
            });
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            this.Refresh();
            cont += 1;
            if (cont == 100)
            {
                timer2.Stop();
            }
        }
        private void ExpandirPanel()
        {
            while (this.panelBotones.Width < 200)
            {
                this.panelBotones.Width += 6;
                //this.Refresh();
                Thread.Sleep(2);
            }
            //btnInstagram.Visible = true;
            if (BotonPresionado == true)
            {
                MoveIconRight();
            }
            timer3.Stop();
            ThreadActivated = false;
        }

        private void ExtraerPanel()
        {
            while (this.panelBotones.Width > 43)
            {
                this.panelBotones.Width -= 6;
                //this.Refresh();
                Thread.Sleep(2);
            }
            //btnInstagram.Visible = false;
            if (BotonPresionado == true)
            {
                MoveIconLeft();
            }
            timer4.Stop();
            ThreadActivated = false;
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(_configuration["Application:Performance:EnabledSliceButtonsPanel"]))
            {
                if (ThreadActivated == false)
                {
                    ThreadActivated = true;
                    Thread th1 = new Thread(ExpandirPanel);
                    th1.Name = "ExpandirPanel";
                    th1.Priority = ThreadPriority.Normal;
                    th1.Start();
                }
            }
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(_configuration["Application:Performance:EnabledSliceButtonsPanel"]))
            {
                if (ThreadActivated == false)
                {
                    ThreadActivated = true;
                    Thread th2 = new Thread(ExtraerPanel);
                    th2.Name = "ExtraerPanel";
                    th2.Priority = ThreadPriority.Normal;
                    th2.Start();
                }
            }
        }
        #endregion

        #region Mouse Enter
        private void btnBloquear_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (btnBloquear.Location.X == 163)
            {
                timer4.Stop();
                timer3.Stop();
            }
            else
            {
                timer4.Stop();
                timer4.Stop();
            }
        }
        private void btnPedidos_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void btnFacturas_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void btnProduccion_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void btnConfiguracion_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void panelBotones_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        #endregion

        #region MouseLeave
        private void btnPedidos_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void btnFacturas_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void btnReportes_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void btnProduccion_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void btnProveedores_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void btnConfiguracion_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void labelBienvenida_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        private void panelBotones_MouseLeave(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                timer4.Start();
                timer3.Stop();
            }
        }
        #endregion

        #region Activar Colores
        private async void ActivateButton(object senderBtn)
        {
            await Task.Run(() =>
            {
                if (senderBtn != null)
                {
                    //Button
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentBtn = (IconButton)senderBtn;
                    currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                    currentBtn.ForeColor = color;
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.IconColor = color;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    btnBloquear.IconColor = color;
                    //Left border button
                    leftBorderBtn.BackColor = color;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
            });
        }
        
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.Enabled = true;
                currentBtn.BackColor = Color.FromName("Black");
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        
        private Color SelectThemeColor()
        {
            int index = random.Next(Tools.ColorTheme.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(Tools.ColorTheme.ColorList.Count);
            }
            string color = Tools.ColorTheme.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        #endregion

        #region Mover Icono
        private void MoveIconLeft()
        {
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
        }

        private void btnBloquear_Click(object sender, EventArgs e)
        {
            if (FuePresionado == false)
            {
                FuePresionado = true;
                if (btnBloquear.Location.X <= 15)
                    btnBloquear.Location = new Point(7, 40);
                else
                    btnBloquear.Location = new Point(163, 40);
            }
            else
            {
                FuePresionado = false;
                if (btnBloquear.Location.X <= 15)
                    btnBloquear.Location = new Point(7, 15);
                else
                    btnBloquear.Location = new Point(163, 15);
            }
        }

        private void MoveIconRight()
        {
            currentBtn.TextAlign = ContentAlignment.MiddleCenter;
            currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentBtn.ImageAlign = ContentAlignment.MiddleRight;
        }
        #endregion

        private void toolStrip1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_RendererChanged(object sender, EventArgs e)
        {

        }

        private void FmTextilSoft_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnPedidos.Enabled = false;
            btnVentas.Enabled = false;
            btnFacturas.Enabled = false;
            btnReportes.Enabled = false;
            btnProduccion.Enabled = false;
            btnProveedores.Enabled = false;
            btnConfiguracion.Enabled = false;
        }
    }
}

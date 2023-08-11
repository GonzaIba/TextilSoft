using Contracts.Controllers;
using FontAwesome.Sharp;
using iTextSharp.text.log;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Extensions.Configuration;
using NAudio.Wave;
using SL.Contracts;
using SL.Domain.Entities;
using SL.Domain.Enums;
using SL.Helper.Services.Log4net;
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
using System.Windows.Media;
using UI.TextilSoft.Configurations;
using UI.TextilSoft.Factory;
using UI.TextilSoft.SubForms.Configuracion;
using UI.TextilSoft.SubForms.Facturas;
using UI.TextilSoft.SubForms.Informes_Reportes;
using UI.TextilSoft.SubForms.Informes_Reportes.Reporte_Ventas;
using UI.TextilSoft.SubForms.Pedidos;
using UI.TextilSoft.SubForms.Pedidos.CargarPedido;
using UI.TextilSoft.SubForms.Produccion;
using UI.TextilSoft.SubForms.Proveedores;
using UI.TextilSoft.SubForms.Ventas;
using UI.TextilSoft.Tools;
using UI.TextilSoft.Tools.FormsTools;
using ILogger = SL.Helper.Services.Log4net.ILogger;

namespace UI.TextilSoft.MainForm
{
    public partial class FmTextilSoft : FmBaseForm
    {
        #region Variables
        private Form activeForm = null;
        public Form subForm = null;
        public Form formPedido = null;
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
        private Point previousMousePosition;
        private DateTime previousMouseMoveTime;
        private double _speed;

        private const int MaxMouseSpeed = 2000;
        public Usuario _user
        {
            get
            {
                Usuario data = (Usuario)toolStrip1.Tag;
                return data;
            }
            set
            {
                toolStrip1.Tag = value;
            }
        }
        #endregion

        #region DI
        //----------------------- DI -------------------
        private readonly IControllerFactory _factory;
        private readonly FmLobby _fmLobby;
        public UsuarioInformacion _usuarioInformacion;

        public FmTextilSoft(IControllerFactory factory, FmLobby fmLobby)
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            random = new Random();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelBotones.Controls.Add(leftBorderBtn);
            _factory = factory;
            _fmLobby = fmLobby;
        }

        private void FmTextilSoft_Load(object sender, EventArgs e)
        {
            try
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    _fmLobby.Hide();
                });
                //
                AbrirFormHija(new FmVacio());
                toolStrip1.Renderer = new ToolStripRenderCustom();
                timer1.Start();
                timer2.Start();
                toolStripLabel1.Text = "Hola " + _user?.Nombre + "!";
                _usuarioInformacion = _factory.Use<IUsuarioController>().ObtenerInformacionUsuario(_user);
                //this.TraducirFormulario();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Sonidos

        //private async Task SonidoForm()
        //{
        //    using (var audioFile = new AudioFileReader("D:/Repositorios-SmartGit/TextilSoft/Aplicacion/UI.TextilSoft/bin/Debug/net5.0-windows/SoundForms/AbrirFormulario.wav"))
        //    using (var outputDevice = new WaveOutEvent())
        //    {
        //        outputDevice.Init(audioFile);
        //        outputDevice.Play();
        //        while (outputDevice.PlaybackState == PlaybackState.Playing)
        //        {
        //            await Task.Delay(2);
        //        }
        //    }
        //}
        //private async Task SonidoEnter()
        //{
        //    using (var audioFile = new AudioFileReader("D:/Repositorios-SmartGit/TextilSoft/Aplicacion/UI.TextilSoft/bin/Debug/net5.0-windows/SoundForms/MouseEnter.wav"))
        //    using (var outputDevice = new WaveOutEvent())
        //    {
        //        outputDevice.Init(audioFile);
        //        outputDevice.Play();
        //        while (outputDevice.PlaybackState == PlaybackState.Playing)
        //        {
        //            await Task.Delay(2);
        //        }
        //    }
        //}

        private void SonidoForm()
        {
            if (_user.EnableVolume)
            {
                Task.Run(() =>
                {
                    using (var waveOut = new WaveOutEvent())
                    using (var fileStream = new WaveFileReader("D:/Repositorios-SmartGit/TextilSoft/Aplicacion/UI.TextilSoft/bin/Debug/net5.0-windows/SoundForms/AbrirFormulario.wav"))
                    {
                        waveOut.Init(fileStream);
                        waveOut.Volume = (((float)(_user.Volume)) / 10);
                        waveOut.Play();
                        while (waveOut.PlaybackState == PlaybackState.Playing)
                        {
                            System.Threading.Thread.Sleep(100);
                        }
                    }
                });
            }

        }

        private void SonidoEnter()
        {
            if (_user.EnableVolume)
            {
                if (_speed <= MaxMouseSpeed)
                {
                    Task.Run(() =>
                    {
                        using (var waveOut = new WaveOutEvent())
                        using (var fileStream = new WaveFileReader("D:/Repositorios-SmartGit/TextilSoft/Aplicacion/UI.TextilSoft/bin/Debug/net5.0-windows/SoundForms/MouseEnter.wav"))
                        {
                            waveOut.Init(fileStream);
                            waveOut.Volume = (((float)(_user.Volume)) / 10);
                            waveOut.Play();
                            while (waveOut.PlaybackState == PlaybackState.Playing)
                            {
                                System.Threading.Thread.Sleep(100);
                            }
                        }
                    });
                }
                else
                {

                }
            }
        }
        #endregion

        #region AbrirFormularios
        private void AbrirAnimator()
        {
            //LogoAnimator.Hide(labelBienvenida);
            if (_user.EnableAnimators)
            {
                Task.Run(() =>
                {
                    panelContenedor.Visible = false;
                    PanelAnimator.ShowSync(panelContenedor, true);
                });
            }
        }

        private async void AbrirFormHija(Form formhija)
        {
            if (subForm != null)
            {
                subForm.Close();
                subForm = null;
            }


            if (activeForm != null)
            {
                if (formPedido != null && formhija is FmCrearPedido)
                {
                    formPedido.Visible = false;
                    formPedido.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
                    formPedido.TopLevel = false;
                    formPedido.FormBorderStyle = FormBorderStyle.None;
                    formPedido.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(formPedido);
                    panelContenedor.Tag = formPedido;
                    formPedido.BringToFront();
                    formPedido.Show();

                    //Si EnabledAnimator esta en true ejecutar el metodo
                    if (PerformanceConfiguration.EnabledAnimator)
                        AbrirAnimator();

                    timer1.Dispose();
                    timer2.Dispose();
                }
                else
                {
                    activeForm = formhija;
                    formhija.Visible = false;
                    formhija.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
                    formhija.TopLevel = false;
                    formhija.FormBorderStyle = FormBorderStyle.None;
                    formhija.Dock = DockStyle.Fill;
                    panelContenedor.Controls.Add(formhija);
                    panelContenedor.Tag = formhija;
                    formhija.BringToFront();
                    formhija.Show();

                    //Si EnabledAnimator esta en true ejecutar el metodo
                    if (PerformanceConfiguration.EnabledAnimator)
                        AbrirAnimator();

                    timer1.Dispose();
                    timer2.Dispose();
                }

            }
            else
            {
                activeForm = formhija;
                formhija.Visible = false;
                formhija.BackColor = System.Drawing.Color.FromArgb(32, 30, 45);
                formhija.TopLevel = false;
                formhija.FormBorderStyle = FormBorderStyle.None;
                formhija.Dock = DockStyle.Fill;
                panelContenedor.Controls.Add(formhija);
                panelContenedor.Tag = formhija;
                formhija.BringToFront();
                //formhija.Show();

                if (PerformanceConfiguration.EnabledAnimator)
                    AbrirAnimator();

                timer1.Dispose();
                timer2.Dispose();
            }
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmPedidos(_factory, this));
            BotonPresionado = true;
            ActivateButton(sender);
            SonidoForm();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmVentas(_factory, this));
            ActivateButton(sender);
            BotonPresionado = true;
            SonidoForm();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmFacturas(_factory, this));
            ActivateButton(sender);
            BotonPresionado = true;
            SonidoForm();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormHija(new FmInformes(_factory, this));
            ActivateButton(sender);
            BotonPresionado = true;
            SonidoForm();
        }

        private void btnProduccion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirFormHija(new FmProduccion(_factory, this));
            BotonPresionado = true;
            SonidoForm();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            AbrirFormHija(new FmProveedores(_factory));
            BotonPresionado = true;
            SonidoForm();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            BotonPresionado = true;
            SonidoForm();
            if (_user.EsAdmin() || _user.IsOwner)
                AbrirFormHija(new FmAdminConfig(_factory, _user, this));
            else
                AbrirFormHija(new FmConfiguracion(_factory, this));
        }
        #endregion

        #region Timers
        private async void timer1_Tick_1(object sender, EventArgs e)
        {
            if (_usuarioInformacion.EnableAnimators)
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
        }
        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (_usuarioInformacion.EnableAnimators)
            {
                if (this.Opacity < 1) this.Opacity += 0.05;
                this.Refresh();
                cont += 1;
                if (cont == 100)
                {
                    timer2.Stop();
                }
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
            if (_usuarioInformacion.EnableAnimators)
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
            if (_usuarioInformacion.EnableAnimators)
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
        private async void btnBloquear_MouseEnter(object sender, EventArgs e)
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
        private async void btnPedidos_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private async void btnVentas_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private async void btnFacturas_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private async void btnReportes_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private async void btnProduccion_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private async void btnProveedores_MouseEnter(object sender, EventArgs e)
        {
            SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private async void btnConfiguracion_MouseEnter(object sender, EventArgs e)
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
            //SonidoEnter();
            if (FuePresionado == false)
            {
                timer3.Start();
                timer4.Stop();
            }
        }
        private void panelBotones_MouseEnter(object sender, EventArgs e)
        {
            //SonidoEnter();
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
            try
            {
                await Task.Run(() =>
                {
                    if (senderBtn != null)
                    {
                        //Button
                        DisableButton();
                        System.Drawing.Color color = SelectThemeColor();
                        currentBtn = (IconButton)senderBtn;
                        currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
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
            catch (Exception)
            {

                throw;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.Enabled = true;
                currentBtn.BackColor = System.Drawing.Color.FromName("Black");
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private System.Drawing.Color SelectThemeColor()
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
            try
            {
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
            catch (Exception)
            {
            }
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

        #region Extras
        private void toolStrip1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStrip1_RendererChanged(object sender, EventArgs e)
        {

        }

        private void panelContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            base.Control_MouseDown(sender, e);
        }

        private void btnBloquear_MouseMove(object sender, MouseEventArgs e)
        {
            var currentMousePosition = e.Location;
            var currentTime = DateTime.Now;
            var timeDelta = (currentTime - previousMouseMoveTime).TotalMilliseconds;
            var distance = Math.Sqrt(
                (currentMousePosition.X - previousMousePosition.X) * (currentMousePosition.X - previousMousePosition.X) +
                (currentMousePosition.Y - previousMousePosition.Y) * (currentMousePosition.Y - previousMousePosition.Y)
            );
            _speed = distance / timeDelta * 1000; // píxeles por segundo
            previousMousePosition = currentMousePosition;
            previousMouseMoveTime = currentTime;
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

            _factory?.Use<ILogger>().Logout();

            if (!_fmLobby.IsDisposed)
                _fmLobby?.Show();
        }
        #endregion
    }
}

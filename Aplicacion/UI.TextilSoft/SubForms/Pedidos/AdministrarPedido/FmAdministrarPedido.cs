using Contracts.Controllers;
using Domain.Enum;
using FontAwesome.Sharp;
using LiveCharts.Wpf;
using LiveCharts;
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

namespace UI.TextilSoft.SubForms.Pedidos.AdministrarPedido
{
    public partial class FmAdministrarPedido : Form
    {
        private int x = 200, xCount = 5;
        private int ySA, yEP, yED, yE;
        private bool txtDniCliChecked, txtNOChecked;
        private int StartHeightPanels = 0, CountHeightPanels = 1, MaxHeightPanels = 50;
        private bool StatusLoadFinished;
        private IClientesController _clientesController;
        private IPedidosController _pedidosController;
        private EstadoPedidosEnum EstadoDelPedido;
        
        public FmAdministrarPedido(IPedidosController pedidosController, IClientesController clientesController)
        {
            InitializeComponent();
            _pedidosController = pedidosController;
            _clientesController = clientesController;
        }

        private void FmAdministrarPedido_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            lblEstadoSA.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            lblEstadoEP.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            lblEstadoED.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            lblEstadoE.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            IbSA.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            IbEP.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            IbED.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
            IbE.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);

            ySA = lblEstadoSA.Location.Y;
            yEP = lblEstadoEP.Location.Y;
            yED = lblEstadoED.Location.Y;
            yE = lblEstadoE.Location.Y;

            txtDniCliChecked = false;
            txtNOChecked = false;
            btnVerEstado.Enabled = false;

            pnlSA.Size = new Size(pnlSA.Size.Width, StartHeightPanels);
            pnlEP.Size = new Size(pnlEP.Size.Width, StartHeightPanels);
            pnlED.Size = new Size(pnlED.Size.Width, StartHeightPanels);
            //pnlE.Size = new Size(pnlE.Size.Width, HeightPanels);

            StatusLoadFinished = false;
            // Crear una colección de series para el gráfico de tipo "Pie"
            SeriesCollection seriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "Valor 1",
                    Values = new ChartValues<double> {20},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Valor 2",
                    Values = new ChartValues<double> {30},
                    DataLabels = true,
                },
                new PieSeries
                {
                    Title = "Valor 3",
                    Values = new ChartValues<double> {50},
                    DataLabels = true,
                }
            };

            // Agregar la colección de series al gráfico
            cartesianChart1.Series = seriesCollection;

            //// Configurar la ubicación de la leyenda
            //cartesianChart1.LegendLocation = LegendLocation.Right;

            //// Ajustar el tamaño del gráfico
            //cartesianChart1.Dock = DockStyle.Fill;


        }

        private void btnVerEstado_Click(object sender, EventArgs e)
        {
            DisableStatus();
            //Validate if exist client
            var cliente = _clientesController.ObtenerCliente(txtDNIcli.Text);
            if (cliente != null)
            {
                var Pedido =_pedidosController.ObtenerPedido(Convert.ToInt32(txtNO.Text), cliente);
                if(Pedido != null)
                {
                    tmLbl.Start();
                    EstadoDelPedido = Pedido.EstadoPedido;
                    ValidarEstadoDelPedido();
                }
                else
                {
                    var centerPosition = new Point(this.Width / 2, this.Height / 2);
                    FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de existencia", "No existe ningún pedido con este número de orden", centerPosition);
                    fmMessageBox.ShowDialog();
                }
            }
            else
            {
                var centerPosition = new Point(this.Width / 2, this.Height / 2);
                FmMessageBox fmMessageBox = new FmMessageBox(Tools.MessageBoxType.Error, "Error de existencia", "El cliente no existe", centerPosition);
                fmMessageBox.ShowDialog();
            }
        }

        private void txtNO_TextChanged(object sender, EventArgs e)
        {
            DisableStatus();
            if (System.Text.RegularExpressions.Regex.IsMatch(txtNO.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtNO, 0, -20, 2000);
                txtNO.Text = txtNO.Text.Remove(txtNO.Text.Length - 1);
                txtNOChecked = false;
            }
            else
                txtNOChecked = true;

            ActivatedButton();
        }
        private void txtDNIcli_TextChanged(object sender, EventArgs e)
        {
            DisableStatus();
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDNIcli.Text, "[^0-9]"))
            {
                toolTipError.Show("Por favor, solo ingrese números", txtDNIcli, 0, -20, 2000);
                txtDNIcli.Text = txtDNIcli.Text.Remove(txtDNIcli.Text.Length - 1);
                txtDniCliChecked = false;
            }
            if (System.Text.RegularExpressions.Regex.IsMatch(txtDNIcli.Text, @"^[0-9]{7,8}$"))
            {
                txtDniCliChecked = true;

            }
            else
                txtDniCliChecked = false;

            ActivatedButton();
        }

        #region Helpers
        private void DisableStatus()
        {
            if (StatusLoadFinished)
            {
                lblEstadoSA.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                lblEstadoEP.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                lblEstadoED.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                lblEstadoE.ForeColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                IbSA.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                IbEP.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                IbED.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);
                IbE.IconColor = Color.FromArgb(this.BackColor.R, this.BackColor.G, this.BackColor.B);

                ySA = lblEstadoSA.Location.Y;
                yEP = lblEstadoEP.Location.Y;
                yED = lblEstadoED.Location.Y;
                yE = lblEstadoE.Location.Y;
                
                pnlSA.Size = new Size(pnlSA.Size.Width, StartHeightPanels);
                pnlEP.Size = new Size(pnlEP.Size.Width, StartHeightPanels);
                pnlED.Size = new Size(pnlED.Size.Width, StartHeightPanels);
                StatusLoadFinished = false;

                IbSA.IconChar = IconChar.CheckCircle;
                IbEP.IconChar = IconChar.CheckCircle;
                IbED.IconChar = IconChar.CheckCircle;
                IbE.IconChar = IconChar.CheckCircle;
            }
        }

        private void ActivatedButton()
        {
            if (txtDniCliChecked && txtNOChecked)
                btnVerEstado.Enabled = true;
            else
                btnVerEstado.Enabled = false;
        }

        private void ValidarEstadoDelPedido()
        {
            if(EstadoDelPedido == EstadoPedidosEnum.SinAsignar)
            {
                IbEP.IconChar = IconChar.Circle;
                IbED.IconChar = IconChar.Circle;
                IbE.IconChar = IconChar.Circle;              
            }
            else if (EstadoDelPedido == EstadoPedidosEnum.EnProducción)
            {
                IbED.IconChar = IconChar.Circle;
                IbE.IconChar = IconChar.Circle;
            }
            else if (EstadoDelPedido == EstadoPedidosEnum.EnDepósito)
            {
                IbE.IconChar = IconChar.Circle;
            }
        }

        #endregion

        #region timers
        private void tmLbl_Tick(object sender, EventArgs e)
        {
            ExecuteTimer(tmLbl, tmLblEP, lblEstadoSA, targetColorWhite, targetColorLimeGreen,ySA, pnlSA,IbSA);
        }

        private void tmLblEP_Tick(object sender, EventArgs e)
        {
            ExecuteTimer(tmLblEP, tmLblED, lblEstadoEP, targetColorWhite, targetColorLimeGreen, yEP, pnlEP, IbEP);
        }

        private void tmLblED_Tick(object sender, EventArgs e)
        {
            ExecuteTimer(tmLblED, tmLblE, lblEstadoED, targetColorWhite, targetColorLimeGreen, yED, pnlED, IbED);
        }

        private void geoMap1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void tmLblE_Tick(object sender, EventArgs e)
        {
            ExecuteTimer(tmLblE, tmLblE, lblEstadoE, targetColorWhite, targetColorLimeGreen, yE, null, IbE);
        }
        
        private void ExecuteTimer(Timer actualTimer,Timer nextTimer,Label labelEstado, int[] targetColorLabel, int[] targetColorIconButton,int Y,Panel panel, IconButton iconButton)
        {
            if(panel is null) //Significa que es el último timer
            {
                FadeIn(labelEstado, targetColorLabel);
                FadeIn(iconButton, targetColorIconButton);
                labelEstado.SetBounds(x, Y, 1, 1);
                this.Refresh();
                x += xCount;
                if (x >= 387)
                {
                    x = 200;
                    StatusLoadFinished = true;
                    actualTimer.Stop();
                }
            }
            else
            {
                if (x >= 387 && panel.Size.Height >= MaxHeightPanels)
                {
                    x = 200;
                    CountHeightPanels = 1;
                    actualTimer.Stop();
                    nextTimer.Start();
                }
                else if (x >= 387 && panel.Size.Height <= MaxHeightPanels)
                {
                    CountHeightPanels++;
                    panel.Size = new Size(panel.Size.Width, CountHeightPanels);
                    this.Refresh();
                }
                else
                {
                    FadeIn(labelEstado, targetColorLabel);
                    FadeIn(iconButton, targetColorIconButton);
                    labelEstado.SetBounds(x, Y, 1, 1);
                    this.Refresh();
                    x += xCount;
                    CountHeightPanels++;
                    panel.Size = new Size(panel.Size.Width, CountHeightPanels);
                }
            }

        }
        #endregion
        
        #region Fade in Labels
        int[] targetColorWhite = { 255, 255, 255 };
        int[] targetColorLimeGreen = { 0, 255, 0 };
        int[] fadeRGB = new int[3];
        int fadeRGBCount = 10;
        
        
        void FadeIn(dynamic control, int[] targetColor)
        {
            if(control is FontAwesome.Sharp.IconButton)
            {
                fadeRGB[0] = control.IconColor.R;
                fadeRGB[1] = control.IconColor.G;
                fadeRGB[2] = control.IconColor.B;
            }
            else
            {
                fadeRGB[0] = control.ForeColor.R;
                fadeRGB[1] = control.ForeColor.G;
                fadeRGB[2] = control.ForeColor.B;
            }
            if (fadeRGB[0] > targetColor[0])
                fadeRGB[0]-= fadeRGBCount;
            else if (fadeRGB[0] < targetColor[0])
                fadeRGB[0]+= fadeRGBCount;
            if (fadeRGB[1] > targetColor[1])
                fadeRGB[1] -= fadeRGBCount;
            else if (fadeRGB[1] < targetColor[1])
                fadeRGB[1] += fadeRGBCount;
            if (fadeRGB[2] > targetColor[2])
                fadeRGB[2]-= fadeRGBCount;
            else if (fadeRGB[2] < targetColor[2])
                fadeRGB[2]+= fadeRGBCount;
            if (fadeRGB[0] == targetColor[0] && fadeRGB[1] == this.BackColor.G && fadeRGB[2] == this.BackColor.B)
            {
                tmLbl.Stop();
            }
            if(control is FontAwesome.Sharp.IconButton)
                control.IconColor = Color.FromArgb(fadeRGB[0] > targetColor[0] ? targetColor[0] : fadeRGB[0], fadeRGB[1] > targetColor[1] ? targetColor[1] : fadeRGB[1], fadeRGB[2] > targetColor[2] ? targetColor[2] : fadeRGB[2]);
            else
                control.ForeColor = Color.FromArgb(fadeRGB[0] > targetColor[0] ? targetColor[0] : fadeRGB[0], fadeRGB[1] > targetColor[1] ? targetColor[1] : fadeRGB[1], fadeRGB[2] > targetColor[2] ? targetColor[2] : fadeRGB[2]);
        }
        #endregion
    }
}

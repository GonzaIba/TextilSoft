using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.SubForms.Pedidos.AdministrarPedido
{
    public partial class FmAdministrarPedido : Form
    {
        private int x = 200, xCount = 5;
        private int ySA, yEP, yED, yE;
        private bool txtDniCliChecked, txtNOChecked;
        private int StartHeightPanels = 0, CountHeightPanels = 1, MaxHeightPanels = 50;
        private bool StatusLoadFinished;
        public FmAdministrarPedido()
        {
            InitializeComponent();
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
        }

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
            }
        }

        private void btnVerEstado_Click(object sender, EventArgs e)
        {
            tmLbl.Start();
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

        private void ActivatedButton()
        {
            if (txtDniCliChecked && txtNOChecked)
                btnVerEstado.Enabled = true;
            else
                btnVerEstado.Enabled = false;
        }

        #region timers
        private void tmLbl_Tick(object sender, EventArgs e)
        {
            if (x >= 387 && pnlSA.Size.Height >= MaxHeightPanels)
            {
                x = 200;
                CountHeightPanels = 1;
                tmLbl.Stop();
                tmLblEP.Start();
            }
            else if (x >= 387 && pnlSA.Size.Height <= MaxHeightPanels)
            {
                CountHeightPanels++;
                pnlSA.Size = new Size(pnlSA.Size.Width, CountHeightPanels);
                this.Refresh();
            }
            else
            {
                FadeIn(lblEstadoSA, targetColorWhite);
                FadeIn(IbSA, targetColorLimeGreen);
                lblEstadoSA.SetBounds(x, ySA, 1, 1);
                this.Refresh();
                x += xCount;
                CountHeightPanels++;
                pnlSA.Size = new Size(pnlSA.Size.Width, CountHeightPanels);
                
            }
        }

        private void tmLblEP_Tick(object sender, EventArgs e)
        {
            if (x >= 387 && pnlEP.Size.Height >= MaxHeightPanels)
            {
                x = 200;
                CountHeightPanels = 1;
                tmLblEP.Stop();
                tmLblED.Start();
            }
            else if (x >= 387 && pnlEP.Size.Height <= MaxHeightPanels)
            {
                CountHeightPanels++;
                pnlEP.Size = new Size(pnlEP.Size.Width, CountHeightPanels);
                this.Refresh();
            }
            else
            {
                FadeIn(lblEstadoEP, targetColorWhite);
                FadeIn(IbEP, targetColorLimeGreen);
                lblEstadoEP.SetBounds(x, yEP, 1, 1);
                this.Refresh();
                x += xCount;
                CountHeightPanels++;
                pnlEP.Size = new Size(pnlEP.Size.Width, CountHeightPanels);
            }
        }

        private void tmLblED_Tick(object sender, EventArgs e)
        {

            if (x >= 387 && pnlED.Size.Height >= MaxHeightPanels)
            {
                x = 200;
                CountHeightPanels = 1;
                tmLblED.Stop();
                tmLblE.Start();
            }
            else if (x >= 387 && pnlED.Size.Height <= MaxHeightPanels)
            {
                CountHeightPanels++;
                pnlED.Size = new Size(pnlED.Size.Width, CountHeightPanels);
                this.Refresh();
            }
            else
            {
                FadeIn(lblEstadoED, targetColorWhite);
                FadeIn(IbED, targetColorLimeGreen);
                lblEstadoED.SetBounds(x, yED, 1, 1);
                this.Refresh();
                x += xCount;
                CountHeightPanels++;
                pnlED.Size = new Size(pnlED.Size.Width, CountHeightPanels);
            }
        }

        private void tmLblE_Tick(object sender, EventArgs e)
        {
            FadeIn(lblEstadoE, targetColorWhite);
            FadeIn(IbE, targetColorLimeGreen);
            lblEstadoE.SetBounds(x, yE, 1, 1);
            this.Refresh();
            x += xCount;
            if (x >= 387)
            {
                x = 200;
                StatusLoadFinished = true;
                tmLblE.Stop();
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

using Contracts.Controllers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SL.Contracts;
using SL.Domain.Entities;
using SL.Helper.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Configurations;
using UI.TextilSoft.Factory;
using UI.TextilSoft.Tools.FormsTools;

namespace UI.TextilSoft.MainForm
{
    public partial class Inicio : FmBaseForm
    {
        private readonly IControllerFactory _controllerFactory;
        private AuthenticationConfig _authenticationConfig;
        public Form Activeform = null;
        public Inicio(IControllerFactory controllerFactory)
        {
            InitializeComponent();
            _controllerFactory = controllerFactory;
            CheckForIllegalCrossThreadCalls = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            this.TransparencyKey = Color.Red;
            circularProgressBar1.Maximum = 2000;
            circularProgressBar1.Value = 0;
            Task.Delay(2000);
            Start();
        }

        private void Start()
        {
            var fmlobby = new FmLobby(_controllerFactory, this);
            AbrirFormHija(fmlobby);
            while (circularProgressBar1.Value < 2000)
            {
                circularProgressBar1.Value++;
                circularProgressBar1.Text = Convert.ToString(circularProgressBar1.Value / 20);
            }
            circularProgressBar1.Visible = false;
            if (PerformanceConfiguration.EnabledAnimator)
                fmlobby.Show();
            else
                fmlobby.Show();

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
        
        private async void AbrirFormHija(Form formhija)
        {
            Activeform = formhija;
            formhija.BackColor = Color.FromArgb(30, 30, 30);
            formhija.BringToFront();
            formhija.FormBorderStyle = FormBorderStyle.Fixed3D;
        }
        private async Task AbrirAnimator(Form formhija)
        {
            await Task.Run(() =>
            {
                LoginAnimator.ShowSync(formhija, true);
            });
        }
    }
}

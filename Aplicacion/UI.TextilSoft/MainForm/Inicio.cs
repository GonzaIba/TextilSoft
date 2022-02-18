using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.MainForm
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.TransparencyKey = Color.Crimson;
            this.BackColor = Color.Crimson;
            circularProgressBar1.Maximum = 2000;
            circularProgressBar1.Value = 0;
            Start();
        }

        private void Start()
        {
            while (circularProgressBar1.Value < 2000)
            {
                circularProgressBar1.Value++;
                circularProgressBar1.Text = Convert.ToString(circularProgressBar1.Value / 20);
            }
            this.Close();
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}

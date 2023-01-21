using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.Tools.FormsTools
{
    public partial class FmInput : Form
    {
        public FmInput(string lbl1, string lbl2)
        {
            InitializeComponent();
            lblInput1.Text = lbl1;
            lblInput2.Text = lbl2;
            //Adjust label
            lblInput1.AutoSize = true;
            lblInput2.AutoSize = true;
            //Adjust textbox
            txt1.AutoSize = true;
            txt2.AutoSize = true;
        }

        private void FmInput_Load(object sender, EventArgs e)
        {

        }
    }
}

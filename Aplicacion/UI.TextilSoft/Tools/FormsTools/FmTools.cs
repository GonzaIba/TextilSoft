using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.Tools
{
    public partial class FmTools : Form
    {
        public FmTools(int SizeWidth, int SizeHeight, Color color, Point location)
        {
            InitializeComponent();
            Size = new Size(SizeWidth, SizeHeight);
            Opacity = 0.1;
            TransparencyKey = color;
            Location = new Point(location.X,location.Y);
        }

        private void FmTools_Load(object sender, EventArgs e)
        {

        }
    }
}

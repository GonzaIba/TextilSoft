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
        Action<string> _funcion;
        Action<string,string> _funcion2;
        Point location;
        public FmInput(string titulo, Color BackColor,Point LocationOld,Action<string> funcion = null, Action<string,string> funcion2 = null,string lbl1 = "", string lbl2 = "", string nombreboton = "")
        {
            WindowState = FormWindowState.Normal;
            StartPosition = FormStartPosition.Manual;
            BringToFront();
            Location = new Point(LocationOld.X, LocationOld.Y);
            this.Refresh();
            this.Text = string.Empty;
            InitializeComponent();
            if (funcion == null)
                _funcion2 = funcion2;
            else
                _funcion = funcion;
            if (BackColor.R < 50 && BackColor.G < 50 && BackColor.B < 50)
            {
                lblTitle.ForeColor = Color.White;
                lblInput1.ForeColor = Color.White;
                lblInput2.ForeColor = Color.White;
                btnAccion1.ForeColor = Color.White;
                //btnCancelar.ForeColor = Color.Black;
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
            }

            lblTitle.Text = titulo;
            lblInput1.Text = lbl1;
            lblInput2.Text = lbl2;
            //Adjust label
            lblInput1.AutoSize = true;
            lblInput2.AutoSize = true;
            //Adjust textbox
            txt1.AutoSize = true;
            txt2.AutoSize = true;
            //Center title
            lblTitle.Location = new Point((this.Width - lblTitle.Width) / 2, lblTitle.Location.Y);

            this.BackColor = BackColor;
            
            if(lbl2 == string.Empty)
            {
                lblInput2.Visible = false;
                txt2.Visible = false;
            }
            if (nombreboton != string.Empty)
            {
                btnAccion1.Text = nombreboton;
            }
        }

        private void FmInput_Load(object sender, EventArgs e)
        {

        }

        private void btnAccion1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt2.Visible == true)
                {
                    _funcion2(txt1.Text, txt2.Text);
                }
                else
                {
                    _funcion(txt1.Text);
                }
                this.Close();
            }
            catch (Exception ex)
            {
                //CenterPosition
                Point CenterPosition = new Point(lblTitle.Width / 2, lblTitle.Height / 2) ;
                FmMessageBox fmMessage = new FmMessageBox(MessageBoxType.Error,"Datos incorrectos","El usuario o el mail es incorrecto", CenterPosition);
                fmMessage.ShowDialog();
            }
        }
    }
}

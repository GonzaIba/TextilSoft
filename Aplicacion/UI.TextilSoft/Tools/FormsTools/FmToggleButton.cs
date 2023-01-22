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
    public partial class FmToggleButton : UserControl
    {
        bool check;
        public FmToggleButton()
        {
            InitializeComponent();
        }

        private void FmToggleButton_Load(object sender, EventArgs e)
        {

        }
        enum eApparence { on, off, onSelected, offSelected }

        eApparence apparence = eApparence.off;
        eApparence Apparence
        {
            get { return Apparence; }
            set { Apparence = value;
                OnChangeApparence();
            }
        }
        
        public bool Check
        {
            get { return check; }
            set { check = value;
                SetApparence();
            }
        }

        public void ChangeValue()
        {
            Check = !check; 
        }
        private void OnChangeApparence()
        {
            switch (apparence)
            {
                case eApparence.on:
                    this.BackgroundImage = Properties.Resources.toggle_on;
                    this.BorderStyle = BorderStyle.None;
                    break;
                case eApparence.off:
                    this.BackgroundImage = Properties.Resources.toggle_off;
                    this.BorderStyle = BorderStyle.None;
                    break;
                case eApparence.onSelected:
                    this.BackgroundImage = Properties.Resources.toggle_on;
                    this.BorderStyle = BorderStyle.FixedSingle;
                    break;
                case eApparence.offSelected:
                    this.BackgroundImage = Properties.Resources.toggle_off;
                    this.BorderStyle = BorderStyle.FixedSingle;
                    break;
                default:
                    break;
            }
        }
        
        private void SetApparence()
        {
            if (this.Focused)
            {
                if (Check)
                    apparence = eApparence.onSelected;
                else
                    apparence = eApparence.offSelected;
            }
            else
            {
                if (Check)
                    Apparence = eApparence.on;
                else
                    Apparence = eApparence.off;
            }
        }

        private void FmToggleButton_Click(object sender, EventArgs e)
        {
            ChangeValue();
        }
    }
}

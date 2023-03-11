using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.TextilSoft.Tools;

namespace UI.TextilSoft.MainForm
{
    public partial class FmError : Form
    {
        private readonly TypeErrorEnum _typeError;
        public FmError(TypeErrorEnum tyeErrorEnum)
        {
            InitializeComponent();
            _typeError = tyeErrorEnum;
        }

        private void FmError_Load(object sender, EventArgs e)
        {
            if (_typeError == TypeErrorEnum.Generic)
            {
                pboxError.Image = Properties.Resources.ErrorGeneral;
            }
            else if (_typeError == TypeErrorEnum.SqlConnect)
            {
                pboxError.Image = Properties.Resources.database_error;
                this.BackColor = Color.White;
                Refresh();
            }
        }
    }
}

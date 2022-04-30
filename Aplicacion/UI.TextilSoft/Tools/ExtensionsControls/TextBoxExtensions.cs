using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.Tools.ExtensionsControls
{
    public static class TextBoxExtensions
    {
        public static void LimpiarTextbox(this TextBox txt) => txt.Text = string.Empty;

        public static void LlenarTextbox(this TextBox txt, string texto) => txt.Text = texto;

    }
}

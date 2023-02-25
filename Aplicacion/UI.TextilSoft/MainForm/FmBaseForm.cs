using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.TextilSoft.MainForm
{
    public class FmBaseForm : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        protected extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        protected extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        protected virtual void Control_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public FmBaseForm()
        {
            
        }
    }
}

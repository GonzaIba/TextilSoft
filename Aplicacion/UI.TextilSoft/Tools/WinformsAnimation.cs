using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace UI.TextilSoft.Tools
{
    public static class Win32
    {
        private const int AW_SLIDE = 0x40000;
        private const int AW_VER_POSITIVE = 0x4;
        private const int AW_VER_NEGATIVE = 0x8;
        private const int AW_HIDE = 0x10000;
        private const int AW_ACTIVATE = 0x20000;

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hWnd, int dwTime, int dwFlags);

        public static void SlideControl(System.Windows.Forms.Control control, int duration, bool slideUp)
        {
            int flags = AW_SLIDE | AW_ACTIVATE;
            if (slideUp)
            {
                flags |= AW_VER_NEGATIVE;
            }
            else
            {
                flags |= AW_VER_POSITIVE;
            }
            AnimateWindow(control.Handle, duration, flags);
        }
    }
}

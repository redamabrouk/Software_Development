using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPIs_Kernel32
{
    public class Win32
    {
        [DllImport("User32.dll")]
        public static extern int MessageBox(int h, string m, string c, int type);

        [DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(IntPtr hWnd);
       
        [DllImport("User32.dll")]
        public static extern Int32 GetWindowText(int hWnd, StringBuilder s, int nMaxCount);
        [DllImport("User32.dll")]
        public static extern Int32 GetWindowTextLength(int hwnd);
        
        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow")]
        public static extern int GetDesktopWindow();
       
        [DllImport("User32.dll")]
        public static extern int GetForegroundWindow();
    }
}

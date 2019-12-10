using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPIs_Kernel32
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Win32.MessageBox(0, "Messagebox Crated from windows OS", "Title", 1);
            }
            catch (Exception er)
            {
                Win32.MessageBox(0, er.Message, "API Demo", 0);
            }
            int hwnd = Win32.GetForegroundWindow();
            StringBuilder title1 = new StringBuilder(2048);
            int intLength = Win32.GetWindowText(hwnd, title1, title1.Capacity);
            if ((intLength <= 0) || (intLength > title1.Length))
                Win32.MessageBox(0, title1.ToString(), "Title", 1);
            string title = title1.ToString();
            Win32.MessageBox(0, title1.ToString(), "Title", 1);


            try
            {
                Process process = Process.GetProcessesByName("WINWORD")[0];
                if (process != null)
                {
                    process.WaitForInputIdle();
                    IntPtr s = process.MainWindowHandle;
                    Win32.SetForegroundWindow(s);
                    Console.Write("Proccess found: " + process.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: Application is not running!\nException: " + ex.Message);
                return;
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace _0501
{
    internal static class Program
    {
        static Mutex mutex = new Mutex(true, "{2B74B7C1-6F91-4A55-A450-5741DA5E33E2}");
        [STAThread]
        static void Main()
        {
            if (mutex.WaitOne(TimeSpan.Zero, true))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show("Програма вже запущена.");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace UniAccessAgent
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Utilities.RefreshTrayArea();//Clear last time notify icon

            bool appRunning = false;
            Mutex mutex = new Mutex(true, Process.GetCurrentProcess().ProcessName, out appRunning);

            if (!appRunning)
                Environment.Exit(0);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmSafeAssistant());
            
            mutex.ReleaseMutex();
        }
    }
}

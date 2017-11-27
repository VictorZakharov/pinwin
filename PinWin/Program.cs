using System;
using System.Windows.Forms;
using PinWin.BusinessLayer;
using PinWin.WinApi;

namespace PinWin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                // prevent overlay from capturing only a portion of the desktop
                ApiScreenCapture.SetProcessDPIAware();
            }

            using (var app = new SingleInstanceManager())
            {
                const int singleInstanceWaitMs = 1000;
                if (!app.IsFirstInstance(singleInstanceWaitMs))
                {
                    // force single instance
                    MessageBox.Show(@"An instance of PinWin is already running.");
                    return;
                }

                // else we are good to run the app
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
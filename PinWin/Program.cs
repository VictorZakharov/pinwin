using System;
using System.Windows.Forms;

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
                SetProcessDPIAware();
            }

            using (var app = new SingleGlobalInstance())
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

        /// <summary>
        ///  Sets process as DPI aware, prevents odd behavior related to auto-scaling.
        /// </summary>
        /// <remarks>
        ///  https://stackoverflow.com/questions/13228185/how-to-configure-an-app-to-run-correctly-on-a-machine-with-a-high-dpi-setting-e/13228495#13228495
        /// </remarks>
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();
    }
}
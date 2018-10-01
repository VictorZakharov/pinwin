namespace PinWin.WinApi
{
    using System.Runtime.InteropServices;

    public class ApiSystemMetrics
    {
        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(SystemMetric smIndex);

        public static int Get(SystemMetric smIndex)
        {
            return GetSystemMetrics(smIndex);
        }
    }
}
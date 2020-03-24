using System;

namespace PinWin.WinApi
{
    using System.Runtime.InteropServices;

    public class ApiSystemMetrics
    {
        /// <summary>
        ///  Get control buttons area width for legacy OS (XP).
        /// </summary>
        /// <returns>Total width in pixels.</returns>
        public static int GetControlButtonWidth()
        {
            return GetSystemMetrics(SystemMetric.SM_CXSIZE);
        }

        /// <summary>
        ///  Get control buttons area width for newer OS (Win 7-10).
        /// </summary>
        /// <returns>Total width in pixels.</returns>
        public static int GetControlBoxWidth(IntPtr handle)
        {
            int DWMWA_CAPTION_BUTTON_BOUNDS = 5;
            RECT rc;
            try
            {
                int errorCode = DwmGetWindowAttribute(handle, DWMWA_CAPTION_BUTTON_BOUNDS,
                    out rc, Marshal.SizeOf(typeof(RECT)));
                if (errorCode != 0)
                {
                    // api function is available but resulted in an error
                    return 0;
                }

                int width = rc.right - rc.left;
                return width;
            }
            catch (DllNotFoundException)
            {
                // api function not available - probably running on windows xp
                return 0;
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct RECT
        {
            public int left;
            public int top;
            public int right;
            public int bottom;
        }

        [DllImport("dwmapi.dll")]
        private static extern int DwmGetWindowAttribute(
            IntPtr hwnd, int attr, out RECT ptr, int size);

        [DllImport("user32.dll")]
        private static extern int GetSystemMetrics(SystemMetric smIndex);

    }
}
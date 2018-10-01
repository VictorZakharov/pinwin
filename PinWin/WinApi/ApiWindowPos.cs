namespace PinWin.WinApi
{
    using System;
    using System.Drawing;
    using System.Runtime.InteropServices;

    /// <summary>
    /// 
    /// </summary>
    /// <remarks>
    ///  Taken from:
    ///  http://stackoverflow.com/questions/16484894/form-tells-wrong-size-on-windows-8-how-to-get-real-size
    /// </remarks>
    public static class ApiWindowPos
    {
        /// <summary>
        /// Get real window size, no matter whether Win XP, Win Vista, 7 or 8.
        /// </summary>
        public static Rectangle Get(IntPtr handle)
        {
            if (Environment.OSVersion.Version.Major < 6)
            {
                return GetWindowRect(handle);
            }
            else
            {
                Rectangle rectangle;
                return DWMWA_EXTENDED_FRAME_BOUNDS(handle, out rectangle) ? rectangle : GetWindowRect(handle);
            }
        }

        /// <summary>
        ///  Determines if the specified handle is open.
        /// </summary>
        /// <param name="hWnd">Window handle to be checked.</param>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsWindow(IntPtr hWnd);

        /// <summary>
        ///  Determines if window is minimized.
        /// </summary>
        /// <param name="hWnd">Window handle to be checked.</param>
        /// <returns></returns>
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool IsIconic(IntPtr hWnd);

        [DllImport(@"dwmapi.dll")]
        private static extern int DwmGetWindowAttribute(IntPtr hwnd, int dwAttribute, out Rect pvAttribute,
            int cbAttribute);

        private enum Dwmwindowattribute
        {
            DwmwaExtendedFrameBounds = 9
        }

        [Serializable, StructLayout(LayoutKind.Sequential)]
        private struct Rect
        {
            // ReSharper disable MemberCanBePrivate.Local
            // ReSharper disable FieldCanBeMadeReadOnly.Local
            public int Left;

            public int Top;
            public int Right;

            public int Bottom;
            // ReSharper restore FieldCanBeMadeReadOnly.Local
            // ReSharper restore MemberCanBePrivate.Local

            public Rectangle ToRectangle()
            {
                return Rectangle.FromLTRB(Left, Top, Right, Bottom);
            }
        }

        private static bool DWMWA_EXTENDED_FRAME_BOUNDS(IntPtr handle, out Rectangle rectangle)
        {
            Rect rect;
            var result = DwmGetWindowAttribute(handle, (int) Dwmwindowattribute.DwmwaExtendedFrameBounds,
                out rect, Marshal.SizeOf(typeof(Rect)));
            rectangle = rect.ToRectangle();
            return result >= 0;
        }

        [DllImport(@"user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out Rect lpRect);

        private static Rectangle GetWindowRect(IntPtr handle)
        {
            Rect rect;
            GetWindowRect(handle, out rect);
            return rect.ToRectangle();
        }
    }
}
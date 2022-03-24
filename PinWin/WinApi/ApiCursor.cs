using System;
using System.Windows.Forms;

namespace PinWin.WinApi
{
    public class ApiCursor
    {
        // from https://stackoverflow.com/a/7809657/897326
        public static Cursor LoadFromPath(String path)
        {
            if (string.IsNullOrWhiteSpace(path))
            {
                return null;
            }

            try
            {
                return new Cursor(LoadCursorFromFile(path));
            }
            catch (ArgumentException)
            {
                return null;
            }
        }
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr LoadCursorFromFile(string fileName);
    }
}

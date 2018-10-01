namespace PinWin.WinApi
{
    using System;
    using System.Runtime.InteropServices;
    using System.Windows.Forms;

    public class ApiHotKey
    {
        #region fields

        public static int MOD_ALT = 0x1;
        public static int MOD_CONTROL = 0x2;
        public static int MOD_SHIFT = 0x4;
        public static int MOD_WIN = 0x8;
        public static int WM_HOTKEY = 0x312;

        #endregion

        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        public static void Set(Form f, Keys key, int keyId)
        {
            int modifiers = 0;

            if ((key & Keys.Alt) == Keys.Alt)
                modifiers = modifiers | ApiHotKey.MOD_ALT;

            if ((key & Keys.Control) == Keys.Control)
                modifiers = modifiers | ApiHotKey.MOD_CONTROL;

            if ((key & Keys.Shift) == Keys.Shift)
                modifiers = modifiers | ApiHotKey.MOD_SHIFT;

            Keys k = key & ~Keys.Control & ~Keys.Shift & ~Keys.Alt;
            ApiHotKey.RegisterHotKey(f.Handle, keyId, modifiers, (int) k);
        }

        public static void Clear(Form f, int keyId)
        {
            try
            {
                ApiHotKey.UnregisterHotKey(f.Handle, keyId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
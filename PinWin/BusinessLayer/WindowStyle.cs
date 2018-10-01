namespace PinWin.BusinessLayer
{
    using System;

    using WinApi;
    
    public class WindowStyle
    {
        private readonly int _windowStyleRaw;

        public IntPtr Handle { get; }

        public bool MaximizeBox => (_windowStyleRaw & (int) ApiWindowStyle.WindowStyles.WS_MAXIMIZEBOX) != 0;

        public bool MinimizeBox => (_windowStyleRaw & (int) ApiWindowStyle.WindowStyles.WS_MINIMIZEBOX) != 0;

        public WindowStyle(IntPtr handle)
        {
            this.Handle = handle;
            this._windowStyleRaw = ApiWindowStyle.GetWindowLong(handle, (int) ApiWindowStyle.WindowLongFlags.GWL_STYLE);
        }
    }
}
namespace PinWin.BusinessLayer
{
    using System.Windows.Forms;

    public class ApplicationSettings
    {
        public Keys ShortcutPinWindowPrompt = Keys.Control | Keys.F11;
        public Keys ShortcutPinWindowUnderCursor = Keys.Control | Keys.F12;
        public string TrayIconPath = "";
        public string CaptureIconPath = "";

        /// <summary>
        ///  Default constructor.
        /// </summary>
        public ApplicationSettings()
        {
        }

        /// <summary>
        ///  Create a copy of provided instance.
        /// </summary>
        /// <param name="settings">Application settings object.</param>
        public ApplicationSettings(ApplicationSettings settings)
        {
            this.ShortcutPinWindowPrompt = settings.ShortcutPinWindowPrompt;
            this.ShortcutPinWindowUnderCursor = settings.ShortcutPinWindowUnderCursor;
            this.TrayIconPath = settings.TrayIconPath;
            this.CaptureIconPath = settings.CaptureIconPath;
        }
    }
}

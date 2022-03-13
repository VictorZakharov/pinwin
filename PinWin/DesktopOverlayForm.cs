using System.Drawing;
using System.Windows.Forms;

using PinWin.BusinessLayer;
using PinWin.Controls;
using PinWin.WinApi;

namespace PinWin
{
    public partial class DesktopOverlayForm : OverlayForm
    {
        #region " Properties "

        private Point? _mouseClickPoint = null;

        public Point? MouseClickPoint => this._mouseClickPoint;

        #endregion

        #region " Constructor "

        public DesktopOverlayForm()
        {
            this.InitializeComponent();

            //clear initial text, it only helps find the label at design time
            this.lbl_DebugInfo.Text = string.Empty;

            //set overlay form as full screen across all monitors
            this.Bounds = ScreenCapture.GetDesktopBounds();

            //set desktop overlay image
            this.BackgroundImage = ScreenCapture.CreateBitmapFromDesktop();

            //appear on top of all windows, including those pinned earlier
            this.TopMost = true;
        }

        #endregion

        #region " Public methods "

        /// <summary>
        ///  Prompt user to select a Point on screen.
        /// </summary>
        /// <param name="parentForm">
        ///  A new window will open for this parent form.
        /// </param>
        /// <returns>
        ///  Point that was selected by user. Null if selection was cancelled.
        /// </returns>
        public static Point? SelectPoint(Form parentForm, string captureIconPath = null)
        {
            var desktopOverlayForm = new DesktopOverlayForm();

            //apply custom cursor - make interface more user-friendly
            var customCursor = ApiCursor.LoadFromPath(captureIconPath);
            desktopOverlayForm.Cursor = customCursor ?? new Cursor(EmbeddedResource.TargetWindowIcon.Handle);

            desktopOverlayForm.ShowDialog(parentForm);
            return desktopOverlayForm.MouseClickPoint;
        }

        #endregion

        #region " Event handlers "

        /// <summary>
        ///  User-friendly interface, escape key triggers form close.
        /// </summary>
        private void DesktopOverlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        /// <summary>
        ///  Mouse coordinates will be temporarily saved for debugging purposes.
        /// </summary>
        private void DesktopOverlayForm_MouseMove(object sender, MouseEventArgs e)
        {
            this.lbl_DebugInfo.Text = $@"Mouse - X: {e.X}, Y: {e.Y}";
        }

        /// <summary>
        ///  Default behavior - user clicks a point, coordinates stored, form is closed.
        /// </summary>
        private void DesktopOverlayForm_MouseDown(object sender, MouseEventArgs e)
        {
            //desktop bounds can have negative values depending on which monitor is primary
            //form coordinates are always positive and need to be adjusted to work as expected
            Rectangle bounds = ScreenCapture.GetDesktopBounds();
            this._mouseClickPoint = new Point(bounds.X + e.X, bounds.Y + e.Y);
            this.Close();
        }

        #endregion
    }
}
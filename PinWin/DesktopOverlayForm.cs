using System;
using System.Drawing;
using System.Windows.Forms;

using PinWin.BusinessLayer;
using PinWin.Controls;

namespace PinWin
{
    public partial class DesktopOverlayForm : OverlayForm
    {
        #region " Properties "

        private Point? _mouseClickPoint = null;

        public Point? MouseClickPoint => _mouseClickPoint;

        #endregion

        #region " Constructor "

        public DesktopOverlayForm()
        {
            InitializeComponent();

            //set overlay form as full screen across all monitors
            this.Bounds = ScreenCapture.GetDesktopBounds();

            //set desktop overlay image
            this.BackgroundImage = ScreenCapture.CreateBitmapFromDesktop();

            //apply custom cursor - make interface more user-friendly
            this.Cursor = new Cursor(EmbeddedResource.TargetWindowIcon.Handle);
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
        public static Point? SelectPoint(Form parentForm)
        {
            var desktopOverlayForm = new DesktopOverlayForm();
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
            lbl_DebugInfo.Text = $@"Mouse - X: {e.X}, Y: {e.Y}";
        }

        /// <summary>
        ///  Default behavior - user clicks a point, coordinates stored, form is closed.
        /// </summary>
        private void DesktopOverlayForm_MouseDown(object sender, MouseEventArgs e)
        {
            this._mouseClickPoint = new Point(e.X, e.Y);
            this.Close();
        }

        #endregion
    }
}
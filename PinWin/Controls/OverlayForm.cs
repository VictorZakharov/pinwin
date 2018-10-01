namespace PinWin.Controls
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    ///  Flicker free form used for overlays.
    /// </summary>
    /// <remarks>
    ///  Used code from here (credit goes to Ivan Stoev):
    ///  http://stackoverflow.com/questions/34420599/desktop-screen-overlay-new-form-flicker-issue
    /// </remarks>
    public class OverlayForm : Form
    {
        bool _activated;

        /// <summary>
        ///  Double-buffered drawing behavior for form and child controls.
        /// </summary>
        /// <remarks>
        ///  Based on this answer by Hans Passant:
        ///  http://stackoverflow.com/a/3718648/897326
        /// </remarks>
        protected override CreateParams CreateParams
        {
            get
            {
                if (this.DesignMode)
                {
                    return base.CreateParams;
                }

                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        protected override bool ShowWithoutActivation
        {
            get
            {
                if (this.DesignMode)
                {
                    return base.ShowWithoutActivation;
                }

                return true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (!this._activated && !this.DesignMode)
            {
                this._activated = true;
                this.BeginInvoke(new Action(Activate));
            }
        }
    }
}
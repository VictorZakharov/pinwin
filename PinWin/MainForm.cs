using System;
using System.Drawing;
using System.Windows.Forms;
using PinWin.BusinessLayer;
using PinWin.Controls;

namespace PinWin
{
    /// <summary>
    ///  Main form of the application. Currently a place for prototyping.
    /// </summary>
    public partial class MainForm : TrayAppForm
    {
        public bool IsLoaded { get; set; }

        // ReSharper disable once InconsistentNaming
        private bool _isDesktopOverlayShown { get; set; }

        // ReSharper disable once InconsistentNaming
        private ApplicationSettings _settings { get; set; }

        #region " Constructor "

        /// <summary>
        ///  Constructor - no special processing.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            // Replace default tooltip text of tray icon with application name
            this.notifyIcon_Main.Text = Application.ProductName;

            // Load key configuration from file when form is created
            this._settings = ApplicationSettingsJson.LoadFromFile();

            // register hot keys in the application
            this.RegisterHotKeys();
        }

        #endregion

        protected void RegisterHotKeys()
        {
            lbl_message.Text = this.GetWelcomeHint();
            this.RegisterHotKey(this._settings.ShortcutPinWindowPrompt, this.PinWindowPrompt);
            this.RegisterHotKey(this._settings.ShortcutPinWindowUnderCursor, this.PinWindowUnderCursor);
        }

        /// <summary>
        ///  Gets the correct wording to hint user on which key toggles window pin operation.
        /// </summary>
        private string GetWelcomeHint()
        {
            var keyHint = KeysStringConverter.ToString(this._settings.ShortcutPinWindowPrompt);
            return $@"Use {keyHint} to trigger window selection when minimized to tray";
        }

        #region " Event handlers - System tray icon "

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.notifyIcon_Main.ShowBalloonTip(500, "Minimized to tray",
                    "PinWin is now running from system tray.", ToolTipIcon.Info);
                this.Hide();
            }
        }

        private void contextMenu_CloseApplication_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenu_OpenApplication_Click(object sender, EventArgs e)
        {
            this.AllowFormShow = true;
            if (!this.IsLoaded)
            {
                this.CenterToScreen();
            }
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon_Main_DoubleClick(object sender, EventArgs e)
        {
            contextMenu_OpenApplication.PerformClick();
        }

        #endregion

        #region " Event handlers - Other"

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.IsLoaded = true;
            this.Text = $@"{Application.ProductName} v{Application.ProductVersion}";
        }

        private void btn_OpenDesktopOverlay_Click(object sender, EventArgs e)
        {
            this.PinWindowPrompt();
        }

        /// <summary>
        ///  Try making window top most, based on mouse click location.
        /// </summary>
        private void PinWindowPrompt()
        {
            if (this._isDesktopOverlayShown)
            {
                //prevent overlay from pinning itself
                return;
            }

            this._isDesktopOverlayShown = true;
            try
            {
                Point? mouseClickPoint = DesktopOverlayForm.SelectPoint(ParentForm);
                if (mouseClickPoint == null)
                {
                    //no point was selected by user, do nothing
                    return;
                }

                this.pinnedWindowListControl.TryAddWindowFromPoint(mouseClickPoint.Value);
            }
            finally
            {
                this._isDesktopOverlayShown = false;
            }
        }

        /// <summary>
        ///  Make window top most, based on mouse hover location (no clicks).
        /// </summary>
        private void PinWindowUnderCursor()
        {
            this.pinnedWindowListControl.TryAddWindowFromPoint(Cursor.Position);
        }

        #endregion

        private void tmrWindowPosSync_Tick(object sender, EventArgs e)
        {
            this.pinnedWindowListControl.SyncWindowPosition();
        }

        private void btnChangeKeyMap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Create local copy of application settings
            var settings = new ApplicationSettings(this._settings);

            // newSettings will contain modified settings or null if user cancelled
            var newSettings = SettingsForm.ShowSettingsDialog(this, settings);
            if (newSettings == null)
            {
                // user cancelled - do not change anything
                return;
            }

            // user OK'd, need to save new key configuration
            this._settings = newSettings;
            if (!ApplicationSettingsJson.SaveToFile(newSettings))
            {
                MessageBox.Show(@"Unable to save to file.", @"Application error");
            }

            // And re-register hot keys
            this.UnregisterHotKeys();
            this.RegisterHotKeys();
        }

        private void notifyIcon_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.PinWindowPrompt();
            }
        }
    }
}
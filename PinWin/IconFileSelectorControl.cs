using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using PinWin.BusinessLayer;

namespace PinWin
{
    public partial class IconFileSelectorControl : UserControl
    {
        private string _defaultPath = "";
        private string _currentPath = "";
        private DebounceDispatcher debounceTimer = new DebounceDispatcher();
        private int DebounceDelay = 0;
        private const int MaxImageSize = 32;

        public IconFileSelectorControl()
        {
            this.InitializeComponent();

            this.chk_UseCustom_CheckedChanged(null, null);
        }

        [Description("Open file dialog hyperlink text"), Category("Data")]
        public string LinkText
        {
            get => this.link_OpenFileDialog.Text;
            set => this.link_OpenFileDialog.Text = value;
        }

        [Description("Default icon file path, it should be set when no path was specified"), Category("Data")]
        public string DefaultPath
        {
            get => this._defaultPath;
            set
            {
                this._defaultPath = value;
                this.SetPath();
            }
        }

        public string CurrentPath
        {
            get
            {
                if (this.chk_UseCustom.Checked)
                {
                    return this._currentPath;
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                this._currentPath = value;
                this.SetPath();
            }
        }

        private void SetPath()
        {
            if (string.IsNullOrWhiteSpace(this._currentPath) ||
                System.IO.Path.GetFullPath(this._currentPath) == System.IO.Path.GetFullPath(this._defaultPath))
            {
                this.txt_Path.Text = this._defaultPath;
                this.chk_UseCustom.Checked = false;
            }
            else
            {
                this.txt_Path.Text = this._currentPath;
                this.chk_UseCustom.Checked = true;
            }
        }

        private void chk_UseCustom_CheckedChanged(object sender, EventArgs e)
        {
            this.txt_Path.Enabled = this.chk_UseCustom.Checked;
            this.link_OpenFileDialog.Visible = this.chk_UseCustom.Checked;
        }

        private void link_OpenFileDialog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.txt_Path.Text = FileFromDisk.Select(this);
        }

        private void txt_Path_TextChanged(object sender, EventArgs e)
        {
            this.debounceTimer.Debounce(this.DebounceDelay, x =>
            {
                this.pic_Preview.Image = IconFileSelectorControl.GetValidBitmap(
                    this.validationErrorProvider, this.txt_Path);
                this._currentPath = this.txt_Path.Text;
            });

            if (this.DebounceDelay == 0)
            {
                // initially we want to update controls immediately
                this.DebounceDelay = 500;
            }
        }

        private static Bitmap GetValidBitmap(ErrorProvider errorProvider, TextBox pathControl)
        {
            if (string.IsNullOrWhiteSpace(pathControl.Text))
            {
                return null;
            }

            if (!IconFileSelectorControl.ValidateFileExists(
                errorProvider, pathControl, "File not found"))
            {
                return null;
            }

            var bitmap = GetValidBitmap(errorProvider, pathControl, "Invalid image");
            return bitmap;
        }

        private static Bitmap GetValidBitmap(ErrorProvider errorProvider, TextBox control, string message)
        {
            try
            {
                errorProvider.SetError(control, string.Empty);

                Bitmap originalImage = new Bitmap(control.Text);
                if (originalImage.Size.Width <= MaxImageSize && originalImage.Size.Height <= MaxImageSize)
                {
                    return originalImage;
                }
                Bitmap resizedImage = new Bitmap(originalImage, new Size(MaxImageSize, MaxImageSize));
                return resizedImage;
            }
            catch (ArgumentException)
            {
                // Not a valid image, do not render a preview
                errorProvider.SetError(control, message);
                return null;
            }
        }

        private static bool ValidateFileExists(ErrorProvider errorProvider, TextBox control, string message)
        {
            if (System.IO.File.Exists(control.Text))
            {
                errorProvider.SetError(control, string.Empty);
                return true;
            }
            else
            {
                errorProvider.SetError(control, message);
                return false;
            }
        }
    }
}

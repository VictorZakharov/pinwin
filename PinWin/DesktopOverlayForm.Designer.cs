using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Windows.Forms;

namespace PinWin
{
    sealed partial class DesktopOverlayForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        [GeneratedCode("WinForms Designer", "")]
        private void InitializeComponent()
        {
            this.lbl_DebugInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_DebugInfo
            // 
            this.lbl_DebugInfo.AutoSize = true;
            this.lbl_DebugInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DebugInfo.ForeColor = System.Drawing.Color.Red;
            this.lbl_DebugInfo.Location = new System.Drawing.Point(32, 32);
            this.lbl_DebugInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DebugInfo.Name = "lbl_DebugInfo";
            this.lbl_DebugInfo.Size = new System.Drawing.Size(203, 46);
            this.lbl_DebugInfo.TabIndex = 0;
            this.lbl_DebugInfo.Text = "DebugInfo";
            // 
            // DesktopOverlayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 448);
            this.Controls.Add(this.lbl_DebugInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DesktopOverlayForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "DesktopOverlay";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DesktopOverlayForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DesktopOverlayForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DesktopOverlayForm_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lbl_DebugInfo;
    }
}
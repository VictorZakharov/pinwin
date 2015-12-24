using System;
using System.ComponentModel;
using System.Drawing;
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
    private void InitializeComponent()
    {
      this.lbl_DebugInfo = new Label();
      this.SuspendLayout();
      // 
      // lbl_DebugInfo
      // 
      this.lbl_DebugInfo.AutoSize = true;
      this.lbl_DebugInfo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
      this.lbl_DebugInfo.ForeColor = Color.Red;
      this.lbl_DebugInfo.Location = new Point(24, 26);
      this.lbl_DebugInfo.Name = "lbl_DebugInfo";
      this.lbl_DebugInfo.Size = new Size(164, 37);
      this.lbl_DebugInfo.TabIndex = 0;
      this.lbl_DebugInfo.Text = "DebugInfo";
      // 
      // DesktopOverlayForm
      // 
      this.AutoScaleDimensions = new SizeF(6F, 13F);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.ClientSize = new Size(556, 364);
      this.Controls.Add(this.lbl_DebugInfo);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Name = "DesktopOverlayForm";
      this.ShowInTaskbar = false;
      this.Text = "DesktopOverlay";
      this.KeyDown += new KeyEventHandler(this.DesktopOverlayForm_KeyDown);
      this.MouseDown += new MouseEventHandler(this.DesktopOverlayForm_MouseDown);
      this.MouseMove += new MouseEventHandler(this.DesktopOverlayForm_MouseMove);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Label lbl_DebugInfo;
  }
}
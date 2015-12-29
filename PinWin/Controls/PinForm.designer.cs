namespace PinWin.Controls
{
  partial class PinForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinForm));
      this.SuspendLayout();
      // 
      // PinForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(16, 16);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "PinForm";
      this.ShowInTaskbar = false;
      this.Text = "PinForm";
      this.Load += new System.EventHandler(this.PinForm_Load);
      this.Shown += new System.EventHandler(this.PinForm_Shown);
      this.ResumeLayout(false);

    }

    #endregion
  }
}
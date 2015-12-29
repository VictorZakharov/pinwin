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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PinForm));
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.SuspendLayout();
      // 
      // PinForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.ClientSize = new System.Drawing.Size(16, 16);
      this.Cursor = System.Windows.Forms.Cursors.Hand;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "PinForm";
      this.ShowInTaskbar = false;
      this.Text = "PinForm";
      this.toolTip1.SetToolTip(this, "Click to unpin");
      this.Load += new System.EventHandler(this.PinForm_Load);
      this.Shown += new System.EventHandler(this.PinForm_Shown);
      this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PinForm_MouseClick);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ToolTip toolTip1;
  }
}
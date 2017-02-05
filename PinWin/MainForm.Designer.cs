namespace PinWin
{
  partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenu_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.contextMenu_OpenApplication = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenu_CloseApplication = new System.Windows.Forms.ToolStripMenuItem();
      this.pinnedWindowListControl = new PinWin.Controls.PinnedWindowListControl();
      this.btn_OpenDesktopOverlay = new System.Windows.Forms.Button();
      this.lbl_message = new System.Windows.Forms.Label();
      this.contextMenu_Main.SuspendLayout();
      this.SuspendLayout();
      // 
      // notifyIcon_Main
      // 
      this.notifyIcon_Main.ContextMenuStrip = this.contextMenu_Main;
      this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
      this.notifyIcon_Main.Text = "notifyIcon1";
      this.notifyIcon_Main.Visible = true;
      this.notifyIcon_Main.DoubleClick += new System.EventHandler(this.notifyIcon_Main_DoubleClick);
      // 
      // contextMenu_Main
      // 
      this.contextMenu_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.contextMenu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenu_OpenApplication,
            this.contextMenu_CloseApplication});
      this.contextMenu_Main.Name = "contextMenu_Main";
      this.contextMenu_Main.Size = new System.Drawing.Size(122, 56);
      // 
      // contextMenu_OpenApplication
      // 
      this.contextMenu_OpenApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.contextMenu_OpenApplication.Name = "contextMenu_OpenApplication";
      this.contextMenu_OpenApplication.Size = new System.Drawing.Size(121, 26);
      this.contextMenu_OpenApplication.Text = "Open";
      this.contextMenu_OpenApplication.Click += new System.EventHandler(this.contextMenu_OpenApplication_Click);
      // 
      // contextMenu_CloseApplication
      // 
      this.contextMenu_CloseApplication.Name = "contextMenu_CloseApplication";
      this.contextMenu_CloseApplication.Size = new System.Drawing.Size(121, 26);
      this.contextMenu_CloseApplication.Text = "Exit";
      this.contextMenu_CloseApplication.Click += new System.EventHandler(this.contextMenu_CloseApplication_Click);
      // 
      // pinnedWindowListControl
      // 
      this.pinnedWindowListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pinnedWindowListControl.Location = new System.Drawing.Point(231, 15);
      this.pinnedWindowListControl.Margin = new System.Windows.Forms.Padding(5);
      this.pinnedWindowListControl.Name = "pinnedWindowListControl";
      this.pinnedWindowListControl.Size = new System.Drawing.Size(483, 224);
      this.pinnedWindowListControl.TabIndex = 9;
      // 
      // btn_OpenDesktopOverlay
      // 
      this.btn_OpenDesktopOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btn_OpenDesktopOverlay.Location = new System.Drawing.Point(16, 15);
      this.btn_OpenDesktopOverlay.Margin = new System.Windows.Forms.Padding(4);
      this.btn_OpenDesktopOverlay.Name = "btn_OpenDesktopOverlay";
      this.btn_OpenDesktopOverlay.Size = new System.Drawing.Size(207, 185);
      this.btn_OpenDesktopOverlay.TabIndex = 10;
      this.btn_OpenDesktopOverlay.Text = "Select Window";
      this.btn_OpenDesktopOverlay.UseVisualStyleBackColor = true;
      this.btn_OpenDesktopOverlay.Click += new System.EventHandler(this.btn_OpenDesktopOverlay_Click);
      // 
      // lbl_message
      // 
      this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_message.ForeColor = System.Drawing.Color.Green;
      this.lbl_message.Location = new System.Drawing.Point(11, 244);
      this.lbl_message.Name = "lbl_message";
      this.lbl_message.Size = new System.Drawing.Size(694, 29);
      this.lbl_message.TabIndex = 11;
      this.lbl_message.Text = "Use CTRL+F11 to trigger window selection when minimized to tray";
      this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(717, 283);
      this.Controls.Add(this.lbl_message);
      this.Controls.Add(this.pinnedWindowListControl);
      this.Controls.Add(this.btn_OpenDesktopOverlay);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(522, 229);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PinWin prototype";
      this.Resize += new System.EventHandler(this.MainForm_Resize);
      this.contextMenu_Main.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.NotifyIcon notifyIcon_Main;
    private System.Windows.Forms.ContextMenuStrip contextMenu_Main;
    private System.Windows.Forms.ToolStripMenuItem contextMenu_OpenApplication;
    private System.Windows.Forms.ToolStripMenuItem contextMenu_CloseApplication;
    private Controls.PinnedWindowListControl pinnedWindowListControl;
    private System.Windows.Forms.Button btn_OpenDesktopOverlay;
    private System.Windows.Forms.Label lbl_message;
  }
}


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
      this.lbl_WindowX = new System.Windows.Forms.Label();
      this.txt_WindowX = new System.Windows.Forms.TextBox();
      this.lbl_WindowY = new System.Windows.Forms.Label();
      this.txt_WindowY = new System.Windows.Forms.TextBox();
      this.btn_CaptureClick = new System.Windows.Forms.Button();
      this.notifyIcon_Main = new System.Windows.Forms.NotifyIcon(this.components);
      this.contextMenu_Main = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.contextMenu_OpenApplication = new System.Windows.Forms.ToolStripMenuItem();
      this.contextMenu_CloseApplication = new System.Windows.Forms.ToolStripMenuItem();
      this.btn_SetWindowTopMost = new System.Windows.Forms.Button();
      this.pinnedWindowListControl = new PinWin.Controls.PinnedWindowListControl();
      this.contextMenu_Main.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbl_WindowX
      // 
      this.lbl_WindowX.AutoSize = true;
      this.lbl_WindowX.Location = new System.Drawing.Point(12, 18);
      this.lbl_WindowX.Name = "lbl_WindowX";
      this.lbl_WindowX.Size = new System.Drawing.Size(56, 13);
      this.lbl_WindowX.TabIndex = 1;
      this.lbl_WindowX.Text = "Window X";
      // 
      // txt_WindowX
      // 
      this.txt_WindowX.Location = new System.Drawing.Point(74, 15);
      this.txt_WindowX.Name = "txt_WindowX";
      this.txt_WindowX.Size = new System.Drawing.Size(100, 20);
      this.txt_WindowX.TabIndex = 2;
      this.txt_WindowX.Text = "100";
      // 
      // lbl_WindowY
      // 
      this.lbl_WindowY.AutoSize = true;
      this.lbl_WindowY.Location = new System.Drawing.Point(12, 47);
      this.lbl_WindowY.Name = "lbl_WindowY";
      this.lbl_WindowY.Size = new System.Drawing.Size(56, 13);
      this.lbl_WindowY.TabIndex = 1;
      this.lbl_WindowY.Text = "Window Y";
      // 
      // txt_WindowY
      // 
      this.txt_WindowY.Location = new System.Drawing.Point(74, 44);
      this.txt_WindowY.Name = "txt_WindowY";
      this.txt_WindowY.Size = new System.Drawing.Size(100, 20);
      this.txt_WindowY.TabIndex = 2;
      this.txt_WindowY.Text = "100";
      // 
      // btn_CaptureClick
      // 
      this.btn_CaptureClick.Location = new System.Drawing.Point(74, 70);
      this.btn_CaptureClick.Name = "btn_CaptureClick";
      this.btn_CaptureClick.Size = new System.Drawing.Size(101, 23);
      this.btn_CaptureClick.TabIndex = 6;
      this.btn_CaptureClick.Text = "From mouse Click";
      this.btn_CaptureClick.UseVisualStyleBackColor = true;
      this.btn_CaptureClick.Click += new System.EventHandler(this.btn_CaptureClick_Click);
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
      this.contextMenu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenu_OpenApplication,
            this.contextMenu_CloseApplication});
      this.contextMenu_Main.Name = "contextMenu_Main";
      this.contextMenu_Main.Size = new System.Drawing.Size(105, 48);
      // 
      // contextMenu_OpenApplication
      // 
      this.contextMenu_OpenApplication.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.contextMenu_OpenApplication.Name = "contextMenu_OpenApplication";
      this.contextMenu_OpenApplication.Size = new System.Drawing.Size(104, 22);
      this.contextMenu_OpenApplication.Text = "Open";
      this.contextMenu_OpenApplication.Click += new System.EventHandler(this.contextMenu_OpenApplication_Click);
      // 
      // contextMenu_CloseApplication
      // 
      this.contextMenu_CloseApplication.Name = "contextMenu_CloseApplication";
      this.contextMenu_CloseApplication.Size = new System.Drawing.Size(104, 22);
      this.contextMenu_CloseApplication.Text = "Exit";
      this.contextMenu_CloseApplication.Click += new System.EventHandler(this.contextMenu_CloseApplication_Click);
      // 
      // btn_SetWindowTopMost
      // 
      this.btn_SetWindowTopMost.Location = new System.Drawing.Point(74, 99);
      this.btn_SetWindowTopMost.Name = "btn_SetWindowTopMost";
      this.btn_SetWindowTopMost.Size = new System.Drawing.Size(100, 23);
      this.btn_SetWindowTopMost.TabIndex = 7;
      this.btn_SetWindowTopMost.Text = "Set top most";
      this.btn_SetWindowTopMost.UseVisualStyleBackColor = true;
      this.btn_SetWindowTopMost.Click += new System.EventHandler(this.btn_SetWindowTopMost_Click);
      // 
      // pinnedWindowListControl
      // 
      this.pinnedWindowListControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pinnedWindowListControl.Location = new System.Drawing.Point(181, 12);
      this.pinnedWindowListControl.Name = "pinnedWindowListControl";
      this.pinnedWindowListControl.Size = new System.Drawing.Size(349, 183);
      this.pinnedWindowListControl.TabIndex = 9;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(533, 198);
      this.Controls.Add(this.pinnedWindowListControl);
      this.Controls.Add(this.btn_SetWindowTopMost);
      this.Controls.Add(this.btn_CaptureClick);
      this.Controls.Add(this.txt_WindowY);
      this.Controls.Add(this.txt_WindowX);
      this.Controls.Add(this.lbl_WindowY);
      this.Controls.Add(this.lbl_WindowX);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PinWin prototype";
      this.Resize += new System.EventHandler(this.MainForm_Resize);
      this.contextMenu_Main.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label lbl_WindowX;
    private System.Windows.Forms.TextBox txt_WindowX;
    private System.Windows.Forms.Label lbl_WindowY;
    private System.Windows.Forms.TextBox txt_WindowY;
    private System.Windows.Forms.Button btn_CaptureClick;
    private System.Windows.Forms.NotifyIcon notifyIcon_Main;
    private System.Windows.Forms.ContextMenuStrip contextMenu_Main;
    private System.Windows.Forms.ToolStripMenuItem contextMenu_OpenApplication;
    private System.Windows.Forms.ToolStripMenuItem contextMenu_CloseApplication;
    private System.Windows.Forms.Button btn_SetWindowTopMost;
    private Controls.PinnedWindowListControl pinnedWindowListControl;
  }
}


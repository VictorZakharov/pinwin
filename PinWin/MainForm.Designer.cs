using System.CodeDom.Compiler;

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
        [GeneratedCode("WinForms Designer", "")]
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
            this.tmrWindowPosSync = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChangeKeyMap = new System.Windows.Forms.LinkLabel();
            this.contextMenu_Main.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon_Main
            // 
            this.notifyIcon_Main.ContextMenuStrip = this.contextMenu_Main;
            this.notifyIcon_Main.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_Main.Icon")));
            this.notifyIcon_Main.Text = "notifyIcon1";
            this.notifyIcon_Main.Visible = true;
            this.notifyIcon_Main.DoubleClick += new System.EventHandler(this.notifyIcon_Main_DoubleClick);
            this.notifyIcon_Main.MouseUp += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_Main_MouseUp);
            // 
            // contextMenu_Main
            // 
            this.contextMenu_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
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
            // pinnedWindowListControl
            // 
            this.pinnedWindowListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pinnedWindowListControl.Location = new System.Drawing.Point(165, 4);
            this.pinnedWindowListControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pinnedWindowListControl.Name = "pinnedWindowListControl";
            this.pinnedWindowListControl.Size = new System.Drawing.Size(443, 181);
            this.pinnedWindowListControl.TabIndex = 9;
            // 
            // btn_OpenDesktopOverlay
            // 
            this.btn_OpenDesktopOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_OpenDesktopOverlay.Location = new System.Drawing.Point(3, 3);
            this.btn_OpenDesktopOverlay.Name = "btn_OpenDesktopOverlay";
            this.btn_OpenDesktopOverlay.Size = new System.Drawing.Size(155, 150);
            this.btn_OpenDesktopOverlay.TabIndex = 10;
            this.btn_OpenDesktopOverlay.Text = "Select Window";
            this.btn_OpenDesktopOverlay.UseVisualStyleBackColor = true;
            this.btn_OpenDesktopOverlay.Click += new System.EventHandler(this.btn_OpenDesktopOverlay_Click);
            // 
            // lbl_message
            // 
            this.lbl_message.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.ForeColor = System.Drawing.Color.Green;
            this.lbl_message.Location = new System.Drawing.Point(163, 189);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(446, 24);
            this.lbl_message.TabIndex = 11;
            this.lbl_message.Text = "Welcome hint - which key to use";
            this.lbl_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrWindowPosSync
            // 
            this.tmrWindowPosSync.Enabled = true;
            this.tmrWindowPosSync.Interval = 10;
            this.tmrWindowPosSync.Tick += new System.EventHandler(this.tmrWindowPosSync_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pinnedWindowListControl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_message, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnChangeKeyMap, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_OpenDesktopOverlay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 213);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // btnChangeKeyMap
            // 
            this.btnChangeKeyMap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangeKeyMap.AutoSize = true;
            this.btnChangeKeyMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeKeyMap.Location = new System.Drawing.Point(20, 192);
            this.btnChangeKeyMap.Name = "btnChangeKeyMap";
            this.btnChangeKeyMap.Size = new System.Drawing.Size(121, 18);
            this.btnChangeKeyMap.TabIndex = 12;
            this.btnChangeKeyMap.TabStop = true;
            this.btnChangeKeyMap.Text = "Change Key Map";
            this.btnChangeKeyMap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnChangeKeyMap_LinkClicked);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 213);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(506, 192);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PinWin";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.contextMenu_Main.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.Timer tmrWindowPosSync;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.LinkLabel btnChangeKeyMap;
    }
}


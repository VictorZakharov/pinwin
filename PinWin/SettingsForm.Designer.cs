using System.CodeDom.Compiler;

namespace PinWin
{
    partial class SettingsForm
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
            this.txt_ShortcutPinWindowPrompt = new System.Windows.Forms.TextBox();
            this.lbl_KeyboardShortcut = new System.Windows.Forms.Label();
            this.btn_SaveSettings = new System.Windows.Forms.Button();
            this.txt_ShortcutPinWindowUnderCursor = new System.Windows.Forms.TextBox();
            this.lbl_ShortcutPinWindowUnderCursor = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_CaptureIconPath = new System.Windows.Forms.Label();
            this.lbl_TrayIconPath = new System.Windows.Forms.Label();
            this.selector_CaptureIcon = new PinWin.IconFileSelectorControl();
            this.selector_TrayIcon = new PinWin.IconFileSelectorControl();
            this.SuspendLayout();
            // 
            // txt_ShortcutPinWindowPrompt
            // 
            this.txt_ShortcutPinWindowPrompt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ShortcutPinWindowPrompt.Location = new System.Drawing.Point(181, 22);
            this.txt_ShortcutPinWindowPrompt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ShortcutPinWindowPrompt.Name = "txt_ShortcutPinWindowPrompt";
            this.txt_ShortcutPinWindowPrompt.ReadOnly = true;
            this.txt_ShortcutPinWindowPrompt.Size = new System.Drawing.Size(326, 20);
            this.txt_ShortcutPinWindowPrompt.TabIndex = 0;
            // 
            // lbl_KeyboardShortcut
            // 
            this.lbl_KeyboardShortcut.Location = new System.Drawing.Point(11, 24);
            this.lbl_KeyboardShortcut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_KeyboardShortcut.Name = "lbl_KeyboardShortcut";
            this.lbl_KeyboardShortcut.Size = new System.Drawing.Size(166, 18);
            this.lbl_KeyboardShortcut.TabIndex = 1;
            this.lbl_KeyboardShortcut.Text = "ShortcutPinWindowPrompt";
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SaveSettings.Location = new System.Drawing.Point(422, 161);
            this.btn_SaveSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(85, 31);
            this.btn_SaveSettings.TabIndex = 2;
            this.btn_SaveSettings.Text = "Save";
            this.btn_SaveSettings.UseVisualStyleBackColor = false;
            this.btn_SaveSettings.Click += new System.EventHandler(this.btn_SaveSettings_Click);
            // 
            // txt_ShortcutPinWindowUnderCursor
            // 
            this.txt_ShortcutPinWindowUnderCursor.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ShortcutPinWindowUnderCursor.Location = new System.Drawing.Point(181, 46);
            this.txt_ShortcutPinWindowUnderCursor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_ShortcutPinWindowUnderCursor.Name = "txt_ShortcutPinWindowUnderCursor";
            this.txt_ShortcutPinWindowUnderCursor.ReadOnly = true;
            this.txt_ShortcutPinWindowUnderCursor.Size = new System.Drawing.Size(326, 20);
            this.txt_ShortcutPinWindowUnderCursor.TabIndex = 3;
            // 
            // lbl_ShortcutPinWindowUnderCursor
            // 
            this.lbl_ShortcutPinWindowUnderCursor.Location = new System.Drawing.Point(11, 49);
            this.lbl_ShortcutPinWindowUnderCursor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ShortcutPinWindowUnderCursor.Name = "lbl_ShortcutPinWindowUnderCursor";
            this.lbl_ShortcutPinWindowUnderCursor.Size = new System.Drawing.Size(166, 18);
            this.lbl_ShortcutPinWindowUnderCursor.TabIndex = 4;
            this.lbl_ShortcutPinWindowUnderCursor.Text = "ShortcutPinWindowUnderCursor";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.Location = new System.Drawing.Point(333, 161);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(85, 31);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Don\'t Save";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_CaptureIconPath
            // 
            this.lbl_CaptureIconPath.Location = new System.Drawing.Point(11, 115);
            this.lbl_CaptureIconPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CaptureIconPath.Name = "lbl_CaptureIconPath";
            this.lbl_CaptureIconPath.Size = new System.Drawing.Size(166, 18);
            this.lbl_CaptureIconPath.TabIndex = 9;
            this.lbl_CaptureIconPath.Text = "CaptureIconPath";
            // 
            // lbl_TrayIconPath
            // 
            this.lbl_TrayIconPath.Location = new System.Drawing.Point(11, 72);
            this.lbl_TrayIconPath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TrayIconPath.Name = "lbl_TrayIconPath";
            this.lbl_TrayIconPath.Size = new System.Drawing.Size(166, 18);
            this.lbl_TrayIconPath.TabIndex = 7;
            this.lbl_TrayIconPath.Text = "TrayIconPath";
            // 
            // selector_CaptureIcon
            // 
            this.selector_CaptureIcon.CurrentPath = "";
            this.selector_CaptureIcon.DefaultPath = "Images/TargetWindowIcon.ico";
            this.selector_CaptureIcon.LinkText = "Select Capture Icon File";
            this.selector_CaptureIcon.Location = new System.Drawing.Point(142, 113);
            this.selector_CaptureIcon.Margin = new System.Windows.Forms.Padding(2);
            this.selector_CaptureIcon.Name = "selector_CaptureIcon";
            this.selector_CaptureIcon.Size = new System.Drawing.Size(363, 44);
            this.selector_CaptureIcon.TabIndex = 14;
            // 
            // selector_TrayIcon
            // 
            this.selector_TrayIcon.CurrentPath = "";
            this.selector_TrayIcon.DefaultPath = "Images/Tray.ico";
            this.selector_TrayIcon.LinkText = "Select Tray Icon File";
            this.selector_TrayIcon.Location = new System.Drawing.Point(142, 69);
            this.selector_TrayIcon.Margin = new System.Windows.Forms.Padding(2);
            this.selector_TrayIcon.Name = "selector_TrayIcon";
            this.selector_TrayIcon.Size = new System.Drawing.Size(363, 44);
            this.selector_TrayIcon.TabIndex = 13;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 201);
            this.Controls.Add(this.selector_CaptureIcon);
            this.Controls.Add(this.selector_TrayIcon);
            this.Controls.Add(this.lbl_CaptureIconPath);
            this.Controls.Add(this.lbl_TrayIconPath);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_ShortcutPinWindowUnderCursor);
            this.Controls.Add(this.txt_ShortcutPinWindowUnderCursor);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.lbl_KeyboardShortcut);
            this.Controls.Add(this.txt_ShortcutPinWindowPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ShortcutPinWindowPrompt;
        private System.Windows.Forms.Label lbl_KeyboardShortcut;
        private System.Windows.Forms.Button btn_SaveSettings;
        private System.Windows.Forms.TextBox txt_ShortcutPinWindowUnderCursor;
        private System.Windows.Forms.Label lbl_ShortcutPinWindowUnderCursor;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_CaptureIconPath;
        private System.Windows.Forms.Label lbl_TrayIconPath;
        private IconFileSelectorControl selector_TrayIcon;
        private IconFileSelectorControl selector_CaptureIcon;
    }
}
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
            this.SuspendLayout();
            // 
            // txt_ShortcutPinWindowPrompt
            // 
            this.txt_ShortcutPinWindowPrompt.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ShortcutPinWindowPrompt.Location = new System.Drawing.Point(241, 27);
            this.txt_ShortcutPinWindowPrompt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ShortcutPinWindowPrompt.Name = "txt_ShortcutPinWindowPrompt";
            this.txt_ShortcutPinWindowPrompt.ReadOnly = true;
            this.txt_ShortcutPinWindowPrompt.Size = new System.Drawing.Size(433, 22);
            this.txt_ShortcutPinWindowPrompt.TabIndex = 0;
            // 
            // lbl_KeyboardShortcut
            // 
            this.lbl_KeyboardShortcut.Location = new System.Drawing.Point(15, 30);
            this.lbl_KeyboardShortcut.Name = "lbl_KeyboardShortcut";
            this.lbl_KeyboardShortcut.Size = new System.Drawing.Size(221, 22);
            this.lbl_KeyboardShortcut.TabIndex = 1;
            this.lbl_KeyboardShortcut.Text = "ShortcutPinWindowPrompt";
            // 
            // btn_SaveSettings
            // 
            this.btn_SaveSettings.Location = new System.Drawing.Point(563, 100);
            this.btn_SaveSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SaveSettings.Name = "btn_SaveSettings";
            this.btn_SaveSettings.Size = new System.Drawing.Size(113, 38);
            this.btn_SaveSettings.TabIndex = 2;
            this.btn_SaveSettings.Text = "Save";
            this.btn_SaveSettings.UseVisualStyleBackColor = false;
            this.btn_SaveSettings.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_ShortcutPinWindowUnderCursor
            // 
            this.txt_ShortcutPinWindowUnderCursor.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ShortcutPinWindowUnderCursor.Location = new System.Drawing.Point(241, 57);
            this.txt_ShortcutPinWindowUnderCursor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_ShortcutPinWindowUnderCursor.Name = "txt_ShortcutPinWindowUnderCursor";
            this.txt_ShortcutPinWindowUnderCursor.ReadOnly = true;
            this.txt_ShortcutPinWindowUnderCursor.Size = new System.Drawing.Size(433, 22);
            this.txt_ShortcutPinWindowUnderCursor.TabIndex = 3;
            // 
            // lbl_ShortcutPinWindowUnderCursor
            // 
            this.lbl_ShortcutPinWindowUnderCursor.Location = new System.Drawing.Point(15, 60);
            this.lbl_ShortcutPinWindowUnderCursor.Name = "lbl_ShortcutPinWindowUnderCursor";
            this.lbl_ShortcutPinWindowUnderCursor.Size = new System.Drawing.Size(221, 22);
            this.lbl_ShortcutPinWindowUnderCursor.TabIndex = 4;
            this.lbl_ShortcutPinWindowUnderCursor.Text = "ShortcutPinWindowUnderCursor";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(444, 100);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 38);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Don\'t Save";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 150);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_ShortcutPinWindowUnderCursor);
            this.Controls.Add(this.txt_ShortcutPinWindowUnderCursor);
            this.Controls.Add(this.btn_SaveSettings);
            this.Controls.Add(this.lbl_KeyboardShortcut);
            this.Controls.Add(this.txt_ShortcutPinWindowPrompt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}
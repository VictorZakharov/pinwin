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
      this.btn_FindWindow = new System.Windows.Forms.Button();
      this.lbl_WindowX = new System.Windows.Forms.Label();
      this.txt_WindowX = new System.Windows.Forms.TextBox();
      this.lbl_WindowY = new System.Windows.Forms.Label();
      this.txt_WindowY = new System.Windows.Forms.TextBox();
      this.lbl_FormTitle = new System.Windows.Forms.Label();
      this.txt_FormTitle = new System.Windows.Forms.TextBox();
      this.btn_FindOwnerForm = new System.Windows.Forms.Button();
      this.btn_CaptureClick = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn_FindWindow
      // 
      this.btn_FindWindow.Location = new System.Drawing.Point(417, 47);
      this.btn_FindWindow.Name = "btn_FindWindow";
      this.btn_FindWindow.Size = new System.Drawing.Size(110, 23);
      this.btn_FindWindow.TabIndex = 0;
      this.btn_FindWindow.Text = "Find window";
      this.btn_FindWindow.UseVisualStyleBackColor = true;
      this.btn_FindWindow.Click += new System.EventHandler(this.btn_FindWindow_Click);
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
      // lbl_FormTitle
      // 
      this.lbl_FormTitle.AutoSize = true;
      this.lbl_FormTitle.Location = new System.Drawing.Point(12, 115);
      this.lbl_FormTitle.Name = "lbl_FormTitle";
      this.lbl_FormTitle.Size = new System.Drawing.Size(76, 13);
      this.lbl_FormTitle.TabIndex = 3;
      this.lbl_FormTitle.Text = "Found window";
      // 
      // txt_FormTitle
      // 
      this.txt_FormTitle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.txt_FormTitle.Location = new System.Drawing.Point(99, 112);
      this.txt_FormTitle.Name = "txt_FormTitle";
      this.txt_FormTitle.ReadOnly = true;
      this.txt_FormTitle.Size = new System.Drawing.Size(428, 20);
      this.txt_FormTitle.TabIndex = 4;
      // 
      // btn_FindOwnerForm
      // 
      this.btn_FindOwnerForm.Location = new System.Drawing.Point(417, 76);
      this.btn_FindOwnerForm.Name = "btn_FindOwnerForm";
      this.btn_FindOwnerForm.Size = new System.Drawing.Size(110, 23);
      this.btn_FindOwnerForm.TabIndex = 5;
      this.btn_FindOwnerForm.Text = "Find owner form";
      this.btn_FindOwnerForm.UseVisualStyleBackColor = true;
      this.btn_FindOwnerForm.Click += new System.EventHandler(this.btn_FindOwnerForm_Click);
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
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(588, 207);
      this.Controls.Add(this.btn_CaptureClick);
      this.Controls.Add(this.btn_FindOwnerForm);
      this.Controls.Add(this.txt_FormTitle);
      this.Controls.Add(this.lbl_FormTitle);
      this.Controls.Add(this.txt_WindowY);
      this.Controls.Add(this.txt_WindowX);
      this.Controls.Add(this.lbl_WindowY);
      this.Controls.Add(this.lbl_WindowX);
      this.Controls.Add(this.btn_FindWindow);
      this.Name = "MainForm";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_FindWindow;
    private System.Windows.Forms.Label lbl_WindowX;
    private System.Windows.Forms.TextBox txt_WindowX;
    private System.Windows.Forms.Label lbl_WindowY;
    private System.Windows.Forms.TextBox txt_WindowY;
    private System.Windows.Forms.Label lbl_FormTitle;
    private System.Windows.Forms.TextBox txt_FormTitle;
    private System.Windows.Forms.Button btn_FindOwnerForm;
    private System.Windows.Forms.Button btn_CaptureClick;
  }
}


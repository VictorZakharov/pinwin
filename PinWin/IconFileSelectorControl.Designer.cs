namespace PinWin
{
    partial class IconFileSelectorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.link_OpenFileDialog = new System.Windows.Forms.LinkLabel();
            this.chk_UseCustom = new System.Windows.Forms.CheckBox();
            this.txt_Path = new System.Windows.Forms.TextBox();
            this.pic_Preview = new System.Windows.Forms.PictureBox();
            this.validationErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // link_OpenFileDialog
            // 
            this.link_OpenFileDialog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.link_OpenFileDialog.Location = new System.Drawing.Point(127, 0);
            this.link_OpenFileDialog.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.link_OpenFileDialog.Name = "link_OpenFileDialog";
            this.link_OpenFileDialog.Size = new System.Drawing.Size(218, 19);
            this.link_OpenFileDialog.TabIndex = 17;
            this.link_OpenFileDialog.TabStop = true;
            this.link_OpenFileDialog.Text = "Select Icon";
            this.link_OpenFileDialog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.link_OpenFileDialog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_OpenFileDialog_LinkClicked);
            // 
            // chk_UseCustom
            // 
            this.chk_UseCustom.AutoSize = true;
            this.chk_UseCustom.Location = new System.Drawing.Point(40, 2);
            this.chk_UseCustom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chk_UseCustom.Name = "chk_UseCustom";
            this.chk_UseCustom.Size = new System.Drawing.Size(83, 17);
            this.chk_UseCustom.TabIndex = 15;
            this.chk_UseCustom.Text = "Use Custom";
            this.chk_UseCustom.UseVisualStyleBackColor = true;
            this.chk_UseCustom.CheckedChanged += new System.EventHandler(this.chk_UseCustom_CheckedChanged);
            // 
            // txt_Path
            // 
            this.txt_Path.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Path.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.SetColumnSpan(this.txt_Path, 2);
            this.txt_Path.Location = new System.Drawing.Point(40, 23);
            this.txt_Path.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Path.Name = "txt_Path";
            this.txt_Path.Size = new System.Drawing.Size(305, 20);
            this.txt_Path.TabIndex = 13;
            this.txt_Path.TextChanged += new System.EventHandler(this.txt_Path_TextChanged);
            // 
            // pic_Preview
            // 
            this.pic_Preview.Location = new System.Drawing.Point(2, 2);
            this.pic_Preview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pic_Preview.Name = "pic_Preview";
            this.tableLayoutPanel1.SetRowSpan(this.pic_Preview, 2);
            this.pic_Preview.Size = new System.Drawing.Size(34, 37);
            this.pic_Preview.TabIndex = 16;
            this.pic_Preview.TabStop = false;
            // 
            // validationErrorProvider
            // 
            this.validationErrorProvider.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Controls.Add(this.pic_Preview, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.link_OpenFileDialog, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chk_UseCustom, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Path, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 45);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // IconFileSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "IconFileSelectorControl";
            this.Size = new System.Drawing.Size(363, 45);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Preview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.validationErrorProvider)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel link_OpenFileDialog;
        private System.Windows.Forms.PictureBox pic_Preview;
        private System.Windows.Forms.CheckBox chk_UseCustom;
        private System.Windows.Forms.TextBox txt_Path;
        private System.Windows.Forms.ErrorProvider validationErrorProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

namespace PinWin.Controls
{
  partial class PinnedWindowListControl
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
            this.btn_UnpinSelectedWindows = new System.Windows.Forms.Button();
            this.btn_UnpinAllWindows = new System.Windows.Forms.Button();
            this.lbl_PinnedWindowListNoItems = new System.Windows.Forms.Label();
            this.lst_PinnedWindowList = new PinWin.Controls.ListBoxEx();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_UnpinSelectedWindows
            // 
            this.btn_UnpinSelectedWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UnpinSelectedWindows.Location = new System.Drawing.Point(195, 119);
            this.btn_UnpinSelectedWindows.Name = "btn_UnpinSelectedWindows";
            this.btn_UnpinSelectedWindows.Size = new System.Drawing.Size(110, 23);
            this.btn_UnpinSelectedWindows.TabIndex = 0;
            this.btn_UnpinSelectedWindows.Text = "Unpin Selected";
            this.btn_UnpinSelectedWindows.UseVisualStyleBackColor = true;
            this.btn_UnpinSelectedWindows.Click += new System.EventHandler(this.btn_UnpinSelectedWindows_Click);
            // 
            // btn_UnpinAllWindows
            // 
            this.btn_UnpinAllWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UnpinAllWindows.Location = new System.Drawing.Point(114, 119);
            this.btn_UnpinAllWindows.Name = "btn_UnpinAllWindows";
            this.btn_UnpinAllWindows.Size = new System.Drawing.Size(75, 23);
            this.btn_UnpinAllWindows.TabIndex = 0;
            this.btn_UnpinAllWindows.Text = "Unpin All";
            this.btn_UnpinAllWindows.UseVisualStyleBackColor = true;
            this.btn_UnpinAllWindows.Click += new System.EventHandler(this.btn_UnpinAllWindows_Click);
            // 
            // lbl_PinnedWindowListNoItems
            // 
            this.lbl_PinnedWindowListNoItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PinnedWindowListNoItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PinnedWindowListNoItems.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_PinnedWindowListNoItems.Location = new System.Drawing.Point(19, 21);
            this.lbl_PinnedWindowListNoItems.Name = "lbl_PinnedWindowListNoItems";
            this.lbl_PinnedWindowListNoItems.Size = new System.Drawing.Size(254, 76);
            this.lbl_PinnedWindowListNoItems.TabIndex = 11;
            this.lbl_PinnedWindowListNoItems.Text = "A list of pinned windows will be shown here";
            this.lbl_PinnedWindowListNoItems.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lst_PinnedWindowList
            // 
            this.lst_PinnedWindowList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.lst_PinnedWindowList, 2);
            this.lst_PinnedWindowList.FormattingEnabled = true;
            this.lst_PinnedWindowList.IntegralHeight = false;
            this.lst_PinnedWindowList.Location = new System.Drawing.Point(3, 3);
            this.lst_PinnedWindowList.Name = "lst_PinnedWindowList";
            this.lst_PinnedWindowList.ScrollAlwaysVisible = true;
            this.lst_PinnedWindowList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lst_PinnedWindowList.Size = new System.Drawing.Size(302, 110);
            this.lst_PinnedWindowList.TabIndex = 1;
            this.lst_PinnedWindowList.ItemsChanged += new System.EventHandler(this.ValidateActions);
            this.lst_PinnedWindowList.SelectedIndexChanged += new System.EventHandler(this.ValidateActions);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lst_PinnedWindowList, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_UnpinAllWindows, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_UnpinSelectedWindows, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(308, 145);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // PinnedWindowListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_PinnedWindowListNoItems);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PinnedWindowListControl";
            this.Size = new System.Drawing.Size(308, 145);
            this.Load += new System.EventHandler(this.ValidateActions);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_UnpinSelectedWindows;
    private System.Windows.Forms.Button btn_UnpinAllWindows;
    private ListBoxEx lst_PinnedWindowList;
    private System.Windows.Forms.Label lbl_PinnedWindowListNoItems;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

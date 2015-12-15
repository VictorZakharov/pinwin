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
      this.lst_PinnedWindowList = new PinWin.Controls.ListBoxEx();
      this.lbl_PinnedWindowListNoItems = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btn_UnpinSelectedWindows
      // 
      this.btn_UnpinSelectedWindows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btn_UnpinSelectedWindows.Location = new System.Drawing.Point(199, 102);
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
      this.btn_UnpinAllWindows.Location = new System.Drawing.Point(118, 102);
      this.btn_UnpinAllWindows.Name = "btn_UnpinAllWindows";
      this.btn_UnpinAllWindows.Size = new System.Drawing.Size(75, 23);
      this.btn_UnpinAllWindows.TabIndex = 0;
      this.btn_UnpinAllWindows.Text = "Unpin All";
      this.btn_UnpinAllWindows.UseVisualStyleBackColor = true;
      this.btn_UnpinAllWindows.Click += new System.EventHandler(this.btn_UnpinAllWindows_Click);
      // 
      // lst_PinnedWindowList
      // 
      this.lst_PinnedWindowList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lst_PinnedWindowList.FormattingEnabled = true;
      this.lst_PinnedWindowList.IntegralHeight = false;
      this.lst_PinnedWindowList.Location = new System.Drawing.Point(3, 3);
      this.lst_PinnedWindowList.Name = "lst_PinnedWindowList";
      this.lst_PinnedWindowList.ScrollAlwaysVisible = true;
      this.lst_PinnedWindowList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lst_PinnedWindowList.Size = new System.Drawing.Size(306, 94);
      this.lst_PinnedWindowList.TabIndex = 1;
      this.lst_PinnedWindowList.ItemsChanged += new System.EventHandler(this.ValidateActions);
      this.lst_PinnedWindowList.SelectedIndexChanged += new System.EventHandler(this.ValidateActions);
      // 
      // lbl_PinnedWindowListNoItems
      // 
      this.lbl_PinnedWindowListNoItems.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.lbl_PinnedWindowListNoItems.AutoSize = true;
      this.lbl_PinnedWindowListNoItems.BackColor = System.Drawing.SystemColors.Window;
      this.lbl_PinnedWindowListNoItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_PinnedWindowListNoItems.ForeColor = System.Drawing.SystemColors.ControlDark;
      this.lbl_PinnedWindowListNoItems.Location = new System.Drawing.Point(17, 41);
      this.lbl_PinnedWindowListNoItems.Name = "lbl_PinnedWindowListNoItems";
      this.lbl_PinnedWindowListNoItems.Size = new System.Drawing.Size(259, 16);
      this.lbl_PinnedWindowListNoItems.TabIndex = 11;
      this.lbl_PinnedWindowListNoItems.Text = "A list of pinned windows will be shown here";
      // 
      // PinnedWindowListControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.lbl_PinnedWindowListNoItems);
      this.Controls.Add(this.lst_PinnedWindowList);
      this.Controls.Add(this.btn_UnpinAllWindows);
      this.Controls.Add(this.btn_UnpinSelectedWindows);
      this.Name = "PinnedWindowListControl";
      this.Size = new System.Drawing.Size(312, 128);
      this.Load += new System.EventHandler(this.ValidateActions);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_UnpinSelectedWindows;
    private System.Windows.Forms.Button btn_UnpinAllWindows;
    private ListBoxEx lst_PinnedWindowList;
    private System.Windows.Forms.Label lbl_PinnedWindowListNoItems;
  }
}

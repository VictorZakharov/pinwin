using System;
using System.Drawing;
using System.Windows.Forms;
using PinWin.Controls;
using PinWin.WinApi;

namespace PinWin
{
  /// <summary>
  ///  Main form of the application. Currently a place for prototyping.
  /// </summary>
  public partial class MainForm : TrayAppForm
  {
#region " Constructor "
    /// <summary>
    ///  Constructor - no special processing.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }
    #endregion

    protected override void RegisterHotKeys()
    {
      this.RegisterHotKey(Keys.Control | Keys.F11, this.AddPinnedWindowFromClick);
    }

    #region " Event handlers - System tray icon "
    private void MainForm_Resize(object sender, EventArgs e)
    {
      if (this.WindowState == FormWindowState.Minimized)
      {
        this.notifyIcon_Main.ShowBalloonTip(500, "Minimized to tray",
          "PinWin is now running from system tray.", ToolTipIcon.Info);
        this.Hide();
      }
    }

    private void contextMenu_CloseApplication_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void contextMenu_OpenApplication_Click(object sender, EventArgs e)
    {
      this.AllowFormShow = true;
      this.Show();
      this.WindowState = FormWindowState.Normal;
    }

    private void notifyIcon_Main_DoubleClick(object sender, EventArgs e)
    {
      contextMenu_OpenApplication.PerformClick();
    }
    #endregion

#region " Event handlers - Other"
    private void btn_OpenDesktopOverlay_Click(object sender, EventArgs e)
    {
      this.AddPinnedWindowFromClick();
    }

    /// <summary>
    ///  Try making window top most, based on mouse click location.
    /// </summary>
    private void AddPinnedWindowFromClick()
    {
      Nullable<Point> mouseClickPoint = DesktopOverlayForm.SelectPoint(ParentForm);
      if (mouseClickPoint == null)
      {
        //no point was selected by user, do nothing
        return;
      }

      this.pinnedWindowListControl.TryAddWindowFromPoint(mouseClickPoint.Value);
    }

    #endregion
  }
}
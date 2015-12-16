using System;
using System.Drawing;
using System.Windows.Forms;
using Gma.UserActivityMonitor;
using PinWin.BusinessLayer;
using PinWin.Controls;

namespace PinWin
{
  /// <summary>
  ///  Main form of the application. Currently a place for prototyping.
  /// </summary>
  public partial class MainForm : TrayAppForm
  {
#region " Contructor "
    /// <summary>
    ///  Constructor - no special processing.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }
#endregion

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

#region " Event handlers - Other "
    /// <summary>
    ///  Fire up single use global hook handler
    ///  to process mouse click outside of this app.
    /// </summary>
    private void btn_CaptureClick_Click(object sender, EventArgs e)
    {
      HookManager.MouseClick += HookManager_MouseClick;
    }

    /// <summary>
    ///  Single use global hook handler.
    /// </summary>
    private void HookManager_MouseClick(object sender, MouseEventArgs e)
    {
      try
      {
        this.ProcessGlobalMouseClick(e);
      }
      finally
      {
        //release global hook, subsequent events will not be fired
        HookManager.MouseClick -= HookManager_MouseClick;
      }
    }

    /// <summary>
    ///  Set window at specified coordinates as top most (always on top).
    /// </summary>
    private void btn_SetWindowTopMost_Click(object sender, EventArgs e)
    {
      IntPtr formHandle = this.FindWindowAtPoint(MainForm.GetFormHandleAtScreenPoint);
      if (formHandle != IntPtr.Zero)
      {
        this.pinnedWindowListControl.AddWindow(formHandle);
      }
    }
    #endregion

#region " Private methods "
    /// <summary>
    ///  Find window at screen point using existing finder delegate.
    /// </summary>
    private IntPtr FindWindowAtPoint(Func<Point, IntPtr> handleFinderDelegate)
    {
      Nullable<Point> windowLocation = this.ReadPointFromUI();
      if (windowLocation == null)
      {
        MessageBox.Show(@"Invalid input");
        return IntPtr.Zero;
      }

      IntPtr formHandle = handleFinderDelegate(windowLocation.Value);
      return formHandle;
    }

    /// <summary>
    ///  Read point data, X and Y, from user input on screen, and returns a Point object.
    /// </summary>
    private Nullable<Point> ReadPointFromUI()
    {
      try
      {
        int xPoint = Convert.ToInt32(txt_WindowX.Text);
        int yPoint = Convert.ToInt32(txt_WindowY.Text);

        return new Point(xPoint, yPoint);
      }
      catch (FormatException)
      {
        //input contained invalid characters
        return null;
      }
    }

    /// <summary>
    ///  Process mouse click args from global handler and display result on screen.
    /// </summary>
    /// <param name="e">Mouse click event args from global handler.</param>
    private void ProcessGlobalMouseClick(MouseEventArgs e)
    {
      txt_WindowX.Text = e.X.ToString();
      txt_WindowY.Text = e.Y.ToString();

      //prevent external application from processing click event
      MouseEventExtArgs args = e as MouseEventExtArgs;
      if (args != null)
      {
        args.Handled = true;
      }
    }

    /// <summary>
    ///  Get form handle at specified coordinates (x,y).
    /// </summary>
    /// <param name="point">Coordinates to search.</param>
    private static IntPtr GetFormHandleAtScreenPoint(Point point)
    {
      IntPtr foundWindowHandle = WinApi.WindowFromPoint(point);

      var parentLookup = new WinApiOwnerFormLookup();
      IntPtr formHandle = parentLookup.FindParent(foundWindowHandle);

      return formHandle;
    }
    #endregion
  }
}
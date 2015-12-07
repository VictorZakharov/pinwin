using System;
using System.Drawing;
using System.Windows.Forms;

namespace PinWin
{
  /// <summary>
  ///  Main form of the application. Currently a place for prototyping.
  /// </summary>
  public partial class MainForm : Form
  {
    /// <summary>
    ///  Form constructor - nothing fancy here, only standard form designer code.
    /// </summary>
    public MainForm()
    {
      InitializeComponent();
    }

    /// <summary>
    ///  Find WinAPI window at point, which can be a form or another control.
    /// </summary>
    private void btn_FindWindow_Click(object sender, EventArgs e)
    {
      Point windowLocation = this.ReadPointFromUI();
      IntPtr windowHandle = this.GetWindowAtScreenPoint(windowLocation);
      this.DisplayIntPtrResult(windowHandle);
    }

    /// <summary>
    ///  Find WinAPI window at point, which is strictly a form.
    /// </summary>
    private void btn_FindOwnerForm_Click(object sender, EventArgs e)
    {
      Point windowLocation = this.ReadPointFromUI();
      IntPtr formHandle = this.GetFormAtScreenPoint(windowLocation);
      this.DisplayIntPtrResult(formHandle);
    }

    #region "Private methods"

    /// <summary>
    ///  Get form handle which is a parent of winapi window found at specified coordinates.
    /// </summary>
    /// <param name="point"></param>
    private IntPtr GetFormAtScreenPoint(Point point)
    {
      IntPtr foundWindowHandle = this.GetWindowAtScreenPoint(point);

      var parentLookup = new WinApiOwnerFormLookup();
      IntPtr formHandle = parentLookup.FindParent(foundWindowHandle);

      return formHandle;
    }

    /// <summary>
    ///  Get window handle which is found at specified coordinates.
    /// </summary>
    /// <param name="point"></param>
    private IntPtr GetWindowAtScreenPoint(Point point)
    {
      return WinApi.WindowFromPoint(point);
    }
    
    /// <summary>
    ///  Output IntPtr result on screen.
    /// </summary>
    /// <param name="handle">Handle to be displayed.</param>
    private void DisplayIntPtrResult(IntPtr handle)
    {
      string displayResult = this.IntPtrResultToString(handle);
      txt_FormTitle.Text = displayResult;
    }

    /// <summary>
    ///  Translates IntPtr value to string by reading window title, associated with provided handle.
    /// </summary>
    /// <param name="handle">Handle to be converted to string.</param>
    private string IntPtrResultToString(IntPtr handle)
    {
      if (handle.ToInt32() == 0)
      {
        return @"Not found";
      }
      
      return WinApi.GetWindowTitle(handle);
    }

    /// <summary>
    ///  Read point data, X and Y, from user input on screen, and returns a Point object.
    /// </summary>
    private Point ReadPointFromUI()
    {
      int xPoint = Convert.ToInt32(txt_WindowX.Text);
      int yPoint = Convert.ToInt32(txt_WindowY.Text);

      return new Point(xPoint, yPoint);
    }
#endregion
  }
}
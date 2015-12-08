using System;
using System.Drawing;
using System.Windows.Forms;
using PinWin.BusinessLayer;

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
      this.FindWindowAtPoint(AppLogic.GetWindowHandleAtScreenPoint);
    }

    /// <summary>
    ///  Find WinAPI window at point, which is strictly a form.
    /// </summary>
    private void btn_FindOwnerForm_Click(object sender, EventArgs e)
    {
      this.FindWindowAtPoint(AppLogic.GetFormHandleAtScreenPoint);
    }

    #region "Private methods"
    /// <summary>
    ///  Find window at screen point using existing finder delegate.
    /// </summary>
    /// <param name="handleFinderDelegate"></param>
    private void FindWindowAtPoint(Func<Point, IntPtr> handleFinderDelegate)
    {
      Nullable<Point> windowLocation = this.ReadPointFromUI();
      if (windowLocation == null)
      {
        MessageBox.Show(@"Invalid input");
        return;
      }

      IntPtr formHandle = handleFinderDelegate(windowLocation.Value);
      string displayResult = formHandle.ToDisplayString();
      txt_FormTitle.Text = displayResult;
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
#endregion
  }
}
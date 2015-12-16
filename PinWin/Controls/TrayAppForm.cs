using System.Windows.Forms;

namespace PinWin.Controls
{
  /// <summary>
  ///  Inherit from this form to create system tray applications.
  /// </summary>
  /// <remarks>
  ///  Form will be hidden by default. Calling .Show() has no effect.
  ///  Set AllowFormShow to true to enable default form behavior.
  /// </remarks>
  public class TrayAppForm : Form
  {
    /// <summary>
    ///  Defines whether form is allowed to be shown.
    /// </summary>
    public bool AllowFormShow { get; set; } = false;

    protected override void SetVisibleCore(bool value)
    {
      if (!this.AllowFormShow && !this.DesignMode)
      {
        //do nothing
        return;
      }

      base.SetVisibleCore(value);
    }
  }
}
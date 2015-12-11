using System.Windows.Forms;

namespace PinWin
{
  /// <summary>
  ///  Inherit from this form to create system tray applications.
  /// </summary>
  /// <remarks>Hidden by default. Set AllowFormShow to true to unhide.</remarks>
  public class TrayAppForm : Form
  {
    private bool _allowFormShow = false;

    public bool AllowFormShow
    {
      get
      {
        return this._allowFormShow;
      }
      set
      {
        this._allowFormShow = value;
      }
    }

    protected override void SetVisibleCore(bool value)
    {
      if (!this._allowFormShow && !this.DesignMode)
      {
        //do nothing
        return;
      }

      base.SetVisibleCore(value);
    }
  }
}

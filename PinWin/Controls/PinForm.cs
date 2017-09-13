using System;
using System.Drawing;
using System.Windows.Forms;
using PinWin.BusinessLayer;
using PinWin.WinApi;
using static PinWin.WinApi.ApiWinEventHook;

namespace PinWin.Controls
{
  public partial class PinForm : Form
  {
    private WinEventHook _winEventHook;

    private readonly IntPtr _parentHandle;
    private readonly string _parentFormTitle;

    public IntPtr ParentHandle => this._parentHandle;
    public string ParentTitle => this._parentFormTitle;

    public PinForm()
    {
      InitializeComponent();

      this.TransparencyKey = Color.FromArgb(255, 240, 240, 240);
    }

    public PinForm(IntPtr parentHandle) : this()
    {
      this._parentHandle = parentHandle;
      this._parentFormTitle = ApiWindowTitle.FromHandle(parentHandle);
    }

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      ApiTopMost.Clear(this._parentHandle);
      this._winEventHook.Dispose();

      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    public static PinForm Create(IntPtr parentHandle)
    {
      PinForm pinForm = new PinForm(parentHandle);
      ApiTopMost.Set(parentHandle);
      pinForm.Show(parentHandle);
      return pinForm;
    }
    
    /// <summary>
    ///  Resets pinned icon location relative to parent when parent is moved.
    /// </summary>
    private void MoveToParentWindow()
    {
      Point newLocation = PinForm.GetRelativeLocation(this._parentHandle);
      this.Left = newLocation.X;
      this.Top = newLocation.Y;
    }

    private void PinForm_Load(object sender, EventArgs e)
    {
      if (this._parentHandle == IntPtr.Zero)
      {
        return;
      }

      this._winEventHook = new WinEventHook(this._parentHandle);
      this._winEventHook.Add(EventId.EVENT_OBJECT_LOCATIONCHANGE, ParentForm_Moved);
      this._winEventHook.Add(EventId.EVENT_SYSTEM_MOVESIZEEND, ParentForm_Moved);
      this._winEventHook.Add(EventId.EVENT_OBJECT_DESTROY, ParentForm_Destroyed);
      
      this.MoveToParentWindow();
    }

    private void ParentForm_Moved(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
    {
      if (hwnd != this._parentHandle)
      {
        //skip unwanted events
        return;
      }

      this.MoveToParentWindow();
    }

    private void ParentForm_Destroyed(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
    {
      if (hwnd != this._parentHandle || idObject != 0)
      {
        //skip unwanted events
        return;
      }

      this.Close();
    }

    private void PinForm_MouseClick(object sender, MouseEventArgs e)
    {
      this.Close();
    }

    /// <summary>
    ///  Used for debugging purposes.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{this._parentHandle} - {this._parentFormTitle}";
    }

    /// <summary>
    ///  Calculates absolute location of pin icon based on parent form's handle.
    /// </summary>
    /// <param name="handle">Parent window handle.</param>
    /// <returns>Absolute location of pin icon.</returns>
    private static Point GetRelativeLocation(IntPtr handle)
    {
      int rightMargin = PinForm.GetControlAreaWidth(handle) + 20;
      Rectangle move = ApiWindowPos.Get(handle);

      return new Point(move.Left + move.Width - rightMargin, move.Top + 5);
    }

    /// <summary>
    ///  Calculates total width of control buttons (minimize, maximize, close).
    /// </summary>
    /// <param name="handle">Window handle.</param>
    /// <returns>Total width in pixels.</returns>
    private static int GetControlAreaWidth(IntPtr handle)
    {
      WindowStyle style = new WindowStyle(handle);
      int buttonCount = style.MaximizeBox || style.MinimizeBox ? 3 : 1;

      int controlButtonAverageWidth = ApiSystemMetrics.Get(SystemMetric.SM_CXSIZE);
      return controlButtonAverageWidth * buttonCount;
    }
  }
}
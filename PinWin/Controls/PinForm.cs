using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PinWin.BusinessLayer;
using PinWin.WinApi;

namespace PinWin.Controls
{
  public partial class PinForm : Form
  {
    private const uint WINEVENT_OUTOFCONTEXT = 0x0000;
    private const uint EVENT_OBJECT_LOCATIONCHANGE = 0x800B;

    private const uint EVENT_SYSTEM_MOVESIZEEND = 0x000B;

    private readonly IntPtr _parentHandle;
    private NativeMethods.WinEventDelegate _parentLocationChangedHandler;

    public PinForm()
    {
      InitializeComponent();

      this.TransparencyKey = Color.FromArgb(255, 240, 240, 240);
    }

    public PinForm(IntPtr parentHandle) : this()
    {
      this._parentHandle = parentHandle;
    }

    public static PinForm Create(IntPtr parentHandle)
    {
      PinForm pinForm = new PinForm(parentHandle);
      pinForm.Show(parentHandle);
      return pinForm;
    }

    private void PinForm_Shown(object sender, EventArgs e)
    {
      this.Height = 16;
      this.Width = 16;
    }

    private void MoveToParentWindow()
    {
      Rectangle move = ApiWindowPos.Get(this._parentHandle);

      Debug.WriteLine("Data: " + move.Left + " " + move.Top);

      this.Left = (int)(move.Left + (move.Right - move.Left) * 0.75);
      this.Top = move.Top + 5;

      //TODO: replace 0.75 with below
      //this.Text = ApiSystemMetrics.Get(SystemMetric.SM_CXSIZE) + @" " +
      //            ApiSystemMetrics.Get(SystemMetric.SM_CYSIZE);

      //WindowStyle style = new WindowStyle(this.Handle);
      //this.Text += $", maxbtn:{style.MaximizeBox} minbtn:{style.MinimizeBox}";
    }

    private void WinEventProc(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime)
    {
      if (hwnd != this._parentHandle)
      {
        //skip mouse moves and child control events
        return;
      }

      this.MoveToParentWindow();
    }

    private void PinForm_Load(object sender, EventArgs e)
    {
      if (this._parentHandle == IntPtr.Zero)
      {
        return;
      }

      uint processId;
      uint threadId;
      threadId = GetWindowThreadProcessId(this._parentHandle, out processId);
      this._parentLocationChangedHandler = WinEventProc;

      NativeMethods.SetWinEventHook(EVENT_OBJECT_LOCATIONCHANGE, EVENT_OBJECT_LOCATIONCHANGE, IntPtr.Zero, this._parentLocationChangedHandler, processId, threadId, WINEVENT_OUTOFCONTEXT);
      NativeMethods.SetWinEventHook(EVENT_SYSTEM_MOVESIZEEND, EVENT_SYSTEM_MOVESIZEEND, IntPtr.Zero, this._parentLocationChangedHandler, processId, threadId, WINEVENT_OUTOFCONTEXT);

      this.MoveToParentWindow();
    }

    [DllImport("user32.dll", SetLastError = true)]
    static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint processId);
  }
}

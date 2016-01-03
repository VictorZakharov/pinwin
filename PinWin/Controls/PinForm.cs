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

    private void PinForm_Shown(object sender, EventArgs e)
    {
      this.Height = 16;
      this.Width = 16;
    }

    private void MoveToParentWindow()
    {
      Rectangle move = ApiWindowPos.Get(this._parentHandle);

      this.Left = (int)(move.Left + (move.Right - move.Left) * 0.75);
      this.Top = move.Top + 5;

      //TODO: replace 0.75 with below
      //this.Text = ApiSystemMetrics.Get(SystemMetric.SM_CXSIZE) + @" " +
      //            ApiSystemMetrics.Get(SystemMetric.SM_CYSIZE);

      //WindowStyle style = new WindowStyle(this.Handle);
      //this.Text += $", maxbtn:{style.MaximizeBox} minbtn:{style.MinimizeBox}";
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
      if (hwnd != this._parentHandle)
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
  }
}

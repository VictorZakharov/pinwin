using System;

namespace PinWin.BusinessLayer
{
  public class WindowListItem
  {
    public string Title { get; }

    public IntPtr Handle { get; }

    public WindowListItem(IntPtr handle)
    {
      this.Handle = handle;
      this.Title = WinApi.GetWindowTitle(handle);
    }

    public void SetPinnedStatus()
    {
      WinApiTopMost.Set(this.Handle);
    }

    public void ClearPinnedStatus()
    {
      WinApiTopMost.Clear(this.Handle);
    }

    public override string ToString()
    {
      return $"{this.Handle} - {this.Title}";
    }
  }
}
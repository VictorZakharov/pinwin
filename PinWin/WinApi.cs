using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace PinWin
{
  public class WinApi
  {
    /// <summary>
    ///  Get window title for a given IntPtr handle.
    /// </summary>
    /// <param name="handle">Input handle.</param>
    /// <remarks>
    ///  Major portition of code for below class was used from here:
    ///  http://stackoverflow.com/questions/4604023/unable-to-read-another-applications-caption
    /// </remarks>
    public static string GetWindowTitle(IntPtr handle)
    {
      if (handle == IntPtr.Zero)
        throw new ArgumentNullException("handle");
      int length = WinApi.SendMessageGetTextLength(handle, WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero);
      if (length > 0 && length < int.MaxValue)
      {
        length++; // room for EOS terminator
        StringBuilder sb = new StringBuilder(length);
        WinApi.SendMessageGetText(handle, WM_GETTEXT, (IntPtr)sb.Capacity, sb);
        return sb.ToString();
      }
      return String.Empty;
    }

    const int WM_GETTEXT = 0x000D;
    const int WM_GETTEXTLENGTH = 0x000E;

    [DllImport("user32.dll")]
    public static extern IntPtr WindowFromPoint(Point p);
    
    [DllImport("User32.dll", EntryPoint = "SendMessage")]
    private static extern int SendMessageGetTextLength(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
    [DllImport("User32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessageGetText(IntPtr hWnd, int msg, IntPtr wParam, [Out] StringBuilder lParam);
  }
}

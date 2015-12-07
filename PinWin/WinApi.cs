using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;

namespace PinWin
{
  public class WinApi
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hwnd"></param>
    /// <remarks>http://stackoverflow.com/questions/4604023/unable-to-read-another-applications-caption</remarks>
    public static string GetWindowTitle(IntPtr hwnd)
    {
      if (hwnd == IntPtr.Zero)
        throw new ArgumentNullException("hwnd");
      int length = WinApi.SendMessageGetTextLength(hwnd, WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero);
      if (length > 0 && length < int.MaxValue)
      {
        length++; // room for EOS terminator
        StringBuilder sb = new StringBuilder(length);
        WinApi.SendMessageGetText(hwnd, WM_GETTEXT, (IntPtr)sb.Capacity, sb);
        return sb.ToString();
      }
      return String.Empty;
    }

    public static IntPtr GetWindowHandleFromPoint(int x, int y)
    {
      var point = new Point(x, y);
      return WinApi.WindowFromPoint(point);
    }

    const int WM_GETTEXT = 0x000D;
    const int WM_GETTEXTLENGTH = 0x000E;

    [DllImport("user32.dll")]
    private static extern IntPtr WindowFromPoint(Point p);
    
    [DllImport("User32.dll", EntryPoint = "SendMessage")]
    private static extern int SendMessageGetTextLength(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
    [DllImport("User32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessageGetText(IntPtr hWnd, int msg, IntPtr wParam, [Out] StringBuilder lParam);
  }
}

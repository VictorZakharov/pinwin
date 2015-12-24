using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PinWin.WinApi
{
  public class ApiWindowTitle
  {
    /// <summary>
    ///  Get window title for a given IntPtr handle.
    /// </summary>
    /// <param name="handle">Input handle.</param>
    /// <remarks>
    ///  Major portition of code for below class was used from here:
    ///  http://stackoverflow.com/questions/4604023/unable-to-read-another-applications-caption
    /// </remarks>
    public static string FromHandle(IntPtr handle)
    {
      if (handle == IntPtr.Zero)
      {
        throw new ArgumentNullException(nameof(handle));
      }
      int length = ApiWindowTitle.SendMessageGetTextLength(handle, WM_GETTEXTLENGTH, IntPtr.Zero, IntPtr.Zero);
      if (length > 0 && length < int.MaxValue)
      {
        length++; // room for EOS terminator
        StringBuilder windowTitle = new StringBuilder(length);
        ApiWindowTitle.SendMessageGetText(handle, WM_GETTEXT, (IntPtr)windowTitle.Capacity, windowTitle);
        return windowTitle.ToString();
      }
      return String.Empty;
    }

    const int WM_GETTEXT = 0x000D;
    const int WM_GETTEXTLENGTH = 0x000E;

    [DllImport("User32.dll", EntryPoint = "SendMessage")]
    private static extern int SendMessageGetTextLength(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
    [DllImport("User32.dll", EntryPoint = "SendMessage", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessageGetText(IntPtr hWnd, int msg, IntPtr wParam, [Out] StringBuilder lParam);
  }
}

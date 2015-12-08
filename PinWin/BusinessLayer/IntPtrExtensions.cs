using System;

namespace PinWin.BusinessLayer
{
  public static class IntPtrExtensions
  {
    /// <summary>
    ///  Translates IntPtr value to string by reading window title, associated with provided handle.
    /// </summary>
    /// <param name="handle">Handle to be converted to string.</param>
    public static string ToDisplayString(this IntPtr handle)
    {
      if (handle.ToInt32() == 0)
      {
        return @"Not found";
      }

      return WinApi.GetWindowTitle(handle);
    }
  }
}
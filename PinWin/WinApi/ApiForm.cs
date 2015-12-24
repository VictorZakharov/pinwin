using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PinWin.WinApi
{
  internal class ApiForm
  {
    [DllImport("user32.dll")]
    private static extern IntPtr WindowFromPoint(Point p);

    /// <summary>
    ///  Get form handle at specified coordinates (x,y).
    /// </summary>
    /// <param name="point">Coordinates to search.</param>
    public static IntPtr Select(Point point)
    {
      IntPtr foundWindowHandle = ApiForm.WindowFromPoint(point);

      var parentLookup = new ApiOwnerFormLookup();
      IntPtr formHandle = parentLookup.FindParent(foundWindowHandle);

      return formHandle;
    }
  }
}
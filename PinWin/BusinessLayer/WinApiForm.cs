using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PinWin.BusinessLayer
{
  internal class WinApiForm
  {
    [DllImport("user32.dll")]
    private static extern IntPtr WindowFromPoint(Point p);

    /// <summary>
    ///  Get form handle at specified coordinates (x,y).
    /// </summary>
    /// <param name="point">Coordinates to search.</param>
    public static IntPtr Select(Point point)
    {
      IntPtr foundWindowHandle = WinApiForm.WindowFromPoint(point);

      var parentLookup = new WinApiOwnerFormLookup();
      IntPtr formHandle = parentLookup.FindParent(foundWindowHandle);

      return formHandle;
    }
  }
}
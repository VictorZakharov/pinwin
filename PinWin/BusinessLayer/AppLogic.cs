using System;
using System.Drawing;

namespace PinWin.BusinessLayer
{
  public class AppLogic
  {
    /// <summary>
    ///  Get window handle which is found at specified coordinates.
    /// </summary>
    /// <param name="point"></param>
    public static IntPtr GetWindowHandleAtScreenPoint(Point point)
    {
      return WinApi.WindowFromPoint(point);
    }

    /// <summary>
    ///  Get form handle which is a parent of winapi window found at specified coordinates.
    /// </summary>
    /// <param name="point"></param>
    public static IntPtr GetFormHandleAtScreenPoint(Point point)
    {
      IntPtr foundWindowHandle = AppLogic.GetWindowHandleAtScreenPoint(point);

      var parentLookup = new WinApiOwnerFormLookup();
      IntPtr formHandle = parentLookup.FindParent(foundWindowHandle);

      return formHandle;
    }
  }
}
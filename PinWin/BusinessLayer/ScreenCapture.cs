using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using PinWin.WinApi;

namespace PinWin.BusinessLayer
{
  /// <summary>
  ///  Utility methods used for screen manipulation.
  /// </summary>
  internal class ScreenCapture
  {
    /// <summary>
    ///  Capture whole desktop into Bitmap (all monitors).
    /// </summary>
    public static Bitmap CreateBitmapFromDesktop()
    {
      Rectangle bounds = ScreenCapture.GetDesktopBounds();
      Bitmap bitmap = ApiScreenCapture.CreateBitmap(bounds);
      return bitmap;
    }

    /// <summary>
    ///  Get desktop bounds as rectangle (all monitors).
    /// </summary>
    /// <remarks>
    ///  Based on this article:
    ///  http://stackoverflow.com/questions/2176648/screen-overlay-for-screenshot
    /// </remarks>
    public static Rectangle GetDesktopBounds()
    {
      Rectangle bounds = Screen.AllScreens
                        .Select(x => x.Bounds)
                        .Aggregate(Rectangle.Union);

      return bounds;
    }
  }
}

using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PinWin.BusinessLayer
{
  /// <summary>
  ///  Utility methods used for screen manipulation.
  /// </summary>
  internal class ScreenCapture
  {
    /// <summary>
    ///  Take screenshot of whole desktop (all monitors) and get result as Bitmap.
    /// </summary>
    /// <remarks>
    ///  Based on this answer on StackOverflow:
    ///  http://stackoverflow.com/questions/1163761/capture-screenshot-of-active-window
    /// </remarks>
    public static Bitmap CreateBitmapFromDesktop()
    {
      Rectangle bounds = ScreenCapture.GetDesktopBounds();
      Bitmap image = new Bitmap(bounds.Width, bounds.Height);

      using (Graphics g = Graphics.FromImage(image))
      {
        g.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
      }

      return image;
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

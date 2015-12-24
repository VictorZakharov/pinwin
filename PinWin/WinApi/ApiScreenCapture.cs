using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace PinWin.WinApi
{
  internal class ApiScreenCapture
  {
    /// <summary>
    ///  Take screenshot of the specified area on desktop (all monitors).
    /// </summary>
    /// <remarks>
    ///  Based on this answer on StackOverflow:
    ///  http://stackoverflow.com/questions/3072349/capture-screenshot-including-semitransparent-windows-in-net
    /// </remarks>
    public static Bitmap CreateBitmap(Rectangle bounds)
    {
      Size sz = bounds.Size;
      IntPtr hDesk = GetDesktopWindow();
      IntPtr hSrce = GetWindowDC(hDesk);
      IntPtr hDest = CreateCompatibleDC(hSrce);
      IntPtr hBmp = CreateCompatibleBitmap(hSrce, sz.Width, sz.Height);
      IntPtr hOldBmp = SelectObject(hDest, hBmp);
      bool b = BitBlt(hDest, 0, 0, sz.Width, sz.Height,
                      hSrce, bounds.Left, bounds.Top,
                      CopyPixelOperation.SourceCopy |
                      CopyPixelOperation.CaptureBlt);
      Bitmap bmp = Image.FromHbitmap(hBmp);
      SelectObject(hDest, hOldBmp);
      DeleteObject(hBmp);
      DeleteDC(hDest);
      ReleaseDC(hDesk, hSrce);
      return bmp;
    }

    [DllImport("gdi32.dll")]
    private static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int
    wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, CopyPixelOperation rop);
    [DllImport("user32.dll")]
    private static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);
    [DllImport("gdi32.dll")]
    private static extern IntPtr DeleteDC(IntPtr hDc);
    [DllImport("gdi32.dll")]
    private static extern IntPtr DeleteObject(IntPtr hDc);
    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);
    [DllImport("gdi32.dll")]
    private static extern IntPtr CreateCompatibleDC(IntPtr hdc);
    [DllImport("gdi32.dll")]
    private static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
    [DllImport("user32.dll")]
    private static extern IntPtr GetDesktopWindow();
    [DllImport("user32.dll")]
    private static extern IntPtr GetWindowDC(IntPtr ptr);
  }
}
using System;
using System.Runtime.InteropServices;

namespace PinWin
{
  /// <summary>
  /// 
  /// </summary>
  public class WinApiParentLookup: ParentLookup<IntPtr>
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="hWnd"></param>
    /// <returns></returns>
    [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
    public static extern IntPtr GetParent(IntPtr hWnd);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="child"></param>
    /// <returns></returns>
    public override IntPtr GetParentElement(IntPtr child)
    {
      return WinApiParentLookup.GetParent(child);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parent"></param>
    /// <returns></returns>
    public override bool StopCondition(IntPtr parent)
    {
      return parent == IntPtr.Zero;
    }
  }
}
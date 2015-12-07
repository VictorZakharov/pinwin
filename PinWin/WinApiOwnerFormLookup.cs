using System;
using System.Runtime.InteropServices;

namespace PinWin
{
  /// <summary>
  ///  Find owner form of a WinAPI window.
  /// </summary>
  public class WinApiOwnerFormLookup: ParentChildHierarchyLookup<IntPtr>
  {
    [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
    public static extern IntPtr GetParent(IntPtr hWnd);

    protected override IntPtr GetParentElement(IntPtr child)
    {
      return WinApiOwnerFormLookup.GetParent(child);
    }

    protected override bool StopCondition(IntPtr parent)
    {
      return parent == IntPtr.Zero;
    }
  }
}
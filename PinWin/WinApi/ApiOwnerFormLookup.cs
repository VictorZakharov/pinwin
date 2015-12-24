using System;
using System.Runtime.InteropServices;
using PinWin.Algorithms;

namespace PinWin.WinApi
{
  /// <summary>
  ///  Find owner form of a WinAPI window.
  /// </summary>
  public class ApiOwnerFormLookup: ParentChildHierarchyLookup<IntPtr>
  {
    [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
    public static extern IntPtr GetParent(IntPtr hWnd);

    protected override IntPtr GetParentElement(IntPtr child)
    {
      return ApiOwnerFormLookup.GetParent(child);
    }

    protected override bool StopCondition(IntPtr parent)
    {
      return parent == IntPtr.Zero;
    }
  }
}
using System;
using System.Windows.Forms;

namespace PinWin.BusinessLayer
{
  static class FormExtensions
  {
    /// <summary>
    /// 
    /// </summary>
    public static void Show(this Form form, IntPtr ownerHandle)
    {
      NativeWindow nativeWindow = new NativeWindow();
      nativeWindow.AssignHandle(ownerHandle);
      form.Show(nativeWindow);
      nativeWindow.ReleaseHandle();
    }
  }
}

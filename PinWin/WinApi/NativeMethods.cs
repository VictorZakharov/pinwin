using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PinWin.WinApi
{
  public static class NativeMethods
  {
    [DllImport("user32.dll")]
    public static extern IntPtr SetWinEventHook(uint eventMin, uint eventMax, IntPtr hmodWinEventProc, WinEventDelegate lpfnWinEventProc, uint idProcess, uint idThread, uint dwFlags);

    public delegate void WinEventDelegate(IntPtr hWinEventHook, uint eventType, IntPtr hwnd, int idObject, int idChild, uint dwEventThread, uint dwmsEventTime);


    [return: MarshalAs(UnmanagedType.Bool)]
    [DllImport("user32.dll")]
    internal static extern bool UnhookWinEvent(IntPtr eventHookHandle);

    internal delegate void WinEventProc(IntPtr winEventHookHandle, AccessibleEvents accEvent, IntPtr windowHandle, int objectId, int childId, uint eventThreadId, uint eventTimeInMilliseconds);

    [Flags]
    internal enum SetWinEventHookParameter
    {
      WINEVENT_INCONTEXT = 4,
      WINEVENT_OUTOFCONTEXT = 0,
      WINEVENT_SKIPOWNPROCESS = 2,
      WINEVENT_SKIPOWNTHREAD = 1

    }
  }
}
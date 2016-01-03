using System;
using System.Collections.Generic;
using PinWin.WinApi;
using static PinWin.WinApi.ApiWinEventHook;

namespace PinWin.BusinessLayer
{
  class WinEventHook : IDisposable
  {
    private readonly List<WinEventHookHandler> _handlers;
    private IntPtr _handle;
    private readonly uint _processId;
    private readonly uint _threadId;

    public WinEventHook(IntPtr handle)
    {
      this._handle = handle;
      this._handlers = new List<WinEventHookHandler>();
      this._threadId = ApiWinEventHook.GetWindowThreadProcessId(handle, out this._processId);
    }

    public void Add(EventId eventId, WinEventDelegate eventHandler)
    {
      var newHandler = new WinEventHookHandler(this._processId, this._threadId, eventId, eventHandler);
      this._handlers.Add(newHandler);
    }

    public void Dispose()
    {
      foreach (WinEventHookHandler handler in _handlers)
      {
        handler.Dispose();
      }
    }
  }
}

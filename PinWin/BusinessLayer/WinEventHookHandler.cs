namespace PinWin.BusinessLayer
{
    using System;

    using static WinApi.ApiWinEventHook;

    public class WinEventHookHandler : IDisposable
    {
        private readonly IntPtr _eventHandle;
        private readonly EventId _eventId;
        private readonly WinEventDelegate _eventHandler;

        public WinEventHookHandler(uint processId,
            uint threadId,
            EventId eventId,
            WinEventDelegate eventHandler)
        {
            this._eventId = eventId;
            this._eventHandler = eventHandler;
            this._eventHandle = AddHook(processId, threadId, eventId, eventHandler);
        }

        private static IntPtr AddHook(uint processId,
            uint threadId,
            EventId eventId,
            WinEventDelegate eventHandler)
        {
            return AddHook(processId, threadId, eventId, eventId, eventHandler);
        }

        private static IntPtr AddHook(uint processId,
            uint threadId,
            EventId eventIdMin,
            EventId eventIdMax,
            WinEventDelegate eventHandler)
        {
            IntPtr handle = SetWinEventHook(
                eventIdMin, eventIdMax, IntPtr.Zero, eventHandler,
                processId, threadId, EventSyncContext.WINEVENT_OUTOFCONTEXT);

            return handle;
        }

        public override string ToString()
        {
            return $"{this._eventId} - {this._eventHandler}";
        }

        public void Dispose()
        {
            if (this._eventHandle == IntPtr.Zero)
            {
                return;
            }

            UnhookWinEvent(this._eventHandle);
        }
    }
}
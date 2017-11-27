using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;

namespace PinWin.BusinessLayer
{
    /// <summary>
    ///  Forces to the application to run in single instance mode.
    /// </summary>
    /// <remarks>
    ///  Used code from here https://stackoverflow.com/a/7810107/897326 as a base.
    /// </remarks>
    class SingleInstanceManager : IDisposable
    {
        private bool _hasHandle = false;
        private Mutex _mutex;

        /// <summary>
        ///  Constructor.
        /// </summary>
        public SingleInstanceManager()
        {
            this.InitMutex();
        }

        /// <summary>
        ///  Check if first instance.
        /// </summary>
        /// <param name="timeout">Timeout in milliseconds.</param>
        public bool IsFirstInstance(int timeout)
        {
            InitMutex();
            try
            {
                var waitMs = timeout >= 0 ? timeout : Timeout.Infinite;
                this._hasHandle = _mutex.WaitOne(waitMs, false);
            }
            catch (AbandonedMutexException)
            {
                // ignore error, still got the handle
                this._hasHandle = true;
            }
            return this._hasHandle;
        }

        /// <summary>
        ///  Implements IDisposable.
        /// </summary>
        public void Dispose()
        {
            if (this._mutex == null)
            {
                return;
            }
            
            if (this._hasHandle)
            {
                this._mutex.ReleaseMutex();
            }

            this._mutex.Close();
        }

        /// <summary>
        ///  Initialize the mutex.
        /// </summary>
        private void InitMutex()
        {
            string appGuid = ((GuidAttribute)Assembly.GetExecutingAssembly().
                GetCustomAttributes(typeof(GuidAttribute), false).GetValue(0)).Value;

            string mutexId = $"Global\\{{{appGuid}}}";
            this._mutex = new Mutex(false, mutexId);

            var allowEveryoneRule = new MutexAccessRule(
                new SecurityIdentifier(WellKnownSidType.WorldSid, null),
                MutexRights.FullControl, AccessControlType.Allow);

            var securitySettings = new MutexSecurity();
            securitySettings.AddAccessRule(allowEveryoneRule);
            this._mutex.SetAccessControl(securitySettings);
        }
    }
}

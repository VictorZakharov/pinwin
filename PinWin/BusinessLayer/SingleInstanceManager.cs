using System;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

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
            // Environment.UserName; -- gets RunAs user
            // WindowsIdentity.GetCurrent ignores RunAs user, which makes sense
            // We don't want to have two instances of PinWin running at the same time
            // It works, but why support a non-useful workflow?
            string accountId = WindowsIdentity.GetCurrent().User.AccountDomainSid.ToString();
            string appName = Application.ProductName;

            String mutexName = $"{appName}:{accountId}";
            this._mutex = new Mutex(false, mutexName);
        }
    }
}

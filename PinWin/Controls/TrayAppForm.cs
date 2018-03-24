using System;
using System.Windows.Forms;
using PinWin.BusinessLayer;

namespace PinWin.Controls
{
    /// <summary>
    ///  Inherit from this form to create system tray applications.
    /// </summary>
    /// <remarks>
    ///  Form will be hidden by default. Calling .Show() has no effect.
    ///  Set AllowFormShow to true to enable default form behavior.
    /// </remarks>
    public class TrayAppForm : Form
    {
        /// <summary>
        ///  Defines whether form is allowed to be shown.
        /// </summary>
        public bool AllowFormShow { get; set; } = false;

        protected override void SetVisibleCore(bool value)
        {
            if (!this.AllowFormShow && !this.DesignMode)
            {
                //do nothing
                return;
            }

            base.SetVisibleCore(value);
        }

        #region " Hot key implementation "

        private readonly HotKeyList _hotKeyList;

        public TrayAppForm()
        {
            this._hotKeyList = new HotKeyList(this);
        }

        /// <summary>
        ///  Call this method from RegisterHotKeys as many times as needed.
        /// </summary>
        /// <param name="keys">Key combination for a hot key.</param>
        /// <param name="action">Action delegate to be called.</param>
        public void RegisterHotKey(Keys keys, Action action)
        {
            if (keys == Keys.None)
            {
                return;
            }

            this._hotKeyList.Add(keys, action);
        }

        /// <summary>
        /// 
        /// </summary>
        public void UnregisterHotKeys()
        {
            this._hotKeyList.Clear();
        }

      /// <summary>
        ///  Process hot key.
        /// </summary>
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            HotKey hotKey = this._hotKeyList.Find(m);
            hotKey?.ActionDelegate.Invoke();
        }

        /// <summary>
        ///  Unregister hot keys.
        /// </summary>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            this._hotKeyList.Clear();
            base.OnFormClosing(e);
        }

        #endregion
    }
}
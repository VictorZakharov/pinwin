namespace PinWin.BusinessLayer
{
    using System;
    using System.Windows.Forms;

    public class HotKey
    {
        public Action ActionDelegate { get; set; }
        public Keys Key { get; set; }

        public HotKey(Keys key, Action action)
        {
            this.ActionDelegate = action;
            this.Key = key;
        }
    }
}
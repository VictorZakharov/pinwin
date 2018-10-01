namespace PinWin.Controls
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    ///  Extends ListBox to implement ItemsChanged event.
    /// </summary>
    /// <remarks>
    ///  Solution taken from here:
    ///  http://stackoverflow.com/questions/655956/how-to-detect-if-items-are-added-to-a-listbox-or-checkedlistbox-control
    /// </remarks>
    public class ListBoxEx : ListBox
    {
        // ReSharper disable All 
        private const int LB_ADDSTRING = 0x180;
        private const int LB_INSERTSTRING = 0x181;
        private const int LB_DELETESTRING = 0x182;
        private const int LB_RESETCONTENT = 0x184;
        // ReSharper restore All

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == LB_ADDSTRING ||
                m.Msg == LB_INSERTSTRING ||
                m.Msg == LB_DELETESTRING ||
                m.Msg == LB_RESETCONTENT)
            {
                ItemsChanged(this, EventArgs.Empty);
            }

            base.WndProc(ref m);
        }

        public event EventHandler ItemsChanged = delegate { };
    }
}
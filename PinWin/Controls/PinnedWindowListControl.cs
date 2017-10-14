using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PinWin.BusinessLayer;
using PinWin.WinApi;

namespace PinWin.Controls
{
    /// <summary>
    ///  User interface to manage "always on top" status for external windows.
    /// </summary>
    public partial class PinnedWindowListControl : UserControl
    {
        #region " Contructors "

        /// <summary>
        ///  Constructor - creates data source for ListBox.
        /// </summary>
        public PinnedWindowListControl()
        {
            InitializeComponent();

            //custom processing
            this.DataSource = new PinFormFactory();

            lbl_PinnedWindowListNoItems.Parent = lst_PinnedWindowList;
            lbl_PinnedWindowListNoItems.BackColor = Color.Transparent;
        }

        #endregion

        #region " Public methods "

        /// <summary>
        ///  Add specified window to the list of pinned windows (always on top).
        /// </summary>
        /// <param name="handle">Window handle to be added.</param>
        private void TryAddWindow(IntPtr handle)
        {
            this.DataSource.TryAddPinned(handle);
        }

        public void TryAddWindowFromPoint(Point point)
        {
            IntPtr formHandle = ApiForm.Select(point);
            if (formHandle == IntPtr.Zero)
            {
                //parent could not be found
                return;
            }

            this.TryAddWindow(formHandle);
        }

        public IntPtr[] SelectedWindowHandles
        {
            get { return this.SelectedItems.Select(x => x.ParentHandle).ToArray(); }
        }

        /// <summary>
        ///  Synchronizes pinned icon position relative to the parent form.
        /// </summary>
        public void SyncWindowPosition()
        {
            var closedForms = new List<PinForm>();

            foreach (PinForm form in this.DataSource)
            {
                if (form.ReceivesParentMoveEvents)
                {
                    //move was already handled
                    continue;
                }
                
                if (!form.IsParentOpen)
                {
                    //form destroyed event not supported by parent application
                    closedForms.Add(form);
                }

                //if parent window is minimized, an attempt to sync the pin location may hide the pin
                if (!ApiWindowPos.IsIconic(form.ParentHandle))
                {
                    //parent window was either never moved, or cannot send move events (not supported)
                    form.MoveToParentWindow();
                }
            }

            this.DataSource.RemoveRange(closedForms);
        }

        #endregion

        #region " Event handlers "

        /// <summary>
        ///  Clear "always on top" option for all windows and remove them from list.
        /// </summary>
        private void btn_UnpinAllWindows_Click(object sender, EventArgs e)
        {
            PinFormFactory dataSource = this.DataSource;
            this.DataSource.RemoveRange(dataSource);
        }

        /// <summary>
        ///  Clear "always on top" option for selected windows and remove them from list.
        /// </summary>
        private void btn_UnpinSelectedWindows_Click(object sender, EventArgs e)
        {
            List<PinForm> selectedItems = this.SelectedItems;
            this.DataSource.RemoveRange(selectedItems);
        }

        /// <summary>
        ///  Ensures UI state corresponds to business state of the control.
        /// </summary>
        private void ValidateActions(object sender, EventArgs e)
        {
            this.btn_UnpinAllWindows.Enabled = this.lst_PinnedWindowList.Items.Count > 0;
            this.btn_UnpinSelectedWindows.Enabled = this.lst_PinnedWindowList.SelectedItems.Count > 0;
            this.lbl_PinnedWindowListNoItems.Visible = !this.btn_UnpinAllWindows.Enabled;
        }

        #endregion

        #region " Private properties "

        /// <summary>
        ///  Gets or sets underlying business object.
        /// </summary>
        private PinFormFactory DataSource
        {
            get => this.lst_PinnedWindowList.DataSource as PinFormFactory;
            set
            {
                this.lst_PinnedWindowList.DataSource = value;
                this.lst_PinnedWindowList.DisplayMember = "ParentTitle";
                this.lst_PinnedWindowList.ValueMember = "ParentHandle";
            }
        }

        /// <summary>
        ///  Read-only accessor to selected items from the underlying business object.
        /// </summary>
        private List<PinForm> SelectedItems
        {
            get
            {
                var items = new List<PinForm>();
                foreach (PinForm pinForm in lst_PinnedWindowList.SelectedItems)
                {
                    items.Add(pinForm);
                }
                return items;
            }
        }

        #endregion
    }
}
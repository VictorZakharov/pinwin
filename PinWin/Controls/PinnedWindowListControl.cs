using System;
using System.Drawing;
using System.Linq;
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
      this.DataSource = new WindowListItemList();

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
      PinForm.Create(handle);
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

    public IntPtr[] SelectedWindowHandles {
      get
      {
        return this.SelectedItems.Select(x => x.Handle).ToArray();
      }
    }
#endregion

#region " Event handlers "
    /// <summary>
    ///  Clear "always on top" option for all windows and remove them from list.
    /// </summary>
    private void btn_UnpinAllWindows_Click(object sender, EventArgs e)
    {
      WindowListItemList dataSource = this.DataSource;
      dataSource.ClearPinnedStatus();
      dataSource.Clear();
    }

    /// <summary>
    ///  Clear "always on top" option for selected windows and remove them from list.
    /// </summary>
    private void btn_UnpinSelectedWindows_Click(object sender, EventArgs e)
    {
      WindowListItemList selectedItems = this.SelectedItems;
      selectedItems.ClearPinnedStatus();

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
    private WindowListItemList DataSource
    {
      get
      {
        return this.lst_PinnedWindowList.DataSource as WindowListItemList;
      }
      set
      {
        this.lst_PinnedWindowList.DataSource = value;
      }
    }

    /// <summary>
    ///  Read-only accessor to selected items from the underlying business object.
    /// </summary>
    private WindowListItemList SelectedItems => this.lst_PinnedWindowList.SelectedItems;
#endregion
  }
}
using System;
using System.Collections;
using System.Windows.Forms;
using PinWin.BusinessLayer;

namespace PinWin.Controls
{
  public partial class PinnedWindowListControl : UserControl
  {
    public PinnedWindowListControl()
    {
      InitializeComponent();
    }

    public void ValidateActions(object sender, EventArgs e)
    {
      btn_UnpinAllWindows.Enabled = lst_PinnedWindowList.Items.Count > 0;
      btn_UnpinSelectedWindows.Enabled = lst_PinnedWindowList.SelectedItems.Count > 0;
      lbl_PinnedWindowListNoItems.Visible = !btn_UnpinAllWindows.Enabled;
    }

    public void AddWindow(IntPtr handle)
    {
      //TODO: validate uniqueness
      var newWindowListItem = new WindowListItem(handle);
      this.lst_PinnedWindowList.Items.Add(newWindowListItem);
      WinApiTopMost.Set(handle);
    }

    private void btn_UnpinAllWindows_Click(object sender, EventArgs e)
    {
      PinnedWindowListControl.ClearPinnedStatus(lst_PinnedWindowList.Items);
      lst_PinnedWindowList.Items.Clear();
    }

    private void btn_UnpinSelectedWindows_Click(object sender, EventArgs e)
    {
      PinnedWindowListControl.ClearPinnedStatus(lst_PinnedWindowList.SelectedItems);
      lst_PinnedWindowList.RemoveSelected();
    }

    private static void ClearPinnedStatus(IList items)
    {
      for (int index = items.Count - 1; index >= 0; index--)
      {
        object selectedItem = items[index];
        var windowListItem = selectedItem as WindowListItem;
        windowListItem?.ClearPinnedStatus();
      }
    }
  }
}
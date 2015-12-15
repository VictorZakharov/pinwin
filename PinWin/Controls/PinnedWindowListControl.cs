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

      this.ValidateActions();
    }

    public void ValidateActions()
    {
      btn_UnpinAllWindows.Enabled = lst_PinnedWindowList.Items.Count > 0;
      btn_UnpinSelectedWindows.Enabled = lst_PinnedWindowList.SelectedItems.Count > 0;
      lbl_PinnedWindowListNoItems.Visible = !btn_UnpinAllWindows.Enabled;
    }

    public void AddWindow(IntPtr handle)
    {
      var newWindowListItem = new WindowListItem(handle);
      this.lst_PinnedWindowList.Items.Add(newWindowListItem);
      WinApiTopMost.Set(handle);
      this.ValidateActions();
    }

    private void btn_UnpinAllWindows_Click(object sender, EventArgs e)
    {
      PinnedWindowListControl.ClearPinnedStatus(lst_PinnedWindowList.Items);
      lst_PinnedWindowList.Items.Clear();
      this.ValidateActions();
    }

    private void btn_UnpinSelectedWindows_Click(object sender, EventArgs e)
    {
      PinnedWindowListControl.ClearPinnedStatus(lst_PinnedWindowList.SelectedItems);
      lst_PinnedWindowList.RemoveSelected();
      this.ValidateActions();
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

    private void lst_PinnedWindowList_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.ValidateActions();
    }
  }
}

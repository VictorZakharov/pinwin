using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace PinWin.BusinessLayer
{
  /// <summary>
  ///  Business object representing list of pinned windows, used for UI binding.
  /// </summary>
  public class WindowListItemList : BindingList<WindowListItem>
  {
#region " Public methods "
    /// <summary>
    ///  Try to retrieve a window with the same handle from the list of owned windows.
    /// </summary>
    /// <param name="windowListItem">Window to be found.</param>
    /// <returns>Found window or null, if cannot be found.</returns>
    public WindowListItem TryGetItem(WindowListItem windowListItem)
    {
      foreach (WindowListItem item in this)
      {
        if (item.Handle == windowListItem.Handle)
        {
          return item;
        }
      }
      return null;
    }

    /// <summary>
    ///  Remove a range of items from the list using window handle as key.
    /// </summary>
    /// <param name="items">Items to be removed.</param>
    public void RemoveRange(IList<WindowListItem> items)
    {
      foreach (WindowListItem item in items)
      {
        WindowListItem foundItem = this.TryGetItem(item);
        if (foundItem != null)
        {
          this.Remove(foundItem);
        }
      }  
    }

    /// <summary>
    ///  Try to add a window to the list of pinned items.
    /// </summary>
    /// <param name="item">Item to be added.</param>
    /// <returns><c>true</c> if item was added, <c>false</c> if already exists.</returns>
    public bool TryAddPinned(WindowListItem item)
    {
      WindowListItem existingItem = this.TryGetItem(item);
      if (existingItem != null)
      {
        return false;
      }

      item.SetPinnedStatus();
      this.Add(item);
      return true;
    }

    /// <summary>
    ///  Clear pinned status for all owned windows.
    /// </summary>
    public void ClearPinnedStatus()
    {
      for (int index = this.Count - 1; index >= 0; index--)
      {
        WindowListItem item = this[index];
        item.ClearPinnedStatus();
      }
    }
#endregion

#region " Implicit converters"
    /// <summary>
    ///  Provides implicit conversion from ListBox.SelectedObjectCollection.
    /// </summary>
    /// <param name="items">Collection of selected items from a ListBox control.</param>
    public static implicit operator WindowListItemList(ListBox.SelectedObjectCollection items)
    {
      return WindowListItemList.ConvertFromIList(items);
    }
#endregion

#region " Private methods "
    /// <summary>
    ///  Appends a copy of the specified window list item to self.
    /// </summary>
    /// <param name="item">Input window list item.</param>
    private void AddCopy(WindowListItem item)
    {
      this.Add(item.Handle);
    }

    /// <summary>
    ///  Creates new WindowListItemList, copying items from the specified IList.
    /// </summary>
    /// <param name="items">List of items to be added.</param>
    /// <returns>New WindowListItemList containing specified items.</returns>
    private static WindowListItemList ConvertFromIList(IList items)
    {
      var newItems = new WindowListItemList();
      foreach (WindowListItem item in items)
      {
        newItems.AddCopy(item);
      }
      return newItems;
    }
#endregion
  }
}
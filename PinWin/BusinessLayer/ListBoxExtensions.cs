using System.Windows.Forms;

namespace PinWin.BusinessLayer
{
  /// <summary>
  ///  Extension methods for ListBox class.
  /// </summary>
  public static class ListBoxExtensions
  {
    /// <summary>
    ///  Remove selected items from the collection.
    /// </summary>
    /// <param name="listBox">ListBox from which selected items need to be removed</param>
    public static void RemoveSelected(this ListBox listBox)
    {
      for (int index = listBox.SelectedItems.Count - 1; index >= 0; index--)
      {
        listBox.Items.Remove(listBox.SelectedItems[index]);
      }
    }
  }
}
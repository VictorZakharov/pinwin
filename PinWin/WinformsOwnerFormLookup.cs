using System.Windows.Forms;

namespace PinWin
{
  /// <summary>
  ///  Find owner form of a control.
  /// </summary>
  /// <remarks>
  ///  Identical to result of calling Control.FindForm:
  ///  https://msdn.microsoft.com/en-us/library/system.windows.forms.control.findform%28v=vs.110%29.aspx
  ///  This class was created to show potential uses for ParentChildHierarchyLookup class.
  /// </remarks>
  public class WinformsOwnerFormLookup : ParentChildHierarchyLookup<Control>
  {
    protected override Control GetParentElement(Control child)
    {
      return child.Parent;
    }

    protected override bool StopCondition(Control parent)
    {
      return parent == null;
    }
  }
}
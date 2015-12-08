namespace PinWin.BusinessLayer
{
  /// <summary>
  ///  Implements abstract definition of parent-child lookup logic
  /// </summary>
  public abstract class ParentChildHierarchyLookup<T>
  {
    /// <summary>
    ///  Find parent element for the specified child.
    /// </summary>
    /// <param name="child">Child object for which parent need to be found.</param>
    /// <returns>Element of the same type as child, located at the root of hierarchy.</returns>
    public T FindParent(T child)
    {
      while (true)
      {
        T parent = this.GetParentElement(child);
        if (this.StopCondition(parent))
        {
          return child;
        }
        child = parent;
      }
    }

    /// <summary>
    ///  Provide implementation of algorithm for retrieval of parent value,
    ///  for a given child element.
    /// </summary>
    /// <param name="child">Child object for which parent need to be found.</param>
    /// <returns>Element of the same type as child, located one level higher in hierarchy.</returns>
    protected abstract T GetParentElement(T child);

    /// <summary>
    ///  Provide implementation for condition to stop search,
    ///  in other words indication that a parent with specific properties is found.
    /// </summary>
    /// <param name="parent">Parent object to be checked against stop condition.</param>
    /// <returns>A boolean value, true means that provided child is actually a parent.</returns>
    protected abstract bool StopCondition(T parent);
  }
}
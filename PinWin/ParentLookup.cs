namespace PinWin
{
  /// <summary>
  ///  Implements abstract definition of parent-child lookup logic
  /// </summary>
  public abstract class ParentLookup<T>
  {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="child"></param>
    /// <returns></returns>
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
    /// 
    /// </summary>
    /// <param name="child"></param>
    /// <returns></returns>
    protected abstract T GetParentElement(T child);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="parent"></param>
    /// <returns></returns>
    protected abstract bool StopCondition(T parent);
  }
}
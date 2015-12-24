using System;
using PinWin.WinApi;

namespace PinWin.BusinessLayer
{
  /// <summary>
  ///  Business object representing a window that can be pinned or unpinned at request.
  /// </summary>
  public class WindowListItem
  {
#region " Public properties "
    /// <summary>
    ///  Window title, a user-friendly identity of the current window.
    /// </summary>
    public string Title { get; }

    /// <summary>
    ///  Window handle, a system-friendly identity of the current window.
    /// </summary>
    public IntPtr Handle { get; }
#endregion

#region " Constructor "
    /// <summary>
    ///  Constructor that creates a window item based on the specified handle.
    /// </summary>
    /// <param name="handle">Input handle.</param>
    public WindowListItem(IntPtr handle)
    {
      this.Handle = handle;
      this.Title = ApiWindowTitle.FromHandle(handle);
    }
    #endregion

#region " Public methods "
    /// <summary>
    ///  Set current window status as pinned (always on top).
    /// </summary>
    public void SetPinnedStatus()
    {
      ApiTopMost.Set(this.Handle);
    }

    /// <summary>
    ///  Clear pinned status for current window (always on top).
    /// </summary>
    public void ClearPinnedStatus()
    {
      ApiTopMost.Clear(this.Handle);
    }

    /// <summary>
    ///  Provides UI display capability for this class.
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      return $"{this.Handle} - {this.Title}";
    }
    #endregion

#region " Implicit converters"   
    /// <summary>
    ///  Implicit conversion from IntPtr handle.
    /// </summary>
    /// <param name="handle">Input handle.</param>
    public static implicit operator WindowListItem(IntPtr handle)
    {
      return new WindowListItem(handle);
    }
#endregion
  }
}
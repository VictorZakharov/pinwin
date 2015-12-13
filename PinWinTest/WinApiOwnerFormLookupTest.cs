using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinWin.BusinessLayer;
using PinWinTest.BusinessLayer;

namespace PinWinTest
{
  [TestClass]
  public class WinApiOwnerFormLookupTest
  {
    [TestMethod]
    public void WinApiFindFormTest_Self()
    {
      using (var testForm = new FormTestLayout())
      {
        this.FindAndValidateParent(testForm.MyForm.Handle, testForm.MyForm.Handle);
      }
    }

    [TestMethod]
    public void WinApiFindFormTest_ComplexNesting()
    {
      using (var testForm = new FormTestLayout()) 
      {
        this.FindAndValidateParent(testForm.MyButton.Handle, testForm.MyForm.Handle);
      }
    }

    [TestMethod]
    public void WinApiFindFormTest_SimpleNesting()
    {
      using (var testForm = new FormTestLayout())
      {
        this.FindAndValidateParent(testForm.MyPanel.Handle, testForm.MyForm.Handle);
      }
    }

    /// <summary>
    ///  Find and validate parent of the specified child window handle.
    /// </summary>
    /// <param name="childWindow">Child window handle.</param>
    /// <param name="expectedParent">Expected parent window handle.</param>
    private void FindAndValidateParent(IntPtr childWindow, IntPtr expectedParent)
    {
      var formLookup = new WinApiOwnerFormLookup();
      IntPtr actualParent = formLookup.FindParent(childWindow);

      Assert.AreEqual(actualParent, expectedParent);
    }
  } 
}
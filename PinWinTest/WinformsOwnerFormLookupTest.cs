using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PinWin.BusinessLayer;
using PinWinTest.BusinessLayer;

namespace PinWinTest
{
  [TestClass]
  public class WinformsOwnerFormLookupTest
  {
    [TestMethod]
    public void WinFormsFindFormTest_Self()
    {
      using (var testForm = new FormTestLayout())
      {
        this.FindAndValidateParent(testForm.MyForm, testForm.MyForm);
      }
    }

    [TestMethod]
    public void WinFormsFindFormTest_ComplexNesting()
    {
      using (var testForm = new FormTestLayout())
      {
        this.FindAndValidateParent(testForm.MyButton, testForm.MyForm);
      }
    }

    [TestMethod]
    public void WinFormsFindFormTest_SimpleNesting()
    {
      using (var testForm = new FormTestLayout())
      {
        this.FindAndValidateParent(testForm.MyPanel, testForm.MyForm);
      }
    }

    /// <summary>
    ///  Find and validate parent control of the specified child control.
    /// </summary>
    /// <param name="childControl">Child control, for which parent needs to be checked.</param>
    /// <param name="expectedParent">Expected parent control for provided child control.</param>
    private void FindAndValidateParent(Control childControl, Control expectedParent)
    {
      var formLookup = new WinformsOwnerFormLookup();
      Control actualParent = formLookup.FindParent(childControl);

      Assert.AreEqual(actualParent, expectedParent);
    }
  } 
}
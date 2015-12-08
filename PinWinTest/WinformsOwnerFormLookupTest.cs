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
    public void FindFormTest_Self()
    {
      var testForm = new FormTestLayout();
      this.FindAndValidateParent(testForm.MyForm, testForm.MyForm);
    }

    [TestMethod]
    public void FindFormTest_ComplexNesting()
    {
      var testForm = new FormTestLayout();
      this.FindAndValidateParent(testForm.MyButton, testForm.MyForm);
    }

    [TestMethod]
    public void FindFormTest_SimpleNesting()
    {
      var testForm = new FormTestLayout();
      this.FindAndValidateParent(testForm.MyPanel, testForm.MyForm);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="childControl"></param>
    /// <param name="expectedParent"></param>
    private void FindAndValidateParent(Control childControl, Control expectedParent)
    {
      var formLookup = new WinformsOwnerFormLookup();
      Control actualParent = formLookup.FindParent(childControl);

      Assert.AreEqual(actualParent, expectedParent);
    }
  } 
}
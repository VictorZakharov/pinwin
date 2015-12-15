using System;
using System.Windows.Forms;

namespace PinWinTest.BusinessLayer
{
  internal class FormTestLayout : IDisposable
  {
    public Form MyForm { get; }
    public Panel MyPanel { get; }
    public Button MyButton { get; }
    
    public FormTestLayout()
    {
      this.MyForm = new Form();
      this.MyForm.Text = @"Test form";

      this.MyPanel = new Panel();
      this.MyPanel.Text = @"Test panel";

      this.MyButton = new Button();
      this.MyButton.Text = @"Test button";
      
      this.MyPanel.Controls.Add(this.MyButton);
      this.MyForm.Controls.Add(this.MyPanel);

      //ensure handles are created
      //below code is required for WinApi tests to pass
      IntPtr myFormHandle = MyForm.Handle;
      IntPtr myPanelHandle = MyPanel.Handle;
      IntPtr myButtonHandle = MyButton.Handle;
    }
    
    /// <summary>
    ///  Speed up freeing up system resources.
    /// </summary>
    public void Dispose()
    {
      this.MyButton.Dispose();
      this.MyPanel.Dispose();
      this.MyForm.Dispose();
    }
  }
}
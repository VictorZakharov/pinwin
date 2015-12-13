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

      //prevents form title being "Winforms parking window" when running WinApi tests
      this.MyForm.Show();
      //prevents multiple forms being shown to user when tests are executed
      this.MyForm.Hide();
      //TODO: it still blinks for a moment, not sure what to do with it
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
using System.Windows.Forms;

namespace PinWinTest.BusinessLayer
{
  internal class FormTestLayout
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
    }
  }
}
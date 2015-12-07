using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PinWin
{
  public partial class MainForm : Form
  {
    public MainForm()
    {
      InitializeComponent();
    }

    private void btn_Find_Click(object sender, EventArgs e)
    {
      int xPoint = Convert.ToInt32(txt_WindowX.Text);
      int yPoint = Convert.ToInt32(txt_WindowY.Text);

      IntPtr formHandle = GetFormFromPoint(xPoint, yPoint);
      if (formHandle.ToInt32() == 0)
      {
        txt_FormTitle.Text = "Not found";
      }
      else
      {
        txt_FormTitle.Text = WinApi.GetWindowTitle(formHandle);
      }
    }

    [DllImport("user32.dll", ExactSpelling = true, CharSet = CharSet.Auto)]
    public static extern IntPtr GetParent(IntPtr hWnd);

    private IntPtr GetFormFromPoint(int xPoint, int yPoint)
    {
      IntPtr foundWindowHandle = WinApi.GetWindowHandleFromPoint(xPoint, yPoint);

      var parentLookup = new WinApiParentLookup();
      IntPtr hWnd = parentLookup.FindParent(foundWindowHandle);
      
      return hWnd;
    }
  }
}
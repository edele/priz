using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PRIZ
{
    public partial class FormAboutProgramm : Form
    {
        public FormAboutProgramm()
        {
            InitializeComponent();
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);
            //this.FormClosing += Program.ApplicationQuit;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            tbForText.LoadFile(@"content/textAboutProgramm.rtf", RichTextBoxStreamType.RichText);
        }
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back02;
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back01;
        }
        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back03;
        }
        private void btnBack_MouseUp(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back02;
        }
        private void tbForText_SizeChanged(object sender, EventArgs e)
        {
           tbForText.Size = new Size(tbForText.Size.Width, this.Size.Height - 300);
        }
        private void tb_MouseWheel(object sender, EventArgs e)
        {
            tbForText.Focus();
        }
        private void btnLogoEducationEra_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutEducation);
            this.Hide();
            Program.fAboutEducation.ShowDialog();
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutCreativeSchool);
            this.Hide();
            Program.fAboutCreativeSchool.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    //______________________________________________________________________________________-


public class ReadOnlyRichTextBox : System.Windows.Forms.RichTextBox
{

  [DllImport("user32.dll")]
  private static extern int HideCaret (IntPtr hwnd);

  public ReadOnlyRichTextBox()
  {
    this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReadOnlyRichTextBox_Mouse);
    this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ReadOnlyRichTextBox_Mouse);
    base.ReadOnly = true;
    base.TabStop = false;
    HideCaret(this.Handle);
  }


  protected override void OnGotFocus(EventArgs e)
  {
    HideCaret(this.Handle);
  }

  protected override void OnEnter(EventArgs e)
  {
    HideCaret(this.Handle);
  }

  [DefaultValue(true)]
  public new bool ReadOnly
  {
    get { return true; }
    set { }
  }

  [DefaultValue(false)]
  public new bool TabStop
  {
    get { return false; }
    set { }
  }

  private void ReadOnlyRichTextBox_Mouse(object sender, System.Windows.Forms.MouseEventArgs e)
  {
    HideCaret(this.Handle);
  }

  private void InitializeComponent()
  {
    //
    // ReadOnlyRichTextBox
    //
    this.Resize += new System.EventHandler(this.ReadOnlyRichTextBox_Resize);

  }

  private void ReadOnlyRichTextBox_Resize(object sender, System.EventArgs e)
  {
    HideCaret(this.Handle);

  }
}
}

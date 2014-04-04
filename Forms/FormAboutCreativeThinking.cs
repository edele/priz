using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PRIZ
{
    public partial class FormAboutCreativeThinking : Form
    {
        public FormAboutCreativeThinking()
        {
            InitializeComponent();
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            try
            {
                tbForText.LoadFile(@"content/textAboutCreativeSchool.rtf", RichTextBoxStreamType.RichText);
            }
            catch (DirectoryNotFoundException)
            {
                tbForText.Text = "Справочный файл удален или поврежден";
            }
        }
        

       private void tbForText_SizeChanged(object sender, EventArgs e)
        {
            tbForText.Size = new Size(tbForText.Size.Width, this.Size.Height - 300);
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

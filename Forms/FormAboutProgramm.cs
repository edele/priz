using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            tbForText.LoadFile(@"content/textAboutProgramm.rtf");
            tbForText.Font = new System.Drawing.Font("Segoe UI Light", 13F);
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
            Program.fAboutEducation.Show();
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutCreativeSchool);
            this.Hide();
            Program.fAboutCreativeSchool.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

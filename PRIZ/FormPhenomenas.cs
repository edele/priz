using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PRIZ
{
    public partial class FormPhenomenas : Form
    {
        Answer answer = Program.p.answer;
        public FormPhenomenas()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            lbUserName.Text = Program.p.CurrentFullName;
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            Random rnd = new Random();
            int res = rnd.Next(1,4);
            switch (res)
            {
                case 1:
                    tbHypo.LoadFile(@"content/textHypoAkus.rtf");
                    tbHypo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
                    break;
                case 2:
                    tbHypo.LoadFile(@"content/textHypoChem.rtf");
                    tbHypo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
                    break;
                case 3:
                    tbHypo.LoadFile(@"content/textHypoGeom.rtf");
                    tbHypo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
                    break;
                case 4:
                    tbHypo.LoadFile(@"content/textHypoPhys.rtf");
                    tbHypo.Font = new System.Drawing.Font("Segoe UI Light", 13F);
                    break;
                default:
                    break;
            }

            this.FormClosing += Program.ApplicationQuit;
        }

        private void btnPlusIdea_Click(object sender, EventArgs e)
        {
            if (tbIdea.Text != "")
            {
                answer._hypothesises.Add(tbIdea.Text);
                tbIdea.Clear();
            }
        }

        private void btnSendToTheNextForm_Click(object sender, EventArgs e)
        {
            if (tbIdea.Text != "" || answer._hypothesises.Count > 0)
            {
                if (tbIdea.Text != "") 
                    answer._hypothesises.Add(tbIdea.Text);
                Program.InitWindow(Forms.fAllIdeas);
                Program.fAllIdeas.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(answer._hypothesises.Count.ToString());
                MessageBox.Show("Введите идею!");
            }
            
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {

            Program.InitWindow(Forms.fAboutCreativeSchool);
            //this.Hide();
            Program.fAboutCreativeSchool.Show();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите перейти в модули? Данные не будут сохранены.\r\n Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.InitWindow(Forms.fModules);
                Program.fModules.Show();
                this.Hide();
            }
            
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutProgramm);
            //this.Hide();
            Program.fAboutProgramm.ShowDialog();
        }

        private void btnWriteToUs_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fMailSender);
            //this.Hide();
            Program.fMailSender.Show();
        }
        private void tbForText_SizeChanged(object sender, EventArgs e)
        {
            tbHypo.Size = new Size(tbHypo.Size.Width, this.Size.Height - 220);
        }
        
        private void btnModules_MouseDown(object sender, MouseEventArgs e)
        {
            btnModules.Image = Properties.Resources.modules03;
        }
        private void btnModules_MouseEnter(object sender, EventArgs e)
        {
            btnModules.Image = Properties.Resources.modules02;
        }
        private void btnModules_MouseLeave(object sender, EventArgs e)
        {
            btnModules.Image = Properties.Resources.modules01;
        }
        private void btnModules_MouseUp(object sender, MouseEventArgs e)
        {
            btnModules.Image = Properties.Resources.modules02;
        }
        /* private void btnMyTasks_MouseDown(object sender, MouseEventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks03;
         }
         private void btnMyTasks_MouseEnter(object sender, EventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks02;
         }
         private void btnMyTasks_MouseLeave(object sender, EventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks01;
         }
         private void btnMyTasks_MouseUp(object sender, MouseEventArgs e)
         {
             btnMyTasks.Image = Properties.Resources.mytasks02;
         }
         */
        private void btnAbout_MouseDown(object sender, MouseEventArgs e)
        {
            btnAbout.Image = Properties.Resources.about03;
        }
        private void btnAbout_MouseEnter(object sender, EventArgs e)
        {
            btnAbout.Image = Properties.Resources.about02;
        }
        private void btnAbout_MouseLeave(object sender, EventArgs e)
        {
            btnAbout.Image = Properties.Resources.about01;
        }
        private void btnAbout_MouseUp(object sender, MouseEventArgs e)
        {
            btnAbout.Image = Properties.Resources.about02;
        }
        private void btnWriteToUs_MouseDown(object sender, MouseEventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus03;
        }
        private void btnWriteToUs_MouseEnter(object sender, EventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus02;
        }
        private void btnWriteToUs_MouseLeave(object sender, EventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus01;
        }
        private void btnWriteToUs_MouseUp(object sender, MouseEventArgs e)
        {
            btnWriteToUs.Image = Properties.Resources.writeus02;
        }

        private void btnLogoEducationEra_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutEducation);
            //this.Hide();
            Program.fAboutEducation.Show();
        }
    }
}

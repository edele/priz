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
    public partial class FormTask : Form
    {
        Task currentTask = Program.p.currentTask;
        Answer answer = Program.p.answer;
        public FormTask()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            pbTask.ImageLocation = currentTask._path + "mainpic.png";
            lDescription.Text = currentTask._description;
            lDescription.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            lDescription.MaximumSize = new System.Drawing.Size(375, 0);
            lDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            lName.Text = currentTask._name;
            lName.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            lName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            lbUserName.Text = Program.p.CurrentFullName;
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            // Если название не помещается в одну строку, то сдвигаем описание ниже
            lDescription.Location = new Point(lDescription.Location.X, lDescription.Location.Y + (lName.Size.Height - 38));
            if (Program.debug)
            {
                tbGiven.Text = "Некоторая задача с такими и такими параметрами. При определенном условии происходят совершенно разные события, но иногда не происходят. Также вероятно варьирование всех вышеперечиленных фактов";
                tbToFind.Text = "Нужно найти такое состояние, при котором правильно выполняются все тесты.";
            }
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
        private void btnToTheNextForm_Click(object sender, EventArgs e)
        {
            if (tbGiven.Text != "" && tbGiven.Text != "Дано:" && tbToFind.Text != "" && tbToFind.Text != "Найти:")
            {
                answer._givenByUser = tbGiven.Text;
                answer._ToFindByUser = tbToFind.Text;
                Program.InitWindow(Forms.fPhenomenas);
                Program.fPhenomenas.Show();
                this.Hide();
            }
            else MessageBox.Show("Заполните «Дано» и «Найти» своими словами для продолжения работы");
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите перейти в задачи? Данные не будут сохранены." + Environment.NewLine + " Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Hide();
                Program.fTasks.Show();
            }
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {
            
            Program.InitWindow(Forms.fAboutCreativeSchool);
            //this.Hide();
            Program.fAboutCreativeSchool.ShowDialog();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите перейти в модули? Данные не будут сохранены." + Environment.NewLine + " Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
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
            Program.fMailSender.ShowDialog();
        }

        private void FormTask_SizeChanged(object sender, EventArgs e)
        {
            lDescription.Size = lName.Size;
        }

        private void btnLogoEducationEra_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutEducation);
            //this.Hide();
            Program.fAboutEducation.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что сменить пользователя? Данные не будут сохранены." + Environment.NewLine + "Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.fLogin.tbLogin.Text = "Фамилия и имя";
                Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
                Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                Program.fLogin.Show();
                this.Hide();
            }
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace PRIZ
{
    public partial class FormNewTask : Form
    {
        bool error = false;
        bool def= true;
        OpenFileDialog ofd = new OpenFileDialog();

        public void GetPlace(bool taskList)
        {
            if (taskList)
            {
                btnBackToTasks.Visible = true;
            }
        }

        public FormNewTask()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            //pnlWhite.Visible = false;
            label2.Text = Program.p.CurrentFullName;
            ofd.Title = "Выберите изображение";
            ofd.Filter = "Файлы изображения|*.jpg; *jpeg; *bmp; *png;";
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.SizeMode = PictureBoxSizeMode.Zoom;
                pbImage.Image = Image.FromFile(ofd.FileName);
                def = false;
            }
            else 
            {
                pbImage.Image = Properties.Resources.iconimage;
                def = true;
            }
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
        static string _earlierText;
        static string _earlierText2;
        private void txtFrom_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Название задания")
            {
                _earlierText = (sender as TextBox).Text;
                (sender as TextBox).Text = "";
                (sender as TextBox).ForeColor = Color.Black;
            }
        }

        private void txtFrom_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as TextBox).Text = _earlierText;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (tbGiven.Text == "" || tbTaskName.Text == "")
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else
            {
                if (!error)
                {
                    NewTask newTask = new NewTask(tbTaskName.Text, tbGiven.Text, pbImage.RectangleToScreen(pbImage.ClientRectangle));
                    pnlAdded.Visible = true;
                    timer1.Enabled = true;
                    tbGiven.Clear();
                    tbTaskName.Clear();
                    pbImage.Image = Properties.Resources.iconimage;
                    pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
                }
            }
        }

        private void descFrom_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Описание задания")
            {
                _earlierText2 = (sender as TextBox).Text;
                (sender as TextBox).Text = "";
                (sender as TextBox).ForeColor = Color.Black;
            }
        }

        private void descFrom_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as TextBox).Text = _earlierText2;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pnlAdded.Visible = false;
        }

        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            if (def)
            {
                pbImage.Image = Properties.Resources.iconimage_hover;
            }
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            if (def)
            {
                pbImage.Image = Properties.Resources.iconimage;
            }
        }
        
        private void btnBackToTasks_Click(object sender, EventArgs e)
        {
            btnBackToTasks.Visible = false;
            Program.InitWindow(Forms.fEditTask);
            Program.fEditTask.Show();
            this.Hide();
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l == '\\' || l == '/' || l == ':' || l == '*' || l == '?' || l == '"' || l == '<' || l == '>' || l == '|')
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сменить пользователя? Данные не будут сохранены." + Environment.NewLine + "Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.InitWindow(Forms.fLogin);
                Program.fLogin.tbLogin.Text = "Фамилия и имя";
                Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
                Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                Program.fLogin.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fEditModule);
            Program.fEditModule.Show();
            this.Hide();
        }
        private void Form_SizeChanged(object sender, EventArgs e)
        {
            Program.currentSize = this.Size;
        }
        private void Form_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState != Program.currentWindowState)
            {
                Program.currentWindowState = this.WindowState;
            }
            Program.currentLocation = this.Location;
        }
        private void Form_Load(object sender, EventArgs e)
        {
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            this.WindowState = Program.currentWindowState;
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
    }
}

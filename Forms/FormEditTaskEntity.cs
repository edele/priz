using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PRIZ
{
    public partial class FormEditTaskEntity : Form
    {
        bool error = false;
        bool def = false;
        string oldTaskName = Program.p.currentTask._name;
        OpenFileDialog ofd = new OpenFileDialog();
        Task currentTask = Program.p.currentTask;
        public FormEditTaskEntity()
        {
            InitializeComponent();
            ofd.Title = "Выберите изображение";
            ofd.Filter = "Файлы изображения|*.jpg; *jpeg; *bmp; *png;";
            label2.Text = Program.p.CurrentFullName;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            this.FormClosing += Program.ApplicationQuit;
            pbTask.ImageLocation = currentTask._path + "mainpic.png";
            pbTask.BackgroundImageLayout = ImageLayout.Stretch;
            lDescription.Text = currentTask._description;
            lName.Text = currentTask._name;
        }
        
        private void pbTask_Click(object sender, EventArgs e)
        {
            var t = ofd.ShowDialog();
            if (t == DialogResult.OK)
            {
                pbTask.SizeMode = PictureBoxSizeMode.Zoom;
                pbTask.Image = Image.FromFile(ofd.FileName);
                def = false;
            }
            else if (t == DialogResult.Cancel)
            {
                pbTask.Image = Properties.Resources.iconimage;
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
        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            if (def)
            {
                pbTask.Image = Properties.Resources.iconimage_hover;
            }
        }

        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            if (def)
            {
                pbTask.Image = Properties.Resources.iconimage;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                string currentModule = Program.p.currentModule._filename;
                NewTask newTask = new NewTask(lName.Text, lDescription.Text, pbTask.RectangleToScreen(pbTask.ClientRectangle), oldTaskName, currentModule);
                oldTaskName = lName.Text;
                pnlEdited.Visible = true;
                timer1.Enabled = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pnlEdited.Visible = false;
        }

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сменить пользователя? Данные не будут сохранены." + Environment.NewLine + "Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.fLogin.WindowState = Program.fAllIdeas.WindowState;
                Program.fLogin.Size = Program.fAllIdeas.Size;
                Program.fLogin.Location = Program.fAllIdeas.Location;
                Program.fLogin.tbLogin.Text = "Фамилия и имя";
                Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
                Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                Program.fLogin.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fEditTask);
            Program.fEditTask.Show();
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
    }
}

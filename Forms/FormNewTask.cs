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
            ofd.Title = "Выберите изображение";
            ofd.Filter = "Файлы изображения|*.jpg; *jpeg; *bmp; *png;";
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
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }
    }
}

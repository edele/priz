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

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Text.RegularExpressions;

namespace PRIZ
{
    public partial class FormNewModule : Form
    {
        bool error = false;
        bool def = true;
        public static string _currentModuleName;
        OpenFileDialog ofd = new OpenFileDialog();

        public FormNewModule()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            pnlWhite.Visible = false;
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
            else {
                pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
                pbImage.Image = Properties.Resources.iconimage;
                def = true;
            }
        }
        static string _earlierText;
        static string _earlierText2;
        private void txtFrom_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text=="Название модуля")
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

        private void descFrom_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "Описание модуля")
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

        private void btnCreateModule_Click(object sender, EventArgs e)
        {
            if (tbModuleName.Text == "" || tbModuleName.Text == "Название модуля" || tbDescription.Text == "Описание модуля")
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else
            {
                if (!error)
                {
                    _currentModuleName = tbModuleName.Text;
                    NewModule newModule = new NewModule(tbModuleName.Text, tbDescription.Text, pbImage.RectangleToScreen(pbImage.ClientRectangle));
                    pnlWhite.Visible = true;
                    pnlWhite.BringToFront();
                }
            }
        }

        private void btnAnotherModule_Click(object sender, EventArgs e)
        {
            pnlWhite.Visible = false;
            tbModuleName.Text = "";
            pbImage.Image = Properties.Resources.Logo_ShKM;
            pbImage.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void btnAddTasks_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fNewTask);
            Program.fNewTask.Show();
            this.Hide();
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

        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l!=' ')
            {
                e.Handled = true;
            }
        }
    }
}

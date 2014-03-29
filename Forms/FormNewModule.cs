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

namespace PRIZ
{
    public partial class FormNewModule : Form
    {
        public static string _currentModuleName;
        OpenFileDialog ofd = new OpenFileDialog();

        public FormNewModule()
        {
            InitializeComponent();
            pnlWhite.Visible = false;
            ofd.Title = "Выберите изображение";
            ofd.Filter = "Файлы изображения|*.jpg; *jpeg; *bmp; *png;";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImage.Image = Image.FromFile(ofd.FileName);
            }
        }
        static string _earlierText;
        private void txtFrom_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text=="Введите название модуля")
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

        private void btnCreateModule_Click(object sender, EventArgs e)
        {
            if (tbDescription.Text == "" || tbModuleName.Text == "")
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else
            {
                _currentModuleName = tbModuleName.Text;
                NewModule newModule = new NewModule(tbModuleName.Text, tbDescription.Text, pbImage.RectangleToScreen(pbImage.ClientRectangle));
                pnlWhite.Visible = true;
            }
        }

        private void btnAnotherModule_Click(object sender, EventArgs e)
        {
            pnlWhite.Visible = false;
            tbDescription.Text = "";
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
    }
}

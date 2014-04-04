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
    public partial class FormEditModuleEntity : Form
    {
        bool error = false;
        bool def = false;
        OpenFileDialog ofd = new OpenFileDialog();
        Module currentModule = Program.p.currentModule;
        string oldModuleName = Program.p.currentModule._filename;
        public FormEditModuleEntity()
        {
            InitializeComponent();
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            label2.Text = Program.p.CurrentFullName;
            ofd.Title = "Выберите изображение";
            ofd.Filter = "Файлы изображения|*.jpg; *jpeg; *bmp; *png;";
            this.FormClosing += Program.ApplicationQuit;
            //this.Size = Program.currentSize;
            //this.Location = Program.currentLocation;
            pbModule.ImageLocation = currentModule._pic;
            lDescription.Text = currentModule._annotation;
            lName.Text = currentModule._name;

            btnSaveChanges.Enabled = false;
            btnSaveChanges.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
        }

        private void pbModule_Click(object sender, EventArgs e)
        {
            var t = ofd.ShowDialog();
            if (t == DialogResult.OK)
            {
                pbModule.SizeMode = PictureBoxSizeMode.Zoom;
                currentModule._filename = Program.p.currentModule._filename;
                pbModule.Image = Image.FromFile(ofd.FileName);
                def = false;
            }
            else if (t == DialogResult.Cancel)
            {
                pbModule.Image = Properties.Resources.iconimage;
                def = true;
            }
        }
        private void pbImage_MouseEnter(object sender, EventArgs e)
        {
            if (def)
            {
                pbModule.Image = Properties.Resources.iconimage_hover;
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
        private void pbImage_MouseLeave(object sender, EventArgs e)
        {
            if (def)
            {
                pbModule.Image = Properties.Resources.iconimage;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                currentModule._filename = Program.p.currentModule._filename;
                NewModule newModule = new NewModule(lName.Text, lDescription.Text, pbModule.RectangleToScreen(pbModule.ClientRectangle), oldModuleName);
                oldModuleName = lName.Text;
                pnlEdited.Visible = true;
                timer1.Enabled = true;
                btnSaveChanges.Enabled = false;
                btnSaveChanges.BackColor = Color.FromArgb(226, 226, 226);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pnlEdited.Visible = false;
        }

        private void btnEditTasks_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fEditTask);
            Program.fEditTask.Show();

            this.Hide();
        }
        private void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if (l=='\\' ||  l=='/' ||  l==':' ||  l=='*' ||  l=='?' ||  l=='"' ||  l=='<' ||  l=='>' ||  l=='|')
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

        private void lName_TextChanged(object sender, EventArgs e)
        {
            btnSaveChanges.Enabled = true;
            btnSaveChanges.BackColor = Color.FromArgb(103, 103, 103);
        }
    }
}

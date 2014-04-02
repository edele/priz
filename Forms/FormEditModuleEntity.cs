﻿using System;
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
            ofd.Title = "Выберите изображение";
            ofd.Filter = "Файлы изображения|*.jpg; *jpeg; *bmp; *png;";
            this.FormClosing += Program.ApplicationQuit;
            //this.Size = Program.currentSize;
            //this.Location = Program.currentLocation;
            pbModule.ImageLocation = currentModule._pic;
            lDescription.Text = currentModule._annotation;
            lName.Text = currentModule._name;
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
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != ' ')
            {
                e.Handled = true;
            }
        }
    }
}

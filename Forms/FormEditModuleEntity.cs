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
    public partial class FormEditModuleEntity : Form
    {
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
            lDescription.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            lDescription.Size = new System.Drawing.Size(360, 216);
            lDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            lName.Text = currentModule._name;
            lName.Size = lDescription.Size;
            lName.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            lName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
        }

        private void pbModule_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbModule.SizeMode = PictureBoxSizeMode.StretchImage;
                pbModule.Image = Image.FromFile(ofd.FileName);
                def = false;
            }
        }

        private void bDeleteImage_Click(object sender, EventArgs e)
        {
            pbModule.Image = Properties.Resources.iconimage;
            def = true;
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
            NewModule newModule = new NewModule(lName.Text,lDescription.Text,pbModule.RectangleToScreen(pbModule.ClientRectangle),oldModuleName);
            pnlEdited.Visible = true;
            timer1.Enabled = true;
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
    }
}

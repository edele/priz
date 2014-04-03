using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PRIZ
{
    public partial class FormModule : Form
    {
        List<Module> modules;
        public FormModule()
        {
            InitializeComponent();
            this.Size = Program.currentSize;
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            this.Location = Program.currentLocation;
            this.FormClosing += Program.ApplicationQuit;
            lName.Text = Program.p.CurrentFullName;
            string status = Program.p.CurrentUser._status;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);
            if (status=="Учитель")
            {
                btnAddTask.Visible = true;
            }
            string[] modulePaths = Directory.GetDirectories(@"modules");
            /* read */
            modules = new List<Module>();
            foreach (string path in modulePaths)
            {
                string name = "";
                string[] pathParts = path.Split('\\');
                name = pathParts[pathParts.Length - 1];
                modules.Add(new Module(name));
            }

            /* front end */
            int ypos = 10;
            for (int i = 0; i < modules.Count; i++)
            {
                Label title = new Label();
                Label description = new Label();
                PictureBox pbox = new PictureBox();

                pbox.Location = new Point(0, ypos);
                pbox.Size = new Size(430, 270);
                pbox.ImageLocation = modules[i]._pic;

                title.AutoSize = true;
                title.Location = new Point(440, ypos);
                title.Text = modules[i]._name;
                title.Font = new System.Drawing.Font("Segoe UI Light", 17F);
                title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
                title.MaximumSize = new System.Drawing.Size(373, 0);
                title.Click += pbox_Click;
                title.Cursor = System.Windows.Forms.Cursors.Hand;
                title.Tag = i;

                description.AutoSize = true;
                description.Location = new Point(440, ypos + 30);
                description.Text = modules[i]._annotation;
                description.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
                description.MaximumSize = new System.Drawing.Size(340, 0);
                description.Click += pbox_Click;
                description.Cursor = System.Windows.Forms.Cursors.Hand;
                description.Tag = i;
                             

                pbox.Click += pbox_Click;
                pbox.Cursor = System.Windows.Forms.Cursors.Hand;
                pbox.Tag = i;
               

                Panel panel = new Panel();
                panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
                panel.Size = new Size(355, 270);
                panel.Location = new Point(430, ypos);

                panelForElements.Controls.Add(title);
                panelForElements.Controls.Add(description);
                panelForElements.Controls.Add(pbox);
                panelForElements.Controls.Add(panel);

                // Если название не помещается в одну строку, то сдвигаем описание ниже
                description.Location = new Point(description.Location.X, description.Location.Y + (title.Size.Height - 31));
                ypos += 300;
            }
            panelForElements.Focus();
        }

        private void tb_MouseWheel(object sender, EventArgs e)
        {
            panelForElements.Focus();
        }
        void pbox_Click(object sender, EventArgs e)
        {
            if (sender.GetType().ToString() == "System.Windows.Forms.PictureBox")
            {
                /*Program.fTasks.WindowState = Program.fModules.WindowState;
                Program.fTasks.Size = Program.fModules.Size;
                Program.fTasks.Location = Program.fModules.Location;*/
                PictureBox pbox = sender as PictureBox;
                Program.p.currentModule = modules[int.Parse(pbox.Tag.ToString())];
                Program.InitWindow(Forms.fTasks);
                Program.fTasks.Show();
                this.Hide();
            }
            if (sender.GetType().ToString() == "System.Windows.Forms.Label")
            {
                /*Program.fTasks.WindowState = Program.fModules.WindowState;
                Program.fTasks.Size = Program.fModules.Size;
                Program.fTasks.Location = Program.fModules.Location;*/
                Label pbox = sender as Label;
                Program.p.currentModule = modules[int.Parse(pbox.Tag.ToString())];
                Program.InitWindow(Forms.fTasks);
                Program.fTasks.Show();
                this.Hide();
            }
        }

        #region events

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
#endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.fLogin.Show();
            this.Hide();
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutCreativeSchool);
            Program.fAboutCreativeSchool.ShowDialog();
        }
        private void tbForText_SizeChanged(object sender, EventArgs e)
        {
            panelForElements.Size = new Size(panelForElements.Size.Width, this.Size.Height-170);
            Program.currentSize = this.Size;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutProgramm);
            Program.fAboutProgramm.ShowDialog();
        }

        private void btnWriteToUs_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fMailSender);
            Program.fMailSender.ShowDialog();
        }

        private void btnLogoEducationEra_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutEducation);
            Program.fAboutEducation.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Program.fLogin.WindowState = Program.fModules.WindowState;
            Program.fLogin.Size = Program.fModules.Size;
            Program.fLogin.Location = Program.fModules.Location;*/
            Program.fLogin.tbLogin.Text = "Фамилия и имя";
            Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
            Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            Program.InitWindow(Forms.fLogin);
            Program.fLogin.Show();
            this.Hide();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            /*Program.fLogin.WindowState = Program.fModules.WindowState;
            Program.fLogin.Size = Program.fModules.Size;
            Program.fLogin.Location = Program.fModules.Location;*/
            Program.InitWindow(Forms.fLogin);
            Program.fLogin.Show();
            this.Hide();
        }

        private void FormModule_Load(object sender, EventArgs e)
        {
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            this.WindowState = Program.currentWindowState;
        }

        private void FormModule_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState != Program.currentWindowState)
            {
                Program.currentWindowState = this.WindowState;
            }
            Program.currentLocation = this.Location;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fModuleEditor);
            Program.fModuleEditor.Show();
            this.Hide();
        }

    }
}

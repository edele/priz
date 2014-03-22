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
    public partial class FormTasks : Form
    {
        List<Task> tasks;
        public FormTasks()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            lblTitleModule.Text = Program.p.currentModule._name;
            lblTitleModule.Font = new System.Drawing.Font("Segoe UI Light", 21F);
            lblTitleModule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            lName.Text = Program.p.CurrentFullName;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);

            string[] modulePaths = Directory.GetDirectories(@"modules/" + Program.p.currentModule._filename + @"/");

            // read 
            tasks = new List<Task>();
            /*Task task01 = new Task("Космические шаттлы", "Есть шаттлы и космос", "Найдите ответ на все вопросы"); //(string name, string given, string toFind)
            task01._description = "Эта задача про космос и шаттлы";
            Task task02 = new Task("Космические звезды", "Есть звезды и космос", "Найдите ответ на все вопросы про здвезды"); //(string name, string given, string toFind)
            task02._description = "Задача о звездах и космос";*/

            //tasks.Add(task01);
            //tasks.Add(task02);
            for (int i = 0; i < modulePaths.Length; i++)
            {
                // MessageBox.Show(modulePaths[i] + @"/main.xml");
                Task tempTask = new Task(modulePaths[i] + @"/main.xml");
                tempTask._path = modulePaths[i] + @"/";
                tasks.Add(tempTask);
            }
            int ypos = 10;

            for (int i = 0; i < tasks.Count; i++)
            {
                Label title = new Label();
                Label description = new Label();
                PictureBox pbox = new PictureBox();

                pbox.Location = new Point(0, ypos);
                pbox.Size = new Size(430, 270);
                pbox.ImageLocation = tasks[i]._path + "mainpic.png";
                pbox.BackgroundImageLayout = ImageLayout.Stretch;


                title.AutoSize = true;
                title.Location = new Point(440, ypos);
                title.Text = tasks[i]._name;
                title.Font = new System.Drawing.Font("Segoe UI Light", 17F);
                title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
                title.MaximumSize = new System.Drawing.Size(373, 0);
                title.Cursor = Cursors.Hand;
                title.Tag = i;

                description.AutoSize = true;
                description.Location = new Point(440, ypos + 30);
                description.Text = tasks[i]._description;
                description.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
                description.MaximumSize = new System.Drawing.Size(340, 0);
                description.Cursor = Cursors.Hand;
                description.Tag = i;

                title.Click += pbox_Click;
                description.Click += pbox_Click;
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
            //MessageBox.Show(sender.GetType().ToString());
            if (sender.GetType().ToString() == "System.Windows.Forms.PictureBox")
            {
                PictureBox pbox = sender as PictureBox;
                Program.p.currentTask = tasks[int.Parse(pbox.Tag.ToString())];
                Program.InitWindow(Forms.fTask);
                Program.fTask.Show();
                this.Hide();
            }
            if (sender.GetType().ToString() == "System.Windows.Forms.Label")
            {
                Label pbox = sender as Label;
                Program.p.currentTask = tasks[int.Parse(pbox.Tag.ToString())];
                Program.InitWindow(Forms.fTask);
                Program.fTask.Show();
                this.Hide();
            }
        }
        #region events

        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back02;
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back01;
        }
        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back03;
        }
        private void btnBack_MouseUp(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back02;
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
       /* private void btnMyTasks_MouseDown(object sender, MouseEventArgs e)
        {
            btnMyTasks.Image = Properties.Resources.mytasks03;
        }
        private void btnMyTasks_MouseEnter(object sender, EventArgs e)
        {
            btnMyTasks.Image = Properties.Resources.mytasks02;
        }
        private void btnMyTasks_MouseLeave(object sender, EventArgs e)
        {
            btnMyTasks.Image = Properties.Resources.mytasks01;
        }
        private void btnMyTasks_MouseUp(object sender, MouseEventArgs e)
        {
            btnMyTasks.Image = Properties.Resources.mytasks02;
        }
        */ 
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
            Program.fModules.Show();
            this.Hide();
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutCreativeSchool);
            //this.Hide();
            Program.fAboutCreativeSchool.ShowDialog();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fModules);
            Program.fModules.Show();
            this.Hide();
        }
        private void tbForText_SizeChanged(object sender, EventArgs e)
        {
            panelForElements.Size = new Size(panelForElements.Size.Width, this.Size.Height - 170);
            Program.currentSize = this.Size;
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

        private void btnLogoEducationEra_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutEducation);
            //this.Hide();
            Program.fAboutEducation.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.fLogin.tbLogin.Text = "Фамилия и имя";
                Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
                Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                Program.fLogin.Show();
                this.Hide();
           
        }

        private void Form_VisibleChangedOrLoad(object sender, EventArgs e)
        {
            this.Location = Program.currentLocation;
            this.Size = Program.currentSize;
        }

        private void Form_LocationChanged(object sender, EventArgs e)
        {
            if (this.WindowState != Program.currentWindowState)
            {
                Program.currentWindowState = this.WindowState;
            }
            Program.currentLocation = this.Location;
        }

    }
}

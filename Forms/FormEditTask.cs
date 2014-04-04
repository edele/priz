using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PRIZ
{
    public partial class FormEditTask : Form
    {
        List<Task> tasks;
        public FormEditTask()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            label2.Text = Program.p.CurrentFullName;
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

            PictureBox addTask = new PictureBox();
            addTask.Cursor = Cursors.Hand;
            addTask.Size = new Size(780, 170);
            addTask.Location = new Point(0, ypos + 20);
            addTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            addTask.MouseEnter += new EventHandler(addTask_MouseEnter);
            addTask.MouseLeave += new EventHandler(addTask_MouseLeave);
            addTask.Click += new EventHandler(addTask_Click);
            addTask.Image = Properties.Resources.add_task;
            addTask.SizeMode = PictureBoxSizeMode.CenterImage;
            panelForElements.Controls.Add(addTask);
            ypos += 200;
            for (int i = 0; i < tasks.Count; i++)
            {
                Button btnDeleteTask = new Button();
                Button btnEditTaskEntity = new Button();
                Label title = new Label();
                Label description = new Label();
                PictureBox pbox = new PictureBox();

                pbox.Location = new Point(0, ypos);
                pbox.Size = new Size(430, 270);
                pbox.ImageLocation = tasks[i]._path + "mainpic.png";
                pbox.Cursor = Cursors.Hand;
                pbox.BorderStyle = BorderStyle.FixedSingle;

                title.Location = new Point(440, ypos);
                title.Text = tasks[i]._name;
                title.Font = new System.Drawing.Font("Segoe UI Light", 17F);
                title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                title.Size = new System.Drawing.Size(340, 43);
                title.Tag = i;
                title.Cursor = Cursors.Hand;

                description.Location = new Point(440, ypos + 40);
                description.Text = tasks[i]._description;
                description.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                description.Size = new System.Drawing.Size(340, 189);
                description.Tag = i;
                description.Cursor = Cursors.Hand;

                btnEditTaskEntity.Text = "Редактировать задание";
                btnEditTaskEntity.Location = new Point(448, ypos + 238);
                btnEditTaskEntity.Size = new Size(162, 31);
                btnEditTaskEntity.Anchor = System.Windows.Forms.AnchorStyles.Top;
                btnEditTaskEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnEditTaskEntity.Cursor = System.Windows.Forms.Cursors.Hand;
                btnEditTaskEntity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnEditTaskEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEditTaskEntity.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                btnEditTaskEntity.ForeColor = System.Drawing.Color.White;
                btnEditTaskEntity.UseVisualStyleBackColor = false;
                btnEditTaskEntity.Click += new EventHandler(btnEditTaskEntity_Click);
                btnEditTaskEntity.Tag = i;


                btnDeleteTask.Text = "Удалить задание";
                btnDeleteTask.Location = new Point(624, ypos + 238);
                btnDeleteTask.Size = new Size(162, 31);
                btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
                btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
                btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnDeleteTask.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                btnDeleteTask.ForeColor = System.Drawing.Color.White;
                btnDeleteTask.UseVisualStyleBackColor = false;
                btnDeleteTask.Click += new EventHandler(btnDeleteTask_Click);
                btnDeleteTask.Tag = i;

                panelForElements.Controls.Add(title);
                panelForElements.Controls.Add(description);
                panelForElements.Controls.Add(pbox);
                panelForElements.Controls.Add(btnEditTaskEntity);
                panelForElements.Controls.Add(btnDeleteTask);


                // Если название не помещается в одну строку, то сдвигаем описание ниже
                // description.Location = new Point(description.Location.X, description.Location.Y + (title.Size.Height - 31));
                ypos += 300;
            }
            panelForElements.Focus();
            
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
        void addTask_Click(object sender, EventArgs e)
        {
            FormNewModule._currentModuleName = Program.p.currentModule._filename;
            Program.InitWindow(Forms.fNewTask);
            Program.fNewTask.Show();
            bool b = true;
            Program.fNewTask.GetPlace(b);
            this.Hide();
        }

        void addTask_MouseLeave(object sender, EventArgs e)
        {
            PictureBox addTask = sender as PictureBox;
            addTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
        }

        void addTask_MouseEnter(object sender, EventArgs e)
        {
            PictureBox addTask = sender as PictureBox;
            addTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(173)))), ((int)(((byte)(173)))));
        }

        void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Button btnDelete = sender as Button;
            Program.p.currentTask = tasks[int.Parse(btnDelete.Tag.ToString())];
            FormDeleteConformTask frm = new FormDeleteConformTask();
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frm.Close();
            }
            else if (dr == DialogResult.OK)
            {
                frm.Close();
                DirectoryInfo dir = new DirectoryInfo(@"modules\" + Program.p.currentModule._filename + @"\" + Program.p.currentTask._name);
                dir.Delete(true);
                Program.InitWindow(Forms.fEditTask);
                Program.fEditTask.Show();
                this.Hide();
            }  
        }

        void btnEditTaskEntity_Click(object sender, EventArgs e)
        {
            if (sender.GetType().ToString() == "System.Windows.Forms.Button")
            {
                Button button = sender as Button;
                Program.p.currentTask = tasks[int.Parse(button.Tag.ToString())];
                Program.InitWindow(Forms.fEditTaskEntity);
                Program.fEditTaskEntity.Show();
                this.Hide();
            }
            if (sender.GetType().ToString() == "System.Windows.Forms.PictureBox")
            {
                PictureBox button = sender as PictureBox;
                Program.p.currentTask = tasks[int.Parse(button.Tag.ToString())];
                Program.InitWindow(Forms.fEditTaskEntity);
                Program.fEditTaskEntity.Show();
                this.Hide();
            }
            if (sender.GetType().ToString() == "System.Windows.Forms.Label")
            {
                Label button = sender as Label;
                Program.p.currentTask = tasks[int.Parse(button.Tag.ToString())];
                Program.InitWindow(Forms.fEditTaskEntity);
                Program.fEditTaskEntity.Show();
                this.Hide();
            }
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
                Program.InitWindow(Forms.fEditTaskEntity);
                Program.fEditTaskEntity.Show();
                this.Hide();
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
            Program.InitWindow(Forms.fEditModuleEntity);
            Program.fEditModuleEntity.Show();
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

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
                Button btnDeleteTask = new Button();
                Button btnEditTaskEntity = new Button();
                Label title = new Label();
                Label description = new Label();
                PictureBox pbox = new PictureBox();

                pbox.Location = new Point(0, ypos);
                pbox.Size = new Size(430, 270);
                pbox.ImageLocation = tasks[i]._path + "mainpic.png";
                pbox.BackgroundImageLayout = ImageLayout.Stretch;

                title.Location = new Point(440, ypos);
                title.Text = tasks[i]._name;
                title.Font = new System.Drawing.Font("Segoe UI Light", 17F);
                title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                title.Size = new System.Drawing.Size(340, 43);
                title.Tag = i;

                description.Location = new Point(440, ypos + 40);
                description.Text = tasks[i]._description;
                description.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                description.Size = new System.Drawing.Size(340, 189);
                description.Tag = i;

                btnEditTaskEntity.Text = "Редактировать задание";
                btnEditTaskEntity.Location = new Point(448, ypos + 245);
                btnEditTaskEntity.Size = new Size(162, 31);
                btnEditTaskEntity.Anchor = System.Windows.Forms.AnchorStyles.Top;
                btnEditTaskEntity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnEditTaskEntity.Cursor = System.Windows.Forms.Cursors.Hand;
                btnEditTaskEntity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnEditTaskEntity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEditTaskEntity.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                btnEditTaskEntity.ForeColor = System.Drawing.Color.White;
                btnEditTaskEntity.UseVisualStyleBackColor = false;
                //btnDone.Click += new System.EventHandler(this.btnEditTask_Click);
                btnEditTaskEntity.Tag = i;


                btnDeleteTask.Text = "Удалить задачу";
                btnDeleteTask.Location = new Point(624, ypos + 245);
                btnDeleteTask.Size = new Size(162, 31);
                btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.Top;
                btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
                btnDeleteTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnDeleteTask.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                btnDeleteTask.ForeColor = System.Drawing.Color.White;
                btnDeleteTask.UseVisualStyleBackColor = false;
                //btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
                btnDeleteTask.Tag = i;

                pbox.Click += pbox_Click;
                pbox.Cursor = System.Windows.Forms.Cursors.Hand;
                pbox.Tag = i;

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
        }
    }
}

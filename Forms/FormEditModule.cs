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
    public partial class FormEditModule : Form
    {
        
        List<Module> modules;
        public FormEditModule()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);
            this.FormClosing += Program.ApplicationQuit;
            string[] modulePaths = Directory.GetDirectories(@"modules");
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
                Button btnDeleteModule = new Button();
                Button btnEditModule = new Button();
                Label title = new Label();
                Label description = new Label();
                PictureBox pbox = new PictureBox();

                pbox.Location = new Point(0, ypos);
                pbox.Size = new Size(430, 270);
                pbox.ImageLocation = modules[i]._pic;

                title.Location = new Point(437, ypos);
                title.Text = modules[i]._name;
                title.Font = new System.Drawing.Font("Segoe UI Light", 17F);
                title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                title.Size = new System.Drawing.Size(340, 43);
                title.Tag = i;

                description.Location = new Point(440, ypos + 32);
                description.Text = modules[i]._annotation;
                description.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                description.Size = new System.Drawing.Size(340, 189);
                description.Tag = i;
                description.Click += new EventHandler(description_Click);

                btnEditModule.Text = "Редактировать модуль";
                btnEditModule.Location = new Point(448, ypos + 237);
                btnEditModule.Size = new Size(162, 31);
                btnEditModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
                btnEditModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnEditModule.Cursor = System.Windows.Forms.Cursors.Hand;
                btnEditModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnEditModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnEditModule.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                btnEditModule.ForeColor = System.Drawing.Color.White;
                btnEditModule.UseVisualStyleBackColor = false;
                btnEditModule.Click += new System.EventHandler(this.btnEditModule_Click);
                btnEditModule.Tag = i;

                btnDeleteModule.Text = "Удалить модуль";
                btnDeleteModule.Location = new Point(624, ypos + 237);
                btnDeleteModule.Size = new Size(162, 31);
                btnDeleteModule.Anchor = System.Windows.Forms.AnchorStyles.Top;
                btnDeleteModule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnDeleteModule.Cursor = System.Windows.Forms.Cursors.Hand;
                btnDeleteModule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnDeleteModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btnDeleteModule.Font = new System.Drawing.Font("Segoe UI Light", 10F);
                btnDeleteModule.ForeColor = System.Drawing.Color.White;
                btnDeleteModule.UseVisualStyleBackColor = false;
                btnDeleteModule.Click += new System.EventHandler(this.btnDeleteTask_Click);
                btnDeleteModule.Tag = i;

                pbox.Tag = i;

                panelForElements.Controls.Add(title);
                panelForElements.Controls.Add(description);
                panelForElements.Controls.Add(pbox);
                panelForElements.Controls.Add(btnDeleteModule);
                panelForElements.Controls.Add(btnEditModule);

                // Если название не помещается в одну строку, то сдвигаем описание ниже
                description.Location = new Point(description.Location.X, description.Location.Y + (title.Size.Height - 31));
                ypos += 300;
                }
            panelForElements.Focus();
            }


        void description_Click(object sender, EventArgs e)
        {
            Label description = sender as Label;
            Program.p.currentModule = modules[int.Parse(description.Tag.ToString())];
        }
        void tbDescriotion_LostFocus(object sender, EventArgs e)
        {
            TextBox description = sender as TextBox;
            Program.p.currentModule = modules[int.Parse(description.Tag.ToString())];
            Label lbDescription = new Label();
            lbDescription.Size = description.Size;
            lbDescription.Location = description.Location;
            lbDescription.Font = description.Font;
            lbDescription.ForeColor = description.ForeColor;
            lbDescription.Text = description.Text;
            lbDescription.Tag = description.Tag;
            lbDescription.Cursor = System.Windows.Forms.Cursors.Hand;
            lbDescription.Click += new EventHandler(description_Click);
            description.Hide();
            panelForElements.Controls.Add(lbDescription);
        }

            void btnEditModule_Click(object sender, EventArgs e) 
            {
                Button btnEditTask = sender as Button;
                Program.p.currentModule = modules[int.Parse(btnEditTask.Tag.ToString())];
                Program.InitWindow(Forms.fEditModuleEntity);
                Program.fEditModuleEntity.Show();
                this.Hide();
            }
            void btnDeleteTask_Click(object sender, EventArgs e)
            {
                Button btnDelete = sender as Button;
                Program.p.currentModule = modules[int.Parse(btnDelete.Tag.ToString())];
                FormDeleteConform frm = new FormDeleteConform();
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    frm.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    frm.Close();
                    DirectoryInfo dir = new DirectoryInfo(@"modules\" + Program.p.currentModule._filename); 
                    dir.Delete(true);
                    Program.InitWindow(Forms.fEditModule);
                    Program.fEditModule.Show();
                    this.Hide();
                }  
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
            private void tb_MouseWheel(object sender, EventArgs e)
            {
                panelForElements.Focus();
            }
        }
    }


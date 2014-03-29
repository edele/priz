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
        }
    }


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    class ModuleFormElement
    {
        Panel _mainPanel;
        Panel _titlePanel;
        Label _titleLabel;
        Label _descriptionLabel;

       
        public ModuleFormElement(int x, int y, string imagePath, string title, string description, int i)
        {
            _mainPanel = new Panel();
            _mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            _mainPanel.BackgroundImageLayout = ImageLayout.None;
            _mainPanel.Location = new Point(x,y);
            _mainPanel.Size = new Size(246, 216);
            _mainPanel.BackgroundImage = Image.FromFile(imagePath);
            _mainPanel.Click += new EventHandler(_mainPanel_Click);
            _mainPanel.MouseEnter += new EventHandler(_mainPanel_MouseEnter);
            _mainPanel.Name = "genetatedPanel" + i;
            _mainPanel.Tag = i;
            _mainPanel.Cursor = Cursors.Hand;

            _titlePanel = new Panel();
            _titlePanel.BackColor = System.Drawing.Color.Transparent;
            _titlePanel.BackgroundImage = global::PRIZ.Properties.Resources.transparentpixel70;
            _titlePanel.Location = new System.Drawing.Point(6, 128);
            _titlePanel.Size = new System.Drawing.Size(236, 31);
            _titlePanel.Click += new EventHandler(_mainPanel_Click);
            _titlePanel.Tag = i;


            _titleLabel = new Label();
            _titleLabel.AutoSize = true;
            _titleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _titleLabel.Location = new System.Drawing.Point(7, 5);
            _titleLabel.Size = new System.Drawing.Size(158, 20);
            _titleLabel.Text = title;
            _titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            _titleLabel.Click += new EventHandler(_titleLabel_Click);
            _titleLabel.Tag = i;


            _descriptionLabel = new Label();
            _descriptionLabel.AutoSize = true;
            _descriptionLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            _descriptionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            _descriptionLabel.Location = new System.Drawing.Point(5, 169);
            _descriptionLabel.MaximumSize = new System.Drawing.Size(240, 40);
            _descriptionLabel.Size = new System.Drawing.Size(236, 39);
            _descriptionLabel.Text = description;
            _descriptionLabel.Click += new EventHandler(_titleLabel_Click);
            _descriptionLabel.Tag = i;
        }

        void _mainPanel_MouseEnter(object sender, EventArgs e)
        {
        }

        void _titleLabel_Click(object sender, EventArgs e)
        {
            Label p = sender as Label;
            int i = (int)p.Tag;
            MessageBox.Show(i.ToString());
        }

        void _mainPanel_Click(object sender, EventArgs e)
        {
            Panel p = sender as Panel;
            int i = (int)p.Tag;
            MessageBox.Show(i.ToString());
        }
        public void PlaceOnForm(Panel panel)
        {
            panel.Controls.Add(_mainPanel);
            _mainPanel.Controls.Add(_titlePanel);
            _mainPanel.Controls.Add(_descriptionLabel);
            _titlePanel.Controls.Add(_titleLabel);
        }
    }
}

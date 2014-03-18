using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    public partial class FormShowAllIdeas : Form
    {
        Answer answer = Program.p.answer;
        public FormShowAllIdeas()
        {
            InitializeComponent();
            for (int i = 0; i < answer._hypothesises.Count; i++)
            {
                lShowAllIdeas.Items.Add(answer._hypothesises[i].ToString());
            }
        }

        private void lShowAllIdeas_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 13 + (13 * GetLinesNumbers((string)lShowAllIdeas.Items[e.Index]));
        }

        private void lShowAllIdeas_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(
                 (string)lShowAllIdeas.Items[e.Index],
                 e.Font,
                 new SolidBrush(e.ForeColor),
                 e.Bounds);
        }

        private int GetLinesNumbers(string text)
        {
            int count = 1;
            for (int i = 0; i < text.Length / 75; i++)
            {
                count++;
            }
            return count;
        }

        private void btnEditIdea_Click(object sender, EventArgs e)
        {
            if ((tbEditIdea.TextLength > 0) && (lShowAllIdeas.SelectedIndex != -1))
            {
                int i = lShowAllIdeas.SelectedIndex;
                lShowAllIdeas.Items.RemoveAt(i);
                lShowAllIdeas.Items.Insert(i, tbEditIdea.Text);
                tbEditIdea.Clear();
            }
            else if (lShowAllIdeas.SelectedIndex < 0)
            {
                MessageBox.Show("Вы не выберали идею для редактирования");
            }
            else
            {
                tbEditIdea.Text = "Сначала запишите идею в этот блок";
                tbEditIdea.ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
            }
        }

        private void btnRemoveIdea_Click(object sender, EventArgs e)
        {
            lShowAllIdeas.Items.Remove(lShowAllIdeas.SelectedItem);
        }
        static string _earlierText;
        private void tbEditIdea_Enter(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text=="Сначала запишите идею в этот блок")
            {
                _earlierText = (sender as TextBox).Text;
                (sender as TextBox).Text = "";
            }
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void tbEditIdea_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as TextBox).Text = _earlierText;
            }
        }

        private void FormShowAllIdeas_FormClosing(object sender, FormClosingEventArgs e)
        {
            answer._hypothesises.Clear();
            for (int i = 0; i < lShowAllIdeas.Items.Count; i++)
            {
                answer._hypothesises.Add(lShowAllIdeas.Items[i].ToString());
            }
        }
    }
}

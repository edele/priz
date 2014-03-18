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
            btnEditIdea.Enabled = false;
            btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
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
        FormEditIdea frm2;
        private void btnEditIdea_Click(object sender, EventArgs e)
        {
            answer._currentIndex = lShowAllIdeas.SelectedIndex;
            frm2 = new FormEditIdea();
            frm2._text = lShowAllIdeas.SelectedItem.ToString();
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                frm2.Close();
                lShowAllIdeas.Items.RemoveAt(answer._currentIndex);
                lShowAllIdeas.Items.Insert(answer._currentIndex, frm2.GetText());
            }  
        }

        private void btnRemoveIdea_Click(object sender, EventArgs e)
        {
            lShowAllIdeas.Items.Remove(lShowAllIdeas.SelectedItem);
        }

        private void FormShowAllIdeas_FormClosing(object sender, FormClosingEventArgs e)
        {
            answer._hypothesises.Clear();
            for (int i = 0; i < lShowAllIdeas.Items.Count; i++)
            {
                answer._hypothesises.Add(lShowAllIdeas.Items[i].ToString());
            }
            Program.fPhenomenas.RefreshlIdeas();
        }

        private void lShowAllIdeas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lShowAllIdeas.SelectedIndex < 0)
            {
                btnEditIdea.Enabled = false;
                btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            }
            else
            {
                btnEditIdea.Enabled = true;
                btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace PRIZ
{
    public partial class FormAllIdeas : Form
    {
        Answer answer = Program.p.answer;
        public FormAllIdeas()
        {
            InitializeComponent();
            this.FormClosing += Program.ApplicationQuit;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            lbUserName.Text = Program.p.CurrentFullName;
            lGiven.Text = answer._givenByUser;
            lToFind.Text = answer._ToFindByUser;
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            btnEditIdea.Enabled = false;
            btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            btnRemoveIdea.Enabled = false;
            btnRemoveIdea.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Program.p.GenerateReport(answer);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            answer._comment = tbComment.Text;
            answer._hypothesises.Clear();
            for (int i = 0; i < lAllHypo.Items.Count; i++)
            {
                answer._hypothesises.Add(lAllHypo.Items[i].ToString());
            }
            Program.p.GenerateTxtReport(answer);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutCreativeSchool);
            Program.fAboutCreativeSchool.ShowDialog();
        }

        private void btnModules_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите перейти в модули? Данные не будут сохранены.\r\n Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.InitWindow(Forms.fModules);
                Program.fModules.WindowState = Program.fAllIdeas.WindowState;
                Program.fModules.Size = Program.fAllIdeas.Size;
                Program.fModules.Location = Program.fAllIdeas.Location;
                answer._hypothesises.Clear();
                answer._givenByUser = "";
                answer._ToFindByUser = "";
                Program.fModules.Show();
                this.Hide();
            }
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите сменить пользователя? Данные не будут сохранены." + Environment.NewLine + "Продолжить?", "Подтверждение", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.fLogin.WindowState = Program.fAllIdeas.WindowState;
                Program.fLogin.Size = Program.fAllIdeas.Size;
                Program.fLogin.Location = Program.fAllIdeas.Location;
                answer._hypothesises.Clear();
                Program.fLogin.tbLogin.Text = "Фамилия и имя";
                Program.fLogin.tbLogin.Font = new System.Drawing.Font("Segoe UI", 10.75F);
                Program.fLogin.tbLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                Program.fLogin.Show();
                this.Hide();
            }
        }

        private void FormAllIdeas_Load(object sender, EventArgs e)
        {
            this.Location = Program.currentLocation;
            this.Size = Program.currentSize;
            for (int i = 0; i < answer._hypothesises.Count; i++)
            {
                lAllHypo.Items.Add(answer._hypothesises[i]);
                
            }
        }
        private void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ХЕУХУЕХУХУ");
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.fPhenomenas.WindowState = Program.fAllIdeas.WindowState;
            Program.fPhenomenas.Size = Program.fAllIdeas.Size;
            Program.fPhenomenas.Location = Program.fAllIdeas.Location;
            this.Hide();
            answer._hypothesises.Clear();
            for (int i = 0; i < lAllHypo.Items.Count; i++)
            {
                answer._hypothesises.Add(lAllHypo.Items[i].ToString());
            }
            Program.fPhenomenas.Show();
            Program.fPhenomenas.RefreshlIdeas();
        }
        private void lAllHypo_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(
                 (string)lAllHypo.Items[e.Index],
                 e.Font,
                 new SolidBrush(e.ForeColor),
                 e.Bounds);
        }
        private void lAllHypo_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            int txtHeight = GetLinesNumber((string)lAllHypo.Items[e.Index]);
            e.ItemHeight = 13 + (13 * txtHeight);
        }

        private int GetLinesNumber(string text)
        {
            int count = 1;
            for (int i = 0; i < text.Length / 65; i++)
            {
                count++;
            }
            return count;
        }
        static string _earlierText;
        FormEditOrAddIdea frm2;
        private void btnEditSelectedItem_Click(object sender, EventArgs e)
        {
            answer._currentIndex = lAllHypo.SelectedIndex;
            frm2 = new FormEditOrAddIdea();
            if (answer._currentIndex != -1)
            {
                frm2._text = lAllHypo.SelectedItem.ToString();
                DialogResult dr = frm2.ShowDialog(this);
                if (dr == DialogResult.Cancel)
                {
                    frm2.Close();
                }
                else if (dr == DialogResult.OK)
                {
                    frm2.Close();
                    lAllHypo.Items.RemoveAt(answer._currentIndex);
                    lAllHypo.Items.Insert(answer._currentIndex, frm2.GetText());
                }  
            }
        }

        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            lAllHypo.Items.Remove(lAllHypo.SelectedItem);
        }

        private void btnAddIdea_Click(object sender, EventArgs e)
        {
            frm2 = new FormEditOrAddIdea();
            frm2._textOnButton = "Добавить";
            DialogResult dr = frm2.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                frm2.Close();
            }
            else if (dr == DialogResult.OK)
            {
                frm2.Close();
                lAllHypo.Items.Add(frm2.GetText());
            }  
        }

        private void tbAddOrEditIdea_Enter(object sender, EventArgs e)
        {

            if ((sender as TextBox).Text == "Сначала запишите идею в этот блок")
            {
                _earlierText = (sender as TextBox).Text;
                (sender as TextBox).Text = "";
            }
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void tbAddOrEditIdea_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as TextBox).Text = _earlierText;
            }
        }

        private void lAllHypo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lAllHypo.SelectedIndex < 0)
            {
                btnEditIdea.Enabled = false;
                btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
                btnRemoveIdea.Enabled = false;
                btnRemoveIdea.BackColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            }
            else
            {
                btnEditIdea.Enabled = true;
                btnEditIdea.BackColor = Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
                btnRemoveIdea.Enabled = true;
                btnRemoveIdea.BackColor = Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(103)))), ((int)(((byte)(103)))));
            }
        }

        private void FormAllIdeas_VisibleChanged(object sender, EventArgs e)
        {
            this.Location = Program.currentLocation;
            this.Size = Program.currentSize;
        }
        private void Form_LocationChanged(object sender, EventArgs e)
        {
            Program.currentLocation = this.Location;
        }

        private void FormAllIdeas_SizeChanged(object sender, EventArgs e)
        {
            Program.currentSize = this.Size;
        }

        private void lAllHypo_MouseDown(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void lAllHypo_MouseUp(object sender, MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }



    }

    public class UserSortableListBox : ListBox
    {
        /// <summary>
        /// Reordered elements indices
        /// </summary>
        public class ReorderEventArgs : EventArgs
        {
            public int index1, index2;
        }
        /// <summary>
        /// Reorder event handler
        /// </summary>
        public delegate void ReorderHandler(object sender, ReorderEventArgs e);
        public event ReorderHandler Reorder;

        // AllowDrop must be set to true in order to make drag'n'drop working
        [Browsable(false)]
        new public bool AllowDrop
        {
            get { return true; }
            set { }

        }
        public UserSortableListBox()
        {
            base.AllowDrop = true;
            base.SelectionMode = SelectionMode.One;
        }

        [Browsable(false)]
        new public SelectionMode SelectionMode
        {
            get { return SelectionMode.One; }
            set { }
        }
        /// <summary>
        /// Index of dragged element
        /// </summary>
        private int sourceIndex = 0;
        protected override void OnDragDrop(DragEventArgs e)
        {
            
            base.OnDragDrop(e);
            Point point = PointToClient(new Point(e.X, e.Y));
            int index = IndexFromPoint(point); // destination index
            // allow DataSource, i.e. BindingList
            IList items = DataSource != null ? DataSource as IList : Items;
            if (index < 0) index = items.Count - 1;
            if (index != sourceIndex)
            {
                if (index > sourceIndex) // destination is below source
                {
                    items.Insert(index + 1, items[sourceIndex]);
                    items.RemoveAt(sourceIndex);
                }
                else // destination is above source
                {
                    items.Insert(index, items[sourceIndex]);
                    items.RemoveAt(sourceIndex + 1);
                }
                if (null != Reorder) Reorder(this, new ReorderEventArgs() { index1 = sourceIndex, index2 = index });
            }
            // selectedIndex was lost during reorder
            SelectedIndex = index;
        }

        protected override void OnDragOver(DragEventArgs e)
        {
            base.OnDragOver(e);
            e.Effect = DragDropEffects.Move | DragDropEffects.Scroll;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (SelectedItem == null)
            {
                return;
            }
            sourceIndex = SelectedIndex;
            // OnSelectedIndexChanged is not launched while using MouseDown :(
            OnSelectedIndexChanged(e);
            DoDragDrop(SelectedItem, DragDropEffects.Move);
        }
    }
}

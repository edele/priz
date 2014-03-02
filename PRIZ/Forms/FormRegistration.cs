using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            //tbStatus.SelectedItem = tbStatus.Items[0];
            //tbStatus.DroppedDown = true;
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            this.FormClosing += Program.ApplicationQuit;
        }
        static string _earlierText;
        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as TextBox).Text = _earlierText;
            }

        }
        
        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            _earlierText = (sender as TextBox).Text;
            (sender as TextBox).Text = "";
            (sender as TextBox).ForeColor = Color.Black;
        }
        private void tbStatus_Enter(object sender, EventArgs e)
        {
            TextBox h = (TextBox)sender;
            if (h.Text == "Статус")
            {
                h.ForeColor = Color.Black;
                h.Text = "";
            }
        }
        private void tbStatus_Leave(object sender, EventArgs e)
        {
            TextBox h = (TextBox)sender;
            if (h.Text == "")
            {
                h.ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                h.Text = "Статус";
            }
        }
        private void btnModules_Click(object sender, EventArgs e)
        {
            Program.fLogin.Show();
            FormLogin.f.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbSurename.Text != "" && tbSurename.Text != "Фамилия" && tbName.Text != "" && tbName.Text != "Имя" && tbPassword.Text != "" && tbPassword.Text != "Фамилия" && tbPassword2.Text != ""
                && tbPassword2.Text != "Имя" && tbCountry.Text != "Страна" && tbCountry.Text != "" && tbStatus.Text != "Статус" && tbStatus.Text != "" && tbAbout.Text != "О себе" && tbAbout.Text != "")
            {
                User user = Program.p.AddNewUser(
                tbName.Text,
                tbAbout.Text,
                tbCountry.Text,
                tbPassword.Text,
                tbStatus.Text,
                tbSurename.Text
                );

                if (tbPassword2.Text == tbPassword.Text)
                {
                    Program.fLogin.RefreshUserList();
                    Program.p.RefreshUsers();
                    MessageBox.Show("Спасибо за регистрацию, " + user._surname + " " + user._name);
                    this.Hide();
                    Program.fLogin.Show();
                }
                else MessageBox.Show("Введенный пароль и его подтверждение не совпадают.");
                
            }
            else MessageBox.Show("Заполните все поля для продолжения работы");
            
        }

        private void btnLogoCreativeThinker_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutCreativeSchool);
            //this.Hide();
            Program.fAboutCreativeSchool.ShowDialog();
        }

        private void btnLogoEducationEra_Click(object sender, EventArgs e)
        {
            Program.InitWindow(Forms.fAboutEducation);
            //this.Hide();
            Program.fAboutEducation.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (!label4.Enabled) return;
            label4.Enabled = false;
            if (sender.GetType().ToString() == "System.Windows.Forms.Label")
            {
                tbStatus.SelectedItem = tbStatus.Items[0];
                tbStatus.DroppedDown = true;
                tbStatus.Focus();
            }

            if (sender.GetType().ToString() == "System.Windows.Forms.ComboBox")
            {
                label4.Enabled = false;
                tbStatus.SelectedItem = tbStatus.Items[0];
                tbStatus.DroppedDown = true;
            }
        }

        private void tbStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            label4.Hide();
        }
    }
}

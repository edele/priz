using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            this.FormClosing += Program.ApplicationQuit;
            // 1) Создаем объект программы. С ним теперь всегда и работаем.
            RefreshUserList();
        }

        public void RefreshUserList()
        {
            var source = new AutoCompleteStringCollection();
            source.AddRange(User.GetUserNames().ToArray());
            tbLogin.AutoCompleteCustomSource = source;
        }

        #region Buttons' hover effects

        private void btnRegistration_MouseEnter(object sender, EventArgs e)
        {
            btnRegistration.BackgroundImage = Properties.Resources.btn_registration_hover;
        }
        private void btnRegistration_MouseLeave(object sender, EventArgs e)
        {
            btnRegistration.BackgroundImage = Properties.Resources.btn_registration;
        }

        private void btnLogoEducationEra_MouseEnter(object sender, EventArgs e)
        {
            btnLogoEducationEra.BackgroundImage = Properties.Resources.logo_educationfornewera_hover;
        }
        private void btnLogoEducationEra_MouseLeave(object sender, EventArgs e)
        {
            btnLogoEducationEra.BackgroundImage = Properties.Resources.logo_educationfornewera;
        }

        private void btnSubmit_MouseEnter(object sender, EventArgs e)
        {
            btnSubmit.BackgroundImage = Properties.Resources.btn_submitt_hover;
        }
        private void btnSubmit_MouseLeave(object sender, EventArgs e)
        {
            btnSubmit.BackgroundImage = Properties.Resources.btn_submitt;
        }
        #endregion

        #region TextBoxes' focus effects
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

        #endregion TextBoxes' focus effects

       
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
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            /*Program.fModules.WindowState = Program.fLogin.WindowState;
            Program.fModules.Size = Program.fLogin.Size;
            Program.fModules.DesktopLocation = Program.fLogin.DesktopLocation;*/
            var users = User.GetListOfObjects();

            for (int i = 0; i < users.Count; i++)
            {
                if ((users[i]._surname.ToLower() + " " + users[i]._name.ToLower()) == tbLogin.Text.ToLower())
                {
                    
                    Program.p._currentUser = i;
                    Program.InitWindow(Forms.fModules);
                    Program.fModules.Show();
                    this.Hide();
                    return;
                }
            }
            MessageBox.Show("Пользователь с таким именем и фамилией не зарегестрирован");
        }
        static public FormRegistration f;
        private void btnRegistration_Click(object sender, EventArgs e)
        {
            f = new FormRegistration();
            /*f.WindowState = Program.fLogin.WindowState;
            f.Size = Program.fLogin.Size;
            f.Location = Program.fLogin.Location;*/
            f.Show();
            this.Hide();
        }

        private void btnLogoCreativeThinker_MouseEnter_1(object sender, EventArgs e)
        {
            btnLogoCreativeThinker.BackColor = Color.White;
        }

        private void FormLogin_SizeChanged(object sender, EventArgs e)
        {
            Program.currentSize = this.Size;
        }

        private void FormLogin_LocationChanged(object sender, EventArgs e)
        {
            Program.currentLocation = this.DesktopLocation;
            if (this.WindowState!=Program.currentWindowState)
            {
                Program.currentWindowState = this.WindowState;
            }
        }

        private void FormLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !e.Control)
            {
                btnSubmit_Click((object)sender, (EventArgs)e);
            }
            /*else if (e.KeyCode == Keys.Enter && e.Control) 
            {
                Program.debug = true;
                tbLogin.Text = "Назарова Александра";
                btnSubmit_Click((object)sender, (EventArgs)e);
            }*/
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.Size = Program.currentSize;
            this.DesktopLocation = Program.currentLocation;
            this.WindowState = Program.currentWindowState;
        }


        private void FormLogin_VisibleChanged_1(object sender, EventArgs e)
        {
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
            this.WindowState = Program.currentWindowState;
        }
    }
}


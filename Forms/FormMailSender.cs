using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace PRIZ
{
    public partial class FormMailSender : Form
    {
        
        public FormMailSender()
        {
            InitializeComponent();
           
            btnLogoCreativeThinker.MouseEnter += Program.LogoMouseEnter;
            btnLogoCreativeThinker.MouseLeave += Program.LogoMouseLeave;
            btnLogoEducationEra.MouseEnter += Program.LogoMouseEnter;
            btnLogoEducationEra.MouseLeave += Program.LogoMouseLeave;
            //this.FormClosing += Program.ApplicationQuit;
            this.MouseWheel += new MouseEventHandler(tb_MouseWheel);
            this.Size = Program.currentSize;
            this.Location = Program.currentLocation;
        }
        private void tb_MouseWheel(object sender, EventArgs e)
        {
            txtMessage.Focus();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            Label user = new Label();
            user.Text = Program.p.CurrentFullName;
            using (var client = new SmtpClient("smtp.yandex.ru", 587))
            {
                if (txtFrom.Text != " " && txtFrom.Text != "example@mail.com" && txtMessage.Text != "")
                {
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("PrizMailer@yandex.ru", "prizmaile");
                    var message = new MailMessage(
                        "PrizMailer@yandex.ru",
                        "PrizMailer@yandex.ru",
                        "Вопросы пользователей программы ПРИЗ",
                        txtMessage.Text + Environment.NewLine + "Мой контактный e-mail: " + txtFrom.Text + "." + Environment.NewLine + "С уважением, " + user.Text + "."
                    );
                    try
                    {
                        client.Send(message);
                    }
                    catch (System.Net.Mail.SmtpException)
                    {
                        MessageBox.Show("Проблемы с интернет-подключением.", "Ошибка");
                        return;
                    }
                    MessageBox.Show("Спасибо за письмо. Мы обязательно с Вами свяжемся", "Письмо отправлено", MessageBoxButtons.OK);
                    txtFrom.Clear();
                    txtMessage.Clear();
                    this.Close();
                }
                else if (txtMessage.Text != "") MessageBox.Show("Пожалуйста, введите Ваш контактный e-mail.", "Ошибка");
                else if (txtFrom.Text != "example@mail.com") MessageBox.Show("Пожалуйста, введите сообщение.", "Ошибка");
                else MessageBox.Show("Пожалуйста, введите Ваш контактный e-mail и сообщение.", "Ошибка");
            }
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
        private void btnBack_MouseEnter(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back02;
        }
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back01;
        }
        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back03;
        }
        private void btnBack_MouseUp(object sender, MouseEventArgs e)
        {
            btnBack.BackgroundImage = Properties.Resources.back02;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        static string _earlierText;
        private void txtFrom_Enter(object sender, EventArgs e)
        {
            _earlierText = (sender as TextBox).Text;
            (sender as TextBox).Text = "";
            (sender as TextBox).ForeColor = Color.Black;
        }

        private void txtFrom_Leave(object sender, EventArgs e)
        {
            if ((sender as TextBox).Text == "")
            {
                (sender as TextBox).ForeColor = Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(126)))), ((int)(((byte)(126)))));
                (sender as TextBox).Text = _earlierText;
            }
        }
    }
}

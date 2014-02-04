using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace PRIZ
{
    enum Forms
    {
        fLogin,
        fModules,
        fTasks,
        fTask,
        fPhenomenas,
        fAllIdeas,
        fAboutCreativeSchool,
        fAboutEducation,
        fReg,
        fAboutProgramm,
        fMailSender
    }


    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        static public ProgramInstance p;
        static public FormLogin fLogin;
        static public FormModule fModules;
        static public FormTasks fTasks;
        static public FormTask fTask;
        static public FormPhenomenas fPhenomenas;
        static public FormAllIdeas fAllIdeas;
        static public FormAboutCreativeThinking fAboutCreativeSchool;
        static public FormAboutEducation fAboutEducation;
        static public Size currentSize;
        static public Point currentLocation;
        static public FormRegistration fReg;
        static public FormAboutProgramm fAboutProgramm;
        static public FormMailSender fMailSender;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            p = new ProgramInstance();
            fLogin = new FormLogin();
            Application.Run(fLogin);
        }

        static public void ApplicationQuit(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти?", "Выход из программы", MessageBoxButtons.YesNo) == DialogResult.OK)
            {
                Application.Exit();
            }            
        }

        static public void LogoMouseEnter(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Name)
            {
                case "btnLogoCreativeThinker":
                    b.BackgroundImage = Properties.Resources.Logo_ShKM_hover;
                    break;
                case "btnLogoEducationEra":
                    b.BackgroundImage = Properties.Resources.logo_educationfornewera_hover;
                    break;
                default:
                    break;
            }
        }

        static public void LogoMouseLeave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            switch (b.Name)
            {
                case "btnLogoCreativeThinker":
                    b.BackgroundImage = Properties.Resources.Logo_ShKM;
                    break;
                case "btnLogoEducationEra":
                    b.BackgroundImage = Properties.Resources.logo_educationfornewera;
                    break;
                default:
                    break;
            }
        }

        static public void InitWindow(Forms form)
        {
            switch (form)
            {
                case Forms.fLogin:
                    //fLogin = new Form1();
                    break;
                case Forms.fModules:
                    fModules = new FormModule();
                    break;
                case Forms.fTasks:
                    fTasks = new FormTasks();
                    break;
                case Forms.fTask:
                    fTask = new FormTask();
                    break;
                case Forms.fPhenomenas:
                    fPhenomenas = new FormPhenomenas();
                    break;
                case Forms.fAllIdeas:
                    fAllIdeas = new FormAllIdeas();
                    break;
                case Forms.fAboutCreativeSchool:
                    fAboutCreativeSchool = new FormAboutCreativeThinking();
                    break;
                case Forms.fAboutEducation:
                    fAboutEducation = new FormAboutEducation();
                    break;
                case Forms.fReg:
                    fReg = new FormRegistration();
                    break;
                case Forms.fAboutProgramm:
                    fAboutProgramm = new FormAboutProgramm();
                    break;
                case Forms.fMailSender:
                    fMailSender = new FormMailSender();
                    break;
                default:
                    break;
            }
        }
    }
}
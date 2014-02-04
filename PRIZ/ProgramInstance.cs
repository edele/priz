using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using MSWord = Microsoft.Office.Interop.Word; // Сокращаем портянку

namespace PRIZ
{
    public class ProgramInstance
    {
        public List<User> _users;
        public List<Task> _tasks;
        public Answer answer;

        public Module currentModule;
        public Task currentTask;
        public int _currentUser = 0;
        public int _currentProblem = 0;

        public User CurrentUser
        {
            get { return _users[_currentUser]; }
        }

        public Task CurrentProblem
        {
            get { return _tasks[_currentProblem]; }
        }

        public string CurrentFullName
        {
            get
            {
                return _users[_currentUser]._name + " " + _users[_currentUser]._surname;
            }
        }

        public ProgramInstance()
        {
            RefreshUsers();
            _tasks = Task.GetListOfObjects();
            answer = new Answer();
        }
        public void RefreshUsers()
        {
            _users = User.GetListOfObjects();
        }

        public User AddNewUser(
            string username,
            string about,
            string country,
            string password,
            string status,
            string surname
            )
        {
            User user = new User();
            user._name = username;
            user._about = about;
            user._country = country;
            user._password = password;
            user._status = status;
            user._surname = surname;
            user.SaveToFile();
            return user;
        }

        public void Login() 
        {

        }
        public void GenerateTxtReport(Answer a) 
        {
            User u = CurrentUser;
            string report;
            report = "===================================\r\n";
            report += Program.p.currentTask._name.ToUpper() + "\r\n";
            report += "===================================\r\n";
            report += "Решал(а): ";
            report += Program.p.CurrentFullName + ", " + u._status + " ("+u._country+")" + "\r\n";
            report += u._about;
            report += "\r\n\r\n";
            report += "Дано:\r\n";
            report += a._givenByUser + "\r\n\r\n";
            report += "Найти:\r\n";
            report += a._ToFindByUser + "\r\n\r\n";
            report += "Гипотезы:\r\n";

            foreach (string hypotesis in a._hypothesises)
            {
                report += "• " + hypotesis;
                report += "\r\n";
            }


            report += "\r\nКомментарий: \r\n";
            report += answer._comment;
            string filename = CurrentFullName.ToLower() + "_" + 
                Program.p.currentTask._name.ToLower() + "_" +
                (System.DateTime.Now.ToShortDateString() +"_" + System.DateTime.Now.ToShortTimeString()).Replace(".", "_").Replace(":", "-") + "_" +
                "_отчет.txt";
            filename.Replace(' ','_');
            System.IO.File.WriteAllText(filename, report);
            System.Diagnostics.Process.Start(filename);

        }
        public void GenerateReport(Answer answer)
        {
            this.answer = answer;
            // 1) Запускаем экземпляр MS Word
            MSWord.Application appWord;
            try
            {
                appWord = new MSWord.Application();
            }
            catch (Exception ex)
            {
                MessageBox.Show("У Вас не установлен Ворд!");
                return;
            }

            // 2) Показываем приложение
            appWord.Visible = true;
            // 3) Добавить новый документ
            MSWord.Document doc = appWord.Documents.Add();
            // 3) Добавляем текст: 

            MSWord.Paragraph para = doc.Paragraphs.Add();
            para.Range.Font.Name = "Arial";
            para.Range.Font.Bold = 1;
            para.Range.Font.Underline = MSWord.WdUnderline.wdUnderlineSingle;
            para.Range.Font.Size = 19;
            para.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphCenter;
            para.Range.Text = "Отчет";
            doc.Paragraphs.Add();
            para = doc.Paragraphs[2];
            para.Range.Font.Name = "Arial";
            para.Range.Font.Size = 12;
            para.Range.Font.Bold = 1;
            para.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphRight;

            para.Range.Text = string.Format
                ("Задание: {0}", _tasks[_currentProblem]._name);

            doc.Paragraphs.Add();
            para = doc.Paragraphs[3];
            para.Range.Text = string.Format
                ("Задание решал(а): {0}", _users[_currentUser]._name);
            /*
            doc.Paragraphs.Add();
            para = doc.Paragraphs[4];
            para.Range.Text = string.Format
                ("Дано, сформулированное учеником: {0}", answer._givenByUser);

            doc.Paragraphs.Add();
            para = doc.Paragraphs[5];
            para.Range.Text = string.Format
                ("Задание, сформулированное учеником: {0}", answer._ToFindByUser);
            */

            #region Table

            doc.Paragraphs.Add();
            para.Range.Font.Name = "Times New Roman";
            para.Alignment = MSWord.WdParagraphAlignment.wdAlignParagraphLeft;
            para.Range.Font.Bold = 0;
            //para = doc.Paragraphs;
            MSWord.Range range = para.Range;
            MSWord.Table table = doc.Tables.Add(range, 3, 3);
            table.Borders.InsideLineStyle = MSWord.WdLineStyle.wdLineStyleSingle;
            table.Borders.OutsideLineStyle = MSWord.WdLineStyle.wdLineStyleSingle;
            table.Borders.OutsideLineWidth = MSWord.WdLineWidth.wdLineWidth150pt;
            table.Columns[1].Width = 70;
            table.Columns[2].Width = 220;

            range = table.Cell(1, 2).Range;
            range.Text = "Дано:";
            range = table.Cell(1, 3).Range;
            range.Text = "Найти:";
            range = table.Cell(2, 1).Range;
            range.Text = "Из задания";
            range = table.Cell(3, 1).Range;
            range.Text = "Своими словами";

            range = table.Cell(2, 2).Range;
            range.Text = answer.problem._given;

            range = table.Cell(2, 3).Range;
            range.Text = answer.problem._toFind;

            range = table.Cell(3, 2).Range;
            range.Text = answer._givenByUser;

            range = table.Cell(3, 3).Range;
            range.Text = answer._ToFindByUser;

            #endregion Table
            doc.Paragraphs.Add();
            range = doc.Paragraphs[16].Range;
            para = doc.Paragraphs[16];

            para.Range.Text = ListOfHypoToString(answer._hypothesises);
        }
        string ListOfHypoToString(List<string> list)
        {
            string st = "";
            for (int i = 0; i < list.Count; i++)
            {
                st += string.Format("Гипотеза номер {0}:", i + 1) + list[i] + ".\r\n";
            }
            return st;
        }
    }
}

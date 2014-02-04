using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PRIZ
{
    public class User
    {
        /// <summary>ФИО ученика или название группы учеников</summary>
        public string _name;
        public string _surname;
        public string _country;
        public string _status;
        public string _password;
        public string _about;
        public List<Answer> answers;


        /// <summary> Сохраняет этот объект в файл методом стандартной сериализации </summary>
        /// <param name="path">Путь к файлу, в который будет сохранен объект</param>
        public void SaveToFile(string path = "Users\\test.xml")
        {
            if (!UserExists(_surname+" "+_name))
            {
                path = "Users\\" + _name + "_" + _surname + ".xml";
            }
            else
            {
                path = "Users\\" + _name + "_" + _surname + "(1)" + ".xml";
            }
            DirectoryInfo parentDir = Directory.GetParent(path);
            if (!Directory.Exists(parentDir.ToString()))
            {
                Directory.CreateDirectory(parentDir.ToString());
            }
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(User));
            xs.Serialize(fs, this);
            fs.Close();
        }

        private bool UserExists(string suname_name)
        {
            var unames = GetUserNames();
            foreach (var uname in unames)
            {
                if (uname == suname_name) return true;
            }
            return false;
        }

        public static List<string> GetUserNames(string path = "Users\\")
        {
            List<string> userNames = new List<string>();
            string[] fileNames = Directory.GetFiles(path, "*.xml");

            User tempUser;
            foreach (var fileName in fileNames)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(User));
                tempUser = (User)xs.Deserialize(fs);
                userNames.Add(tempUser._surname + " " + tempUser._name);
                fs.Close();
            }

            return userNames;
        }
        public static List<User> GetListOfObjects(string path = "Users\\")
        {
            List<User> users = new List<User>();
            string[] fileNames = Directory.GetFiles(path, "*.xml");


            User tempUser;
            foreach (var fileName in fileNames)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(User));
                tempUser = (User)xs.Deserialize(fs);
                users.Add(tempUser);
                fs.Close();
            }

            return users;
        }
        public bool CheckIfUserAlreadyStartedProblem(string problemName)
        {
            foreach (Answer answer in answers)
            {
                if (answer.problem._name == problemName)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

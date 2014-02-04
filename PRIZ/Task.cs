using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace PRIZ
{
    [Serializable]
    public class Task
    {
        public string _name;
        public string _description;
        public List<string> _hints;
        public List<string> _kstati;
        public string _authors;
        public string _given;
        public string _toFind;
        public string _path;
        public Task(){} // конструктор для сериализатора

        /// <summary>
        /// Конструктор для заполнения полей при создании
        /// </summary>
        /// <param name="name"></param>
        /// <param name="given"></param>
        /// <param name="toFind"></param>
        public Task(string name, string given, string toFind)
        {
            _name = name;
            _given = given;
            _toFind = toFind;
        }

        /// <summary>
        /// Конструктор, который сразу создает объект из файла
        /// </summary>
        /// <param name="filePath">Путь к xml, из которого будет десериализован объект</param>
        public Task(string filePath)
        {
            CreateFromTxt(filePath);
        }

        public void CreateFromTxt(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Task));

            Task tempTask = (Task)xs.Deserialize(fs);
            _name = tempTask._name;
            _given = tempTask._given;
            _toFind = tempTask._toFind;
            _description = tempTask._description;
            _hints = tempTask._hints;
            _kstati = tempTask._kstati;
            _authors = tempTask._authors;

            fs.Close();
        }
        /// <summary>
        /// Сохраняет этот объект в файл методом стандартной сериализации
        /// </summary>
        /// <param name="path">Путь к файлу, в которй будет сохранен объект</param>
        public void SaveToFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Task));
            xs.Serialize(fs, this);
            fs.Close();
        }
        public static List<Task> GetListOfObjects(string path = "Problems\\")
        {
            /*
        List<Task> tasks = new List<Task>();
        string[] fileNames = Directory.GetFiles(path, "*.xml");


        Task tempProblem;
        foreach (var fileName in fileNames)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Task));
            tempProblem = (Task)xs.Deserialize(fs);
            tasks.Add(tempProblem);
            fs.Close();
        }

        return tasks;
            */
            return null;
        }
        public static List<string> GetProblemNames(string path = "Problems\\")
        {
            List<string> tasks = new List<string>();
            string[] fileNames = Directory.GetFiles(path, "*.xml");


            Task tempProblem;
            foreach (var fileName in fileNames)
            {
                FileStream fs = new FileStream(fileName, FileMode.Open);
                XmlSerializer xs = new XmlSerializer(typeof(Task));
                tempProblem = (Task)xs.Deserialize(fs);
                tasks.Add(tempProblem._name);
                fs.Close();
            }

            return tasks;
        }
    }
}

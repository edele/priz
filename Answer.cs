using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace PRIZ
{
    [Serializable]
    public class Answer
    {
        private int currentHypo = 0;
        /// <summary> Дано, сформулированное юзером </summary>
        public string _givenByUser;

        public string _comment;

        public Task problem;

        public Answer()
        {
            _hypothesises = new List<string>();
        }
        /// <summary> Конструктор для создания объекта из XML файла </summary>
        /// <param name="path">путь к XML файлу</param>
        public Answer(string path)
        {
            CreateFromXml(path);
        }

        /// <summary> Найти, сформулированное юзером </summary>
        public string _ToFindByUser;
        /// <summary>
        /// Ответ на вопрос:
        /// 1)	Какой объект в данной задаче основной? Из каких частей или элементов он состоит?  </summary>
        public string _answerToQuestion1;
        /// <summary>
        /// Ответ на вопрос:
        /// 2)	Какие объекты находятся вокруг основного объекта? С какими объектами и как он взаимодействует?  </summary>
        public string _answerToQuestion2;
        /// <summary>
        /// Ответ на вопрос:
        /// 3)	Какие процессы протекают в самом объекте, с его участием и вокруг него? </summary>
        public string _answerToQuestion3;

        /// <summary> Список гипотез </summary>
        public List<string> _hypothesises;

        public void EditHypo(string text)
        {
            if (_hypothesises == null)
            {
                _hypothesises = new List<string>();
                _hypothesises.Add("");
            }
            _hypothesises[currentHypo] = text;
        }
        public string ShowHypotesis()
        {
            if (_hypothesises == null)
            {
                _hypothesises = new List<string>();
                _hypothesises.Add("");
            }
            return _hypothesises[currentHypo];
        }
        public string NewHypo()
        {
            _hypothesises.Add("");
            currentHypo = _hypothesises.Count - 1;
            return "";
        }
        public string ShowNextHypo()
        {
            if (currentHypo < (_hypothesises.Count - 1) && _hypothesises.Count > 1)
            {
                currentHypo++;
                return _hypothesises[currentHypo];
            }
            return _hypothesises[currentHypo];
        }

        public string ShowPrevHypo()
        {
            if (currentHypo > 0)
            {
                currentHypo--;
                return _hypothesises[currentHypo];
            }
            return _hypothesises[currentHypo];
        }
        public string ReturnCountInfo()
        {
            return string.Format("{0}/{1}", currentHypo + 1, _hypothesises.Count);
        }
        public Answer(string givenByUser, string toFindByUser, string answerToQuestion1, string answerToQuestion2, string answerToQuestion3, List<string> hypothesises)
        {
            _givenByUser = givenByUser;
            _ToFindByUser = toFindByUser;
            _answerToQuestion1 = answerToQuestion1;
            _answerToQuestion2 = answerToQuestion2;
            _answerToQuestion3 = answerToQuestion3;
            _hypothesises = hypothesises;
        }

        public void CreateFromXml(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Answer));

            Answer tempAnswer = (Answer)xs.Deserialize(fs);
            _givenByUser = tempAnswer._givenByUser;
            _ToFindByUser = tempAnswer._ToFindByUser;
            _answerToQuestion1 = tempAnswer._answerToQuestion1;
            _answerToQuestion2 = tempAnswer._answerToQuestion2;
            _answerToQuestion3 = tempAnswer._answerToQuestion3;
            _hypothesises = tempAnswer._hypothesises;
            fs.Close();
        }
        /// <summary> Сохраняет этот объект в файл методом стандартной сериализации </summary>
        /// <param name="path">Путь к файлу, в которй будет сохранен объект</param>
        public void SaveToFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Answer));
            xs.Serialize(fs, this);
            fs.Close();
        }
    }
}

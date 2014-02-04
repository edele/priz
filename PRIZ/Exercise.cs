using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace PRIZ
{
    [Serializable]
    public class Exercise
    {
        public string _name;
        public string _annotation;
        public string _picPath;
        public List<Task> _tasks;

        public Exercise()
        {
            _tasks = new List<Task>();
        }

        public void LoadFromXml(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Exercise));

            Exercise tempModule = (Exercise)xs.Deserialize(fs);
            _name = tempModule._name;
            _annotation = tempModule._annotation;
            _picPath = tempModule._picPath;
            _tasks = tempModule._tasks;
            fs.Close();
        }
        public void SaveToFile(string path)
        {
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Exercise));
            xs.Serialize(fs, this);
            fs.Close();
        }
    }
}

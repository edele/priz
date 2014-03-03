using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace PRIZ
{
    [Serializable]
    public class Module
    {
        public string _name;
        public string _annotation;
        public string _pic;
        public string _filename;
        public string ModulePath
        {
            get { return @"modules\" + _name + @"\"; }
        }

        public Module() { }

        public Module(string name = "", string annotation = "", string pic = "mainpic.png")
        {
            _name = name;
            _annotation = annotation;
            _pic = @"modules\" + name + @"\mainpic.png";
            _filename = Helper.MakeValidFileName(name);
        }
        /// <summary>
        /// Load from file
        /// </summary>
        /// <param name="path">Name of module</param>
        public Module(string name = "")
        {
            string path = @"modules\" + name + @"\main.xml";
            FileStream fs = new FileStream(path, FileMode.Open);

            XmlSerializer xs = new XmlSerializer(typeof(Module));
            Module tempModule = (Module)xs.Deserialize(fs);
            fs.Close();

            // keep this part up to date with standart constructor
            _name = tempModule._name;
            _annotation = tempModule._annotation;
            _pic = @"modules\" + name + @"\mainpic.png";
            _filename = Helper.MakeValidFileName(tempModule._name);
        }
        public void Serialize()
        {
            string path = @"modules\" + _filename + @"\main.xml";
            try
            {
                FileStream fs = new FileStream(path, FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(Module));
                xs.Serialize(fs, this);
                fs.Close();
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"modules\" + _filename);
                FileStream fs = new FileStream(path, FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(Module));
                xs.Serialize(fs, this);
                fs.Close();
            }
        }
    }
}

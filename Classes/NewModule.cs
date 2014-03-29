using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Drawing;

namespace PRIZ
{
    [Serializable]
    public class NewModule
    {
        public string _name;
        public string _pic;
        public string _annotation;
        public string _filename;


        public NewModule(){ }

        public void SaveToFile(string name)
        {
            string path = @"modules\" + name + @"\main.xml";
            FileStream fs = new FileStream(path, FileMode.Create);
            XmlSerializer xs = new XmlSerializer(typeof(Module));
            xs.Serialize(fs, this);
            fs.Close();
        }
        public NewModule(string name,string annotation, Rectangle r)
        {
            this._name = name;
            this._annotation = annotation;
            this._pic = "mainpic.png";
            this._filename = name;
            Directory.CreateDirectory(@"modules\" + name);
            Serialize(name, r);
        }
        public void Serialize(string name, Rectangle r)
        {
            string path = @"modules\" + name + @"\main.xml";
            try
            {
                Module n = new Module();
                n._annotation = this._annotation;
                n._filename = this._filename;
                n._name = this._name;
                n._pic = this._pic;
                FileStream fs = new FileStream(path, FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(Module));
                xs.Serialize(fs, n);
                fs.Close();
                SaveImage(r,name);
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(@"modules\" + name);
                FileStream fs = new FileStream(path, FileMode.Create);
                XmlSerializer xs = new XmlSerializer(typeof(Module));
                xs.Serialize(fs, this);
                fs.Close();
            }
        }
        public void SaveImage(Rectangle r, string name)
        {
            Bitmap b = new Bitmap(r.Width, r.Height);
            Graphics g = Graphics.FromImage(b);
            g.CopyFromScreen(r.Location, new Point(0, 0), r.Size);
            b.Save(@"modules\" + name + @"\mainpic.png");
        }
    }
}

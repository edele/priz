using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Windows.Forms;
namespace PRIZ
{
    static class Helper
    {
        static public string MakeValidFileName(string name)
        {
            var builder = new StringBuilder();
            var invalid = System.IO.Path.GetInvalidFileNameChars();
            foreach (var cur in name)
            {
                if (!invalid.Contains(cur))
                {
                    builder.Append(cur);
                }
            }
            return builder.ToString();
        }
    }
}

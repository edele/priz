using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRIZ
{
    public partial class FormDeleteConform : Form
    {
        public FormDeleteConform()
        {
            InitializeComponent();
            lReallyModule.Text = lReallyModule.Text + "\r\n «" + Program.p.currentModule._filename + "»?";
        }
    }
}

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
    public partial class FormEditIdea : Form
    {
        public string _text;
        Answer answer = Program.p.answer;
        public FormEditIdea()
        {
            InitializeComponent();
        }
        
        private void btnEditIdea_Click(object sender, EventArgs e)
        {
           // return tbToEdit.Text;
        }
        
        public string GetText()
        {
            return tbToEdit.Text;
        }

        private void FormEditIdea_Load(object sender, EventArgs e)
        {
            tbToEdit.Text = _text;
        }
    }
}

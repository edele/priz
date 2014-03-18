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
    public partial class FormEditOrAddIdea : Form
    {
        public string _textOnButton = "Редактировать";
        public string _text;
        Answer answer = Program.p.answer;
        public FormEditOrAddIdea()
        {
            InitializeComponent();
        }
        
        private void btnEditIdea_Click(object sender, EventArgs e)
        {
           // return tbToEdit.Text;
        }
        
        public string GetText()
        {
            _textOnButton = "Редактировать";
            return tbToEdit.Text.Trim();
        }

        private void FormEditIdea_Load(object sender, EventArgs e)
        {
            tbToEdit.Text = _text;
            btnEditIdea.Text = _textOnButton;
        }
    }
}

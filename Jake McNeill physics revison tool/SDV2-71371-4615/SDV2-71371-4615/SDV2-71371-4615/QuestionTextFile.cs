using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV2_71371_4615
{
    public partial class QuestionTextFile : Form
    {
        public QuestionTextFile()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Question = tbxQuestion.Text;
            string CorrectA = tbxCA.Text;
            string IncorrectA1 = tbxICA1.Text;
            string IncorrectA2 = tbxICA2.Text;
            string IncorrectA3 = tbxICA3.Text;


            StreamWriter sw = new StreamWriter(@"Question.txt", true);

            sw.WriteLine(Question + "," + CorrectA + "," + IncorrectA1 + "," + IncorrectA2 + "," + IncorrectA3);

            sw.Close();
        }

        private void QuestionTextFile_Load(object sender, EventArgs e)
        {

        }
    }
}

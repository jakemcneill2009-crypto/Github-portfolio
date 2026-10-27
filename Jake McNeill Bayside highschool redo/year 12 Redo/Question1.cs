using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace year_12_Redo
{
	public partial class Question1 : Form
	{
		public Question1()
		{
			InitializeComponent();
		}

		private void cbxQuestion1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxQuestion1.SelectedIndex == 1)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Program.LoggedStudent.TotalScore +=1;//when the correct answer in selected 1 point is added to the result
				Program.quizResult += 1;
				Program.questionsCompleted += 1;
				MessageBox.Show("Correct plus one score");
				Quiz newform = new Quiz();
				newform.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Incorrect better luck next time\n correct answer B"); // This appears when the answer is incorrect and says the correct answer
				Program.questionsCompleted += 1;
				Quiz newform = new Quiz();
				newform.Show();
				this.Hide();
			}
		}
	}
}

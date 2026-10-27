using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace year_12_Redo
{
	public partial class question4 : Form
	{
		public question4()
		{
			InitializeComponent();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			if (tbxAnswer.Text.ToLower() == "light") // It will change the text entered to lower case and then check it to see if it matches
			{
				Program.LoggedStudent.TotalScore += 1;
				Program.quizResult += 1;
				Program.questionsCompleted += 1;
				MessageBox.Show("Correct plus one score");
				Quiz newform = new Quiz();
				newform.Show();
				this.Hide();
			}
			else if (string.IsNullOrWhiteSpace(tbxAnswer.Text)) // This will check to see if there is something entered in the textbox or not
			{
				MessageBox.Show("Answer not entered please type an answer");
				Program.questionsCompleted += 1;
				Quiz newform = new Quiz();
				newform.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Incorrect better luck next time correct answer was light"); // This message will be displayed if the answer entered is not correct
				Program.questionsCompleted += 1;
				Quiz newform = new Quiz();
				newform.Show();
				this.Hide();
			}
		}
	}
}

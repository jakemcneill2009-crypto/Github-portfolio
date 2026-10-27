using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace year_12_Redo
{
	public partial class Quiz : Form
	{
		public Quiz()
		{
			InitializeComponent();
		}

		private void Quiz_Load(object sender, EventArgs e)
		{
			lblscore.Text = "Score: " + Program.LoggedStudent.TotalScore;
		}

		private void btnQuestion1_Click(object sender, EventArgs e)
		{
			if (Program.questionsCompleted == 0)
			{
				Question1 newform = new Question1();
				newform.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("You have already completed this question.");
			}
		}

		private void btnQuestion2_Click(object sender, EventArgs e)
		{
			if (Program.questionsCompleted == 1)
			{
				question2 newform = new question2();
				newform.Show();
				this.Hide();
			}
			else if (Program.questionsCompleted >= 2)
			{
				MessageBox.Show("You have already completed this question.");
			}
			else
			{
				MessageBox.Show("You still need to answer question 1 before you can answer this question");
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (Program.questionsCompleted == 2)
			{
				Question3 newform = new Question3();
				newform.Show();
				this.Hide();
			}
			else if (Program.questionsCompleted >= 3)
			{
				MessageBox.Show("You have already completed this question.");
			}
			else
			{
				MessageBox.Show("You still need to answer question 2 before you can answer this question");
			}
		}

		private void btnQuestion4_Click(object sender, EventArgs e)
		{
			if (Program.questionsCompleted == 3)
			{
				question4 newform = new question4();
				newform.Show();
				this.Hide();
			}
			else if (Program.questionsCompleted >= 4)
			{
				MessageBox.Show("You have already completed this question.");
			}
			else
			{
				MessageBox.Show("You still need to answer question 3 before you can answer this question");
			}
		}

		private void btnQuestion5_Click(object sender, EventArgs e)
		{
			if (Program.questionsCompleted == 4)
			{
				question5 newform = new question5();
				newform.Show();
				this.Hide();
			}
			else
			{
				MessageBox.Show("You still need to answer question 4 before you can answer this question");
			}
		}
	}
}

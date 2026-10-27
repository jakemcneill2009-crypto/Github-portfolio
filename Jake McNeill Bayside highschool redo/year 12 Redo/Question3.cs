using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace year_12_Redo
{
	public partial class Question3 : Form
	{
		public Question3()
		{
			InitializeComponent();
		}

		private void btnFalse_Click(object sender, EventArgs e)
		{
			Program.LoggedStudent.TotalScore += 1;
			Program.questionsCompleted += 1;
			Program.quizResult += 1;
			Quiz newform = new Quiz();
			newform.Show();
			this.Hide();
		}

		private void btnTrue_Click(object sender, EventArgs e)
		{
			Program.questionsCompleted += 1;
			Quiz newform = new Quiz();
			newform.Show();
			this.Hide();
		}
	}
}

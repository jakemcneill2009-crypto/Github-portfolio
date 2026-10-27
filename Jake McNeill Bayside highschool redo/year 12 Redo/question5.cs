using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BaysideHighSchool;

namespace year_12_Redo
{
	public partial class question5 : Form
	{
		public question5()
		{
			InitializeComponent();
		}

		private void pbx1_Click(object sender, EventArgs e)
		{
			Program.LoggedStudent.TotalScore += 1;
			Program.questionsCompleted += 1;
			Program.quizResult += 1;
			pbx1.ImageLocation = "Images/green tick.jpg";// If the correct answer is selected then the image will change to a green tick
			frmReactionTime newform = new frmReactionTime();
			newform.Show();
			this.Hide();
		}

		private void pbx2_Click(object sender, EventArgs e)
		{
			Program.questionsCompleted += 1;
			pbx2.ImageLocation = "Images/red x.jpg";
			frmReactionTime newform = new frmReactionTime();
			newform.Show();
			this.Hide();
		}

		private void pbx3_Click(object sender, EventArgs e)
		{
			Program.questionsCompleted += 1;
			pbx3.ImageLocation = "Images/red x.jpg";// if the incorrect answer is selected then a red x will be displayed
			frmReactionTime newform = new frmReactionTime();
			newform.Show();
			this.Hide();
		}
	}
}

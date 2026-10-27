using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace year_12_Redo
{
	public partial class question2 : Form
	{
		public question2()
		{
			InitializeComponent();
		}
		public int btnCounter = 0;
		public void CheckClicks()
		{
			if (btnCounter == 2) // when the btn counter amount reaches 2 it will disable the rest of the buttons so that they cannot be clicked more than twice

			{
				btn1.Enabled = false;
				btn2.Enabled = false;
				btn3.Enabled = false;
				btn4.Enabled = false;
				Program.questionsCompleted += 1;
				Quiz newform = new Quiz();
				newform.Show();
				this.Close();
			}
		}
		private void button3_Click(object sender, EventArgs e)
		{
			btn3.BackColor = Color.Red;
			
			btn3.Enabled = false;
			btnCounter += 1; // when it is clicked 1 is added to the counter
			CheckClicks();
		}

		private void btn2_Click(object sender, EventArgs e)
		{
			Program.LoggedStudent.TotalScore += 1;// if the correct phrase is selected 1 point will be added to their total
			
			Program.quizResult += 1;
			btn1.BackColor = Color.Green;
			btn1.Enabled = false;
			btnCounter += 1;
			CheckClicks();
		}

		private void btn1_Click(object sender, EventArgs e)
		{
			btn1.BackColor = Color.Red;
			btn1.Enabled = false;
			
			btnCounter += 1;
			CheckClicks();
		}

		private void btn4_Click(object sender, EventArgs e)
		{
			Program.LoggedStudent.TotalScore += 1;
			
			Program.quizResult += 1;
			btn4.BackColor = Color.Green;
			btn4.Enabled = false;
			btnCounter += 1;
			CheckClicks();
		}
	}
}

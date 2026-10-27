using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using year_12_Redo;

namespace BaysideHighSchool
{
	public partial class frmDataEntry : Form
	{
		public frmDataEntry()
		{
			InitializeComponent();
		}

		public string Group()
		{
			int Score1 = 0;
			int Score2 = 0;
			string Group;
			int averageLengths = Convert.ToInt32(tbxAverage.Text);

			if (averageLengths >= 15)
			{
				Score1 = 5;
			}
			else if ((averageLengths >= 7) && (averageLengths <= 14))
			{
				Score1 = 3;
			}
			else
			{
				Score1 = 1;
			}

			int Totalscore = Convert.ToInt32(lblTotalScoreDisplayed.Text);

			if (Totalscore >= 12)//Depending on what the score is a certain number of points will be awarded to Score1 eg. if the score is greater than or equal to 12 you will get 5 points.
			{
				Score2 = 5;
			}
			else if ((Totalscore >= 6) && (Totalscore <= 11))
			{
				Score2 = 3;
			}
			else
			{
				Score2 = 1;
			}

			int groupScore = Score1 + Score2;

			if (groupScore >= 8)
			{
				Group = "advanced";// depending on the users total score they will be sorted into the advanced swimmer or Non-swimmer groups
			}
			else if ((groupScore >= 6) && (groupScore <= 8))
			{
				Group = "swimmer";
			}
			else
			{
				Group = "Non-swimmer";
			}
			return Group;
		}
		public void ResetDataEntry()
		{
			tbxFirstName.Clear();
			tbxSurname.Clear();
			tbxAttempt1.Clear();
			tbxAttempt2.Clear();
			tbxAverage.Clear();
			Gender = "";
			Program.LoggedStudent.Year = "";

		}
		private void frmDataEntry_Load(object sender, EventArgs e)
		{
			if (Program.challengeComplete == false)
			{
				tbxFirstName.Enabled = false;
				tbxSurname.Enabled = false;

				cbxGender.Enabled = false;
				btnSubmit.Enabled = false;
				pnlDataEntry.Enabled = false;

				btnQuiz.Enabled = true;
				btnViewReport.Enabled = true;// when the data entry form is opened all of the buttons and text boxes will be disabled
			}
			else
			{
				btnQuiz.Enabled = false;
				tbxFirstName.Enabled = true;
				tbxSurname.Enabled = true;

				cbxGender.Enabled = true;
				btnSubmit.Enabled = true;

				btnViewReport.Enabled = true;
				pnlDataEntry.Enabled = true;// when the quiz has been completed then everything on the data entry form is unlocked and the quiz button is disabled to stop people form taking the quiz twice
			}
			lblQuizResultDisplay.Text = Program.quizResult.ToString();
			lblReactionTimeDisplay.Text = Program.ReactionTestScore.ToString();
			lblTotalScoreDisplayed.Text = Program.TotalScore.ToString();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void btnAverage_Click(object sender, EventArgs e)
		{
			string error = "";
			bool valid = true;
			int average = 0;

			if (string.IsNullOrWhiteSpace(tbxAttempt1.Text))// This checks to make sure that the attempt boxes are not left blank
			{
				error += "Nothing entered in attempt 1";
			}
			if (string.IsNullOrWhiteSpace(tbxAttempt2.Text))
			{
				error += "Nothing entered in attempt 2";
			}
			foreach (char letter in tbxAttempt1.Text)
			{
				if (char.IsDigit(letter) == false)
				{
					valid = false;
				}
			}
			foreach (char letter in tbxAttempt2.Text)
			{
				if (char.IsDigit(letter) == false)
				{
					valid = false;// If the character entered is a letter then it will not be accepted
				}
			}
			if (valid == false)
			{
				error += " only include numbers";// If letters are included then a message will appear to tell the user that it is only for numbers
			}
			if (error == "")
			{
				average = (Convert.ToInt32(tbxAttempt1.Text) + Convert.ToInt32(tbxAttempt2.Text)) / 2; // This code calculates the average of the two numbers entered
				tbxAverage.Text = average.ToString();
			}
			else
			{
				MessageBox.Show("error");
			}
		}

		private void btnQuiz_Click(object sender, EventArgs e)
		{
			Quiz newform = new Quiz();
			newform.Show();
			this.Hide();
			//Form MoveToQuiz = new frmQuiz();
			//MoveToQuiz.Show(); // This moves the user to the quiz form
		}

		private void btnViewReport_Click(object sender, EventArgs e)
		{
			frmReport newform = new frmReport();
			newform.Show();
			this.Hide();
			//Form MoveToReport = new frmReport();
			//MoveToReport.Show();// This moves the user to the report form
		}

		private void btnHelpDataEntry_Click(object sender, EventArgs e)
		{
			MessageBox.Show("if the textboxes are disabled then you have to complete the quiz first");
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			string group = "";
			string Error = "";

			if (string.IsNullOrWhiteSpace(tbxFirstName.Text) || tbxFirstName.Text.Length > 15)
				Error += "\nPlease enter your first name. it cannot be longer than 15 letters.";

			if (string.IsNullOrWhiteSpace(tbxSurname.Text) || tbxSurname.Text.Length > 15)// will check to see if a surname has been entered and checks to make sure it is not too long.
				Error += "\nPlease enter your surname. it cannot be longer than 15 letters.";





			if (Error != "")
			{
				MessageBox.Show(Error, "Error in Data Entry");// if the Error string isn't empty then this error message will pop up to tell the user that something has been done incorrectly.
			}
			else
			{
				group = Group();

				string filePath = @"Pupil info.txt";
				FileStream aFile;
				StreamWriter sw;

				if (!File.Exists(filePath))
				{
					aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
				}
				else
				{
					aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
				}

				sw = new StreamWriter(aFile);

				sw.WriteLine(string.Format("\r\n{0}~{1}~{2}~{3}~{4}~{5}~{6}", tbxFirstName.Text, tbxSurname.Text, Program.LoggedStudent.Year, Gender, tbxAverage.Text, lblTotalScoreDisplayed.Text, group));// makes the order that the students details are writen in firstname, surname, yeargroup, gender, average lengths, total score and then their group.
				MessageBox.Show(string.Format("you are in {0} group your details have been saved in a file", group));
				ResetDataEntry();
				sw.Close();
				aFile.Close();
				
				
				
				this.Close();
				new frmReport().Show();

			}
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("if the textboxes are disabled then you have to complete the quiz first");
		}
		public string Gender;
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxGender.SelectedIndex == 0)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Gender = "Male";



			}
			else if (cbxGender.SelectedIndex == 1)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Gender = "Female";



			}
			else if (cbxGender.SelectedIndex == 2)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Gender = "Other";



			}
			else if (cbxGender.SelectedIndex == 3)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Gender = "Prefer not to say";



			}
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Program.LoggedStudent = null;
			Program.ReactionTestScore = 0;
			Program.quizResult = 0;
			Program.challengeComplete = false;
			Program.questionsCompleted = 0;
			
			frmLogIn newfrom = new frmLogIn();
			newfrom.Show();
			this.Hide();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace year_12_Redo
{
	public partial class frmSignUp : Form
	{
		List<Student> students = new List<Student>();
		List<string> errors = new List<string>();

		public frmSignUp()
		{
			InitializeComponent();
		}
		public string Year;
		private void btnCreate_Click(object sender, EventArgs e)
		{
			Student newStudent = new Student();

			newStudent.Avatar = Avatar;
			



			if (students.Count < 10)
			{
				foreach (Student current in students)
				{
					if (current.Username == tbxUsername.Text)// Checks to make sure the usernames are not the same
					{
						errors.Add("Username is already in use");

					}

					if (current.Password == tbxPassword.Text)// Checks to make sure the Passwords are not the same
					{
						errors.Add("Password is already being used");

					}
				}

				try
				{
					newStudent.Username = tbxUsername.Text;
				}
				catch (RegExceptions ex)
				{
					errors.Add(ex.Message);


				}
				try
				{
					newStudent.Password = tbxPassword.Text;
				}
				catch (RegExceptions ex)
				{
					errors.Add(ex.Message); // Adds to the error count
				}
				if (Avatar == null)// Checks to make sure the user entered an avatar
				{
					errors.Add("You need to select an avatar");
				}
				if (Year == null)
				{
					errors.Add("You need to select you year group");
				}
				if (errors.Count == 0) // If the error count is 0 the new player will be created and it writes it to the playerlist binary file
				{
					newStudent.Year = Year;
					students.Add(newStudent);
					Program.WriteToFile(students);
					Program.LoggedStudent = newStudent;// Sets the logged player variable equal to the new player that was created
					this.Hide();
					frmLogIn newform = new frmLogIn();
					newform.Show();
					MessageBox.Show("Student added to the file");



				}
				else // Clears the form to its origional state if the user fail to create the account
				{
					string errorMessage = string.Join("\n", errors.ToArray());
					MessageBox.Show(string.Format("Errors Encountered -" + "\n" + errorMessage));
					tbxPassword.Clear();
					tbxUsername.Clear();
					errors.Clear();
					pbxChosenPfp.Image = null;
					Avatar = "";
				}


			}



		}
		public string Avatar;
		private void pbx1_Click(object sender, EventArgs e)
		{
			Avatar = "water"; // When a picture box is clicked it changes the avatar variable to match
			pbxChosenPfp.ImageLocation = "Images/water.jpg";
		}

		private void pbx2_Click(object sender, EventArgs e)
		{
			Avatar = "fish"; // When a picture box is clicked it changes the avatar variable to match
			pbxChosenPfp.ImageLocation = "Images/fish.jpg";
		}

		private void pbx3_Click(object sender, EventArgs e)
		{
			Avatar = "shark"; // When a picture box is clicked it changes the avatar variable to match
			pbxChosenPfp.ImageLocation = "Images/shark.jpg";
		}

		private void pbx4_Click(object sender, EventArgs e)
		{
			Avatar = "jellyfish"; // When a picture box is clicked it changes the avatar variable to match
			pbxChosenPfp.ImageLocation = "Images/jellyfish.jpg";
		}

		private void frmSignUp_Load(object sender, EventArgs e)
		{
			Program.ReadFromFile(students);
		}
		
		private void cbxYear_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbxYear.SelectedIndex == 0)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Year = "11";

				
				
			}
			else if (cbxYear.SelectedIndex == 1)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Year = "12";
				
				
				
			}
			else if (cbxYear.SelectedIndex == 2)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Year = "13";

				
				
			}
			else if (cbxYear.SelectedIndex == 3)// if the answer selected is in position 1 is selected the program will run in different ways
			{
				Year = "14";

				
				
			}


		}
	}
}

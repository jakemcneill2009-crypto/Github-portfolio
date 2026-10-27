using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using BaysideHighSchool;

namespace year_12_Redo
{
	public partial class frmLogIn : Form

	{
		public frmLogIn()
		{
			InitializeComponent();

		}
		List<Student> students = new List<Student>();
		bool valid;
		private void btnSignUp_Click(object sender, EventArgs e)
		{
			frmSignUp newform = new frmSignUp();
			newform.Show();
			this.Hide();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			valid = false;
			foreach (Student current in students)// Checks to see if the entered username and password are in the playerlist file under the same user
			{
				if (current.Username == tbxuser.Text && current.Password == tbxPass.Text)
				{
					valid = true;
					Program.LoggedStudent = current; // Sets the current user equal to the player in the playerlist file
					break;
				}


			}
			if (valid == true)// If a valid username and password are entered it allows the user to go to the main menu
			{
				MessageBox.Show("Login Successful");

				tbxPass.Clear();
				tbxuser.Clear();
				frmDataEntry newform = new frmDataEntry();
				newform.Show();
				this.Hide();



			}
			else if (tbxuser.Text == "" || tbxPass.Text == "")
			{
				MessageBox.Show("A password or username wasn't entered please try again");
				tbxPass.Clear();// If the username and password is incorrect it clears the textboxes
				tbxuser.Clear();
			}
			else
			{
				MessageBox.Show("incorrect Username or Password");
				tbxPass.Clear();// If the username and password is incorrect it clears the textboxes
				tbxuser.Clear();

			}
		}

		//private void frmLogIn_Load(object sender, EventArgs e)
		//{

		//	Program.ReadFromFile(students); // Reads the information from the players file into the form
		//	if (Program.LoggedStudent != null)
		//	{
		//		tbxuser.Text = Program.LoggedStudent.Username;// This auto sets the users username and password if they just created an account
		//		tbxPass.Text = Program.LoggedStudent.Password;
		//		tbxPass.UseSystemPasswordChar = true;
		//	}
		//}

		private void frmLogIn_Load_1(object sender, EventArgs e)
		{
			Program.ReadFromFile(students); // Reads the information from the players file into the form
			if (Program.LoggedStudent != null)
			{
				tbxuser.Text = Program.LoggedStudent.Username;// This auto sets the users username and password if they just created an account
				tbxPass.Text = Program.LoggedStudent.Password;
				tbxPass.UseSystemPasswordChar = true;
			}
		}
	}


}

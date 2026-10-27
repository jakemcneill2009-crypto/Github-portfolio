using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace year_12_Redo
{
	[Serializable]
	internal class Student
	{
		public int errors = 0;

		private string _Username;
		private string _Password;
		private string _Avatar;
		private string _Year;
		private int _Score1;
		private int _Score2;
		private int _Score3;
		private int _Score4;
		private int _Score5;
		private int _TotalScore;
		private string _LastForm;
		public Student(string username, string password, string avatar,string year, int score1, int score2, int score3, int score4, int score5, int totalscore, string lastform)
		{
			Username = username;
			Password = password;
			Avatar = avatar;
			Score1 = score1;
			Score1 = score2;
			Score1 = score3;
			Score1 = score4;
			Score1 = score5;
			TotalScore = totalscore;
			LastForm = lastform;
			


		}
		public Student()
		{
		}
		public string Username
		{
			get => _Username;
			set
			{
				if (value.Length == 0) { throw new RegExceptions("You must enter a username"); }
				else if (value.Length > 20) { throw new RegExceptions("Your username must be less than 20 characters"); }
				else if (value.Length < 8) { throw new RegExceptions(" Your username must be longer than 8 characters"); }
				else { _Username = value; }
			}
		}
		public string Password
		{
			get => _Password;
			set
			{
				if (value.Length == 0) { throw new RegExceptions("You have to enter a password"); }
				else if (value.Length > 20) { throw new RegExceptions("Your Password must be less than 20 characters"); }
				else if (value.Length < 8) { throw new RegExceptions(" Your Password must be longer than 8 characters"); }
				else if (!value.Any(char.IsLetter)) { throw new RegExceptions("your password must contain at least one letter!"); }
				else if (!value.Any(char.IsDigit)) { throw new RegExceptions("Your Password must contain at least one number!"); }
				else { _Password = value; }
			}
		}

		public string Avatar { get => _Avatar; set => _Avatar = value; }
		public string Year { get => _Year; set => _Year = value; }
		public string LastForm { get => _LastForm; set => _LastForm = value; }
		public int Score1 { get => _Score1; set => _Score1 = value; }
		public int Score2 { get => _Score2; set => _Score2 = value; }
		public int Score3 { get => _Score3; set => _Score3 = value; }
		public int Score4 { get => _Score4; set => _Score4 = value; }
		public int Score5 { get => _Score5; set => _Score5 = value; }
		public int TotalScore { get => _TotalScore; set => _TotalScore = value; }

	}
}

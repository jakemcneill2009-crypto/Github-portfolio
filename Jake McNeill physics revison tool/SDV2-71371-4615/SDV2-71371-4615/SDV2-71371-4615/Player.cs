using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDV2_71371_4615
{
    [Serializable]
    public class Player
    {
        public int errors = 0;

        private string _Username;
        private string _Password;
        private string _Avatar;
        private int _HighScore;
        private DateTime _DOB;
        private int _Score1;
        private int _Score2;
        private int _Score3;
        private int _Score4;
        private int _Score5;
        private int _TotalScore;
        private string _LastForm;
        private string _Review1;
        private string _Review2;
        private string _Review3;
        private string _Review4;
        private string _Review5;
        private string _TotalReview;
        


        public Player(string username, string password, string avatar, int highScore, DateTime dOB, int score1, int score2, int score3, int score4, int score5, int totalscore, string lastform,string rev1,string rev2,string rev3,string rev4,string rev5,string revTotal)
        {
            Username = username;
            Password = password;
            Avatar = avatar;
            HighScore = highScore;
            DOB = dOB;
            Score1 = score1;
            Score1 = score2;
            Score1 = score3;
            Score1 = score4;
            Score1 = score5;
            TotalScore = totalscore;
            LastForm = lastform;
            Review1 = rev1;
            Review2 = rev2;
            Review3 = rev3;
            Review4 = rev4;
            Review5 = rev5;
            TotalReview = revTotal;
            
            
        }
        public Player()
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
        public string LastForm { get => _LastForm; set => _LastForm = value; }
        public int HighScore { get => _HighScore; set => _HighScore = value; }
        public int Score1 { get => _Score1; set => _Score1 = value; }
        public int Score2 { get => _Score2; set => _Score2 = value; }
        public int Score3 { get => _Score3; set => _Score3 = value; }
        public int Score4 { get => _Score4; set => _Score4 = value; }
        public int Score5 { get => _Score5; set => _Score5 = value; }
        public int TotalScore { get => _TotalScore; set => _TotalScore = value; }

        public DateTime DOB
        {
            get => _DOB; set => _DOB = value;
        }
        public string Review1 { get => _Review1; set => _Review1 = value; }
        public string Review2 { get => _Review2; set => _Review2 = value; }
        public string Review3 { get => _Review3; set => _Review3 = value; }
        public string Review4 { get => _Review4; set => _Review4 = value; }
        public string Review5 { get => _Review5; set => _Review5 = value; }
        public string TotalReview { get => _TotalReview; set => _TotalReview = value; }
        
        
    }
}


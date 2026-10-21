using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV2_71371_4615
{

    public partial class frmQuestion5 : Form
    {
        List<Question> listItems = new List<Question>();
        int CurrentQuestion = 0;
        string CorrectAns = "";
        string LastQuestion;
        string QuestionText;
        public frmQuestion5()
        {
            InitializeComponent();
        }
        public void SameQuestion()//Resets the question if the method is called during set up
        {
            SetUpQuestion(CurrentQuestion++);
            CurrentQuestion--;
        }

        private void frmQuestion5_Load(object sender, EventArgs e)
        {
            lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
            try
            {
                string line;
                string filePath = @"Question5.txt";

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] itemString = line.Split(',');

                        Question NewQuestion = new Question();

                        NewQuestion.QuestionText = itemString[0];//Creates a question object with the information read in from the text file
                        QuestionText = itemString[0];
                        NewQuestion.CorrectAnswer = itemString[1];
                       

                        listItems.Add(NewQuestion);
                    }
                }
                Program.RandomizeList(listItems);
                SetUpQuestion(CurrentQuestion);
            }
            catch (Exception z)
            {
                Console.WriteLine("The file could not be read");// Throws an exception if the playerlist.bin file couldn't be found
                Console.WriteLine(z.Message);
            }
        }
        private void SetUpQuestion(int QuestionNumber)
        {
           
            lblQuestion.Text = listItems[QuestionNumber].QuestionText;
            LastQuestion = QuestionText;
            QuestionText = lblQuestion.Text;
            CorrectAns = listItems[QuestionNumber].CorrectAnswer; 
            if(QuestionText == LastQuestion)
            {
                SameQuestion();
                
            }
        }
        private void btnAns2_Click(object sender, EventArgs e)
        {
            if (btnAns2.Text == CorrectAns)// Checks to see if the users answer is correct
            {
                Program.LoggedPlayer.Score5 += 2;// Adds 2 score to the users score5 variable and 2 to the total score
                Program.LoggedPlayer.TotalScore += 2;
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                SetUpQuestion(CurrentQuestion++);//Resets the question
                Countdown += 1;// Adds one second to the countdown
                if (CurrentQuestion ==15)// Checks to see if the user has answered all of the questions on the form
                {
                    tmrCountDown.Stop();// Stops the timer and displays a message box telling the user that they have answered all of the questions on the form
                    MessageBox.Show("Well done you answered all the questions before time ran out");
                    frmQuizReview newform = new frmQuizReview();
                   
                    if (Program.LoggedPlayer.Score5 >= 2 && Program.LoggedPlayer.Score5 < 6)// Gives the user a review based on how they answered the question
                    {
                        MessageBox.Show("You need to do alot more revision");
                        Program.LoggedPlayer.Review5 = "";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 6 && Program.LoggedPlayer.Score5 < 8)
                    {
                        MessageBox.Show("You need to do some more work");
                        Program.LoggedPlayer.Review5 = "You need to do some more work";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 8 && Program.LoggedPlayer.Score5 <= 10)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review5 = "Well Done";

                    }
                    else if (Program.LoggedPlayer.Score5 > 10)
                    {
                        MessageBox.Show("Well done you got the highest Boundary");
                        Program.LoggedPlayer.Review5 = "you got the highest Boundary";
                    }
                    else

                    {
                        MessageBox.Show("You need to do alot more Revision");
                        Program.LoggedPlayer.Review5 = "You need to do alot more revision";
                    }

                    
                    
                    newform.Show();// Hides the question 5 form and opens the quiz review form
                    this.Hide();

                }
            }
            else
            {
                    SetUpQuestion(CurrentQuestion++);// If the user gets the answer wrong they don't recieve any score and the question is reset.
                Countdown -= 3;// Takes 3 seconds away from the countdown
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                if (CurrentQuestion == 15)
                {
                    tmrCountDown.Stop();
                    MessageBox.Show("Well done you answered all the questions before time ran out");
                    frmQuizReview newform = new frmQuizReview();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score5 >= 2 && Program.LoggedPlayer.Score5 < 6)
                    {
                        MessageBox.Show("You need to do alot more revision");
                        Program.LoggedPlayer.Review5 = "";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 6 && Program.LoggedPlayer.Score5 < 8)
                    {
                        MessageBox.Show("You need to do some more work");
                        Program.LoggedPlayer.Review5 = "You need to do some more work";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 8 && Program.LoggedPlayer.Score5 <= 10)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review5 = "Well Done";

                    }
                    else if (Program.LoggedPlayer.Score5 > 10)
                    {
                        MessageBox.Show("Well done you got the highest Boundary");
                        Program.LoggedPlayer.Review5 = "you got the highest Boundary";
                    }
                    else

                    {
                        MessageBox.Show("You need to do alot more Revision");
                        Program.LoggedPlayer.Review5 = "You need to do alot more revision";
                    }

                   
                    newform.Show();
                    this.Hide();

                }
            }
        }

        private void btnAns1_Click(object sender, EventArgs e)
        {
            if (btnAns1.Text == CorrectAns)
            {
                Program.LoggedPlayer.Score5 += 2;
                Program.LoggedPlayer.TotalScore += 2;
                SetUpQuestion(CurrentQuestion++);
                Countdown += 1;
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                if (CurrentQuestion == 15)
                {
                    tmrCountDown.Stop();
                    MessageBox.Show("Well done you answered all the questions before time ran out");
                    frmQuizReview newform = new frmQuizReview();
                    
                    if (Program.LoggedPlayer.Score5 >= 2 && Program.LoggedPlayer.Score5 < 6)
                    {
                        MessageBox.Show("You need to do alot more revision");
                        Program.LoggedPlayer.Review5 = "";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 6 && Program.LoggedPlayer.Score5 < 8)
                    {
                        MessageBox.Show("You need to do some more work");
                        Program.LoggedPlayer.Review5 = "You need to do some more work";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 8 && Program.LoggedPlayer.Score5 <= 10)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review5 = "Well Done";

                    }
                    else if (Program.LoggedPlayer.Score5 > 10)
                    {
                        MessageBox.Show("Well done you got the highest Boundary");
                        Program.LoggedPlayer.Review5 = "Well done you got the highest Boundary";
                    }
                    else

                    {
                        MessageBox.Show("You need to do alot more Revision");
                        Program.LoggedPlayer.Review5 = "You need to do alot more revision";
                    }

                   
                    newform.Show();
                    this.Hide();

                }
            }
            else
            {
                    SetUpQuestion(CurrentQuestion++);
                Countdown -= 3;
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                if (CurrentQuestion == 15)
                {
                    
                    MessageBox.Show("Well done you answered all the questions before time ran out");
                    frmQuizReview newform = new frmQuizReview();
                   
                    
                    tmrCountDown.Stop();
                    if (Program.LoggedPlayer.Score5 >= 2 && Program.LoggedPlayer.Score5 < 6)
                    {
                        MessageBox.Show("You need to do alot more revision");
                        Program.LoggedPlayer.Review5 = "";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 6 && Program.LoggedPlayer.Score5 < 8)
                    {
                        MessageBox.Show("You need to do some more work");
                        Program.LoggedPlayer.Review5 = "You need to do some more work";
                    }
                    else if (Program.LoggedPlayer.Score5 >= 8 && Program.LoggedPlayer.Score5 <= 10)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review5 = "Well Done";

                    }
                    else if (Program.LoggedPlayer.Score5 > 10)
                    {
                        MessageBox.Show("Well done you got the highest Boundary");
                        Program.LoggedPlayer.Review5 ="you got the highest Boundary";
                    }
                    else

                    {
                        MessageBox.Show("You need to do alot more Revision");
                        Program.LoggedPlayer.Review5 = "You need to do alot more revision";
                    }

                    
                    newform.Show();
                    this.Hide();
                }
            }
        }
        int Countdown = 20;
        private void tmrCountDown_Tick(object sender, EventArgs e)
        {
            Countdown--;// Every time the timer ticks it decreases the countdown by one second

            lblTimeRemaining.Text = "Time Remaining: " + Countdown;// changes the text in lblTimeRemaining
            if (Countdown <= 0)// If the countdown is equal to 0 the timer stops and the user is taken to the quiz review form

            {
                tmrCountDown.Stop();
                MessageBox.Show("Time has ran out");
                frmQuizReview newform = new frmQuizReview();



                if (Program.LoggedPlayer.Score5 >= 2 && Program.LoggedPlayer.Score5 < 6)
                {
                    MessageBox.Show("You need to do alot more revision");
                    Program.LoggedPlayer.Review5 = "";
                }
                else if (Program.LoggedPlayer.Score5 >= 6 && Program.LoggedPlayer.Score5 < 8)
                {
                    MessageBox.Show("You need to do some more work");
                    Program.LoggedPlayer.Review5 = "You need to do some more work";
                }
                else if (Program.LoggedPlayer.Score5 >= 8 && Program.LoggedPlayer.Score5 <= 10)
                {
                    MessageBox.Show("Well Done");
                    Program.LoggedPlayer.Review5 = "Well Done";

                }
                else if (Program.LoggedPlayer.Score5 > 10)
                {
                    MessageBox.Show("Well done you got the highest Boundary");
                    Program.LoggedPlayer.Review5 = "you got the highest Boundary";
                }
                else

                {
                    MessageBox.Show("You need to do alot more Revision");
                    Program.LoggedPlayer.Review5 = "You need to do alot more revision";
                }

                
                newform.Show();
                this.Hide();
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrCountDown.Stop();
            MessageBox.Show("Answer as many questions as possible before the timer runs out to gain the most score");
            tmrCountDown.Start();
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer = null;


            frmSignUp newform = new frmSignUp();// Logs out the player and sends them back to the sign up screen
            newform.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void returnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Program.LoggedPlayer.LastForm = "Question5";
        //    frmMainMenu newform = new frmMainMenu();
        //    newform.Show();
        //}
    }
}

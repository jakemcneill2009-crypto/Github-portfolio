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
    public partial class Question1 : Form
    {
        List<Question> listItems = new List<Question>();
        int CurrentQuestion = 1;
        string CorrectAns = "";
        string QuestionText;
        string lastQuestion;
        int score = 0;
        public Question1()
        {
            InitializeComponent();
        }
        int lives = 3;
        private void Question1_Load(object sender, EventArgs e)
        {
            try
            {
                string line;
                string filePath = @"Question.txt";

                using (StreamReader sr = new StreamReader(filePath))
                {
                    while ((line = sr.ReadLine())!= null)
                    {
                        string[] itemString = line.Split(',');

                        Question NewQuestion = new Question();

                        NewQuestion.QuestionText = itemString[0];// This sets up the question by using the question1.txt file
                        QuestionText = itemString[0];
                        NewQuestion.CorrectAnswer = itemString[1];
                        NewQuestion.IncorrectAnswer1 = itemString[2];
                        NewQuestion.IncorrectAnswer2 = itemString[3];
                        NewQuestion.IncorrectAnswer3 = itemString[4];

                        listItems.Add(NewQuestion);
                    }
                }
                Program.RandomizeList(listItems);
                SetUpQuestion(CurrentQuestion);
            }
            catch (Exception z)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(z.Message);
            }
        }
        private void SetUpQuestion(int QuestionNumber)
        {
            lblQuestion.Text = listItems[QuestionNumber].QuestionText;
            lastQuestion = QuestionText;
            QuestionText = lblQuestion.Text;
            CorrectAns = listItems[QuestionNumber].CorrectAnswer;
            List<string> RandomAnswerList = new List<string>();

            RandomAnswerList.Add(listItems[QuestionNumber].CorrectAnswer);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer1); // Puts the information read in from the question 1 file into the correct spot for the question
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer2);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer3);

            Program.RandomizeList(RandomAnswerList);

            btn1.Text = RandomAnswerList[0];
            btn2.Text = RandomAnswerList[1];
            btn3.Text = RandomAnswerList[2];
            btn4.Text = RandomAnswerList[3];
            if (lastQuestion ==QuestionText)// This checks to see if the same question has appeared twice in a row
            {
                SameQuestion();
                CurrentQuestion--;
            }
        }
        private void SameQuestion()
        {
            SetUpQuestion(CurrentQuestion++);// This resets the question
        }

        private void LifeLoss()
        {
            if (lives == 3)
            {
                pbxLife3.Hide();
                lives -= 1;
            }
            else if (lives == 2)
            {
                pbxLife2.Hide();
                lives -= 1;
            }
            else if (lives == 1)
            {
                pbxLife1.Hide();
                lives -= 1;



                MessageBox.Show("You ran out of lives");
                Program.LoggedPlayer.Score1 = score;
                frmQuestion2 newform = new frmQuestion2();
                newform.Show();
                this.Hide();
                if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)// Checks the users score and gives a review depending on how they achieved
                {
                    MessageBox.Show("You need alot more practice on base units");
                    Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                }
                else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                {
                    MessageBox.Show("you need some practice on base units");
                    Program.LoggedPlayer.Review1 = "you need some practice on base units";
                }
                else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                {
                    MessageBox.Show("Well Done");
                    Program.LoggedPlayer.Review1 = "You got the highest boundary";
                }
                else
                {
                    MessageBox.Show("You need to relearn base units");
                    Program.LoggedPlayer.Review1 = "You need to relearn base units";
                }

            }
        }

        
        

        private void btn1_Click(object sender, EventArgs e)
        {
            if(btn1.Text ==CorrectAns)
            {
                MessageBox.Show("Correct");// If the text of the button the player clicks matches the correct answer it awards the user with 2 points and resets the question
                Program.LoggedPlayer.Score1 += 1;
                Program.LoggedPlayer.TotalScore += 1;
                score += 1;
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                if (CurrentQuestion ==10)// If the current question number is 5 it moves the user to the next question
                {
                    Program.LoggedPlayer.Score1 = score;
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)// This checks the score the user got to see what review message they should recieve
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
            else
            {
                MessageBox.Show("Incorrect");// If the text doesn't match the correct answer the question is reset and the user isn't awarded any score
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                LifeLoss();
                
               
                if (CurrentQuestion ==10)
                {
                    Program.LoggedPlayer.Score1 = score;
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)// Checks the users score and gives a review depending on how they achieved
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == CorrectAns)
            {
                MessageBox.Show("Correct");
                Program.LoggedPlayer.Score1 += 1;
                Program.LoggedPlayer.TotalScore += 1;
                score += 1;
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;// changes the text in the label to match the user new total score
                if (CurrentQuestion == 10)
                {
                    Program.LoggedPlayer.Score1 = score;
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
            else
            {
                MessageBox.Show("Incorrect");
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                LifeLoss();

				if (CurrentQuestion == 10)
                {
                    Program.LoggedPlayer.Score1 = score;
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == CorrectAns)
            {
                MessageBox.Show("Correct");
                Program.LoggedPlayer.Score1 += 1;
                Program.LoggedPlayer.TotalScore += 1;
                score += 1;
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                if (CurrentQuestion == 10)
                {
                    Program.LoggedPlayer.Score1 = score;
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
            else
            {
                MessageBox.Show("Incorrect");
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                LifeLoss();

				if (CurrentQuestion == 10)
                {
                    Program.LoggedPlayer.Score1 = score;
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == CorrectAns)
            {
                MessageBox.Show("Correct");
                Program.LoggedPlayer.Score1 += 1;
                Program.LoggedPlayer.TotalScore += 1;
                score += 1;
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                if (CurrentQuestion == 10)
                {
                    Program.LoggedPlayer.Score1 = score;
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();

                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
            else
            {
                MessageBox.Show("Incorrect");
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                LifeLoss();

				if (CurrentQuestion == 10)
                {
                    frmQuestion2 newform = new frmQuestion2();
                    newform.Show();
                    this.Hide();
                    if (Program.LoggedPlayer.Score1 >= 2 && Program.LoggedPlayer.Score1 < 6)
                    {
                        MessageBox.Show("You need alot more practice on base units");
                        Program.LoggedPlayer.Review1 = "You need alot more practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 6 && Program.LoggedPlayer.Score1 < 8)
                    {
                        MessageBox.Show("you need some practice on base units");
                        Program.LoggedPlayer.Review1 = "you need some practice on base units";
                    }
                    else if (Program.LoggedPlayer.Score1 >= 8 && Program.LoggedPlayer.Score1 <= 14)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review1 = "You got the highest boundary";
                    }
                    else
                    {
                        MessageBox.Show("You need to relearn base units");
                        Program.LoggedPlayer.Review1 = "You need to relearn base units";
                    }

                }
                else
                {
                    SetUpQuestion(CurrentQuestion++);
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("choose the correct answer to the question to earn score");
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer.LastForm = "Question1";// Sends the user back to the main menu and changes the Lastform variable to Question3
            frmMainMenu newform = new frmMainMenu();
            newform.Show();
            this.Hide();
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

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}

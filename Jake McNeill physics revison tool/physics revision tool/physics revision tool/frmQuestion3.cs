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
    public partial class frmQuestion3 : Form
    {
        List<Question> listItems = new List<Question>();
        int CurrentQuestion = 0;
        List<string> CorrectAnswerList = new List<string>();
        List<string> RandomAnswerList = new List<string>();
        string QuestionText;
        string lastQuestion;
        public frmQuestion3()
        {
            InitializeComponent();
        }

        private void frmQuestion3_Load(object sender, EventArgs e)
        {
            lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
            lblWord1.AllowDrop = true;
            lblWord2.AllowDrop = true;
            lblWord3.AllowDrop = true;
            lblWord4.AllowDrop = true;
            lblWord5.AllowDrop = true;
            lblAnsLine1.AllowDrop = true;
            lblAnsLine2.AllowDrop = true;
            lblAnsLine3.AllowDrop = true;
            lblAnsLine4.AllowDrop = true;
            lblAnsLine5.AllowDrop = true;
            try
            {
                string Line;
                String Filepath = "Question3.txt";// Sets the file that needs to be used for the question
                using (StreamReader sr = new StreamReader(Filepath))
                {
                    while ((Line = sr.ReadLine()) != null)
                    {
                        string[] itemString = Line.Split(',');

                        Question NewQuestion = new Question();

                        NewQuestion.QuestionText = itemString[0];
                        QuestionText = itemString[0];
                        NewQuestion.IncorrectAnswer1 = itemString[1];
                        NewQuestion.IncorrectAnswer2 = itemString[2];// Reads in the information from the file and places it into the spots that corrospond to the information
                        NewQuestion.IncorrectAnswer3 = itemString[3];
                        NewQuestion.IncorrectAnswer4 = itemString[4];
                        NewQuestion.IncorrectAnswer5 = itemString[5];
                        NewQuestion.Textline1 = itemString[6];
                        NewQuestion.Textline2 = itemString[7];
                        NewQuestion.Textline3 = itemString[8];
                        NewQuestion.Textline4 = itemString[9];
                        NewQuestion.Textline5 = itemString[10];

                        listItems.Add(NewQuestion);
                    }
                }
                Program.RandomizeList(listItems);// Randomises the list of question to make sure the user doesn't get the same order of questions
                SetUpQuestion(CurrentQuestion);
            }
            catch (Exception z)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine(z.Message);
            }
        }
        private void SameQuestion()
        {
            SetUpQuestion(CurrentQuestion++);
        }
        private void SetUpQuestion(int QuestionNumber)
        {
            lblQuestion.Text = listItems[QuestionNumber].QuestionText;
            lastQuestion = QuestionText;
            QuestionText = lblQuestion.Text;
            lblText1.Text = listItems[QuestionNumber].Textline1;
            lblText2.Text = listItems[QuestionNumber].Textline2;
            lbltext3.Text = listItems[QuestionNumber].Textline3;
            lblText4.Text = listItems[QuestionNumber].Textline4;
            lblText5.Text = listItems[QuestionNumber].Textline5;

            CorrectAnswerList.Clear();

            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer1);
            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer2);// Creates a list of the correct order for the answers
            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer3);
            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer4);
            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer5);

            RandomAnswerList.Clear();

            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer1);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer2);// Creates a list of the random answers to put into the labels
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer3);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer4);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer5);

            Program.RandomizeList(RandomAnswerList);

            lblWord1.Text = RandomAnswerList[0];
            lblWord2.Text = RandomAnswerList[1];
            lblWord3.Text = RandomAnswerList[2];
            lblWord4.Text = RandomAnswerList[3];
            lblWord5.Text = RandomAnswerList[4];
            if (lastQuestion == QuestionText)
            {
                SameQuestion();
                CurrentQuestion--;
            }
        }

        string[] order = new string[5];
        string selected;
        string[] UserAnswer = new string[5];

        private void lblWord1_MouseDown(object sender, MouseEventArgs e)
        {
            selected = lblWord1.Text;// Sets the selected variable to whatever the user clicked
            lblWord1.DoDragDrop(lblWord1.Text, DragDropEffects.Copy); // Starts a drag drop on word1
        }

        private void lblWord2_MouseDown(object sender, MouseEventArgs e)
        {
            selected = lblWord2.Text;
            lblWord2.DoDragDrop(lblWord2.Text, DragDropEffects.Copy);
        }

        private void lblWord3_MouseDown(object sender, MouseEventArgs e)
        {
            selected = lblWord3.Text;
            lblWord3.DoDragDrop(lblWord3.Text, DragDropEffects.Copy);
        }

        private void lblWord4_MouseDown(object sender, MouseEventArgs e)
        {
            selected = lblWord4.Text;
            lblWord4.DoDragDrop(lblWord4.Text, DragDropEffects.Copy);
        }

        private void lblWord5_MouseDown(object sender, MouseEventArgs e)
        {
            selected = lblWord5.Text;
            lblWord5.DoDragDrop(lblWord5.Text, DragDropEffects.Copy);
        }

        private void lblAnsLine1_DragDrop(object sender, DragEventArgs e)
        {
            lblAnsLine1.Text = e.Data.GetData(DataFormats.Text).ToString(); // Changes the text of the answerline to the word
            UserAnswer[0] = selected; // Set the answerline where the word was dropped equal to the selected variable
        }

        private void lblAnsLine2_DragDrop(object sender, DragEventArgs e)
        {
            lblAnsLine2.Text = e.Data.GetData(DataFormats.Text).ToString();
            UserAnswer[1] = selected;
        }

        private void lblAnsLine3_DragDrop(object sender, DragEventArgs e)
        {
            lblAnsLine3.Text = e.Data.GetData(DataFormats.Text).ToString();
            UserAnswer[2] = selected;
        }

        private void lblAnsLine4_DragDrop(object sender, DragEventArgs e)
        {
            lblAnsLine4.Text = e.Data.GetData(DataFormats.Text).ToString();
            UserAnswer[3] = selected;
        }

        private void lblAnsLine5_DragDrop(object sender, DragEventArgs e)
        {
            lblAnsLine5.Text = e.Data.GetData(DataFormats.Text).ToString();
            UserAnswer[4] = selected;
        }

        private void lblAnsLine1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lblAnsLine2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lblAnsLine3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lblAnsLine4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void lblAnsLine5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        int questionNumber = 0;

        private void btnCheckOrder_Click(object sender, EventArgs e)
        {
            int Score = 0;
            for (int i = 0; i < order.Length; i++)
            {
                if (CorrectAnswerList[i] == UserAnswer[i])// If the user answer is equal to the correct answer it adds 1 to the score
                {
                    Score++; 
                }
               
            }
            if (Score == 5)// If the user gets 5 score it gives the 5 points for the score1 variable and resets the question
            {
                MessageBox.Show(string.Format("Order Correct"));
                Program.LoggedPlayer.Score3 += 5;
                Program.LoggedPlayer.TotalScore += 5;
                questionNumber += 1;
                UserAnswer[0] = null;
                UserAnswer[1] = null;
                UserAnswer[2] = null;
                UserAnswer[3] = null;
                UserAnswer[4] = null;
                lblAnsLine1.Text = "_____________";
                lblAnsLine2.Text = "_____________";
                lblAnsLine3.Text = "_____________";
                lblAnsLine4.Text = "_____________";
                lblAnsLine5.Text = "_____________";
                SetUpQuestion(questionNumber);
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;


            }
            else
            {
                MessageBox.Show(string.Format("Order Incorrect"));// If the user doesn't get 5 score it just resets the question
                questionNumber += 1;
                SetUpQuestion(questionNumber);
                UserAnswer[0] = null;
                UserAnswer[1] = null;
                UserAnswer[2] = null;
                UserAnswer[3] = null;
                UserAnswer[4] = null;
                lblAnsLine1.Text = "_____________";
                lblAnsLine2.Text = "_____________";
                lblAnsLine3.Text = "_____________";
                lblAnsLine4.Text = "_____________";
                lblAnsLine5.Text = "_____________";
                lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
            }
            if (questionNumber == 5)
            {
                frmQuestion4 newform = new frmQuestion4();// Sends the user to frmQuestion4 and uses their question 4 score to decide on a review.
                newform.Show();
                this.Hide();
                if ( Program.LoggedPlayer.Score3 < 5)
                {
                    MessageBox.Show("You need to do some revision on these topics");
                    Program.LoggedPlayer.Review3 = "You need to do alot of revision";
                }
                else if (Program.LoggedPlayer.Score3 >= 5 && Program.LoggedPlayer.Score3 < 15)
                {
                    MessageBox.Show("You did well but still need some work");
                    Program.LoggedPlayer.Review3 = "You still need some work";
                }
                else if (Program.LoggedPlayer.Score3 >= 15 && Program.LoggedPlayer.Score3 <=25)
                {
                    MessageBox.Show("Well Done");
                    Program.LoggedPlayer.Review3 = "you got the highest boundary";
                }
               
            

                
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Match the correct word with the correct statement");
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer.LastForm = "Question3";// Sends the user back to the main menu and changes the Lastform variable to Question3
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
    }
}

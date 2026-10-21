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
    public partial class frmQuestion2 : Form
    {
        List<Question> listItems = new List<Question>();
        int CurrentQuestion = 0;
        List<string> CorrectAnswerList = new List<string>();
        List<string> RandomAnswerList = new List<string>();

        public frmQuestion2()
        {
            InitializeComponent();
        }

        string[] order = new string[2];
        string selected;
        string[] UserAnswer = new string[3];
        string QuestionText;
        string lastQuestion;

        private void lblQuestion_Load(object sender, EventArgs e)
        {
            lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
            pbx1.AllowDrop = true;// this allows the picture boxes to use the drag drop mechanic
            pbx2.AllowDrop = true;
            pbx3.AllowDrop = true;
            pbxAns1.AllowDrop = true;
            pbxAns2.AllowDrop = true;
            pbxAns3.AllowDrop = true;
            try
            {
                string Line;
                String Filepath = "Question2.txt";// gives the name of the file that the information is taken from
                using (StreamReader sr = new StreamReader(Filepath))
                {
                    while ((Line = sr.ReadLine()) != null)
                    {
                        string[] itemString = Line.Split(',');

                        Question NewQuestion = new Question();

                        NewQuestion.QuestionText = itemString[0];
                        QuestionText = itemString[0];
                        NewQuestion.IncorrectAnswer1 = itemString[1];
                        NewQuestion.IncorrectAnswer2 = itemString[2];
                        NewQuestion.IncorrectAnswer3 = itemString[3];
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
        private void SameQuestion()
        {
            SetUpQuestion(CurrentQuestion++);
        }
        private void SetUpQuestion(int QuestionNumber)
        {
            lblQuestion2.Text = listItems[QuestionNumber].QuestionText;
            lastQuestion = QuestionText;
            QuestionText = lblQuestion2.Text;
            CorrectAnswerList.Clear();

            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer1);
            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer2);
            CorrectAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer3);

            RandomAnswerList.Clear();

            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer1);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer2);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer3);

            Program.RandomizeList(RandomAnswerList);

            pbx1.ImageLocation = RandomAnswerList[0];// sets the images in the image boxes to the string values stored in Randomanswerlist
            pbx2.ImageLocation = RandomAnswerList[1];
            pbx3.ImageLocation = RandomAnswerList[2];
            if (lastQuestion == QuestionText)
            {
                SameQuestion();
                CurrentQuestion--;
            }
        }


        private void pbx1_MouseDown(object sender, MouseEventArgs e)
        {
            selected = pbx1.ImageLocation; //.Name.Substring(4);
            pbx1.DoDragDrop(pbx1.Image, DragDropEffects.Copy);
        }

        private void pbx2_MouseDown(object sender, MouseEventArgs e)
        {
            selected = pbx2.ImageLocation;//Name.Substring(4);
            pbx2.DoDragDrop(pbx2.Image, DragDropEffects.Copy);
        }

        private void pbx3_MouseDown(object sender, MouseEventArgs e)
        {
            selected = pbx3.ImageLocation;//.Name.Substring(4);
            pbx3.DoDragDrop(pbx3.Image, DragDropEffects.Copy);
        }

        private void pbxAns1_DragDrop(object sender, DragEventArgs e)
        {
            pbxAns1.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            UserAnswer[0] = selected;
        }

        private void pbxAns1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxAns2_DragDrop(object sender, DragEventArgs e)
        {
            pbxAns2.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            UserAnswer[1] = selected;
        }

        private void pbxAns2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxAns3_DragDrop(object sender, DragEventArgs e)
        {
            pbxAns3.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            UserAnswer[2] = selected;
        }

        private void pbxAns3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }


        private void pbxAns4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        int questionNumber = 0;
        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Score = 0;
            if (UserAnswer[0] == null && UserAnswer[1] == null && UserAnswer[2] == null)
            {
                MessageBox.Show("Please place the images into the correct boxes");
            }
            else
            {
                for (int i = 0; i <= order.Length; i++)
                {
                    if (CorrectAnswerList[i] == UserAnswer[i])
                    {
                        Score++;

                    }
                }
                if (Score == 3)
                {
                    MessageBox.Show(string.Format("Order Correct"));// Makes a message box appear telling the user they got the answer correct and resets the for to its origional state
                    Program.LoggedPlayer.Score2 += 3;
                    Program.LoggedPlayer.TotalScore += 3;
                    questionNumber += 1;
                    pbxAns1.Image = null;
                    pbxAns2.Image = null;
                    pbxAns3.Image = null;
                    UserAnswer[0] = null;
                    UserAnswer[1] = null;
                    UserAnswer[2] = null;
                    pbx1.Image = null;
                    pbx2.Image = null;
                    pbx3.Image = null;
                    SetUpQuestion(questionNumber);// Sets up a new question
                    lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;

                }
                else
                {
                    MessageBox.Show(string.Format("Order Incorrect")); //Makes a message box appear telling the user they got the answer incorrect
                     questionNumber += 1;
                    pbxAns1.Image = null;
                    pbxAns2.Image = null;
                    pbxAns3.Image = null;
                    UserAnswer[0] = null;
                    UserAnswer[1] = null;
                    UserAnswer[2] = null;
                    pbx1.Image = null;
                    pbx2.Image = null;
                    pbx3.Image = null;

                    SetUpQuestion(questionNumber);
                    lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;



                }
                if (questionNumber == 5)
                {
                    frmQuestion3 newform = new frmQuestion3();

                    if (Program.LoggedPlayer.Score2 < 3)
                    {
                        MessageBox.Show("You need to do some revision on these topics");//Checks the users score and gives a review depending on how they did
                        Program.LoggedPlayer.Review2 = "You need alot of revision";
                    }
                    else if (Program.LoggedPlayer.Score2 >= 3 && Program.LoggedPlayer.Score2 < 9)
                    {
                        MessageBox.Show("You did well but still need some work");
                        Program.LoggedPlayer.Review2 = "You still need some work";
                    }
                    else if (Program.LoggedPlayer.Score2 >= 9 && Program.LoggedPlayer.Score2 <= 15)
                    {
                        MessageBox.Show("Well Done");
                        Program.LoggedPlayer.Review2 = "you got the highest boundary";
                    }

                    newform.Show();
                    this.Hide();
                }
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)// Displays help telling the user what to do in this form
        {
            MessageBox.Show("put the pictures in the correct order to earn score");
        }

        private void returnToMainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer.LastForm = "Question2";
            frmMainMenu newform = new frmMainMenu();
            newform.Show();
            this.Hide();
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

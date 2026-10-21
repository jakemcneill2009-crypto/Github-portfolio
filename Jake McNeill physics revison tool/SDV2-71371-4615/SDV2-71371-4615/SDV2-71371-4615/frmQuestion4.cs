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
    public partial class frmQuestion4 : Form
    {
        List<Question> listItems = new List<Question>();
        int CurrentQuestion = 1;
        string CorrectAns = "";
        //int Question = 0;
       
        public frmQuestion4()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(ProcessCmdKey);
        }

        private void ProcessCmdKey(object sender, KeyEventArgs e)
        {
            int x = pbxAvatar.Location.X;
            int y = pbxAvatar.Location.Y;
            switch(e.KeyCode)
            {
                case Keys.Left:// Moves the user to the left when the left arrow key is pressed
                    x -= 10;
                    break;
                case Keys.Right:// Moves the user to the right when the right arrow key is pressed
                    x += 10;
                    break;
                case Keys.Down:// Moves the user down when the down arrow key is pressed
                    y += 10;
                    break;
                case Keys.Up:// Moves the user up when the up arrow key is pressed
                    y -= 10;
                    break;
                case Keys.A:// Moves the user to the left when the A key is pressed
                    x -= 10;
                    break;
                case Keys.D:
                    x += 10;// Moves the user to the right when the D key is pressed
                    break;
                case Keys.S:
                    y += 10;// Moves the user down when the S key is pressed
                    break;
                case Keys.W:
                    y -= 10;// Moves the user up when the W key is pressed
                    break;
                    
            }
            pbxAvatar.Location = new Point(x, y);
            if (pbxAvatar.Bounds.IntersectsWith(pbxAns2.Bounds))
            {
                if (pbxAns2.ImageLocation == CorrectAns)// Checks to see if the users answer is the correct answer
                {
                    MessageBox.Show("Correct");
                    Program.LoggedPlayer.Score4 += 2;// Adds score to the user if they got the correct answer
                    Program.LoggedPlayer.TotalScore += 2;
                    lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                    if (CurrentQuestion == 5)// Checks to see if the current question is the fifth question
                    {
                        frmQuestion5 newform = new frmQuestion5();// Moves the user to frmQuestion5
                        newform.Show();
                        this.Hide();
                        if ( Program.LoggedPlayer.Score4 < 6)// Uses the user score for question 5 to decide on a review
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
                        }
                        

                    }
                    else
                    {
                        SetUpQuestion(CurrentQuestion++);// Sets up the question again
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect");// Displays a message box telling the user that they got the question incorrect
                    lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                    if (CurrentQuestion == 5 )
                    {
                        frmQuestion5 newform = new frmQuestion5();
                        newform.Show();
                        this.Hide();

                        if (Program.LoggedPlayer.Score4 < 6)
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
                        }
                    }
                    else
                    {
                        SetUpQuestion(CurrentQuestion++);
                    }
                }
                pbxAvatar.Location = new Point(342, 255);
            }
            else if(pbxAvatar.Bounds.IntersectsWith(pbxAns1.Bounds))
            {
                if (pbxAns1.ImageLocation == CorrectAns)
                {
                    MessageBox.Show("Correct");
                    Program.LoggedPlayer.Score4 += 2;
                    Program.LoggedPlayer.TotalScore += 2;
                    lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                    if (CurrentQuestion == 5)
                    {
                        frmQuestion5 newform = new frmQuestion5();
                        newform.Show();
                        this.Hide();

                        if (Program.LoggedPlayer.Score4 < 6)
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
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
                    if (CurrentQuestion == 5 )
                    {
                        frmQuestion5 newform = new frmQuestion5();
                        newform.Show();
                        this.Hide();

                        if (Program.LoggedPlayer.Score4 < 6)
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
                        }
                    }
                    else
                    {
                        SetUpQuestion(CurrentQuestion++);
                    }
                }
                pbxAvatar.Location = new Point(342, 255);
            }
            else if (pbxAvatar.Bounds.IntersectsWith(pbxAns3.Bounds))
            {
                if (pbxAns3.ImageLocation == CorrectAns)
                {
                    MessageBox.Show("Correct");
                    Program.LoggedPlayer.Score4 += 2;
                    Program.LoggedPlayer.TotalScore += 2;
                    lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                    if (CurrentQuestion == 5)
                    {
                        frmQuestion5 newform = new frmQuestion5();
                        newform.Show();
                        this.Hide();

                        if (Program.LoggedPlayer.Score4 < 6)
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
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
                    if (CurrentQuestion == 5)
                    {
                        frmQuestion5 newform = new frmQuestion5();
                        newform.Show();
                        this.Hide();

                        if (Program.LoggedPlayer.Score4 < 6)
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
                        }
                    }
                    else
                    {
                        SetUpQuestion(CurrentQuestion++);
                    }
                }
                pbxAvatar.Location = new Point(342, 255);
            }
            else if (pbxAvatar.Bounds.IntersectsWith(pbxAns4.Bounds))
            {
                if (pbxAns4.ImageLocation == CorrectAns)
                {
                    MessageBox.Show("Correct");
                    Program.LoggedPlayer.Score4 += 2;
                    Program.LoggedPlayer.TotalScore += 2;
                    lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
                    if (CurrentQuestion == 5)
                    {
                        frmQuestion5 newform = new frmQuestion5();
                        newform.Show();
                        this.Hide();
                        if (Program.LoggedPlayer.Score4 < 6)
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
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
                    if (CurrentQuestion == 5)
                    {
                        frmQuestion5 newform = new frmQuestion5();
                        newform.Show();
                        this.Hide();
                        if (Program.LoggedPlayer.Score4 < 6)
                        {
                            MessageBox.Show("You need to do alot more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do alot more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 6 && Program.LoggedPlayer.Score4 < 8)
                        {
                            MessageBox.Show("You need to do some more work on symbols and equipment");
                            Program.LoggedPlayer.Review4 = "You need to do some more work on equipment";
                        }
                        else if (Program.LoggedPlayer.Score4 >= 8 && Program.LoggedPlayer.Score4 <= 10)
                        {
                            MessageBox.Show("Well Done");
                            Program.LoggedPlayer.Review4 = "you got the highest boundary";
                        }


                    }
                    else
                    {
                        SetUpQuestion(CurrentQuestion++);
                    }
                }
                pbxAvatar.Location = new Point(342, 255);
            }
        }
        private void SameQuestion()// Resets the question
        {
            SetUpQuestion(CurrentQuestion++);
        }
        string LastQuestion;
        string QuestionText;
        private void frmQuestion4_Load(object sender, EventArgs e)
        {
            lblRunningScore.Text = "Total Score - " + Program.LoggedPlayer.TotalScore;
            if (Program.LoggedPlayer.Avatar == "Lloyd Berkner")
                {
                    pbxAvatar.ImageLocation = "Images/Lloyd Berkner.jpg";
                }
                else if (Program.LoggedPlayer.Avatar == "John Bardeen")
                {
                    pbxAvatar.ImageLocation = "Images/John Bardeen.jpg";
                }
                else if (Program.LoggedPlayer.Avatar == "William Arnold")
                {
                    pbxAvatar.ImageLocation = "Images/William Arnold.jpg";
                }
                else if (Program.LoggedPlayer.Avatar == "Owen ChamberLain")
                {
                    pbxAvatar.ImageLocation = "Images/Owen ChamberLain.jpg";
                }
            try
            {
                string Line;
                String Filepath = "Question4.txt";
                using (StreamReader sr = new StreamReader(Filepath))
                {
                    while ((Line = sr.ReadLine()) != null)// Reads in the information from the file.
                    {
                        string[] itemString = Line.Split(',');

                        Question NewQuestion = new Question();

                        NewQuestion.QuestionText = itemString[0];// Creates a new question object with the information that was read in
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
            SetUpQuestion(CurrentQuestion++);
            
        }
        private void SetUpQuestion(int QuestionNumber)// Sets up the next question the user will be asked
        {
            lblQuestion.Text = listItems[QuestionNumber].QuestionText;
            LastQuestion = QuestionText;
            QuestionText = lblQuestion.Text;
            CorrectAns = listItems[QuestionNumber].CorrectAnswer;
            List<string> RandomAnswerList = new List<string>();

            RandomAnswerList.Add(listItems[QuestionNumber].CorrectAnswer);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer1);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer2);
            RandomAnswerList.Add(listItems[QuestionNumber].IncorrectAnswer3);

            Program.RandomizeList(RandomAnswerList);

            pbxAns1.ImageLocation = RandomAnswerList[0];
            pbxAns2.ImageLocation = RandomAnswerList[1];
            pbxAns3.ImageLocation = RandomAnswerList[2];
            pbxAns4.ImageLocation = RandomAnswerList[3];
            if(LastQuestion == QuestionText)// Checks to see if the last question is the same as the current question
            {
                SameQuestion();
                CurrentQuestion--;
            }
        }

        private void pbxAns1_Click(object sender, EventArgs e)
        {

        }

        private void returnToMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer.LastForm = "Question4";// Returns the user to the main menu and allows them to go back with the last form string variable
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

        private void pbxAns2_Click(object sender, EventArgs e)
        {

        }
    }
}


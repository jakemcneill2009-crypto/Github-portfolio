using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV2_71371_4615
{

    public partial class frmMainMenu : Form
    {
        List<Player> players = new List<Player>();
        public frmMainMenu()
        {
            InitializeComponent();
        }


        private void frmMainMenu_Load(object sender, EventArgs e)// Sets the image for the user avatar to whatever avatar the user selected in the sign up form
        {
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
            lblUsername.Text = Program.LoggedPlayer.Username;

            players = Program.ReadFromFile(players);
            Program.SortList(players);
            SetUplistView(players);
        }
        public bool valid = false;
        private void btnStart_Click(object sender, EventArgs e)// Sets the users score in all of the quiz questions to 0
        {

            Question1 newform = new Question1();
            newform.Show();
            this.Hide();
            Program.LoggedPlayer.TotalScore = 0;
            Program.LoggedPlayer.Score1 = 0;
            Program.LoggedPlayer.Score2 = 0;
            Program.LoggedPlayer.Score3 = 0;
            Program.LoggedPlayer.Score4 = 0;
            Program.LoggedPlayer.Score5 = 0;


        }

        private void tbnHighScore_Click(object sender, EventArgs e)// Sends the user to the highscore form
        {
            frmHighScore newform = new frmHighScore();
            newform.Show();
            this.Hide();
        }
        private void SetUplistView(List<Player> players)// Sets up the list view 
        {
            ltv1.GridLines = true;
            ltv1.View = View.Details;
            ltv1.Columns.Add("Username", 100);
            
            ltv1.Columns.Add("Avatar", 70);
            ltv1.Columns.Add("HighScore", 70);// Creates the layout of the list view
            ltv1.Columns.Add("DOB", 70);
            ltv1.CheckBoxes = false;
            int count = 1;

            foreach (Player current in players)
            {
                ListViewItem item = new ListViewItem();

                item.Text = current.Username;

                
                item.SubItems.Add(current.Avatar);
                item.SubItems.Add(current.HighScore.ToString());// Adds the information from the player file to the listview
                item.SubItems.Add(current.DOB.ToString());

                ltv1.Items.Add(item);
                count += 1;
                if (count >= 10)
                {
                    break;

                }
            }
        }


        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer = null;

            
            frmSignUp newform = new frmSignUp();// logs out the player and sends them back to the sign up screen
            newform.Show();
            this.Hide();
        }


        private void btnReturn_Click(object sender, EventArgs e)
        {

            if (Program.LoggedPlayer.LastForm == "Question4")// depending on the question the user was on before they pressed to the return to main menu it will send them back to that question and reset the question
            {
                frmQuestion4 newform = new frmQuestion4();
                newform.Show();
                this.Hide();
                Program.LoggedPlayer.Score4 = 0;
            }
            if (Program.LoggedPlayer.LastForm == "Question3")
            {
                frmQuestion3 newform = new frmQuestion3();
                newform.Show();
                this.Hide();
                Program.LoggedPlayer.Score3 = 0;
            }
            if (Program.LoggedPlayer.LastForm == "Question2")
            {
                frmQuestion2 newform = new frmQuestion2();
                newform.Show();
                this.Hide();
                Program.LoggedPlayer.Score2 = 0;
            }
            if (Program.LoggedPlayer.LastForm == "Question1")
            {
                Question1 newform = new Question1();
                newform.Show();
                this.Hide();
                Program.LoggedPlayer.Score1 = 0;
            }
            else
            {
                MessageBox.Show("you haven't started the quiz yet");
            }
        }



        private void helpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Form the main menu you can start the quiz, view the Highscore screen or log out");
        }

        private void quizReviewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Program.LoggedPlayer.Score5 != 0)// this stops the user from accessing the quiz review before starting the quiz
            {
                frmQuizReview newform = new frmQuizReview();
                newform.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("You haven't completed the quiz yet");
            }

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer = null;


            frmSignUp newform = new frmSignUp();// logs out the player and sends them back to the sign up screen
            newform.Show();
            this.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV2_71371_4615
{
    public partial class frmQuizReview : Form
    {
        List<Player> players = new List<Player>();
        public frmQuizReview()
        {
             InitializeComponent();
        }
        bool valid = false;
        private void frmQuizReview_Load(object sender, EventArgs e)
        {
            players = Program.ReadFromFile(players);

            for (int i = 0; i < players.Count; i++)// Checks through all of the users until it finds the current user and if the total score is greater than the high score it replaces highscore with the total score
            {
                if (players[i].Username == Program.LoggedPlayer.Username)
                {
                    if (Program.LoggedPlayer.TotalScore > Program.LoggedPlayer.HighScore)
                    {
                        players[i].HighScore = Program.LoggedPlayer.TotalScore;
                        valid = true;
                        
                    }
                }
            }
            if (Program.LoggedPlayer.TotalScore >= 20 && Program.LoggedPlayer.TotalScore <= 40)// Uses the users total score to give a review
            {

                Program.LoggedPlayer.TotalReview = "You need to do some more work to pass";
            }
            else if (Program.LoggedPlayer.TotalScore >= 40 && Program.LoggedPlayer.TotalScore < 60)
            {

                Program.LoggedPlayer.TotalReview = "You did well but can still work some more";
            }
            else if (Program.LoggedPlayer.TotalScore >= 60 && Program.LoggedPlayer.TotalScore <= 90) 
            {
                
                Program.LoggedPlayer.TotalReview = "Well done you got the highest boundary";
            }
            
            
            else
            {
                Program.LoggedPlayer.TotalReview = "You need alot more practice with everything";
               
            }

            lblQ1Result.Text = "Question 1 Result: " + Convert.ToString(Program.LoggedPlayer.Score1);// Displays the score of the user in all of the questions and the reviews for all of the questions
            lblQ2Result.Text = "Question 2 Result: " + Convert.ToString(Program.LoggedPlayer.Score2);
            lblQ3Result.Text = "Question 3 Result: " + Convert.ToString(Program.LoggedPlayer.Score3);
            lblQ4Result.Text = "Question 4 Result: " + Convert.ToString(Program.LoggedPlayer.Score4);
            lblQ5Result.Text = "Question 5 Result: " + Convert.ToString(Program.LoggedPlayer.Score5);
            lblTotalResult.Text = "Total Score: " + Convert.ToString(Program.LoggedPlayer.TotalScore);
            lblQuiz1.Text = Program.LoggedPlayer.Review1;
            lblQuiz2.Text = Program.LoggedPlayer.Review2;
            lblQuiz3.Text = Program.LoggedPlayer.Review3;
            lblQuiz4.Text = Program.LoggedPlayer.Review4;
            lblQuiz5.Text = Program.LoggedPlayer.Review5;
            lblTotal.Text = Program.LoggedPlayer.TotalReview;
            if (valid == true)
            {
                MessageBox.Show("New HighScore of " + Program.LoggedPlayer.TotalScore);
                Program.WriteToFile(players);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            frmMainMenu newform = new frmMainMenu();
            newform.Show();
            this.Hide();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            frmHighScore newform = new frmHighScore();
            newform.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On this form you are able to see what you got in each of the questions once you are finished you can either go back to the main menu or the highscore form with the respective buttons");
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Program.LoggedPlayer = null;


            frmSignUp newform = new frmSignUp();// logs out the player and sends them back to the sign up screen
            newform.Show();
            this.Hide();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}

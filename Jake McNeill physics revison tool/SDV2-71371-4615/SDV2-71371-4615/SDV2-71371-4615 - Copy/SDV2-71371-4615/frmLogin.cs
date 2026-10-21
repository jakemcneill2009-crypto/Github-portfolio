using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV2_71371_4615
{
    public partial class frmSignUp : Form
    {
        List<Player> players = new List<Player>();
        List<string> errors = new List<string>();
        public frmSignUp()
        {
            InitializeComponent();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)// Creates a new player using the data that the user has entered into the textboxes
        {
            Player newPlayer = new Player();
            
            newPlayer.Avatar = Avatar;
            newPlayer.DOB = dtpDOB.Value;



            if (players.Count > 0)
            {
                foreach (Player current in players)
                {
                    if (current.Username == tbxUsername.Text)// Checks to make sure the usernames are not the same
                    {
                        errors.Add("Username is already in use");

                    }

                    if (current.Password == tbxPassword.Text)// Checks to make sure the Passwords are not the same
                    {
                        errors.Add("Password is already being used");

                    }
                }

                try
                    {
                        newPlayer.Username = tbxUsername.Text;
                    }
                    catch (RegExceptions ex)
                    {
                        errors.Add(ex.Message);


                    }
                    try
                    {
                        newPlayer.Password = tbxPassword.Text;
                    }
                    catch (RegExceptions ex)
                    {
                        errors.Add(ex.Message); // Adds to the error count
                    }
                

                
                if(dtpDOB.Value.Year > 2011)
                {
                    errors.Add("You are too young to be doing this quiz");// Checks the date time picker to make sure the user isn't to young
                    
                }
                else if(dtpDOB.Value.Year<2000)
                {
                    errors.Add("You are too old to be doing this quiz");// Checks the date time picker to make sure the user isn't to old

                }
                if (Avatar == null)// Checks to make sure the user entered an avatar
                {
                    errors.Add("You need to select an avatar");
                }
                if (errors.Count == 0) // If the error count is 0 the new player will be created and it writes it to the playerlist binary file
                {
                    players.Add(newPlayer);
                    Program.WriteToFile(players);
                    Program.LoggedPlayer = newPlayer;// Sets the logged player variable equal to the new player that was created
                    this.Hide();
                    FrmLoginScreen newform = new FrmLoginScreen();
                    newform.Show();
                    MessageBox.Show("Players added to the file");
                   


                }
                else // Clears the form to its origional state if the user fail to create the account
                {
                    string errorMessage = string.Join("\n", errors.ToArray());
                    MessageBox.Show(string.Format("Errors Encountered -" + "\n" + errorMessage));
                    tbxPassword.Clear();
                    tbxUsername.Clear();
                    errors.Clear();
                    pbxChosenAvatar.Image = null;
                    Avatar = "";
                }


            }
            

        }


        private void frmSignUp_Load(object sender, EventArgs e)
        {
            players = Program.ReadFromFile(players); // Reads in the playerlist
        }
        
        public string Avatar;
       

        

       

        private void pbxAvatar2_Click_1(object sender, EventArgs e)
        {
            Avatar = "Lloyd Berkner"; // When a picture box is clicked it changes the avatar variable to match
            pbxChosenAvatar.ImageLocation = "Images/Lloyd Berkner.jpg";
        }

        private void pbxAvatar1_Click(object sender, EventArgs e)
        {
            Avatar = "John Bardeen";
            pbxChosenAvatar.ImageLocation = "Images/John Bardeen.jpg";
        }

        private void pbxAvatar3_Click(object sender, EventArgs e)
        {
            Avatar = "William Arnold";
            pbxChosenAvatar.ImageLocation = "Images/William Arnold.jpg";
        }

        private void pbxAvatar4_Click(object sender, EventArgs e)
        {
            Avatar = "Owen ChamberLain";
            pbxChosenAvatar.ImageLocation = "Images/Owen ChamberLain.jpg";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            FrmLoginScreen newform = new FrmLoginScreen();
            newform.Show();
            this.Hide();
        }

        private void btnHelp_Click(object sender, EventArgs e) // Tells the user what to do on the form
        {
            MessageBox.Show("fill in the form with a username and password then select an avatar from the option avalible and finaly enter your date of birth into the data time picker. The username and password have to be betwwen 8 and 20 letters long and the password has to contail at least one letter and number");
        }

        private void dtpDOB_ValueChanged(object sender, EventArgs e)
        {
            

        }
    }
}

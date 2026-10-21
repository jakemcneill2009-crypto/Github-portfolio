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
    public partial class FrmLoginScreen : Form
    {
        List<Player> players = new List<Player>();

        public FrmLoginScreen()
        {
            InitializeComponent();
            
            
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }
        bool valid;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            foreach (Player current in players)// Checks to see if the entered username and password are in the playerlist file under the same user
            {
                if (current.Username == tbxUsername.Text && current.Password == tbxPassword.Text)
                {
                    valid = true;
                    Program.LoggedPlayer = current; // Sets the current user equal to the player in the playerlist file
                    break;
                }
               

            }
            if (valid == true)// If a valid username and password are entered it allows the user to go to the main menu
            {
                MessageBox.Show("Login Successful");
                frmMainMenu newform = new frmMainMenu();
                newform.Show();
                this.Hide();
                tbxPassword.Clear();
                tbxUsername.Clear();



            }
            else if (tbxUsername.Text == "" || tbxPassword.Text == "")
            {
                MessageBox.Show("A password or username wasn't entered please try again");
                tbxPassword.Clear();// If the username and password is incorrect it clears the textboxes
                tbxUsername.Clear();
            }
            else
            {
                MessageBox.Show("incorrect Username or Password");
                tbxPassword.Clear();// If the username and password is incorrect it clears the textboxes
                tbxUsername.Clear();

            }
        }
        
        private void FrmLoginScreen_Load(object sender, EventArgs e)
        {
            players = Program.ReadFromFile(players); // Reads the information from the players file into the form
            if (Program.LoggedPlayer != null)
            {
                tbxUsername.Text = Program.LoggedPlayer.Username;// This auto sets the users username and password if they just created an account
                tbxPassword.Text = Program.LoggedPlayer.Password;
                tbxPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)// Bring the user to the sign up form to create an account
        {
            frmSignUp newform = new frmSignUp();
            newform.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Enter your Username and password into the corrosponding textboxes and click the submit button to continue to the main menu");// This tells the user what they have to do on this form
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmHighScore : Form
    {
        List<Player> players = new List<Player>();

        public frmHighScore()
        {
            InitializeComponent();
        }

        private void frmHighScore_Load(object sender, EventArgs e)
        {
            players = Program.ReadFromFile(players);// Reads in the information from the players bin file

            SetUplistView(players);
        }
        
        
        private void SetUplistView(List<Player> players)
        {
            ltv1.GridLines = true;
            ltv1.View = View.Details;
            ltv1.Columns.Add("Username", 100);
            
            ltv1.Columns.Add("Avatar", 120);
            ltv1.Columns.Add("HighScore", 70);
            ltv1.Columns.Add("DOB", 140);// Adds the coloum names and their sizes
            ltv1.CheckBoxes = false;

            foreach (Player current in players)
            {
                ListViewItem item = new ListViewItem();

                item.Text = current.Username;

               
                item.SubItems.Add(current.Avatar);
                item.SubItems.Add(current.HighScore.ToString());// Adds information to the rows of the list
                item.SubItems.Add(current.DOB.ToString());

                ltv1.Items.Add(item);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Program.RandomizeList(players);// Randomizes the order that the players appear on the list
            ltv1.Clear();
            SetUplistView(players);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMainMenu newform = new frmMainMenu();// Takes the user back to the main menu
            newform.Show();
            this.Hide();
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On this form you can view the score of all the other players and randomize their order with the randomize button then when you want you can go back to the main menu with the back button");
        }
    }
}


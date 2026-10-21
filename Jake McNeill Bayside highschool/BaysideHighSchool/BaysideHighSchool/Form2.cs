using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaysideHighSchool
{
    public partial class frmQuiz : Form
    {
        int btncounter = 0;
        public frmQuiz()
        {
            InitializeComponent();
        }
        public void CheckClicks()
        {
            if (btncounter == 2) // when the btn counter amount reaches 2 it will disable the rest of the buttons so that they cannot be clicked more than twice

            {
                btnTeachers.Enabled = false;
                btnSafetySigns.Enabled = false;
                btnCallForHelp.Enabled = false;
                btnJumpInToHelp.Enabled = false;
                pnlQuestion2.Enabled = false;
                pnlQuestion3.Enabled = true;
            }
        }
        
        private void cbbQuestion1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxQuestion1.SelectedIndex == 1)// if the answer selected is in position 1 is selected the program will run in different ways
            {
                Program.DisplayedResult += 1;//when the correct answer in selected 1 point is added to the result
                lblDisplayedResult.Text = Program.DisplayedResult.ToString();
                MessageBox.Show("Correct plus one score");
                cbxQuestion1.BackColor = Color.Green;
                cbxQuestion1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Incorrect better luck next time\n correct answer B"); // This appears when the answer is incorrect and says the correct answer
                cbxQuestion1.BackColor = Color.Red;
                cbxQuestion1.Enabled = false;
            }
            pnlQuestion1.Enabled = false;
            pnlQuestion2.Enabled = true;
        }



        private void btnQuestion4_Click(object sender, EventArgs e)
        {
            if (tbxQuesition4.Text.ToLower() == "light") // It will change the text entered to lower case and then check it to see if it matches
            {
                Program.DisplayedResult += 1;
                lblDisplayedResult.Text = Program.DisplayedResult.ToString();
                MessageBox.Show("Correct plus one score");
                btnQuestion4.BackColor = Color.Green; // If the answer entered is correct the buttons colour will change to green
                btnQuestion4.Enabled = false;
            }
            else if (string.IsNullOrWhiteSpace(tbxQuesition4.Text)) // This will check to see if there is something entered in the textbox or not
            {
                MessageBox.Show("Answer not entered please type an answer");
                btnQuestion4.Enabled = false;
            }
            else
            {
                MessageBox.Show("Incorrect better luck next time correct answer light"); // This message will be displayed if the answer entered is not correct
                btnQuestion4.BackColor = Color.Red;
                btnQuestion4.Enabled = false;
            }
            pnlQuestion4.Enabled = false;
            pnlQuestion5.Enabled = true;
        }

        private void pbxOption3_Click(object sender, EventArgs e)
        {
            Program.DisplayedResult += 1;
            lblDisplayedResult.Text = Program.DisplayedResult.ToString();
            pbxOption1.Enabled = false;
            pbxOption2.Enabled = false;
            pbxOption3.Enabled = false;// After one of the options is selected all of them will be disabled to stop people from choosing multiple answers
            pbxOption3.ImageLocation = "Images/green tick.jpg";// If the correct answer is selected then the image will change to a green tick

        }

        private void pbxOption2_Click(object sender, EventArgs e)
        {
            pbxOption1.Enabled = false;
            pbxOption2.Enabled = false;
            pbxOption3.Enabled = false;
            pbxOption2.ImageLocation = "Images/red x.jpg";// if the incorrect answer is selected then a red x will be displayed
        }

        private void pbxOption1_Click(object sender, EventArgs e)
        {
            pbxOption1.Enabled = false;
            pbxOption2.Enabled = false;
            pbxOption3.Enabled = false;
            pbxOption1.ImageLocation = "Images/red x.jpg";
        }

        private void btnCallForHelp_Click(object sender, EventArgs e)
        {
            Program.DisplayedResult += 1;// if the correct phrase is selected 1 point will be added to their total
            lblDisplayedResult.Text = Program.DisplayedResult.ToString();
            btnCallForHelp.BackColor = Color.Green;
            btnCallForHelp.Enabled = false;
            btncounter += 1;
            CheckClicks();
        }

        private void btnSafetySigns_Click(object sender, EventArgs e)
        {
            Program.DisplayedResult += 1;
            lblDisplayedResult.Text = Program.DisplayedResult.ToString();
            btnSafetySigns.BackColor = Color.Green;// if the correct answer is selected then the 
            btnSafetySigns.Enabled = false;
            btncounter += 1;
            CheckClicks();
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            btnTeachers.BackColor = Color.Red;
            btnTeachers.Enabled = false;
            btncounter += 1; // when it is clicked 1 is added to the counter
            CheckClicks(); // when it is clicked the amount of clicks is checked and if it is two all the buttons will be dissabled
        }

        private void btnJumpInToHelp_Click(object sender, EventArgs e)
        {
            btnJumpInToHelp.BackColor = Color.Red;
            btnJumpInToHelp.Enabled = false;
            btncounter += 1;
            CheckClicks();
        }

        private void btnTrue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("incorrect answer the correct answer was false ");
            btnFalse.Enabled = false; // when one of the buttons are pressed both are dissabled to stop both being pressed.
            btnTrue.Enabled = false;
            btnTrue.BackColor = Color.Red;
            pnlQuestion3.Enabled = false;
            pnlQuestion4.Enabled = true;
        }

        private void btnFalse_Click(object sender, EventArgs e)
        {
            Program.DisplayedResult += 1;
            lblDisplayedResult.Text = Program.DisplayedResult.ToString();
            btnFalse.Enabled = false;
            btnTrue.Enabled = false;
            btnFalse.BackColor = Color.Green;
            pnlQuestion3.Enabled = false;// when the question is anwered it will disable
            pnlQuestion4.Enabled = true;
        }

        private void btnReactionTest_Click(object sender, EventArgs e)
        {
            this.Close();
            Form MoveToReactionTest = new frmReactionTime();
            MoveToReactionTest.Show();
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            pnlQuestion1.Enabled = true;
            pnlQuestion2.Enabled = false;
            pnlQuestion3.Enabled = false;
            pnlQuestion4.Enabled = false;
            pnlQuestion5.Enabled = false;
        }
    }
}
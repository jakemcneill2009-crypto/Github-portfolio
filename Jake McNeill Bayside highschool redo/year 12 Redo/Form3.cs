using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using year_12_Redo;

namespace BaysideHighSchool
{
	public partial class frmReactionTime : Form
	{
		public frmReactionTime()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Program.challengeComplete = true;
			countdown = 15;
			Program.TotalScore = Program.LoggedStudent.TotalScore + Program.ReactionTestScore;
			this.Hide();
			Form MoveToDataEnty = new frmDataEntry();
			MoveToDataEnty.Show();
		}

		private void pbx1_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx1.ImageLocation = "Images/HappyFace.jpg";
			pbx1.Enabled = false;
		}

		private void pbx4_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx4.ImageLocation = "Images/HappyFace.jpg";
			pbx4.Enabled = false;// if the correct image is selected 1 point will be added to the reaction test result and the picrure will change to the correct image
		}

		private void pbx11_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx11.ImageLocation = "Images/HappyFace.jpg";
			pbx11.Enabled = false;
		}

		private void pbx8_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx8.ImageLocation = "Images/HappyFace.jpg";
			pbx8.Enabled = false;
		}

		private void pbx7_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx7.ImageLocation = "Images/HappyFace.jpg";
			pbx7.Enabled = false;
		}

		private void pbx10_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx10.ImageLocation = "Images/HappyFace.jpg";
			pbx10.Enabled = false;
		}

		private void pbx14_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx14.ImageLocation = "Images/HappyFace.jpg";
			pbx14.Enabled = false;
		}

		private void pbx13_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore += 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx13.ImageLocation = "Images/HappyFace.jpg";
			pbx13.Enabled = false;
		}

		private void pbx2_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx2.ImageLocation = "Images/SadFace.jpg";
			pbx2.Enabled = false;
		}

		private void pbx5_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx5.ImageLocation = "Images/SadFace.jpg";
			pbx5.Enabled = false;
		}

		private void pbx9_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx9.ImageLocation = "Images/SadFace.jpg";
			pbx9.Enabled = false;// if the incorrect image is selected 1 point will be taken away from the total and the image will change to the incorrect image
		}

		private void pbx6_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx6.ImageLocation = "Images/SadFace.jpg";
			pbx6.Enabled = false;
		}

		private void pbx12_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx12.ImageLocation = "Images/SadFace.jpg";
			pbx12.Enabled = false;
		}

		private void pbx15_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx15.ImageLocation = "Images/SadFace.jpg";
			pbx15.Enabled = false;
		}

		private void pbx3_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx3.ImageLocation = "Images/SadFace.jpg";
			pbx3.Enabled = false;
		}

		private void pbx16_Click(object sender, EventArgs e)
		{
			Program.ReactionTestScore -= 1;
			lblResult.Text = "Result: " + Program.ReactionTestScore.ToString();
			pbx16.ImageLocation = "Images/SadFace.jpg";
			pbx16.Enabled = false;
		}
		private int countdown = 15;
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (countdown > 0)
			{
				countdown--;
				lblTime.Text = $"Time: {countdown} seconds";
			}
			else
			{
				timer1.Stop();
				MessageBox.Show("time up");// when the time runs out all of the options will be disabled
				pbx1.Enabled = false;
				pbx2.Enabled = false;
				pbx3.Enabled = false;
				pbx4.Enabled = false;
				pbx5.Enabled = false;
				pbx6.Enabled = false;
				pbx7.Enabled = false;
				pbx8.Enabled = false;
				pbx9.Enabled = false;
				pbx10.Enabled = false;
				pbx11.Enabled = false;
				pbx12.Enabled = false;
				pbx13.Enabled = false;
				pbx14.Enabled = false;
				pbx15.Enabled = false;
				pbx16.Enabled = false;
				btnBackToDataEntry.Enabled = true;
			}
		}

		private void frmReactionTime_Load(object sender, EventArgs e)
		{
			btnBackToDataEntry.Enabled = false;
			timer1.Enabled = true;
			pbx1.ImageLocation = "Images/RedTick.png";
			pbx8.ImageLocation = "Images/RedTick.png";
			pbx11.ImageLocation = "Images/RedTick.png";
			pbx14.ImageLocation = "Images/RedTick.png";
			pbx2.ImageLocation = "Images/green tick.jpg";
			pbx5.ImageLocation = "Images/green tick.jpg";
			pbx12.ImageLocation = "Images/green tick.jpg";
			pbx15.ImageLocation = "Images/green tick.jpg";
			pbx3.ImageLocation = "Images/red x.jpg";
			pbx9.ImageLocation = "Images/red x.jpg";
			pbx6.ImageLocation = "Images/red x.jpg";
			pbx16.ImageLocation = "Images/red x.jpg";
			pbx4.ImageLocation = "Images/GreenX.png";
			pbx7.ImageLocation = "Images/GreenX.png";
			pbx10.ImageLocation = "Images/GreenX.png";
			pbx13.ImageLocation = "Images/GreenX.png";
			pbx2.Enabled = Enabled;
			pbx3.Enabled = Enabled;
			pbx4.Enabled = Enabled;
			pbx5.Enabled = Enabled;
			pbx6.Enabled = Enabled;
			pbx7.Enabled = Enabled;
			pbx8.Enabled = Enabled;
			pbx9.Enabled = Enabled;
			pbx10.Enabled = Enabled;
			pbx11.Enabled = Enabled;
			pbx12.Enabled = Enabled;
			pbx13.Enabled = Enabled;
			pbx14.Enabled = Enabled;
			pbx15.Enabled = Enabled;
			pbx16.Enabled = Enabled;
			pbx1.Enabled = Enabled;
			countdown = 15;
			Program.ReactionTestScore = 0;





		}

		private void btnHelp_Click(object sender, EventArgs e)
		{

		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Read the task and click on the corrosponding pictures before the time runs out");
		}
	}
}

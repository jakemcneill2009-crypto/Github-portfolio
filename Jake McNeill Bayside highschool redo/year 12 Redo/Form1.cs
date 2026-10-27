namespace year_12_Redo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
		timer1.Stop();
		frmLogIn newform = new frmLogIn();
			newform.Show();
			this.Hide();
		}
	}
}

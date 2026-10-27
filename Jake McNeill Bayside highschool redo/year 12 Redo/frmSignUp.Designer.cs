namespace year_12_Redo
{
	partial class frmSignUp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSignUp));
			pbxSignUp = new PictureBox();
			panel1 = new Panel();
			tbxPassword = new TextBox();
			tbxUsername = new TextBox();
			lblSignUp = new Label();
			cbxYear = new ComboBox();
			btnCreate = new Button();
			pbx2 = new PictureBox();
			pbx4 = new PictureBox();
			pbx1 = new PictureBox();
			pbx3 = new PictureBox();
			lblPfp = new Label();
			lblYear = new Label();
			lblUsername = new Label();
			lblPassword = new Label();
			pbxChosenPfp = new PictureBox();
			BtnLogin = new Button();
			backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			((System.ComponentModel.ISupportInitialize)pbxSignUp).BeginInit();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbx2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbx4).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbx3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbxChosenPfp).BeginInit();
			SuspendLayout();
			// 
			// pbxSignUp
			// 
			pbxSignUp.Image = Properties.Resources.bayside_logo;
			pbxSignUp.Location = new Point(12, 144);
			pbxSignUp.Name = "pbxSignUp";
			pbxSignUp.Size = new Size(209, 125);
			pbxSignUp.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxSignUp.TabIndex = 1;
			pbxSignUp.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.LightSeaGreen;
			panel1.Controls.Add(tbxPassword);
			panel1.Controls.Add(tbxUsername);
			panel1.Controls.Add(lblSignUp);
			panel1.Controls.Add(cbxYear);
			panel1.Controls.Add(btnCreate);
			panel1.Controls.Add(pbx2);
			panel1.Controls.Add(pbx4);
			panel1.Controls.Add(pbx1);
			panel1.Controls.Add(pbx3);
			panel1.Controls.Add(lblPfp);
			panel1.Controls.Add(lblYear);
			panel1.Controls.Add(lblUsername);
			panel1.Controls.Add(lblPassword);
			panel1.Location = new Point(227, -6);
			panel1.Name = "panel1";
			panel1.Size = new Size(359, 468);
			panel1.TabIndex = 2;
			// 
			// tbxPassword
			// 
			tbxPassword.Location = new Point(87, 133);
			tbxPassword.Name = "tbxPassword";
			tbxPassword.Size = new Size(241, 23);
			tbxPassword.TabIndex = 17;
			// 
			// tbxUsername
			// 
			tbxUsername.Location = new Point(88, 87);
			tbxUsername.Name = "tbxUsername";
			tbxUsername.Size = new Size(240, 23);
			tbxUsername.TabIndex = 16;
			// 
			// lblSignUp
			// 
			lblSignUp.AutoSize = true;
			lblSignUp.Location = new Point(152, 25);
			lblSignUp.Name = "lblSignUp";
			lblSignUp.Size = new Size(48, 15);
			lblSignUp.TabIndex = 15;
			lblSignUp.Text = "Sign Up";
			// 
			// cbxYear
			// 
			cbxYear.FormattingEnabled = true;
			cbxYear.Items.AddRange(new object[] { "11", "12", "13", "14" });
			cbxYear.Location = new Point(88, 178);
			cbxYear.Name = "cbxYear";
			cbxYear.Size = new Size(121, 23);
			cbxYear.TabIndex = 15;
			cbxYear.SelectedIndexChanged += cbxYear_SelectedIndexChanged;
			// 
			// btnCreate
			// 
			btnCreate.BackColor = Color.FromArgb(255, 255, 192);
			btnCreate.Location = new Point(142, 395);
			btnCreate.Name = "btnCreate";
			btnCreate.Size = new Size(134, 49);
			btnCreate.TabIndex = 13;
			btnCreate.Text = "Create";
			btnCreate.UseVisualStyleBackColor = false;
			btnCreate.Click += btnCreate_Click;
			// 
			// pbx2
			// 
			pbx2.Image = (Image)resources.GetObject("pbx2.Image");
			pbx2.Location = new Point(228, 225);
			pbx2.Name = "pbx2";
			pbx2.Size = new Size(100, 65);
			pbx2.SizeMode = PictureBoxSizeMode.StretchImage;
			pbx2.TabIndex = 11;
			pbx2.TabStop = false;
			pbx2.Click += pbx2_Click;
			// 
			// pbx4
			// 
			pbx4.Image = (Image)resources.GetObject("pbx4.Image");
			pbx4.Location = new Point(228, 306);
			pbx4.Name = "pbx4";
			pbx4.Size = new Size(100, 66);
			pbx4.SizeMode = PictureBoxSizeMode.StretchImage;
			pbx4.TabIndex = 10;
			pbx4.TabStop = false;
			pbx4.Click += pbx4_Click;
			// 
			// pbx1
			// 
			pbx1.Image = (Image)resources.GetObject("pbx1.Image");
			pbx1.Location = new Point(100, 225);
			pbx1.Name = "pbx1";
			pbx1.Size = new Size(100, 65);
			pbx1.TabIndex = 9;
			pbx1.TabStop = false;
			pbx1.Click += pbx1_Click;
			// 
			// pbx3
			// 
			pbx3.Image = (Image)resources.GetObject("pbx3.Image");
			pbx3.Location = new Point(100, 306);
			pbx3.Name = "pbx3";
			pbx3.Size = new Size(100, 66);
			pbx3.SizeMode = PictureBoxSizeMode.StretchImage;
			pbx3.TabIndex = 8;
			pbx3.TabStop = false;
			pbx3.Click += pbx3_Click;
			// 
			// lblPfp
			// 
			lblPfp.AutoSize = true;
			lblPfp.Location = new Point(13, 290);
			lblPfp.Name = "lblPfp";
			lblPfp.Size = new Size(81, 15);
			lblPfp.TabIndex = 7;
			lblPfp.Text = "Profile Picture";
			// 
			// lblYear
			// 
			lblYear.AutoSize = true;
			lblYear.Location = new Point(17, 181);
			lblYear.Name = "lblYear";
			lblYear.Size = new Size(65, 15);
			lblYear.TabIndex = 6;
			lblYear.Text = "Year Group";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(24, 90);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(60, 15);
			lblUsername.TabIndex = 4;
			lblUsername.Text = "Username";
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Location = new Point(24, 136);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(57, 15);
			lblPassword.TabIndex = 5;
			lblPassword.Text = "Password";
			// 
			// pbxChosenPfp
			// 
			pbxChosenPfp.Location = new Point(644, 201);
			pbxChosenPfp.Name = "pbxChosenPfp";
			pbxChosenPfp.Size = new Size(100, 68);
			pbxChosenPfp.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxChosenPfp.TabIndex = 12;
			pbxChosenPfp.TabStop = false;
			// 
			// BtnLogin
			// 
			BtnLogin.BackColor = Color.LightSeaGreen;
			BtnLogin.Location = new Point(65, 275);
			BtnLogin.Name = "BtnLogin";
			BtnLogin.Size = new Size(99, 57);
			BtnLogin.TabIndex = 14;
			BtnLogin.Text = "Back to Log in";
			BtnLogin.UseVisualStyleBackColor = false;
			// 
			// frmSignUp
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 255, 192);
			ClientSize = new Size(800, 450);
			Controls.Add(pbxChosenPfp);
			Controls.Add(BtnLogin);
			Controls.Add(panel1);
			Controls.Add(pbxSignUp);
			Name = "frmSignUp";
			Text = "frmSignUp";
			Load += frmSignUp_Load;
			((System.ComponentModel.ISupportInitialize)pbxSignUp).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbx2).EndInit();
			((System.ComponentModel.ISupportInitialize)pbx4).EndInit();
			((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbx3).EndInit();
			((System.ComponentModel.ISupportInitialize)pbxChosenPfp).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private PictureBox pbxSignUp;
		private Panel panel1;
		private ComboBox cbxYear;
		private Button btnCreate;
		private PictureBox pbx2;
		private PictureBox pbx4;
		private PictureBox pbx1;
		private PictureBox pbx3;
		private Label lblPfp;
		private Label lblYear;
		private Label lblUsername;
		private Label lblPassword;
		private PictureBox pbxChosenPfp;
		private Button BtnLogin;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private Label lblSignUp;
		private TextBox tbxPassword;
		private TextBox tbxUsername;
	}
}
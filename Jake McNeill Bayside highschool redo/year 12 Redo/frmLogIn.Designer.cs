namespace year_12_Redo
{
	partial class frmLogIn
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
			pictureBox1 = new PictureBox();
			tbxuser = new TextBox();
			lblUsername = new Label();
			btnSignUp = new Button();
			btnEnter = new Button();
			lblPass = new Label();
			tbxPass = new TextBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.bayside_logo;
			pictureBox1.Location = new Point(225, 24);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(337, 229);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// tbxuser
			// 
			tbxuser.Location = new Point(269, 273);
			tbxuser.Name = "tbxuser";
			tbxuser.Size = new Size(303, 23);
			tbxuser.TabIndex = 2;
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Location = new Point(203, 276);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(60, 15);
			lblUsername.TabIndex = 4;
			lblUsername.Text = "Username";
			// 
			// btnSignUp
			// 
			btnSignUp.BackColor = Color.LightSeaGreen;
			btnSignUp.Location = new Point(452, 371);
			btnSignUp.Name = "btnSignUp";
			btnSignUp.Size = new Size(96, 49);
			btnSignUp.TabIndex = 5;
			btnSignUp.Text = "Sign Up";
			btnSignUp.UseVisualStyleBackColor = false;
			btnSignUp.Click += btnSignUp_Click;
			// 
			// btnEnter
			// 
			btnEnter.BackColor = Color.LightSeaGreen;
			btnEnter.Location = new Point(269, 371);
			btnEnter.Name = "btnEnter";
			btnEnter.Size = new Size(96, 49);
			btnEnter.TabIndex = 6;
			btnEnter.Text = "Enter";
			btnEnter.UseVisualStyleBackColor = false;
			btnEnter.Click += btnEnter_Click;
			// 
			// lblPass
			// 
			lblPass.AutoSize = true;
			lblPass.Location = new Point(203, 332);
			lblPass.Name = "lblPass";
			lblPass.Size = new Size(57, 15);
			lblPass.TabIndex = 7;
			lblPass.Text = "Password";
			// 
			// tbxPass
			// 
			tbxPass.Location = new Point(266, 329);
			tbxPass.Name = "tbxPass";
			tbxPass.Size = new Size(306, 23);
			tbxPass.TabIndex = 8;
			// 
			// frmLogIn
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 255, 192);
			ClientSize = new Size(800, 450);
			Controls.Add(tbxPass);
			Controls.Add(lblPass);
			Controls.Add(btnEnter);
			Controls.Add(btnSignUp);
			Controls.Add(lblUsername);
			Controls.Add(tbxuser);
			Controls.Add(pictureBox1);
			Name = "frmLogIn";
			Text = "frmLogIn";
			Load += frmLogIn_Load_1;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private PictureBox pictureBox1;
		private TextBox tbxuser;
		private Label lblUsername;
		private Button btnSignUp;
		private Button btnEnter;
		private Label lblPass;
		private TextBox tbxPass;
	}
}
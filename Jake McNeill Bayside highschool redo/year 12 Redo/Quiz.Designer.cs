namespace year_12_Redo
{
	partial class Quiz
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
			lbltitle = new Label();
			lblscore = new Label();
			btnQuestion1 = new Button();
			btnQuestion2 = new Button();
			btnQuestion3 = new Button();
			btnQuestion5 = new Button();
			btnQuestion4 = new Button();
			SuspendLayout();
			// 
			// lbltitle
			// 
			lbltitle.AutoSize = true;
			lbltitle.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lbltitle.Location = new Point(244, 174);
			lbltitle.Name = "lbltitle";
			lbltitle.Size = new Size(294, 40);
			lbltitle.TabIndex = 0;
			lbltitle.Text = "Water Safety Quiz";
			// 
			// lblscore
			// 
			lblscore.AutoSize = true;
			lblscore.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			lblscore.Location = new Point(300, 225);
			lblscore.Name = "lblscore";
			lblscore.Size = new Size(110, 40);
			lblscore.TabIndex = 1;
			lblscore.Text = "Score:";
			// 
			// btnQuestion1
			// 
			btnQuestion1.BackColor = Color.FromArgb(255, 192, 192);
			btnQuestion1.Location = new Point(28, 92);
			btnQuestion1.Name = "btnQuestion1";
			btnQuestion1.Size = new Size(199, 102);
			btnQuestion1.TabIndex = 2;
			btnQuestion1.Text = "Question 1";
			btnQuestion1.UseVisualStyleBackColor = false;
			btnQuestion1.Click += btnQuestion1_Click;
			// 
			// btnQuestion2
			// 
			btnQuestion2.BackColor = Color.FromArgb(255, 224, 192);
			btnQuestion2.Location = new Point(416, 44);
			btnQuestion2.Name = "btnQuestion2";
			btnQuestion2.Size = new Size(199, 102);
			btnQuestion2.TabIndex = 3;
			btnQuestion2.Text = "Question 2";
			btnQuestion2.UseVisualStyleBackColor = false;
			btnQuestion2.Click += btnQuestion2_Click;
			// 
			// btnQuestion3
			// 
			btnQuestion3.BackColor = Color.FromArgb(192, 255, 255);
			btnQuestion3.Location = new Point(171, 319);
			btnQuestion3.Name = "btnQuestion3";
			btnQuestion3.Size = new Size(199, 102);
			btnQuestion3.TabIndex = 4;
			btnQuestion3.Text = "Question 3";
			btnQuestion3.UseVisualStyleBackColor = false;
			btnQuestion3.Click += button3_Click;
			// 
			// btnQuestion5
			// 
			btnQuestion5.BackColor = Color.FromArgb(255, 255, 192);
			btnQuestion5.Location = new Point(614, 174);
			btnQuestion5.Name = "btnQuestion5";
			btnQuestion5.Size = new Size(157, 91);
			btnQuestion5.TabIndex = 5;
			btnQuestion5.Text = "Question 5";
			btnQuestion5.UseVisualStyleBackColor = false;
			btnQuestion5.Click += btnQuestion5_Click;
			// 
			// btnQuestion4
			// 
			btnQuestion4.BackColor = Color.FromArgb(192, 255, 192);
			btnQuestion4.Location = new Point(490, 294);
			btnQuestion4.Name = "btnQuestion4";
			btnQuestion4.Size = new Size(199, 102);
			btnQuestion4.TabIndex = 6;
			btnQuestion4.Text = "Question 4";
			btnQuestion4.UseVisualStyleBackColor = false;
			btnQuestion4.Click += btnQuestion4_Click;
			// 
			// Quiz
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 192, 255);
			ClientSize = new Size(800, 450);
			Controls.Add(btnQuestion4);
			Controls.Add(btnQuestion5);
			Controls.Add(btnQuestion3);
			Controls.Add(btnQuestion2);
			Controls.Add(btnQuestion1);
			Controls.Add(lblscore);
			Controls.Add(lbltitle);
			Name = "Quiz";
			Text = "Quiz";
			Load += Quiz_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lbltitle;
		private Label lblscore;
		private Button btnQuestion1;
		private Button btnQuestion2;
		private Button btnQuestion3;
		private Button btnQuestion5;
		private Button btnQuestion4;
	}
}
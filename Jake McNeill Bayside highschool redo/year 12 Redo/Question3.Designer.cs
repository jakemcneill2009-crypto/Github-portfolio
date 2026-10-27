namespace year_12_Redo
{
	partial class Question3
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
			lblQuestion3 = new Label();
			btnTrue = new Button();
			btnFalse = new Button();
			SuspendLayout();
			// 
			// lblQuestion3
			// 
			lblQuestion3.AutoSize = true;
			lblQuestion3.Location = new Point(75, 61);
			lblQuestion3.Name = "lblQuestion3";
			lblQuestion3.Size = new Size(314, 15);
			lblQuestion3.TabIndex = 0;
			lblQuestion3.Text = "open water isn't dangerous to swim in with others around.";
			// 
			// btnTrue
			// 
			btnTrue.BackColor = Color.FromArgb(128, 255, 255);
			btnTrue.Location = new Point(119, 113);
			btnTrue.Name = "btnTrue";
			btnTrue.Size = new Size(79, 60);
			btnTrue.TabIndex = 1;
			btnTrue.Text = "True";
			btnTrue.UseVisualStyleBackColor = false;
			btnTrue.Click += btnTrue_Click;
			// 
			// btnFalse
			// 
			btnFalse.BackColor = Color.FromArgb(255, 192, 192);
			btnFalse.Location = new Point(260, 113);
			btnFalse.Name = "btnFalse";
			btnFalse.Size = new Size(79, 60);
			btnFalse.TabIndex = 2;
			btnFalse.Text = "False";
			btnFalse.UseVisualStyleBackColor = false;
			btnFalse.Click += btnFalse_Click;
			// 
			// Question3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 255, 128);
			ClientSize = new Size(484, 230);
			Controls.Add(btnFalse);
			Controls.Add(btnTrue);
			Controls.Add(lblQuestion3);
			Name = "Question3";
			Text = "Question3";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblQuestion3;
		private Button btnTrue;
		private Button btnFalse;
	}
}
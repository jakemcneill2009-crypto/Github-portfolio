namespace year_12_Redo
{
	partial class Question1
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
			lblQuestion1 = new Label();
			cbxQuestion1 = new ComboBox();
			SuspendLayout();
			// 
			// lblQuestion1
			// 
			lblQuestion1.AutoSize = true;
			lblQuestion1.Font = new Font("Comic Sans MS", 9.75F);
			lblQuestion1.Location = new Point(115, 65);
			lblQuestion1.Name = "lblQuestion1";
			lblQuestion1.Size = new Size(314, 18);
			lblQuestion1.TabIndex = 0;
			lblQuestion1.Text = "How can cold water affect your swimming ability?";
			// 
			// cbxQuestion1
			// 
			cbxQuestion1.FormattingEnabled = true;
			cbxQuestion1.Items.AddRange(new object[] { "A) Make you swim faster", "B) Makes it harder to swim", "C) It has no effect" });
			cbxQuestion1.Location = new Point(131, 126);
			cbxQuestion1.Name = "cbxQuestion1";
			cbxQuestion1.Size = new Size(278, 23);
			cbxQuestion1.TabIndex = 1;
			cbxQuestion1.SelectedIndexChanged += cbxQuestion1_SelectedIndexChanged;
			// 
			// Question1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(192, 255, 192);
			ClientSize = new Size(544, 213);
			Controls.Add(cbxQuestion1);
			Controls.Add(lblQuestion1);
			Name = "Question1";
			Text = "Question1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblQuestion1;
		private ComboBox cbxQuestion1;
	}
}
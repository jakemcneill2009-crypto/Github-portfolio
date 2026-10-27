namespace year_12_Redo
{
	partial class question4
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
			lblQueston4 = new Label();
			tbxAnswer = new TextBox();
			btnEnter = new Button();
			SuspendLayout();
			// 
			// lblQueston4
			// 
			lblQueston4.AutoSize = true;
			lblQueston4.Location = new Point(123, 86);
			lblQueston4.Name = "lblQueston4";
			lblQueston4.Size = new Size(294, 15);
			lblQueston4.TabIndex = 0;
			lblQueston4.Text = "What could you throw to someone to help them float?";
			// 
			// tbxAnswer
			// 
			tbxAnswer.Location = new Point(60, 141);
			tbxAnswer.Name = "tbxAnswer";
			tbxAnswer.Size = new Size(235, 23);
			tbxAnswer.TabIndex = 1;
			// 
			// btnEnter
			// 
			btnEnter.Location = new Point(328, 122);
			btnEnter.Name = "btnEnter";
			btnEnter.Size = new Size(75, 67);
			btnEnter.TabIndex = 2;
			btnEnter.Text = "Enter";
			btnEnter.UseVisualStyleBackColor = true;
			btnEnter.Click += btnEnter_Click;
			// 
			// question4
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 128, 128);
			ClientSize = new Size(559, 274);
			Controls.Add(btnEnter);
			Controls.Add(tbxAnswer);
			Controls.Add(lblQueston4);
			Name = "question4";
			Text = "question4";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblQueston4;
		private TextBox tbxAnswer;
		private Button btnEnter;
	}
}
namespace year_12_Redo
{
	partial class question2
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
			lblGaps = new Label();
			lblLine1 = new Label();
			lblLine2 = new Label();
			btn1 = new Button();
			btn2 = new Button();
			btn3 = new Button();
			btn4 = new Button();
			SuspendLayout();
			// 
			// lblGaps
			// 
			lblGaps.AutoSize = true;
			lblGaps.Location = new Point(179, 57);
			lblGaps.Name = "lblGaps";
			lblGaps.Size = new Size(83, 15);
			lblGaps.TabIndex = 0;
			lblGaps.Text = "Fill in the gaps";
			// 
			// lblLine1
			// 
			lblLine1.AutoSize = true;
			lblLine1.Location = new Point(109, 88);
			lblLine1.Name = "lblLine1";
			lblLine1.Size = new Size(226, 15);
			lblLine1.TabIndex = 1;
			lblLine1.Text = "If someone is in trouble you should______.";
			// 
			// lblLine2
			// 
			lblLine2.AutoSize = true;
			lblLine2.Location = new Point(109, 117);
			lblLine2.Name = "lblLine2";
			lblLine2.Size = new Size(215, 15);
			lblLine2.TabIndex = 2;
			lblLine2.Text = "Always follow the rules set by the______.";
			// 
			// btn1
			// 
			btn1.BackColor = Color.FromArgb(0, 192, 192);
			btn1.Location = new Point(28, 158);
			btn1.Name = "btn1";
			btn1.Size = new Size(85, 49);
			btn1.TabIndex = 3;
			btn1.Text = "Jump in and help";
			btn1.UseVisualStyleBackColor = false;
			btn1.Click += btn1_Click;
			// 
			// btn2
			// 
			btn2.BackColor = Color.FromArgb(255, 128, 128);
			btn2.Location = new Point(141, 158);
			btn2.Name = "btn2";
			btn2.Size = new Size(83, 49);
			btn2.TabIndex = 4;
			btn2.Text = "Call for help";
			btn2.UseVisualStyleBackColor = false;
			btn2.Click += btn2_Click;
			// 
			// btn3
			// 
			btn3.BackColor = Color.FromArgb(255, 255, 128);
			btn3.Location = new Point(252, 158);
			btn3.Name = "btn3";
			btn3.Size = new Size(83, 49);
			btn3.TabIndex = 5;
			btn3.Text = "Teachers";
			btn3.UseVisualStyleBackColor = false;
			btn3.Click += button3_Click;
			// 
			// btn4
			// 
			btn4.BackColor = Color.FromArgb(128, 255, 128);
			btn4.Location = new Point(363, 158);
			btn4.Name = "btn4";
			btn4.Size = new Size(83, 49);
			btn4.TabIndex = 6;
			btn4.Text = "Safety signs";
			btn4.UseVisualStyleBackColor = false;
			btn4.Click += btn4_Click;
			// 
			// question2
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 192, 128);
			ClientSize = new Size(477, 219);
			Controls.Add(btn4);
			Controls.Add(btn3);
			Controls.Add(btn2);
			Controls.Add(btn1);
			Controls.Add(lblLine2);
			Controls.Add(lblLine1);
			Controls.Add(lblGaps);
			Name = "question2";
			Text = "question2";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblGaps;
		private Label lblLine1;
		private Label lblLine2;
		private Button btn1;
		private Button btn2;
		private Button btn3;
		private Button btn4;
	}
}
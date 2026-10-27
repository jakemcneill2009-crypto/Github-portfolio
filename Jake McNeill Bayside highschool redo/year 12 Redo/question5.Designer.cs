namespace year_12_Redo
{
	partial class question5
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(question5));
			lblQuestion5 = new Label();
			pbx1 = new PictureBox();
			pbx2 = new PictureBox();
			pbx3 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pbx1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbx2).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbx3).BeginInit();
			SuspendLayout();
			// 
			// lblQuestion5
			// 
			lblQuestion5.AutoSize = true;
			lblQuestion5.Location = new Point(125, 36);
			lblQuestion5.Name = "lblQuestion5";
			lblQuestion5.Size = new Size(251, 15);
			lblQuestion5.TabIndex = 0;
			lblQuestion5.Text = "What is the symbol for dangerous deep water?";
			// 
			// pbx1
			// 
			pbx1.Image = (Image)resources.GetObject("pbx1.Image");
			pbx1.Location = new Point(73, 71);
			pbx1.Name = "pbx1";
			pbx1.Size = new Size(100, 85);
			pbx1.SizeMode = PictureBoxSizeMode.StretchImage;
			pbx1.TabIndex = 1;
			pbx1.TabStop = false;
			pbx1.Click += pbx1_Click;
			// 
			// pbx2
			// 
			pbx2.Image = (Image)resources.GetObject("pbx2.Image");
			pbx2.Location = new Point(204, 71);
			pbx2.Name = "pbx2";
			pbx2.Size = new Size(100, 85);
			pbx2.SizeMode = PictureBoxSizeMode.StretchImage;
			pbx2.TabIndex = 2;
			pbx2.TabStop = false;
			pbx2.Click += pbx2_Click;
			// 
			// pbx3
			// 
			pbx3.Image = (Image)resources.GetObject("pbx3.Image");
			pbx3.Location = new Point(331, 71);
			pbx3.Name = "pbx3";
			pbx3.Size = new Size(100, 85);
			pbx3.SizeMode = PictureBoxSizeMode.StretchImage;
			pbx3.TabIndex = 3;
			pbx3.TabStop = false;
			pbx3.Click += pbx3_Click;
			// 
			// question5
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(0, 192, 192);
			ClientSize = new Size(506, 198);
			Controls.Add(pbx3);
			Controls.Add(pbx2);
			Controls.Add(pbx1);
			Controls.Add(lblQuestion5);
			Name = "question5";
			Text = "question5";
			((System.ComponentModel.ISupportInitialize)pbx1).EndInit();
			((System.ComponentModel.ISupportInitialize)pbx2).EndInit();
			((System.ComponentModel.ISupportInitialize)pbx3).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblQuestion5;
		private PictureBox pbx1;
		private PictureBox pbx2;
		private PictureBox pbx3;
	}
}
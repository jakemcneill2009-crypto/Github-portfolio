
namespace BaysideHighSchool
{
    partial class frmDataEntry
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
			lblDataEntryTitle = new Label();
			lblFirstName = new Label();
			lblSurname = new Label();
			lblGender = new Label();
			tbxFirstName = new TextBox();
			tbxSurname = new TextBox();
			pbxLogoDataEntry = new PictureBox();
			btnSubmit = new Button();
			pnlDataEntry = new Panel();
			btnAverage = new Button();
			lblAverage = new Label();
			tbxAverage = new TextBox();
			tbxAttempt2 = new TextBox();
			lblAttempt2 = new Label();
			tbxAttempt1 = new TextBox();
			lblAttempt1 = new Label();
			btnQuiz = new Button();
			lblQuizResult = new Label();
			lblReactionTime = new Label();
			lblQuizResultDisplay = new Label();
			lblReactionTimeDisplay = new Label();
			btnViewReport = new Button();
			label1 = new Label();
			lblTotalScore = new Label();
			lblTotalScoreDisplayed = new Label();
			menuStrip1 = new MenuStrip();
			helpToolStripMenuItem = new ToolStripMenuItem();
			cbxGender = new ComboBox();
			logOutToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)pbxLogoDataEntry).BeginInit();
			pnlDataEntry.SuspendLayout();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// lblDataEntryTitle
			// 
			lblDataEntryTitle.AutoSize = true;
			lblDataEntryTitle.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			lblDataEntryTitle.Location = new Point(410, 57);
			lblDataEntryTitle.Margin = new Padding(4, 0, 4, 0);
			lblDataEntryTitle.Name = "lblDataEntryTitle";
			lblDataEntryTitle.Size = new Size(175, 41);
			lblDataEntryTitle.TabIndex = 0;
			lblDataEntryTitle.Text = "Data Entry";
			lblDataEntryTitle.Click += label1_Click;
			// 
			// lblFirstName
			// 
			lblFirstName.AutoSize = true;
			lblFirstName.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblFirstName.Location = new Point(22, 189);
			lblFirstName.Margin = new Padding(4, 0, 4, 0);
			lblFirstName.Name = "lblFirstName";
			lblFirstName.Size = new Size(110, 26);
			lblFirstName.TabIndex = 1;
			lblFirstName.Text = "First Name";
			// 
			// lblSurname
			// 
			lblSurname.AutoSize = true;
			lblSurname.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblSurname.Location = new Point(42, 235);
			lblSurname.Margin = new Padding(4, 0, 4, 0);
			lblSurname.Name = "lblSurname";
			lblSurname.Size = new Size(89, 26);
			lblSurname.TabIndex = 2;
			lblSurname.Text = "Surname";
			// 
			// lblGender
			// 
			lblGender.AutoSize = true;
			lblGender.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblGender.Location = new Point(42, 281);
			lblGender.Margin = new Padding(4, 0, 4, 0);
			lblGender.Name = "lblGender";
			lblGender.Size = new Size(147, 52);
			lblGender.TabIndex = 4;
			lblGender.Text = "Gender\r\nMale or Female\r\n";
			// 
			// tbxFirstName
			// 
			tbxFirstName.Location = new Point(140, 189);
			tbxFirstName.Margin = new Padding(4, 3, 4, 3);
			tbxFirstName.Name = "tbxFirstName";
			tbxFirstName.Size = new Size(178, 23);
			tbxFirstName.TabIndex = 5;
			// 
			// tbxSurname
			// 
			tbxSurname.Location = new Point(140, 238);
			tbxSurname.Margin = new Padding(4, 3, 4, 3);
			tbxSurname.Name = "tbxSurname";
			tbxSurname.Size = new Size(178, 23);
			tbxSurname.TabIndex = 6;
			// 
			// pbxLogoDataEntry
			// 
			pbxLogoDataEntry.Image = year_12_Redo.Properties.Resources.bayside_logo;
			pbxLogoDataEntry.Location = new Point(0, 36);
			pbxLogoDataEntry.Margin = new Padding(4, 3, 4, 3);
			pbxLogoDataEntry.Name = "pbxLogoDataEntry";
			pbxLogoDataEntry.Size = new Size(270, 137);
			pbxLogoDataEntry.SizeMode = PictureBoxSizeMode.StretchImage;
			pbxLogoDataEntry.TabIndex = 9;
			pbxLogoDataEntry.TabStop = false;
			// 
			// btnSubmit
			// 
			btnSubmit.BackColor = Color.LightSeaGreen;
			btnSubmit.ForeColor = SystemColors.ControlText;
			btnSubmit.Location = new Point(354, 195);
			btnSubmit.Margin = new Padding(4, 3, 4, 3);
			btnSubmit.Name = "btnSubmit";
			btnSubmit.Size = new Size(113, 107);
			btnSubmit.TabIndex = 10;
			btnSubmit.Text = "submit";
			btnSubmit.UseVisualStyleBackColor = false;
			btnSubmit.Click += btnSubmit_Click;
			// 
			// pnlDataEntry
			// 
			pnlDataEntry.BackColor = Color.LightSeaGreen;
			pnlDataEntry.Controls.Add(btnAverage);
			pnlDataEntry.Controls.Add(lblAverage);
			pnlDataEntry.Controls.Add(tbxAverage);
			pnlDataEntry.Controls.Add(tbxAttempt2);
			pnlDataEntry.Controls.Add(lblAttempt2);
			pnlDataEntry.Controls.Add(tbxAttempt1);
			pnlDataEntry.Controls.Add(lblAttempt1);
			pnlDataEntry.Location = new Point(0, 346);
			pnlDataEntry.Margin = new Padding(4, 3, 4, 3);
			pnlDataEntry.Name = "pnlDataEntry";
			pnlDataEntry.Size = new Size(1010, 199);
			pnlDataEntry.TabIndex = 12;
			// 
			// btnAverage
			// 
			btnAverage.BackColor = Color.FromArgb(255, 255, 192);
			btnAverage.Location = new Point(548, 13);
			btnAverage.Margin = new Padding(4, 3, 4, 3);
			btnAverage.Name = "btnAverage";
			btnAverage.Size = new Size(88, 85);
			btnAverage.TabIndex = 19;
			btnAverage.Text = "Average";
			btnAverage.UseVisualStyleBackColor = false;
			btnAverage.Click += btnAverage_Click;
			// 
			// lblAverage
			// 
			lblAverage.AutoSize = true;
			lblAverage.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAverage.Location = new Point(438, 112);
			lblAverage.Margin = new Padding(4, 0, 4, 0);
			lblAverage.Name = "lblAverage";
			lblAverage.Size = new Size(147, 26);
			lblAverage.TabIndex = 18;
			lblAverage.Text = "Average lenths:";
			// 
			// tbxAverage
			// 
			tbxAverage.Location = new Point(616, 119);
			tbxAverage.Margin = new Padding(4, 3, 4, 3);
			tbxAverage.Name = "tbxAverage";
			tbxAverage.Size = new Size(116, 23);
			tbxAverage.TabIndex = 17;
			// 
			// tbxAttempt2
			// 
			tbxAttempt2.Location = new Point(144, 119);
			tbxAttempt2.Margin = new Padding(4, 3, 4, 3);
			tbxAttempt2.Name = "tbxAttempt2";
			tbxAttempt2.Size = new Size(116, 23);
			tbxAttempt2.TabIndex = 16;
			// 
			// lblAttempt2
			// 
			lblAttempt2.AutoSize = true;
			lblAttempt2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAttempt2.Location = new Point(21, 112);
			lblAttempt2.Margin = new Padding(4, 0, 4, 0);
			lblAttempt2.Name = "lblAttempt2";
			lblAttempt2.Size = new Size(99, 26);
			lblAttempt2.TabIndex = 15;
			lblAttempt2.Text = "attempt 2";
			// 
			// tbxAttempt1
			// 
			tbxAttempt1.Location = new Point(140, 45);
			tbxAttempt1.Margin = new Padding(4, 3, 4, 3);
			tbxAttempt1.Name = "tbxAttempt1";
			tbxAttempt1.Size = new Size(116, 23);
			tbxAttempt1.TabIndex = 14;
			// 
			// lblAttempt1
			// 
			lblAttempt1.AutoSize = true;
			lblAttempt1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblAttempt1.Location = new Point(21, 38);
			lblAttempt1.Margin = new Padding(4, 0, 4, 0);
			lblAttempt1.Name = "lblAttempt1";
			lblAttempt1.Size = new Size(96, 26);
			lblAttempt1.TabIndex = 14;
			lblAttempt1.Text = "attempt 1";
			// 
			// btnQuiz
			// 
			btnQuiz.BackColor = Color.LightSeaGreen;
			btnQuiz.Location = new Point(749, 179);
			btnQuiz.Margin = new Padding(4, 3, 4, 3);
			btnQuiz.Name = "btnQuiz";
			btnQuiz.Size = new Size(162, 108);
			btnQuiz.TabIndex = 0;
			btnQuiz.Text = "Quiz";
			btnQuiz.UseVisualStyleBackColor = false;
			btnQuiz.Click += btnQuiz_Click;
			// 
			// lblQuizResult
			// 
			lblQuizResult.AutoSize = true;
			lblQuizResult.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblQuizResult.Location = new Point(575, 165);
			lblQuizResult.Margin = new Padding(4, 0, 4, 0);
			lblQuizResult.Name = "lblQuizResult";
			lblQuizResult.Size = new Size(120, 26);
			lblQuizResult.TabIndex = 13;
			lblQuizResult.Text = "Quiz Result:";
			// 
			// lblReactionTime
			// 
			lblReactionTime.AutoSize = true;
			lblReactionTime.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblReactionTime.Location = new Point(575, 208);
			lblReactionTime.Margin = new Padding(4, 0, 4, 0);
			lblReactionTime.Name = "lblReactionTime";
			lblReactionTime.Size = new Size(114, 23);
			lblReactionTime.TabIndex = 20;
			lblReactionTime.Text = "Reaction time:";
			// 
			// lblQuizResultDisplay
			// 
			lblQuizResultDisplay.AutoSize = true;
			lblQuizResultDisplay.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblQuizResultDisplay.Location = new Point(703, 165);
			lblQuizResultDisplay.Margin = new Padding(4, 0, 4, 0);
			lblQuizResultDisplay.Name = "lblQuizResultDisplay";
			lblQuizResultDisplay.Size = new Size(24, 26);
			lblQuizResultDisplay.TabIndex = 21;
			lblQuizResultDisplay.Text = "0";
			// 
			// lblReactionTimeDisplay
			// 
			lblReactionTimeDisplay.AutoSize = true;
			lblReactionTimeDisplay.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblReactionTimeDisplay.Location = new Point(697, 208);
			lblReactionTimeDisplay.Margin = new Padding(4, 0, 4, 0);
			lblReactionTimeDisplay.Name = "lblReactionTimeDisplay";
			lblReactionTimeDisplay.Size = new Size(20, 23);
			lblReactionTimeDisplay.TabIndex = 22;
			lblReactionTimeDisplay.Text = "0";
			// 
			// btnViewReport
			// 
			btnViewReport.BackColor = Color.LightSeaGreen;
			btnViewReport.Location = new Point(860, 36);
			btnViewReport.Margin = new Padding(4, 3, 4, 3);
			btnViewReport.Name = "btnViewReport";
			btnViewReport.Size = new Size(125, 103);
			btnViewReport.TabIndex = 23;
			btnViewReport.Text = "view reports";
			btnViewReport.UseVisualStyleBackColor = false;
			btnViewReport.Click += btnViewReport_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(765, 366);
			label1.Margin = new Padding(4, 0, 4, 0);
			label1.Name = "label1";
			label1.Size = new Size(0, 15);
			label1.TabIndex = 24;
			// 
			// lblTotalScore
			// 
			lblTotalScore.AutoSize = true;
			lblTotalScore.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTotalScore.Location = new Point(575, 249);
			lblTotalScore.Margin = new Padding(4, 0, 4, 0);
			lblTotalScore.Name = "lblTotalScore";
			lblTotalScore.Size = new Size(98, 23);
			lblTotalScore.TabIndex = 25;
			lblTotalScore.Text = "Total score:";
			// 
			// lblTotalScoreDisplayed
			// 
			lblTotalScoreDisplayed.AutoSize = true;
			lblTotalScoreDisplayed.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblTotalScoreDisplayed.Location = new Point(681, 249);
			lblTotalScoreDisplayed.Margin = new Padding(4, 0, 4, 0);
			lblTotalScoreDisplayed.Name = "lblTotalScoreDisplayed";
			lblTotalScoreDisplayed.Size = new Size(20, 23);
			lblTotalScoreDisplayed.TabIndex = 26;
			lblTotalScoreDisplayed.Text = "0";
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem, logOutToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(1011, 24);
			menuStrip1.TabIndex = 27;
			menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(44, 20);
			helpToolStripMenuItem.Text = "Help";
			helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
			// 
			// cbxGender
			// 
			cbxGender.FormattingEnabled = true;
			cbxGender.Items.AddRange(new object[] { "Male", "Female", "Other", "Prefer not to say" });
			cbxGender.Location = new Point(139, 281);
			cbxGender.Name = "cbxGender";
			cbxGender.Size = new Size(121, 23);
			cbxGender.TabIndex = 28;
			cbxGender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// logOutToolStripMenuItem
			// 
			logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
			logOutToolStripMenuItem.Size = new Size(62, 20);
			logOutToolStripMenuItem.Text = "Log Out";
			logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
			// 
			// frmDataEntry
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 255, 192);
			ClientSize = new Size(1011, 543);
			Controls.Add(cbxGender);
			Controls.Add(lblTotalScoreDisplayed);
			Controls.Add(lblTotalScore);
			Controls.Add(label1);
			Controls.Add(btnViewReport);
			Controls.Add(lblReactionTimeDisplay);
			Controls.Add(lblQuizResultDisplay);
			Controls.Add(lblReactionTime);
			Controls.Add(lblQuizResult);
			Controls.Add(btnQuiz);
			Controls.Add(pnlDataEntry);
			Controls.Add(btnSubmit);
			Controls.Add(pbxLogoDataEntry);
			Controls.Add(tbxSurname);
			Controls.Add(tbxFirstName);
			Controls.Add(lblGender);
			Controls.Add(lblSurname);
			Controls.Add(lblFirstName);
			Controls.Add(lblDataEntryTitle);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(4, 3, 4, 3);
			Name = "frmDataEntry";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Data Entry";
			Load += frmDataEntry_Load;
			((System.ComponentModel.ISupportInitialize)pbxLogoDataEntry).EndInit();
			pnlDataEntry.ResumeLayout(false);
			pnlDataEntry.PerformLayout();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblDataEntryTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.PictureBox pbxLogoDataEntry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlDataEntry;
        private System.Windows.Forms.Label lblAttempt1;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.Label lblQuizResult;
        private System.Windows.Forms.TextBox tbxAttempt1;
        private System.Windows.Forms.TextBox tbxAttempt2;
        private System.Windows.Forms.Label lblAttempt2;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.TextBox tbxAverage;
        private System.Windows.Forms.Label lblReactionTime;
        private System.Windows.Forms.Label lblQuizResultDisplay;
        private System.Windows.Forms.Label lblReactionTimeDisplay;
        private System.Windows.Forms.Button btnViewReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalScore;
        private System.Windows.Forms.Label lblTotalScoreDisplayed;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem helpToolStripMenuItem;
		private ComboBox cbxGender;
		private ToolStripMenuItem logOutToolStripMenuItem;
	}
}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataEntry));
            this.lblDataEntryTitle = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblYearGroup = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxSurname = new System.Windows.Forms.TextBox();
            this.tbxYearGroup = new System.Windows.Forms.TextBox();
            this.TbxGender = new System.Windows.Forms.TextBox();
            this.pbxLogoDataEntry = new System.Windows.Forms.PictureBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnHelpDataEntry = new System.Windows.Forms.Button();
            this.pnlDataEntry = new System.Windows.Forms.Panel();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.tbxAverage = new System.Windows.Forms.TextBox();
            this.tbxAttempt2 = new System.Windows.Forms.TextBox();
            this.lblAttempt2 = new System.Windows.Forms.Label();
            this.tbxAttempt1 = new System.Windows.Forms.TextBox();
            this.lblAttempt1 = new System.Windows.Forms.Label();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.lblQuizResult = new System.Windows.Forms.Label();
            this.lblReactionTime = new System.Windows.Forms.Label();
            this.lblQuizResultDisplay = new System.Windows.Forms.Label();
            this.lblReactionTimeDisplay = new System.Windows.Forms.Label();
            this.btnViewReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalScore = new System.Windows.Forms.Label();
            this.lblTotalScoreDisplayed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoDataEntry)).BeginInit();
            this.pnlDataEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataEntryTitle
            // 
            this.lblDataEntryTitle.AutoSize = true;
            this.lblDataEntryTitle.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataEntryTitle.Location = new System.Drawing.Point(311, 31);
            this.lblDataEntryTitle.Name = "lblDataEntryTitle";
            this.lblDataEntryTitle.Size = new System.Drawing.Size(175, 41);
            this.lblDataEntryTitle.TabIndex = 0;
            this.lblDataEntryTitle.Text = "Data Entry";
            this.lblDataEntryTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(84, 116);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(110, 26);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(427, 116);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(89, 26);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname";
            // 
            // lblYearGroup
            // 
            this.lblYearGroup.AutoSize = true;
            this.lblYearGroup.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearGroup.Location = new System.Drawing.Point(84, 209);
            this.lblYearGroup.Name = "lblYearGroup";
            this.lblYearGroup.Size = new System.Drawing.Size(164, 26);
            this.lblYearGroup.TabIndex = 3;
            this.lblYearGroup.Text = "Year Group 11-14";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(427, 192);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(147, 52);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender\r\nMale or Female\r\n";
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(89, 145);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(153, 20);
            this.tbxFirstName.TabIndex = 5;
            // 
            // tbxSurname
            // 
            this.tbxSurname.Location = new System.Drawing.Point(432, 145);
            this.tbxSurname.Name = "tbxSurname";
            this.tbxSurname.Size = new System.Drawing.Size(153, 20);
            this.tbxSurname.TabIndex = 6;
            // 
            // tbxYearGroup
            // 
            this.tbxYearGroup.Location = new System.Drawing.Point(89, 247);
            this.tbxYearGroup.Name = "tbxYearGroup";
            this.tbxYearGroup.Size = new System.Drawing.Size(153, 20);
            this.tbxYearGroup.TabIndex = 7;
            // 
            // TbxGender
            // 
            this.TbxGender.Location = new System.Drawing.Point(432, 247);
            this.TbxGender.Name = "TbxGender";
            this.TbxGender.Size = new System.Drawing.Size(153, 20);
            this.TbxGender.TabIndex = 8;
            // 
            // pbxLogoDataEntry
            // 
            this.pbxLogoDataEntry.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoDataEntry.Image")));
            this.pbxLogoDataEntry.Location = new System.Drawing.Point(681, 12);
            this.pbxLogoDataEntry.Name = "pbxLogoDataEntry";
            this.pbxLogoDataEntry.Size = new System.Drawing.Size(139, 143);
            this.pbxLogoDataEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogoDataEntry.TabIndex = 9;
            this.pbxLogoDataEntry.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSubmit.Location = new System.Drawing.Point(285, 247);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(97, 93);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnHelpDataEntry
            // 
            this.btnHelpDataEntry.BackColor = System.Drawing.Color.Yellow;
            this.btnHelpDataEntry.Location = new System.Drawing.Point(0, 0);
            this.btnHelpDataEntry.Name = "btnHelpDataEntry";
            this.btnHelpDataEntry.Size = new System.Drawing.Size(104, 72);
            this.btnHelpDataEntry.TabIndex = 11;
            this.btnHelpDataEntry.Text = "Help";
            this.btnHelpDataEntry.UseVisualStyleBackColor = false;
            this.btnHelpDataEntry.Click += new System.EventHandler(this.btnHelpDataEntry_Click);
            // 
            // pnlDataEntry
            // 
            this.pnlDataEntry.BackColor = System.Drawing.Color.Lime;
            this.pnlDataEntry.Controls.Add(this.btnAverage);
            this.pnlDataEntry.Controls.Add(this.lblAverage);
            this.pnlDataEntry.Controls.Add(this.tbxAverage);
            this.pnlDataEntry.Controls.Add(this.tbxAttempt2);
            this.pnlDataEntry.Controls.Add(this.lblAttempt2);
            this.pnlDataEntry.Controls.Add(this.tbxAttempt1);
            this.pnlDataEntry.Controls.Add(this.lblAttempt1);
            this.pnlDataEntry.Location = new System.Drawing.Point(0, 346);
            this.pnlDataEntry.Name = "pnlDataEntry";
            this.pnlDataEntry.Size = new System.Drawing.Size(866, 200);
            this.pnlDataEntry.TabIndex = 12;
            // 
            // btnAverage
            // 
            this.btnAverage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAverage.Location = new System.Drawing.Point(470, 11);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(75, 74);
            this.btnAverage.TabIndex = 19;
            this.btnAverage.Text = "Average";
            this.btnAverage.UseVisualStyleBackColor = false;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage.Location = new System.Drawing.Point(375, 97);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(147, 26);
            this.lblAverage.TabIndex = 18;
            this.lblAverage.Text = "Average lenths:";
            // 
            // tbxAverage
            // 
            this.tbxAverage.Location = new System.Drawing.Point(528, 103);
            this.tbxAverage.Name = "tbxAverage";
            this.tbxAverage.Size = new System.Drawing.Size(100, 20);
            this.tbxAverage.TabIndex = 17;
            // 
            // tbxAttempt2
            // 
            this.tbxAttempt2.Location = new System.Drawing.Point(123, 103);
            this.tbxAttempt2.Name = "tbxAttempt2";
            this.tbxAttempt2.Size = new System.Drawing.Size(100, 20);
            this.tbxAttempt2.TabIndex = 16;
            // 
            // lblAttempt2
            // 
            this.lblAttempt2.AutoSize = true;
            this.lblAttempt2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempt2.Location = new System.Drawing.Point(18, 97);
            this.lblAttempt2.Name = "lblAttempt2";
            this.lblAttempt2.Size = new System.Drawing.Size(99, 26);
            this.lblAttempt2.TabIndex = 15;
            this.lblAttempt2.Text = "attempt 2";
            // 
            // tbxAttempt1
            // 
            this.tbxAttempt1.Location = new System.Drawing.Point(120, 39);
            this.tbxAttempt1.Name = "tbxAttempt1";
            this.tbxAttempt1.Size = new System.Drawing.Size(100, 20);
            this.tbxAttempt1.TabIndex = 14;
            // 
            // lblAttempt1
            // 
            this.lblAttempt1.AutoSize = true;
            this.lblAttempt1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempt1.Location = new System.Drawing.Point(18, 33);
            this.lblAttempt1.Name = "lblAttempt1";
            this.lblAttempt1.Size = new System.Drawing.Size(96, 26);
            this.lblAttempt1.TabIndex = 14;
            this.lblAttempt1.Text = "attempt 1";
            // 
            // btnQuiz
            // 
            this.btnQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnQuiz.Location = new System.Drawing.Point(681, 209);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(139, 58);
            this.btnQuiz.TabIndex = 0;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = false;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // lblQuizResult
            // 
            this.lblQuizResult.AutoSize = true;
            this.lblQuizResult.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizResult.Location = new System.Drawing.Point(665, 268);
            this.lblQuizResult.Name = "lblQuizResult";
            this.lblQuizResult.Size = new System.Drawing.Size(120, 26);
            this.lblQuizResult.TabIndex = 13;
            this.lblQuizResult.Text = "Quiz Result:";
            // 
            // lblReactionTime
            // 
            this.lblReactionTime.AutoSize = true;
            this.lblReactionTime.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReactionTime.Location = new System.Drawing.Point(671, 294);
            this.lblReactionTime.Name = "lblReactionTime";
            this.lblReactionTime.Size = new System.Drawing.Size(114, 23);
            this.lblReactionTime.TabIndex = 20;
            this.lblReactionTime.Text = "Reaction time:";
            // 
            // lblQuizResultDisplay
            // 
            this.lblQuizResultDisplay.AutoSize = true;
            this.lblQuizResultDisplay.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuizResultDisplay.Location = new System.Drawing.Point(791, 270);
            this.lblQuizResultDisplay.Name = "lblQuizResultDisplay";
            this.lblQuizResultDisplay.Size = new System.Drawing.Size(24, 26);
            this.lblQuizResultDisplay.TabIndex = 21;
            this.lblQuizResultDisplay.Text = "0";
            // 
            // lblReactionTimeDisplay
            // 
            this.lblReactionTimeDisplay.AutoSize = true;
            this.lblReactionTimeDisplay.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReactionTimeDisplay.Location = new System.Drawing.Point(792, 296);
            this.lblReactionTimeDisplay.Name = "lblReactionTimeDisplay";
            this.lblReactionTimeDisplay.Size = new System.Drawing.Size(20, 23);
            this.lblReactionTimeDisplay.TabIndex = 22;
            this.lblReactionTimeDisplay.Text = "0";
            // 
            // btnViewReport
            // 
            this.btnViewReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewReport.Location = new System.Drawing.Point(587, 14);
            this.btnViewReport.Name = "btnViewReport";
            this.btnViewReport.Size = new System.Drawing.Size(75, 58);
            this.btnViewReport.TabIndex = 23;
            this.btnViewReport.Text = "view reports";
            this.btnViewReport.UseVisualStyleBackColor = false;
            this.btnViewReport.Click += new System.EventHandler(this.btnViewReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(656, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 24;
            // 
            // lblTotalScore
            // 
            this.lblTotalScore.AutoSize = true;
            this.lblTotalScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScore.Location = new System.Drawing.Point(677, 317);
            this.lblTotalScore.Name = "lblTotalScore";
            this.lblTotalScore.Size = new System.Drawing.Size(98, 23);
            this.lblTotalScore.TabIndex = 25;
            this.lblTotalScore.Text = "Total score:";
            // 
            // lblTotalScoreDisplayed
            // 
            this.lblTotalScoreDisplayed.AutoSize = true;
            this.lblTotalScoreDisplayed.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalScoreDisplayed.Location = new System.Drawing.Point(776, 320);
            this.lblTotalScoreDisplayed.Name = "lblTotalScoreDisplayed";
            this.lblTotalScoreDisplayed.Size = new System.Drawing.Size(20, 23);
            this.lblTotalScoreDisplayed.TabIndex = 26;
            this.lblTotalScoreDisplayed.Text = "0";
            // 
            // frmDataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(867, 546);
            this.Controls.Add(this.lblTotalScoreDisplayed);
            this.Controls.Add(this.lblTotalScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewReport);
            this.Controls.Add(this.lblReactionTimeDisplay);
            this.Controls.Add(this.lblQuizResultDisplay);
            this.Controls.Add(this.lblReactionTime);
            this.Controls.Add(this.lblQuizResult);
            this.Controls.Add(this.btnQuiz);
            this.Controls.Add(this.pnlDataEntry);
            this.Controls.Add(this.btnHelpDataEntry);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.pbxLogoDataEntry);
            this.Controls.Add(this.TbxGender);
            this.Controls.Add(this.tbxYearGroup);
            this.Controls.Add(this.tbxSurname);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblYearGroup);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblDataEntryTitle);
            this.Name = "frmDataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Entry";
            this.Load += new System.EventHandler(this.frmDataEntry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoDataEntry)).EndInit();
            this.pnlDataEntry.ResumeLayout(false);
            this.pnlDataEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataEntryTitle;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblYearGroup;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxSurname;
        private System.Windows.Forms.TextBox tbxYearGroup;
        private System.Windows.Forms.TextBox TbxGender;
        private System.Windows.Forms.PictureBox pbxLogoDataEntry;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnHelpDataEntry;
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
    }
}
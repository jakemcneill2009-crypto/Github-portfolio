
namespace BaysideHighSchool
{
    partial class frmReport
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
			btnBack = new Button();
			ltvReports = new ListView();
			FirstName = new ColumnHeader();
			Surname = new ColumnHeader();
			YearGroup = new ColumnHeader();
			Gender = new ColumnHeader();
			AverageLengths = new ColumnHeader();
			TotalScore = new ColumnHeader();
			Group = new ColumnHeader();
			lblReport = new Label();
			pbxLogo = new PictureBox();
			btnViewAll = new Button();
			cbxReports = new ComboBox();
			cbxYearGroup = new ComboBox();
			menuStrip1 = new MenuStrip();
			helpToolStripMenuItem = new ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// btnBack
			// 
			btnBack.BackColor = Color.LightSeaGreen;
			btnBack.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnBack.Location = new Point(13, 425);
			btnBack.Margin = new Padding(4, 3, 4, 3);
			btnBack.Name = "btnBack";
			btnBack.Size = new Size(121, 82);
			btnBack.TabIndex = 0;
			btnBack.Text = "Back";
			btnBack.UseVisualStyleBackColor = false;
			btnBack.Click += btnBack_Click;
			// 
			// ltvReports
			// 
			ltvReports.Columns.AddRange(new ColumnHeader[] { FirstName, Surname, YearGroup, Gender, AverageLengths, TotalScore, Group });
			ltvReports.Location = new Point(258, 156);
			ltvReports.Margin = new Padding(4, 3, 4, 3);
			ltvReports.Name = "ltvReports";
			ltvReports.Size = new Size(614, 261);
			ltvReports.TabIndex = 1;
			ltvReports.UseCompatibleStateImageBehavior = false;
			ltvReports.View = View.Details;
			ltvReports.ColumnClick += ltvReports_ColumnClick;
			// 
			// FirstName
			// 
			FirstName.Text = "First Name";
			FirstName.Width = 66;
			// 
			// Surname
			// 
			Surname.Text = "Surname";
			Surname.Width = 55;
			// 
			// YearGroup
			// 
			YearGroup.Text = "Year Group";
			YearGroup.Width = 67;
			// 
			// Gender
			// 
			Gender.Text = "Gender";
			Gender.Width = 47;
			// 
			// AverageLengths
			// 
			AverageLengths.Text = "Average Lengths";
			AverageLengths.Width = 95;
			// 
			// TotalScore
			// 
			TotalScore.Text = "Total Score";
			TotalScore.Width = 71;
			// 
			// Group
			// 
			Group.Text = "Group";
			Group.Width = 79;
			// 
			// lblReport
			// 
			lblReport.AutoSize = true;
			lblReport.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			lblReport.Location = new Point(492, 61);
			lblReport.Margin = new Padding(4, 0, 4, 0);
			lblReport.Name = "lblReport";
			lblReport.Size = new Size(111, 40);
			lblReport.TabIndex = 2;
			lblReport.Text = "Report";
			// 
			// pbxLogo
			// 
			pbxLogo.Image = year_12_Redo.Properties.Resources.bayside_logo;
			pbxLogo.Location = new Point(13, 32);
			pbxLogo.Margin = new Padding(4, 3, 4, 3);
			pbxLogo.Name = "pbxLogo";
			pbxLogo.Size = new Size(208, 136);
			pbxLogo.TabIndex = 8;
			pbxLogo.TabStop = false;
			// 
			// btnViewAll
			// 
			btnViewAll.BackColor = Color.LightSeaGreen;
			btnViewAll.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			btnViewAll.Location = new Point(784, 423);
			btnViewAll.Margin = new Padding(4, 3, 4, 3);
			btnViewAll.Name = "btnViewAll";
			btnViewAll.Size = new Size(88, 43);
			btnViewAll.TabIndex = 5;
			btnViewAll.Text = "View all";
			btnViewAll.UseVisualStyleBackColor = false;
			btnViewAll.Click += btnViewAll_Click;
			// 
			// cbxReports
			// 
			cbxReports.FormattingEnabled = true;
			cbxReports.Items.AddRange(new object[] { "advanced", "swimmer", "Non-swimmer" });
			cbxReports.Location = new Point(37, 230);
			cbxReports.Margin = new Padding(4, 3, 4, 3);
			cbxReports.Name = "cbxReports";
			cbxReports.Size = new Size(140, 23);
			cbxReports.TabIndex = 6;
			cbxReports.SelectedIndexChanged += cbxReports_SelectedIndexChanged;
			// 
			// cbxYearGroup
			// 
			cbxYearGroup.FormattingEnabled = true;
			cbxYearGroup.Items.AddRange(new object[] { "11", "12", "13", "14" });
			cbxYearGroup.Location = new Point(37, 309);
			cbxYearGroup.Margin = new Padding(4, 3, 4, 3);
			cbxYearGroup.Name = "cbxYearGroup";
			cbxYearGroup.Size = new Size(140, 23);
			cbxYearGroup.TabIndex = 7;
			cbxYearGroup.SelectedIndexChanged += cbxYearGroup_SelectedIndexChanged;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { helpToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(933, 24);
			menuStrip1.TabIndex = 9;
			menuStrip1.Text = "menuStrip1";
			// 
			// helpToolStripMenuItem
			// 
			helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			helpToolStripMenuItem.Size = new Size(44, 20);
			helpToolStripMenuItem.Text = "Help";
			helpToolStripMenuItem.Click += helpToolStripMenuItem_Click;
			// 
			// frmReport
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(255, 255, 192);
			ClientSize = new Size(933, 519);
			Controls.Add(cbxYearGroup);
			Controls.Add(cbxReports);
			Controls.Add(btnViewAll);
			Controls.Add(pbxLogo);
			Controls.Add(lblReport);
			Controls.Add(ltvReports);
			Controls.Add(btnBack);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(4, 3, 4, 3);
			Name = "frmReport";
			Text = "Report";
			Load += frmReport_Load;
			((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListView ltvReports;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader YearGroup;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader AverageLengths;
        private System.Windows.Forms.ColumnHeader TotalScore;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox cbxReports;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ComboBox cbxYearGroup;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem helpToolStripMenuItem;
	}
}
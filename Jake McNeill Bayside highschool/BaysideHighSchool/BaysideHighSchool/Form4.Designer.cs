
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
            this.btnBack = new System.Windows.Forms.Button();
            this.ltvReports = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.YearGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AverageLengths = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Group = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblReport = new System.Windows.Forms.Label();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.cbxReports = new System.Windows.Forms.ComboBox();
            this.cbxYearGroup = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBack.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 71);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ltvReports
            // 
            this.ltvReports.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.Surname,
            this.YearGroup,
            this.Gender,
            this.AverageLengths,
            this.TotalScore,
            this.Group});
            this.ltvReports.HideSelection = false;
            this.ltvReports.Location = new System.Drawing.Point(241, 138);
            this.ltvReports.Name = "ltvReports";
            this.ltvReports.Size = new System.Drawing.Size(487, 213);
            this.ltvReports.TabIndex = 1;
            this.ltvReports.UseCompatibleStateImageBehavior = false;
            this.ltvReports.View = System.Windows.Forms.View.Details;
            this.ltvReports.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ltvReports_ColumnClick);
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 66;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 55;
            // 
            // YearGroup
            // 
            this.YearGroup.Text = "Year Group";
            this.YearGroup.Width = 67;
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            this.Gender.Width = 47;
            // 
            // AverageLengths
            // 
            this.AverageLengths.Text = "Average Lengths";
            this.AverageLengths.Width = 95;
            // 
            // TotalScore
            // 
            this.TotalScore.Text = "Total Score";
            this.TotalScore.Width = 71;
            // 
            // Group
            // 
            this.Group.Text = "Group";
            this.Group.Width = 79;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(223, 63);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(111, 40);
            this.lblReport.TabIndex = 2;
            this.lblReport.Text = "Report";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::BaysideHighSchool.Properties.Resources.bayside_logo;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(205, 133);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbxLogo.TabIndex = 3;
            this.pbxLogo.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(662, 23);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(98, 64);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnViewAll.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.Location = new System.Drawing.Point(672, 367);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 37);
            this.btnViewAll.TabIndex = 5;
            this.btnViewAll.Text = "View all";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // cbxReports
            // 
            this.cbxReports.FormattingEnabled = true;
            this.cbxReports.Items.AddRange(new object[] {
            "advanced",
            "swimmer",
            "Non-swimmer"});
            this.cbxReports.Location = new System.Drawing.Point(32, 251);
            this.cbxReports.Name = "cbxReports";
            this.cbxReports.Size = new System.Drawing.Size(121, 21);
            this.cbxReports.TabIndex = 6;
            this.cbxReports.SelectedIndexChanged += new System.EventHandler(this.cbxReports_SelectedIndexChanged);
            // 
            // cbxYearGroup
            // 
            this.cbxYearGroup.FormattingEnabled = true;
            this.cbxYearGroup.Items.AddRange(new object[] {
            "11",
            "12",
            "13",
            "14"});
            this.cbxYearGroup.Location = new System.Drawing.Point(32, 306);
            this.cbxYearGroup.Name = "cbxYearGroup";
            this.cbxYearGroup.Size = new System.Drawing.Size(121, 21);
            this.cbxYearGroup.TabIndex = 7;
            this.cbxYearGroup.SelectedIndexChanged += new System.EventHandler(this.cbxYearGroup_SelectedIndexChanged);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbxYearGroup);
            this.Controls.Add(this.cbxReports);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.ltvReports);
            this.Controls.Add(this.btnBack);
            this.Name = "frmReport";
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ComboBox cbxReports;
        private System.Windows.Forms.ColumnHeader Group;
        private System.Windows.Forms.ComboBox cbxYearGroup;
    }
}
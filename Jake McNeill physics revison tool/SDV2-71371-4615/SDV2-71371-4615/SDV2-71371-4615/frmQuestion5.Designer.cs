
namespace SDV2_71371_4615
{
    partial class frmQuestion5
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
            this.components = new System.ComponentModel.Container();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAns1 = new System.Windows.Forms.Button();
            this.btnAns2 = new System.Windows.Forms.Button();
            this.tmrCountDown = new System.Windows.Forms.Timer(this.components);
            this.mnsQuestion5 = new System.Windows.Forms.MenuStrip();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTimeRemaining = new System.Windows.Forms.ToolStripMenuItem();
            this.dpdFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOutMsp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.lblRunningScore = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsQuestion5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(245, 171);
            this.lblQuestion.MaximumSize = new System.Drawing.Size(300, 100);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(300, 100);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Question";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
            // 
            // btnAns1
            // 
            this.btnAns1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAns1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAns1.Location = new System.Drawing.Point(12, 143);
            this.btnAns1.Name = "btnAns1";
            this.btnAns1.Size = new System.Drawing.Size(194, 167);
            this.btnAns1.TabIndex = 1;
            this.btnAns1.Text = "True";
            this.btnAns1.UseVisualStyleBackColor = false;
            this.btnAns1.Click += new System.EventHandler(this.btnAns1_Click);
            // 
            // btnAns2
            // 
            this.btnAns2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAns2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAns2.Location = new System.Drawing.Point(594, 143);
            this.btnAns2.Name = "btnAns2";
            this.btnAns2.Size = new System.Drawing.Size(194, 167);
            this.btnAns2.TabIndex = 2;
            this.btnAns2.Text = "False";
            this.btnAns2.UseVisualStyleBackColor = false;
            this.btnAns2.Click += new System.EventHandler(this.btnAns2_Click);
            // 
            // tmrCountDown
            // 
            this.tmrCountDown.Enabled = true;
            this.tmrCountDown.Interval = 1000;
            this.tmrCountDown.Tick += new System.EventHandler(this.tmrCountDown_Tick);
            // 
            // mnsQuestion5
            // 
            this.mnsQuestion5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp,
            this.lblTimeRemaining,
            this.dpdFile,
            this.lblRunningScore});
            this.mnsQuestion5.Location = new System.Drawing.Point(0, 0);
            this.mnsQuestion5.Name = "mnsQuestion5";
            this.mnsQuestion5.Size = new System.Drawing.Size(800, 29);
            this.mnsQuestion5.TabIndex = 5;
            this.mnsQuestion5.Text = "menuStrip1";
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(54, 25);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // lblTimeRemaining
            // 
            this.lblTimeRemaining.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemaining.Name = "lblTimeRemaining";
            this.lblTimeRemaining.Size = new System.Drawing.Size(160, 25);
            this.lblTimeRemaining.Text = "Time Remaining: 20";
            // 
            // dpdFile
            // 
            this.dpdFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOutMsp,
            this.btnClose});
            this.dpdFile.Name = "dpdFile";
            this.dpdFile.Size = new System.Drawing.Size(37, 25);
            this.dpdFile.Text = "File";
            // 
            // btnLogOutMsp
            // 
            this.btnLogOutMsp.Name = "btnLogOutMsp";
            this.btnLogOutMsp.Size = new System.Drawing.Size(117, 22);
            this.btnLogOutMsp.Text = "Log Out";
            this.btnLogOutMsp.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(117, 22);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(84, 25);
            this.lblRunningScore.Text = "Total Score -";
            // 
            // frmQuestion5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAns2);
            this.Controls.Add(this.btnAns1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.mnsQuestion5);
            this.MainMenuStrip = this.mnsQuestion5;
            this.Name = "frmQuestion5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Question 5";
            this.Load += new System.EventHandler(this.frmQuestion5_Load);
            this.mnsQuestion5.ResumeLayout(false);
            this.mnsQuestion5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAns1;
        private System.Windows.Forms.Button btnAns2;
        private System.Windows.Forms.Timer tmrCountDown;
        private System.Windows.Forms.MenuStrip mnsQuestion5;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem lblTimeRemaining;
        private System.Windows.Forms.ToolStripMenuItem dpdFile;
        private System.Windows.Forms.ToolStripMenuItem btnLogOutMsp;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem lblRunningScore;
    }
}
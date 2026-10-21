
namespace SDV2_71371_4615
{
    partial class frmMainMenu
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
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.ltv1 = new System.Windows.Forms.ListView();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuizReview = new System.Windows.Forms.ToolStripMenuItem();
            this.dpdFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLogOutMsp = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(373, 50);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(160, 40);
            this.lblMainMenu.TabIndex = 0;
            this.lblMainMenu.Text = "Main Menu";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(76, 138);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(130, 78);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Quiz";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnReturn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(76, 278);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 78);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to last form";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnHighScore.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.Location = new System.Drawing.Point(701, 138);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(130, 78);
            this.btnHighScore.TabIndex = 3;
            this.btnHighScore.Text = "HighScore";
            this.btnHighScore.UseVisualStyleBackColor = false;
            this.btnHighScore.Click += new System.EventHandler(this.tbnHighScore_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnLogOut.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(701, 278);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(130, 78);
            this.btnLogOut.TabIndex = 4;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // ltv1
            // 
            this.ltv1.HideSelection = false;
            this.ltv1.Location = new System.Drawing.Point(246, 116);
            this.ltv1.Name = "ltv1";
            this.ltv1.Size = new System.Drawing.Size(419, 287);
            this.ltv1.TabIndex = 5;
            this.ltv1.UseCompatibleStateImageBehavior = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(106, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(68, 29);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "label1";
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.Location = new System.Drawing.Point(0, 26);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(100, 83);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 7;
            this.pbxAvatar.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp,
            this.btnQuizReview,
            this.dpdFile});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(910, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(44, 20);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.helpToolStripMenuItem_Click_1);
            // 
            // btnQuizReview
            // 
            this.btnQuizReview.Name = "btnQuizReview";
            this.btnQuizReview.Size = new System.Drawing.Size(83, 20);
            this.btnQuizReview.Text = "Quiz Review";
            this.btnQuizReview.Click += new System.EventHandler(this.quizReviewToolStripMenuItem_Click);
            // 
            // dpdFile
            // 
            this.dpdFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLogOutMsp,
            this.btnClose});
            this.dpdFile.Name = "dpdFile";
            this.dpdFile.Size = new System.Drawing.Size(37, 20);
            this.dpdFile.Text = "File";
            // 
            // btnLogOutMsp
            // 
            this.btnLogOutMsp.Name = "btnLogOutMsp";
            this.btnLogOutMsp.Size = new System.Drawing.Size(180, 22);
            this.btnLogOutMsp.Text = "Log Out";
            this.btnLogOutMsp.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 22);
            this.btnClose.Text = "Close";
            this.btnClose.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(910, 502);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.ltv1);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainMenu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ListView ltv1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem btnQuizReview;
        private System.Windows.Forms.ToolStripMenuItem dpdFile;
        private System.Windows.Forms.ToolStripMenuItem btnLogOutMsp;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
    }
}
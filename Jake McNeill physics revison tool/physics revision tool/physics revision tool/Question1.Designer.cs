
namespace SDV2_71371_4615
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
			this.components = new System.ComponentModel.Container();
			this.lblQuestion = new System.Windows.Forms.Label();
			this.btn1 = new System.Windows.Forms.Button();
			this.btn2 = new System.Windows.Forms.Button();
			this.btn3 = new System.Windows.Forms.Button();
			this.btn4 = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.returnToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dpdFile = new System.Windows.Forms.ToolStripMenuItem();
			this.btnLogOutMsp = new System.Windows.Forms.ToolStripMenuItem();
			this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
			this.lblRunningScore = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.pbxLife1 = new System.Windows.Forms.PictureBox();
			this.pbxLife2 = new System.Windows.Forms.PictureBox();
			this.pbxLife3 = new System.Windows.Forms.PictureBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxLife1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLife2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLife3)).BeginInit();
			this.SuspendLayout();
			// 
			// lblQuestion
			// 
			this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblQuestion.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblQuestion.Location = new System.Drawing.Point(0, 24);
			this.lblQuestion.Name = "lblQuestion";
			this.lblQuestion.Size = new System.Drawing.Size(800, 426);
			this.lblQuestion.TabIndex = 0;
			this.lblQuestion.Text = "Question";
			this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblQuestion.Click += new System.EventHandler(this.lblQuestion_Click);
			// 
			// btn1
			// 
			this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btn1.Location = new System.Drawing.Point(50, 100);
			this.btn1.Name = "btn1";
			this.btn1.Size = new System.Drawing.Size(144, 104);
			this.btn1.TabIndex = 1;
			this.btn1.Text = "Answer1";
			this.btn1.UseVisualStyleBackColor = false;
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			// 
			// btn2
			// 
			this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.btn2.Location = new System.Drawing.Point(50, 307);
			this.btn2.Name = "btn2";
			this.btn2.Size = new System.Drawing.Size(144, 104);
			this.btn2.TabIndex = 2;
			this.btn2.Text = "Answer2";
			this.btn2.UseVisualStyleBackColor = false;
			this.btn2.Click += new System.EventHandler(this.btn2_Click);
			// 
			// btn3
			// 
			this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btn3.Location = new System.Drawing.Point(589, 100);
			this.btn3.Name = "btn3";
			this.btn3.Size = new System.Drawing.Size(144, 104);
			this.btn3.TabIndex = 3;
			this.btn3.Text = "Answer3";
			this.btn3.UseVisualStyleBackColor = false;
			this.btn3.Click += new System.EventHandler(this.btn3_Click);
			// 
			// btn4
			// 
			this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btn4.Location = new System.Drawing.Point(589, 307);
			this.btn4.Name = "btn4";
			this.btn4.Size = new System.Drawing.Size(144, 104);
			this.btn4.TabIndex = 4;
			this.btn4.Text = "Answer4";
			this.btn4.UseVisualStyleBackColor = false;
			this.btn4.Click += new System.EventHandler(this.btn4_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHelp,
            this.returnToMainMenuToolStripMenuItem,
            this.dpdFile,
            this.lblRunningScore});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btnHelp
			// 
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(44, 20);
			this.btnHelp.Text = "Help";
			this.btnHelp.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// returnToMainMenuToolStripMenuItem
			// 
			this.returnToMainMenuToolStripMenuItem.Name = "returnToMainMenuToolStripMenuItem";
			this.returnToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
			this.returnToMainMenuToolStripMenuItem.Text = "Return to MainMenu";
			this.returnToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.returnToMainMenuToolStripMenuItem_Click);
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
			this.lblRunningScore.Size = new System.Drawing.Size(85, 20);
			this.lblRunningScore.Text = "Total Score -";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(24, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 30);
			this.label1.TabIndex = 6;
			this.label1.Text = "Lives Remaining :";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// pbxLife1
			// 
			this.pbxLife1.Image = global::SDV2_71371_4615.Properties.Resources.Heart;
			this.pbxLife1.Location = new System.Drawing.Point(218, 27);
			this.pbxLife1.Name = "pbxLife1";
			this.pbxLife1.Size = new System.Drawing.Size(100, 94);
			this.pbxLife1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxLife1.TabIndex = 7;
			this.pbxLife1.TabStop = false;
			// 
			// pbxLife2
			// 
			this.pbxLife2.Image = global::SDV2_71371_4615.Properties.Resources.Heart;
			this.pbxLife2.Location = new System.Drawing.Point(324, 27);
			this.pbxLife2.Name = "pbxLife2";
			this.pbxLife2.Size = new System.Drawing.Size(100, 94);
			this.pbxLife2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxLife2.TabIndex = 8;
			this.pbxLife2.TabStop = false;
			// 
			// pbxLife3
			// 
			this.pbxLife3.Image = global::SDV2_71371_4615.Properties.Resources.Heart;
			this.pbxLife3.Location = new System.Drawing.Point(430, 27);
			this.pbxLife3.Name = "pbxLife3";
			this.pbxLife3.Size = new System.Drawing.Size(100, 94);
			this.pbxLife3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbxLife3.TabIndex = 9;
			this.pbxLife3.TabStop = false;
			// 
			// Question1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pbxLife3);
			this.Controls.Add(this.pbxLife2);
			this.Controls.Add(this.pbxLife1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn4);
			this.Controls.Add(this.btn3);
			this.Controls.Add(this.btn2);
			this.Controls.Add(this.btn1);
			this.Controls.Add(this.lblQuestion);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Question1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Question1";
			this.Load += new System.EventHandler(this.Question1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbxLife1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLife2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbxLife3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem returnToMainMenuToolStripMenuItem;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.ToolStripMenuItem dpdFile;
        private System.Windows.Forms.ToolStripMenuItem btnLogOutMsp;
        private System.Windows.Forms.ToolStripMenuItem btnClose;
        private System.Windows.Forms.ToolStripMenuItem lblRunningScore;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.PictureBox pbxLife1;
		private System.Windows.Forms.PictureBox pbxLife2;
		private System.Windows.Forms.PictureBox pbxLife3;
	}
}
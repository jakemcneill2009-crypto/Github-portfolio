
namespace SDV2_71371_4615
{
    partial class frmSplash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblTitle = new System.Windows.Forms.Label();
            this.tmrLoading = new System.Windows.Forms.Timer(this.components);
            this.pbxLoadingGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(86, 51);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(281, 49);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "McNeill Studios";
            // 
            // tmrLoading
            // 
            this.tmrLoading.Interval = 5000;
            this.tmrLoading.Tick += new System.EventHandler(this.tmrLoading_Tick);
            // 
            // pbxLoadingGif
            // 
            this.pbxLoadingGif.Image = ((System.Drawing.Image)(resources.GetObject("pbxLoadingGif.Image")));
            this.pbxLoadingGif.Location = new System.Drawing.Point(12, 103);
            this.pbxLoadingGif.Name = "pbxLoadingGif";
            this.pbxLoadingGif.Size = new System.Drawing.Size(432, 327);
            this.pbxLoadingGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLoadingGif.TabIndex = 1;
            this.pbxLoadingGif.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(456, 442);
            this.Controls.Add(this.pbxLoadingGif);
            this.Controls.Add(this.lblTitle);
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplash";
            this.Load += new System.EventHandler(this.frmSplash_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSplash_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.PictureBox pbxLoadingGif;
    }
}
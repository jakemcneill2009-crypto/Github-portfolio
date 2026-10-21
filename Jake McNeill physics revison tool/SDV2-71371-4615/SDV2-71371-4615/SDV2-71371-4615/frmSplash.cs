using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SDV2_71371_4615
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(ProcessCmdKey);
        }

        private void frmSplash_Load(object sender, EventArgs e)
        {
            tmrLoading.Start();// Starts the timer when the program opens
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            tmrLoading.Stop();// Stops the timer at the same time as the gif stops and moves to the next
            this.Hide();
            frmSignUp newform = new frmSignUp();
            newform.Show();
        }

        private void frmSplash_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void ProcessCmdKey(object sender, KeyEventArgs e)
        {

            switch (e.KeyCode) // Allows the user to skip the splash screen and move right to the sign up form
            {
                case Keys.Enter:
                    frmSignUp Newform = new frmSignUp();
                    Newform.Show();
                    this.Hide();
                    tmrLoading.Stop();
                    break;
                    

            }
        }
    }
}

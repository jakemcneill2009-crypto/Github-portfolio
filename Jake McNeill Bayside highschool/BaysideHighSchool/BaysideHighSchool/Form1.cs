using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaysideHighSchool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (tbxUsername.Text == "Username1" && tbxPassword.Text == "password1")
            {
                MessageBox.Show("Login Successful");// is the correct login detail are entered this message is shown
                this.Hide();
                Form MoveToDataEntry = new frmDataEntry();
                MoveToDataEntry.Show();
            }
            else
            {
                MessageBox.Show("incorrect Username or Password entered");// is the incorrect username and password are entered this message shows
            }
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("username =Username1 and password =password1");
        }
    }
}

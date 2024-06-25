using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(username.Text=="سید رضا سفیدگر" && password.Text=="1111")
            {
                welcome welcome = new welcome();
                 welcome.Show();

                this.Hide();
                

            }
            else
            {
                MessageBox.Show("هویت شما تایید نشده", "شکست در ورود", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            username.Text = "";
            password.Text = "";
            
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if(showpass.Checked)
            {
                password.PasswordChar = '\0';
            }
            else
            {
                password.PasswordChar = '*';
            }
        }

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
             

        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
                register register = new register();
                register.Show();

                this.Hide();
        }
    }
}

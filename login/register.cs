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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            if (username.Text == "" && password.Text == "" && comfrimpass.Text == "")
            {
                MessageBox.Show("فیلد های مورد نظر را پر کنید","شکست در ثبت نام",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           else if (password.Text == comfrimpass.Text)
           {
                welcome welcome = new welcome();
                welcome.Show();
                this.Hide();
           }
            else
            {
                welcome welcome = new welcome();
                welcome.Show();

                this.Hide();
            }
        }

        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                password.PasswordChar = '\0';
                comfrimpass.PasswordChar = '\0';
            }
           
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
           
             username.Text = "";
             password.Text = "";
             comfrimpass.Text = "";
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            loginform loginform = new loginform();
            loginform.Show();
            this.Hide();
        }
    }
}

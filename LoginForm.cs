using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void logIn_btn_Click(object sender, EventArgs e)
        {

        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            loginPassword.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

    }
}

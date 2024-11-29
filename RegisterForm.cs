using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            FormStylingCorners.ApplyRoundedCorners(this, 20, 20); // apply rounded corners
        }

        private void alreadyRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Hide();
        }

        private void Register_btn_Click(object sender, System.EventArgs e)
        {
            if (fName.Text != "" && lName.Text != "" && uName.Text != "" && contactNo.Text != "" && registerPassword.Text != "" && cPassword.Text != "")
            {
                if (registerPassword.Text == cPassword.Text)
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;");
                        string query = "INSERT INTO `users` (`firstName`,`lastName`,`userName`,`contactNo`,`password`) VALUES ('" + fName.Text.Trim() + "','" + lName.Text.Trim() + "','" + uName.Text.Trim() + "','" + contactNo.Text.Trim() + "','" + MD5Hash(registerPassword.Text.Trim()) + "')";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Registered Successfully.", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Visible = false;
                        LoginForm lf = new LoginForm();
                        lf.ShowDialog();
                        this.Hide();
                    }
                    catch (MySqlException)
                    {
                        MessageBox.Show("Username Taken");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Passwords doesn't match");
                }
            }
            else
                MessageBox.Show("Please fill out all fields.", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.PasswordChar = showPass.Checked ? '\0' : '*';
        }
    }
}


using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

        private void Register_btn_Click(object sender, System.EventArgs e)
        {
            // Regular expressions for validation
            Regex nameRegex = new Regex("^[a-zA-Z]+$"); // Only letters allowed for firstName, lastName, and userName
            Regex contactRegex = new Regex("^[0-9]{11}$"); // Exactly 11 digits for contactNo
            Regex passwordRegex = new Regex(@"^[a-zA-Z0-9!@#$%^&*(),.?{}|<>]+$"); // Password with letters, numbers, and special characters

            // Check if any field is empty
            if (fName.Text != "" && lName.Text != "" && uName.Text != "" && contactNo.Text != "" && registerPassword.Text != "" && cPassword.Text != "")
            {
                // Validate first name, last name, and username (must not contain numbers)a
                if (!nameRegex.IsMatch(fName.Text) || !nameRegex.IsMatch(lName.Text))
                {
                    MessageBox.Show("First name, last name, and username must not contain numbers.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                // Validate contact number (must be 11 digits and only numbers)
                if (!contactRegex.IsMatch(contactNo.Text))
                {
                    MessageBox.Show("Contact number must be exactly 11 digits and contain only numbers.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                // Validate password (allow letters, numbers, and special characters)
                if (!passwordRegex.IsMatch(registerPassword.Text))
                {
                    MessageBox.Show("Password contains invalid characters. It should only contain letters, numbers, and special characters.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                // Check if passwords match
                if (registerPassword.Text == cPassword.Text)
                {
                    try
                    {
                        // Check if username already exists
                        MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;");
                        string checkUserQuery = "SELECT COUNT(*) FROM `users` WHERE `userName` = @userName";
                        MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, conn);
                        checkCmd.Parameters.AddWithValue("@userName", uName.Text.Trim());

                        conn.Open();
                        int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());
                        conn.Close();

                        // If username exists, show error
                        if (userExists > 0)
                        {
                            MessageBox.Show("Username is already taken. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Proceed with registration if username is available
                        string query = "INSERT INTO `users` (`firstName`,`lastName`,`userName`,`contactNo`,`password`) VALUES (@firstName, @lastName, @userName, @contactNo, @password)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        // parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@firstName", fName.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", lName.Text.Trim());
                        cmd.Parameters.AddWithValue("@userName", uName.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNo", contactNo.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", MD5Hash(registerPassword.Text.Trim()));

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Registered account successfully.", "Success", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information);

                        this.Visible = false;
                        LoginForm lf = new LoginForm();
                        lf.ShowDialog();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password does not match.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        private void AlreadyRegistered_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Visible = false;
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            this.Hide();
        }
        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            registerPassword.PasswordChar = showPass.Checked ? '\0' : '*';
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
    }
}


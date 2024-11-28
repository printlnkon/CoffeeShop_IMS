using MySql.Data.MySqlClient;
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
    public partial class ResetPassword : Form
    {
        private readonly string email;

        public ResetPassword(object email)
        {
            InitializeComponent();
            this.email = (string)email;
        }

        private void resetPassword_btn_Click(object sender, EventArgs e)
        {
            string newPassword = newPassword_txtbox.Text;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please enter a valid password.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UpdatePassword(newPassword))
            {
                MessageBox.Show("Password reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to reset password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private bool UpdatePassword(string newPassword)
        {
            string connectionString = (@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;");
            using (var connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE forgotpassword SET password = @Password WHERE email = @Email";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Password", newPassword);
                    command.Parameters.AddWithValue("@Email", email);
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}

using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class AdminDashboard : Form
    {
        bool menuExpand;
        bool userCollapse;
        public AdminDashboard()
        {
            InitializeComponent();
            FormStylingCorners.ApplyRoundedCorners(this, 20, 20); // apply rounded corners
            this.DoubleBuffered = true; // prevent flickering animation
        }

        private void sidebarTimer_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                // shrink the sidebar
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    menuExpand = false;
                    sidebarTimer.Stop();
                    AdjustPanel();
                }
            }
            else
            {
                // expand the sidebar
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    menuExpand = true;
                    sidebarTimer.Stop();
                    AdjustPanel();
                }
            }

        }
        private void AdjustPanel()
        {
            if (menuExpand)
            {
                // sidebar is expanded
                dashboardPanel.Left = sidebar.Width;
                dashboardPanel.Width = this.Width - sidebar.Width;
            }
            else
            {
                // sidebar is collapsed
                dashboardPanel.Left = sidebar.MinimumSize.Width;
                dashboardPanel.Width = this.Width - sidebar.MinimumSize.Width;
            }

            if (menuExpand)
            {
                createUserPanel.Left = sidebar.Width;
                createUserPanel.Width = this.Width - sidebar.Width;
            }
            else
            {
                createUserPanel.Left = sidebar.MinimumSize.Width;
                createUserPanel.Width = this.Width - sidebar.MinimumSize.Width;
            }

        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
        }

        private void userTimer_Tick(object sender, EventArgs e)
        {
            if (userCollapse)
            {
                // expand drop down bar
                userContainer.Height += 10;
                if (userContainer.Height == userContainer.MaximumSize.Height)
                {
                    userCollapse = false;
                    userTimer.Stop();
                }
            }
            else
            {
                // shrink drop down bar
                userContainer.Height -= 10;
                if (userContainer.Height == userContainer.MinimumSize.Height)
                {
                    userCollapse = true;
                    userTimer.Stop();
                }
            }
        }
        private void userButton_Click(object sender, EventArgs e)
        {
            userTimer.Start();
        }

        private void createUser_btn_Click(object sender, EventArgs e)
        {
            createUserPanel.BringToFront();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardPanel.BringToFront();
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            createPassword_txtBox.PasswordChar = showPass.Checked ? '\0' : '*';
        }

        private void createUserAccount_btn_Click(object sender, EventArgs e)
        {
            if (firstName_txtBox.Text != "" && lastName_txtBox.Text != "" && userName_txtBox.Text != "" && contactNo_txtBox.Text != "" && createPassword_txtBox.Text != "" && confirmPassword_txtBox.Text != "" && userType_comboBox.Text != "")
            {
                if (createPassword_txtBox.Text == confirmPassword_txtBox.Text)
                {
                    string userType = userType_comboBox.Text.Trim();

                    if (userType == "User" || userType == "Manager")
                    {
                        try
                        {
                            MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;");
                            string query = "INSERT INTO `users`(`firstName`,`lastName`,`userName`,`contactNo`,`password`,`userType`) VALUES (@firstName, @lastName, @userName, @contactNo, @password, @userType)";
                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            // Parameters to prevent SQL injection
                            cmd.Parameters.AddWithValue("@firstName", firstName_txtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@lastName", lastName_txtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@userName", userName_txtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@contactNo", contactNo_txtBox.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", MD5Hash(createPassword_txtBox.Text.Trim()));
                            cmd.Parameters.AddWithValue("@userType", userType);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show($"New {userType} account has been created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (MySqlException)
                        {
                            MessageBox.Show("Username already taken.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid user type selected.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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

        private void clear_btn_Click(object sender, EventArgs e)
        {
            firstName_txtBox.Text = string.Empty;
            lastName_txtBox.Text = string.Empty;
            userName_txtBox.Text = string.Empty;
            contactNo_txtBox.Text = string.Empty;
            createPassword_txtBox.Text = string.Empty;
            confirmPassword_txtBox.Text = string.Empty;

            // reset the combo box to default state
            userType_comboBox.SelectedIndex = -1;

            // set focus back to the first field
            firstName_txtBox.Focus();

            MessageBox.Show("All fields have been cleared.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void editUser_btn_Click(object sender, EventArgs e)
        {
            editUserPanel.BringToFront();
        }

        private void greetingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}

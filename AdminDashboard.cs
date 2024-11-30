using MySql.Data.MySqlClient;
using System;
using System.Data;
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

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            UpdateGridView();
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

            if (menuExpand)
            {
                editUserPanel.Left = sidebar.Width;
                editUserPanel.Width = this.Width - sidebar.Width;
            }
            else
            {
                editUserPanel.Left = sidebar.MinimumSize.Width;
                editUserPanel.Width = this.Width - sidebar.MinimumSize.Width;
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

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardPanel.BringToFront();
        }

        // ---------- create account function ---------- //
        private void createUser_btn_Click(object sender, EventArgs e)
        {
            createUserPanel.BringToFront();
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

                            firstName_txtBox.Clear();
                            lastName_txtBox.Clear();
                            userName_txtBox.Clear();
                            contactNo_txtBox.Clear();
                            createPassword_txtBox.Clear();
                            confirmPassword_txtBox.Clear();
                            userType_comboBox.SelectedIndex = -1;
                            firstName_txtBox.Focus();
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

        //---------- edit user function ----------//
        private void editUser_btn_Click(object sender, EventArgs e)
        {
            editUserPanel.BringToFront();
        }

        void UpdateGridView()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;"))
                {
                    conn.Open();

                    string query = "SELECT id, firstName, lastName, userName, contactNo, userType FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Clear existing columns
                    //dataGridView.Columns.Clear();

                    // Set AutoGenerateColumns to false
                    //dataGridView.AutoGenerateColumns = false;

                    // Add columns manually
                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "id",
                        HeaderText = "ID",
                        Name = "id",
                        ReadOnly = true,
                        Width = 50
                    });

                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "firstName",
                        HeaderText = "First Name",
                        Name = "firstName"
                    });

                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "lastName",
                        HeaderText = "Last Name",
                        Name = "lastName"
                    });

                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "userName",
                        HeaderText = "Username",
                        Name = "userName"
                    });

                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "contactNo",
                        HeaderText = "Contact Number",
                        Name = "contactNo"
                    });

                    dataGridView.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        DataPropertyName = "userType",
                        HeaderText = "User Type",
                        Name = "userType"
                    });

                    dataGridView.DataSource = dt;
                    dataGridView.Refresh();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView.Rows.Count)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                editID_txtbox.Text = row.Cells[0].Value.ToString();
                editfirstName_txtBox.Text = row.Cells[1].Value.ToString();
                editlastName_txtBox.Text = row.Cells[2].Value.ToString();
                edituserName_txtBox.Text = row.Cells[3].Value.ToString();
                editcontactNo_txtBox.Text = row.Cells[4].Value.ToString();
                edituserType_comboBox.Text = row.Cells[5].Value.ToString();

                // Make ID textbox read-only
                editID_txtbox.ReadOnly = true;
            }
        }

        private void updateAccount_Click(object sender, EventArgs e)
        {
            if (editfirstName_txtBox.Text != "" && editlastName_txtBox.Text != "" && editID_txtbox.Text != "" && edituserName_txtBox.Text != "" && editcontactNo_txtBox.Text != "" && edituserType_comboBox.Text != "")
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;"))
                    {
                        string query = "UPDATE users SET firstName = @firstName, lastName = @lastName, userName = @userName, contactNo = @contactNo, userType = @userType WHERE id = @id";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        // parameters to avoid sql injection
                        cmd.Parameters.AddWithValue("@id", editID_txtbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@firstName", editfirstName_txtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@lastName", editlastName_txtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@userName", edituserName_txtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNo", editcontactNo_txtBox.Text.Trim());
                        cmd.Parameters.AddWithValue("@userType", edituserType_comboBox.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Account updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // automatically clear textboxes and combobox
                        editID_txtbox.Enabled = false;
                        editID_txtbox.Clear();
                        editfirstName_txtBox.Clear();
                        editlastName_txtBox.Clear();
                        edituserName_txtBox.Clear();
                        editcontactNo_txtBox.Clear();
                        edituserType_comboBox.SelectedIndex = -1;
                        UpdateGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an account to update. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

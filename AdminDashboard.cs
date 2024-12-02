using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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
        }
        private void AdminDashboard1_Load(object sender, EventArgs e)
        {
            FillEditGridView();
            FillDeleteGridView();
        }

        private string GetAdminUsername()
        {
            string username = string.Empty;

            try
            {
                // Set up database connection (use your actual connection string)
                using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;"))
                {
                    string query = "SELECT `userType` FROM `users` WHERE `userType` = 'Admin' LIMIT 1"; // Example query to get admin username
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    conn.Open();
                    username = cmd.ExecuteScalar()?.ToString();  // Execute the query and get the result
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching username: " + ex.Message);
            }

            return username;
        }

        private void GreetingPanel_Paint(object sender, PaintEventArgs e)
        {
            // Get the admin username from the database
            string adminUsername = GetAdminUsername();

            // Set the text of the label directly
            if (!string.IsNullOrEmpty(adminUsername))
            {
                helloGreeting.Text = "Hello, " + adminUsername + "!"; // Update the text of the label
            }
            else
            {
                helloGreeting.Text = "Hello, User" + "!"; // Default greeting if username is empty or null
            }
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MessageBox.Show("Logout successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        private void createUser_btn_Click(object sender, EventArgs e)
        {
            createUserPanel.BringToFront();
        }
        private void editUser_btn_Click(object sender, EventArgs e)
        {
            editUserPanel.BringToFront();
        }
        private void DeleteUser_btn_Click(object sender, EventArgs e)
        {
            deleteUserPanel.BringToFront();
        }

        // ---------- start of sidebar function ---------- //
        private void SidebarTimer_Tick(object sender, EventArgs e)
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
        private void UserTimer_Tick(object sender, EventArgs e)
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
        private void Menu_btn_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();
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

            if (menuExpand)
            {
                deleteUserPanel.Left = sidebar.Width;
                deleteUserPanel.Width = this.Width - sidebar.Width;
            }
            else
            {
                deleteUserPanel.Left = sidebar.MinimumSize.Width;
                deleteUserPanel.Width = this.Width - sidebar.MinimumSize.Width;
            }

        }
        private void UserManagement_btn_Click(object sender, EventArgs e)
        {
            userTimer.Start();
        }
        private void Dashboard_btn_Click(object sender, EventArgs e)
        {
            dashboardPanel.BringToFront();
        }
        // ---------- end of sidebar function ---------- //

        // ---------- start of create user function ---------- //
        private void CreateAccount_Click(object sender, EventArgs e)
        {
            // Regular expressions for validation
            Regex nameRegex = new Regex("^[a-zA-Z]+$"); // Only letters allowed
            Regex contactRegex = new Regex("^[0-9]{11}$"); // Exactly 11 digits
            Regex passwordRegex = new Regex(@"^[a-zA-Z0-9!@#$%^&*(),.?{}|<>]+$"); // Allow letters, numbers, and special characters

            // Check if any field is empty
            if (firstName_txtBox.Text != "" && lastName_txtBox.Text != "" && userName_txtBox.Text != "" && contactNo_txtBox.Text != "" && createPassword_txtBox.Text != "" && confirmPassword_txtBox.Text != "" && userType_comboBox.Text != "")
            {
                // Validate first name, last name, and username (must not contain numbers)
                if (!nameRegex.IsMatch(firstName_txtBox.Text) || !nameRegex.IsMatch(lastName_txtBox.Text))
                {
                    MessageBox.Show("First name, last name, and username must not contain numbers.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                // Validate contact number (must be 11 digits and only numbers)
                if (!contactRegex.IsMatch(contactNo_txtBox.Text))
                {
                    MessageBox.Show("Contact number must be exactly 11 digits and contain only numbers.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                // Validate password match
                if (createPassword_txtBox.Text == confirmPassword_txtBox.Text)
                {
                    // Validate password (allow letters, numbers, and special characters)
                    if (!passwordRegex.IsMatch(createPassword_txtBox.Text))
                    {
                        MessageBox.Show("Password contains invalid characters.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        return;
                    }

                    string userType = userType_comboBox.Text.Trim();

                    if (userType == "User" || userType == "Manager" || userType == "Admin")
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
                            cmd.Parameters.AddWithValue("@password", MD5Hash(createPassword_txtBox.Text.Trim())); // Hash password
                            cmd.Parameters.AddWithValue("@userType", userType);

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show($"New {userType} account has been created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            firstName_txtBox.Clear();
                            lastName_txtBox.Clear();
                            userName_txtBox.Clear();
                            contactNo_txtBox.Clear();
                            createPassword_txtBox.Clear();
                            confirmPassword_txtBox.Clear();
                            userType_comboBox.SelectedIndex = -1;
                            firstName_txtBox.Focus();

                            FillEditGridView();
                            FillDeleteGridView();
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

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            createPassword_txtBox.PasswordChar = showPass.Checked ? '\0' : '*';
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
        // ---------- end of create user function ---------- //

        // ---------- start of edit user function ---------- //
        private void EditAccount_Click(object sender, EventArgs e)
        {
            // Regular expressions for validation
            Regex nameRegex = new Regex("^[a-zA-Z]+$"); // Only letters allowed for firstName, lastName, and userName
            Regex contactRegex = new Regex("^[0-9]{11}$"); // Exactly 11 digits for contactNo
            Regex userTypeRegex = new Regex("^(User|Manager|Admin)$"); // Only "User", "Manager", or "Admin" for userType

            // Check if any field is empty
            if (editfirstName.Text != "" && editlastName.Text != "" && editId.Text != "" && edituserName.Text != "" && editcontactNo.Text != "" && edituserType.Text != "")
            {
                // Validate first name, last name, and username (must not contain numbers)
                if (!nameRegex.IsMatch(editfirstName.Text) || !nameRegex.IsMatch(editlastName.Text) || !nameRegex.IsMatch(edituserName.Text))
                {
                    MessageBox.Show("First name, last name, and username must not contain numbers.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                // Validate contact number (must be 11 digits and only numbers)
                if (!contactRegex.IsMatch(editcontactNo.Text))
                {
                    MessageBox.Show("Contact number must be exactly 11 digits and contain only numbers.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                // Validate user type (must be "User" or "Manager")
                if (!userTypeRegex.IsMatch(edituserType.Text))
                {
                    MessageBox.Show("Invalid user type selected. It must be either 'User' or 'Manager'.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;");

                    string query = "UPDATE users SET firstName = @firstName, lastName = @lastName, userName = @userName, contactNo = @contactNo, userType = @userType WHERE id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // parameters to avoid SQL injection
                    cmd.Parameters.AddWithValue("@id", editId.Text.Trim());
                    cmd.Parameters.AddWithValue("@firstName", editfirstName.Text.Trim());
                    cmd.Parameters.AddWithValue("@lastName", editlastName.Text.Trim());
                    cmd.Parameters.AddWithValue("@userName", edituserName.Text.Trim());
                    cmd.Parameters.AddWithValue("@contactNo", editcontactNo.Text.Trim());
                    cmd.Parameters.AddWithValue("@userType", edituserType.Text.Trim());

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Account updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Automatically clear textboxes and combobox
                    editId.Enabled = false;
                    editId.Clear();
                    editfirstName.Clear();
                    editlastName.Clear();
                    edituserName.Clear();
                    editcontactNo.Clear();
                    edituserType.SelectedIndex = -1;

                    FillEditGridView();
                    FillDeleteGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an account to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillEditGridView()
        {
            try
            {
                // Connection string for MySQL database
                string connectionString = @"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    conn.Open();

                    // SQL query to fetch user data
                    string query = "SELECT id, firstName, lastName, userName, contactNo, userType FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    // Load data into a DataTable
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    editDataGridView.DataSource = null; // Reset the data source (optional)
                    editDataGridView.DataSource = dt;   // Assign the new data source
                    // Ensure the grid refreshes properly
                    editDataGridView.Refresh();

                    // Optional: Set auto-generate columns if needed
                    editDataGridView.AutoGenerateColumns = true;
                    editDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific errors
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void EditDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row (not a header or invalid row index)   
                if (e.RowIndex >= 0 && e.RowIndex < editDataGridView.Rows.Count)
                {
                    // Get the selected row
                    DataGridViewRow row = this.editDataGridView.Rows[e.RowIndex];

                    // Safely retrieve cell values and handle potential nulls
                    editId.Text = row.Cells["id"]?.Value?.ToString() ?? string.Empty;
                    editfirstName.Text = row.Cells["firstName"]?.Value?.ToString() ?? string.Empty;
                    editlastName.Text = row.Cells["lastName"]?.Value?.ToString() ?? string.Empty;
                    edituserName.Text = row.Cells["userName"]?.Value?.ToString() ?? string.Empty;
                    editcontactNo.Text = row.Cells["contactNo"]?.Value?.ToString() ?? string.Empty;
                    edituserType.Text = row.Cells["userType"]?.Value?.ToString() ?? string.Empty;

                    // Make ID textbox read-only (optional)
                    editId.ReadOnly = true;
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show($"Error selecting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ---------- end of edit user function ---------- //


        // ---------- start of delete user function ---------- //
        private void DeleteAccount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (deletefirstName.Text != "" && deletelastName.Text != "" && deleteId.Text != "" && deleteuserName.Text != "" && deletecontactNo.Text != "" && deleteuserType.Text != "")
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;"))
                        {
                            string query = "DELETE FROM users WHERE id = @id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);

                            // parameters to avoid sql injection
                            cmd.Parameters.AddWithValue("@id", deleteId.Text.Trim());

                            conn.Open();
                            int rowsAffected = cmd.ExecuteNonQuery();
                            conn.Close();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // clear textboxes and reset combobox
                                deleteId.Enabled = false;
                                deleteId.Clear();
                                deletefirstName.Clear();
                                deletelastName.Clear();
                                deleteuserName.Clear();
                                deletecontactNo.Clear();
                                deleteuserType.SelectedIndex = -1;

                                FillEditGridView();
                                FillDeleteGridView();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error error account: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account to delete. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void FillDeleteGridView()
        {
            try
            {
                // Connection string for MySQL database
                string connectionString = @"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // Open the database connection
                    conn.Open();

                    // SQL query to fetch user data
                    string query = "SELECT id, firstName, lastName, userName, contactNo, userType FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    // Load data into a DataTable
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    deletedataGridView.DataSource = null; // Reset the data source (optional)
                    deletedataGridView.DataSource = dt;   // Assign the new data source
                    // Ensure the grid refreshes properly
                    deletedataGridView.Refresh();

                    // Optional: Set auto-generate columns if needed
                    deletedataGridView.AutoGenerateColumns = true;
                    deletedataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific errors
                MessageBox.Show($"Error connecting to the database: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Handle general exceptions
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DeletedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row (not a header or invalid row index)   
                if (e.RowIndex >= 0 && e.RowIndex < deletedataGridView.Rows.Count)
                {
                    // Get the selected row
                    DataGridViewRow row = deletedataGridView.Rows[e.RowIndex];

                    // Safely retrieve cell values using column names or indexes and handle potential nulls
                    deleteId.Text = row.Cells["id"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    deletefirstName.Text = row.Cells["firstName"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    deletelastName.Text = row.Cells["lastName"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    deleteuserName.Text = row.Cells["userName"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    deletecontactNo.Text = row.Cells["contactNo"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    deleteuserType.Text = row.Cells["userType"]?.Value?.ToString()?.Trim() ?? string.Empty;

                    deleteId.ReadOnly = true;
                }
                else
                {
                    MessageBox.Show("Invalid row selected. Please select a valid account.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // Handle any unexpected errors
                MessageBox.Show($"Error selecting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // ---------- end of delete user function ---------- //

        // ---------- start of user lists function ---------- //
        private void UserLists_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserLists ul = new UserLists();
            ul.ShowDialog();
            this.Hide();
        }

        


        // ---------- end of user lists function ---------- //
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CoffeeShop_IMS
{
    public partial class ManagerDashboard : Form
    {
        public ManagerDashboard()
        {
            InitializeComponent();
        }
        private void ManagerDashboard_Load(object sender, EventArgs e)
        {
            addId.ReadOnly = true;
            FillAddGridView();
        }
        private void createUser_btn_Click(object sender, EventArgs e)
        {
            addItemPanel.BringToFront();
        }

        private void Logout_btn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            MessageBox.Show("Logout successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
        }

        // ---------- start of add product function ---------- //

        private void FillAddGridView()
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
                    string query = "SELECT id, itemName, type, quantity FROM products";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);

                    // Load data into a DataTable
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the DataTable to the DataGridView
                    adddataGridView.DataSource = null; // Reset the data source (optional)
                    adddataGridView.DataSource = dt;   // Assign the new data source

                    // Auto-resize columns to fill the DataGridView
                    adddataGridView.AutoGenerateColumns = true;
                    adddataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fill the grid view
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

        private void AdddataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Ensure the click is on a valid row (not a header or invalid row index)
                if (e.RowIndex >= 0 && e.RowIndex < adddataGridView.Rows.Count)
                {
                    // Get the selected row
                    DataGridViewRow row = adddataGridView.Rows[e.RowIndex];

                    // Safely retrieve cell values using column names or indexes and handle potential nulls
                    addId.Text = row.Cells["id"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    addItemName.Text = row.Cells["itemName"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    addType.Text = row.Cells["type"]?.Value?.ToString()?.Trim() ?? string.Empty;
                    addQuantity.Text = row.Cells["quantity"]?.Value?.ToString()?.Trim() ?? string.Empty;

                    addId.ReadOnly = true; // Ensure `id` remains read-only
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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            // Regular expressions for validation
            Regex nameRegex = new Regex("^[a-zA-Z ]+$"); // Allow only letters and spaces for names

            // Check if any field is empty
            if (!string.IsNullOrWhiteSpace(addItemName.Text) &&
                !string.IsNullOrWhiteSpace(addType.Text) &&
                !string.IsNullOrWhiteSpace(addQuantity.Text))
            {
                // Validate itemName (must not contain numbers)
                if (!nameRegex.IsMatch(addItemName.Text))
                {
                    MessageBox.Show("Item Name must only contain letters and spaces.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return;
                }

                string addTypeValue = addType.Text.Trim();

                // Validate the type
                if (addTypeValue == "Raw Materials" || addTypeValue == "Consumables" || addTypeValue == "Equipment and Tools")
                {
                    try
                    {
                        MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;");
                        string query = "INSERT INTO `products`(`itemName`,`type`,`quantity`) VALUES (@itemName, @type, @quantity)";
                        MySqlCommand cmd = new MySqlCommand(query, conn);

                        // Parameters to prevent SQL injection
                        cmd.Parameters.AddWithValue("@itemName", addItemName.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", addTypeValue);
                        cmd.Parameters.AddWithValue("@quantity", addQuantity.Text.Trim());

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("New product has been added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear fields and refresh grid
                        addItemName.Clear();
                        addQuantity.Clear();
                        addType.SelectedIndex = -1;
                        addId.Text = string.Empty; // Clear ID field
                        addId.Focus();
                        FillAddGridView();
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Database Error: {ex.Message}", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unexpected Error: {ex.Message}", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid product type selected. Please choose a valid type.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("All fields must be filled out before adding a product.", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

    }


    // ---------- end of add product function ---------- //

}

using Google.Protobuf.Reflection;
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
    public partial class UserLists : Form
    {
        public UserLists()
        {
            InitializeComponent();
            FormStylingCorners.ApplyRoundedCorners(this, 20, 20); // apply rounded corners
        }
        private void UserLists_Load(object sender, EventArgs e)
        {
            FillUserListsGridView();
        }

        private void FillUserListsGridView()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(@"datasource=127.0.0.1;port=3306;SslMode=none;username=root;password=;database=coffeeshop_ims_csharp;"))
                {
                    conn.Open();

                    string query = "SELECT id, firstName, lastName, userName, contactNo, userType FROM users";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dtList = new DataTable();
                    adapter.Fill(dtList);

                    userListsDataGridView.DataSource = null; // Reset the data source
                    userListsDataGridView.DataSource = dtList;  // Assign the new data
                    userListsDataGridView.Refresh();       // Refresh the grid

                    userListsDataGridView.AutoGenerateColumns = true; // Ensure columns are auto-generated
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

        private void Close_btn_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            ad.ShowDialog();
            this.Close();
        }
    }
}

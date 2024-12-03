using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            this.Hide();
            AdminDashboard ad = new AdminDashboard();
            ad.Show();
            this.Close();
        }

        private void userListsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            userListsDataGridView.AutoGenerateColumns = true;
            userListsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fill the grid view
        }

        // STILL NOT WORKING!
        private void generatePDF_Click(object sender, EventArgs e)
        {
            try
            {
                // Prompt the user to select a file location
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "PDF files (*.pdf)|*.pdf",
                    Title = "Save PDF File"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    // Create a PDF writer instance
                    using (PdfWriter writer = new PdfWriter(filePath))
                    {
                        PdfDocument pdfDoc = new PdfDocument(writer);
                        Document document = new Document(pdfDoc);

                        // Add a title to the PDF
                        document.Add(new Paragraph("User List")
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                            .SetFontSize(20));

                        // Create a table with the same number of columns as the DataGridView
                        Table table = new Table(userListsDataGridView.Columns.Count);

                        // Add column headers to the table
                        foreach (DataGridViewColumn column in userListsDataGridView.Columns)
                        {
                            table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
                        }

                        // Add rows from DataGridView to the table
                        foreach (DataGridViewRow row in userListsDataGridView.Rows)
                        {
                            // Skip empty rows
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellValue = cell.Value?.ToString() ?? string.Empty;
                                    table.AddCell(new Cell().Add(new Paragraph(cellValue)));
                                }
                            }
                        }

                        // Add the table to the document
                        document.Add(table);
                        document.Close();
                    }

                    MessageBox.Show("PDF generated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

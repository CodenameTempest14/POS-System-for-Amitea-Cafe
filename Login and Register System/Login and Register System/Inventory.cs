using FontAwesome.Sharp;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Login_and_Register_System {
    public partial class Inventory : UserControl {

        private Dashboard _dashboard;
        private string userPosition;
        public Inventory(Dashboard dashboard) {
            InitializeComponent();
            LoadInventoryDataFromDatabase();
            _dashboard = dashboard;
            userPosition = _dashboard.getPosition();
            dataPanel.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
        }

        // Public method to refresh inventory data
        public void RefreshInventoryData() {
            LoadInventoryDataFromDatabase(); // Call the data loading method
        }

        // Function to fetch data from the database and populate the DataGridView
        private void LoadInventoryDataFromDatabase() {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string query = "SELECT productID, productName, price, quantity, total FROM inventory";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                using (MySqlCommand cmd = new MySqlCommand(query, connection)) {
                    try {
                        connection.Open();
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);

                        // Clear existing rows in the DataGridView
                        dataPanel.Rows.Clear();

                        // Populate DataGridView with fetched data
                        foreach (DataRow row in dataTable.Rows) {
                            dataPanel.Rows.Add(
                                row["productID"],  // Product Code
                                row["productName"],  // Product Name
                                row["price"],  // Price
                                row["quantity"],  // Quantity
                                row["total"]  // Total
                            );
                        }
                    } catch (Exception ex) {
                        // Handle exception (e.g., show error message)
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }


        public bool TopLevel { get; internal set; }

        private void SetButtonProperties(IconButton button, Color iconColor, Cursor cursor) {
            button.IconColor = iconColor;
            button.Cursor = cursor;
        }

        private bool mouseEnter = false;

        private void addBtn_MouseEnter(object sender, EventArgs e) {
            SetButtonProperties(addBtn, Color.FromArgb(242, 222, 194), Cursors.Hand);
            mouseEnter = true;
        }

        private void addBtn_MouseLeave(object sender, EventArgs e) {
            SetButtonProperties(addBtn, Color.FromArgb(101, 53, 15), Cursors.Default);
            mouseEnter = false;
        }

        private void addBtn_MouseDown(object sender, MouseEventArgs e) {
            addBtn.IconColor = Color.FromArgb(219, 162, 81);
            addBtn.Cursor = Cursors.Hand;
        }

        private void addBtn_MouseUp(object sender, MouseEventArgs e) {
            if (mouseEnter != false)
                addBtn_MouseEnter(sender, e);
            else 
                addBtn_MouseLeave(sender, e);
        }



        // For Add and Delete Commands
        private void addBtn_Click(object sender, EventArgs e) {
            ProductModoule prodMod = new ProductModoule(this);
            if (userPosition != "Admin") {
                MessageBox.Show("Only the admin can add a product.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method if not admin
            }
            // Disabling the update button
            prodMod.updateProdBtn.Enabled = false;

            prodMod.ShowDialog();
        }

        private void dataPanel_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (userPosition != "Admin") {
                MessageBox.Show("Only the admin can edit and delete a product.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return; // Exit the method if not admin
            }

            // Check if the clicked cell is in the 'Edit' column
            if (dataPanel.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0) {
                int rowIndex = e.RowIndex; // Get the row index of the clicked cell


                // Assuming the first column contains the productID
                string productID = dataPanel.Rows[rowIndex].Cells[0].Value?.ToString();

                // Assuming the columns for product code, name, price, and quantity are at indexes 0, 1, 2, 3 respectively
                string prodCode = dataPanel.Rows[rowIndex].Cells[0].Value?.ToString();
                string prodName = dataPanel.Rows[rowIndex].Cells[1].Value?.ToString();
                string price = dataPanel.Rows[rowIndex].Cells[2].Value?.ToString();
                string quantity = dataPanel.Rows[rowIndex].Cells[3].Value?.ToString();

                // Now, after updating the database, retrieve the image based on the productID
                string selectQuery = "SELECT thumbnail FROM inventory WHERE productID = @productID";

                ProductModoule prodMod = new ProductModoule(this);
                prodMod.prodCodeTB.Texts = prodCode;
                prodMod.prodNameTB.Texts = prodName;
                prodMod.priceTB.Texts = price;
                prodMod.quantityTB.Texts = quantity;
                prodMod.saveProdBtn.Enabled = false;

                // Execute the query to retrieve the image
                string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    connection.Open();
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@productID", productID);

                    byte[] imageData = (byte[])selectCommand.ExecuteScalar();

                    // Display the retrieved image in the PictureBox with zoom to fit
                    if (imageData != null && imageData.Length > 0) {
                        using (MemoryStream ms = new MemoryStream(imageData)) {
                            // Set the PictureBox image with zoom mode to fit
                            prodMod.addImagePicBox.SizeMode = PictureBoxSizeMode.Zoom;
                            prodMod.addImagePicBox.Image = Image.FromStream(ms);
                        }
                    } else {
                        prodMod.addImagePicBox.Image = null; // No image found for the specified productID
                    }
                } 
                prodMod.ShowDialog();
            }  else if (dataPanel.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0) { // Logic for Deletion of product
                // Ask for confirmation before deleting the record
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    // Perform deletion logic here

                    // Assuming the first column contains the productID
                    string productIDToDelete = dataPanel.Rows[e.RowIndex].Cells[0].Value?.ToString();

                    // Perform deletion query here
                    string deleteQuery = "DELETE FROM inventory WHERE productID = @productID";

                    string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                        connection.Open();
                        MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@productID", productIDToDelete);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Refresh or update the DataGridView after deletion if needed
                    LoadInventoryDataFromDatabase();
                }
            }
        }

        private void searchFunction() {
            string searchTerm = searchTB.Texts.Trim();

            string selectQuery = "SELECT productID AS ProductCode, productName AS ProductName, price AS Price, quantity AS Quantity, total AS Total FROM inventory WHERE productName LIKE @searchTerm OR productID LIKE @searchTerm";

            if (string.IsNullOrEmpty(searchTerm)) {
                LoadInventoryDataFromDatabase(); // Reload all data if the search term is null or empty
                return;
            }

            string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                connection.Open();
                MySqlCommand countCommand = new MySqlCommand("SELECT COUNT(*) FROM inventory WHERE productName LIKE @searchTerm OR productID LIKE @searchTerm", connection);
                countCommand.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                int queryCount = Convert.ToInt32(countCommand.ExecuteScalar());

                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Clear DataGridView content
                dataPanel.Rows.Clear();

                // Populate DataGridView with filtered data
                foreach (DataRow row in dataTable.Rows) {
                    dataPanel.Rows.Add(row["ProductCode"], row["ProductName"], row["Price"], row["Quantity"], row["Total"]);
                }

                // Display query count in searchLabel
                searchLabel.Text = $"Search Results: {queryCount}";

                if (searchTB.Texts.Equals(""))
                    searchLabel.Text = $"Search Results: 0";
            }
        }


        private void searchTB__TextChanged(object sender, EventArgs e) {
                searchFunction();
        }
    }
}

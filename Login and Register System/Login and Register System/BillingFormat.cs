using System.Windows.Forms;
using System;
using MySql.Data.MySqlClient;

namespace Login_and_Register_System {
    public partial class BillingFormat : UserControl{

        private Inventory _inventoryInstance;
        private string productID;
        private ItemHolder itemHold;
        private Menu menu;
        private int quantity = 0;
        private double price = 0, totalPrice = 0, subTotal = 0, currentTotal = 0;
        private double taxVal = 0.1;

        public BillingFormat(Inventory inventoryInstance) {
            InitializeComponent();
            _inventoryInstance = inventoryInstance;
        }   

        public BillingFormat(ItemHolder itemHolderInstance, Menu menu) {
            InitializeComponent();
            itemHold = itemHolderInstance;
            this.menu = menu;
        }

        public BillingFormat() {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e) {
            if (itemHold.getEnable() == false || itemHold.addBtn.Enabled == false) {
                itemHold.addBtn.Enabled = true;
                subTotal = quantity * price;
                totalPrice = (subTotal * taxVal) + subTotal;
                menu.setOverAllSubTotal(menu.getOverAllSubTotal() - subTotal);
                menu.setOverAllTaxTotal(menu.getOverAllTaxTotal() - (subTotal * taxVal));
                menu.setOverAllTotal(menu.getTotal() - totalPrice);

                menu.subTotalAmount.Text = menu.getOverAllSubTotal().ToString("F2");
                menu.taxAmount.Text = menu.getOverAllTaxTotal().ToString("F2");
                menu.totalAmount.Text = menu.getTotal().ToString("F2");

                // Update quantity in the database
                UpdateQuantityInDatabase();
            }
            this.Hide();
        }

        // Method to update quantity in the database
        private void UpdateQuantityInDatabase() {
            if (!string.IsNullOrEmpty(productID)) {
                string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";

                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    try {
                        connection.Open();

                        // Retrieve current quantity
                        string selectQuery = $"SELECT quantity FROM inventory WHERE productID = '{productID}'";
                        string selectTotalQuery = $"SELECT total FROM inventory WHERE productID = '{productID}'";
                        MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                        int currentQuantity = Convert.ToInt32(selectCommand.ExecuteScalar());

                        // Calculate updated quantity
                        int updatedQuantity = currentQuantity + quantity;

                        // Update the database with the new quantity
                        string updateQuery = $"UPDATE inventory SET quantity = {updatedQuantity} WHERE productID = '{productID}'";
                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                        updateCommand.ExecuteNonQuery();

                        // Retrieve the current total from the database
                        MySqlCommand totalCommand = new MySqlCommand(selectTotalQuery, connection);
                        object result = totalCommand.ExecuteScalar();
                        if (result != null && result != DBNull.Value) {
                            currentTotal = Convert.ToDouble(result);
                        }

                        // Calculate the new total
                        double newTotal = price * updatedQuantity;

                        // Update the total in the database
                        string updateTotalQuery = $"UPDATE inventory SET total = {newTotal} WHERE productID = '{productID}'";
                        MySqlCommand updateTotalCommand = new MySqlCommand(updateTotalQuery, connection);
                        updateTotalCommand.ExecuteNonQuery();

                        connection.Close();
                    } catch (Exception ex) {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            } else {
                MessageBox.Show("Product ID is empty.");
            }
        }


        // Setter 

        public void setQuantity(int quantity) { this.quantity = quantity;}

        public void setPrice(double price) { this.price = price; }

        public void setProductID(string productID) { this.productID = productID; }
    }
}

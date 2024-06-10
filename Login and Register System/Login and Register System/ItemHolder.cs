using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Login_and_Register_System {

    public partial class ItemHolder : UserControl {

        private string prodCode;
        private bool enable = false;
        private double subTotal = 0, tax = 0, total = 0;
        private double taxVal = 0.1;

        private Menu _menuInstance;
        public ItemHolder(Menu menu) {
            InitializeComponent();
            _menuInstance = menu;
        }

        public ItemHolder() {
            InitializeComponent();
        }

        public string getProdCode() { return prodCode; }
        public bool getEnable() { return enable; }
        public void setEnable(bool enable) { this.enable = enable; }

        private void addBtn_Click(object sender, EventArgs e) {    

            if (quantityTB.Texts.Equals("")) {
                MessageBox.Show("Please fill in the necessary fields first.", "Invalid Transaction Method", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try {
                prodCode = prodCodeL.Text;
                string prodName = productNameL.Text;
                double price = Double.Parse(priceL.Text);
                string mood = moodComboBox.Text;
                string sugarLvl = sugarLvlComboB.Text;
                int inputQuantity = int.Parse(quantityTB.Texts);
                int quantity = 0;
                double currentTotal = 0;

                string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    string selectQuantityQuery = $"SELECT quantity FROM inventory WHERE productID = '{prodCode}'";
                    string selectTotalQuery = $"SELECT total FROM inventory WHERE productID = '{prodCode}'";

                    MySqlCommand command = new MySqlCommand(selectQuantityQuery, connection);
                    connection.Open();

                    // Execute the query and get the quantity if the productID exists
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read()) {
                        quantity = Convert.ToInt32(reader["quantity"]);
                    } else {
                        MessageBox.Show("Product not found in the inventory.");
                        reader.Close();
                        return;
                    }
                    reader.Close();

                    if (inputQuantity > quantity) {
                        MessageBox.Show("Insufficient quantity in stock.");
                        return;
                    }

                    // Deduct sold quantity from the existing quantity in the database
                    int updatedQuantity = quantity - inputQuantity;
                    string updateQuantityQuery = $"UPDATE inventory SET quantity = {updatedQuantity} WHERE productID = '{prodCode}'";
                    MySqlCommand updateQuantityCommand = new MySqlCommand(updateQuantityQuery, connection);
                    updateQuantityCommand.ExecuteNonQuery();

                    // Retrieve the current total from the database
                    MySqlCommand totalCommand = new MySqlCommand(selectTotalQuery, connection);
                    object result = totalCommand.ExecuteScalar();
                    if (result != null && result != DBNull.Value) {
                        currentTotal = Convert.ToDouble(result);
                    }

                    // Calculate the new total
                    double newTotal = price * updatedQuantity;

                    // Update the total in the database
                    string updateTotalQuery = $"UPDATE inventory SET total = {newTotal} WHERE productID = '{prodCode}'";
                    MySqlCommand updateTotalCommand = new MySqlCommand(updateTotalQuery, connection);
                    updateTotalCommand.ExecuteNonQuery();

                    connection.Close();

                    if (mood.Equals("Select") || sugarLvl.Equals("Select") || quantityTB.Texts.Equals("")) {
                        MessageBox.Show("Please select a mood or sugar level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    } else {
                        BillingFormat billForm = new BillingFormat(this, _menuInstance);
                        billForm.productLabel.Text = prodName;
                        billForm.moodLabel.Text = mood;
                        billForm.priceLabel.Text = price.ToString("F2");
                        billForm.sugarLabel.Text = sugarLvl;
                        billForm.quantityL.Text = inputQuantity.ToString();

                        billForm.setProductID(prodCode);
                        billForm.setPrice(price);
                        billForm.setQuantity(inputQuantity);

                        subTotal = price * inputQuantity;
                        tax = taxVal * subTotal;
                        total = tax + subTotal;

                        // Stack the input 
                        _menuInstance.setOverAllSubTotal(_menuInstance.getOverAllSubTotal() + subTotal);
                        _menuInstance.setOverAllTaxTotal(_menuInstance.getOverAllTaxTotal() + tax);
                        _menuInstance.setOverAllTotal(_menuInstance.getTotal() + total);

                        // Display the stack input
                        _menuInstance.subTotalAmount.Text = _menuInstance.getOverAllSubTotal().ToString("F2");
                        _menuInstance.taxAmount.Text = _menuInstance.getOverAllTaxTotal().ToString("F2");
                        _menuInstance.totalAmount.Text = _menuInstance.getTotal().ToString("F2");

                        addBtn.Enabled = enable;
                        moodComboBox.Text = "Select";
                        sugarLvlComboB.Text = "Select";
                        quantityTB.Texts = "";
                        _menuInstance.billingPanel.Controls.Add(billForm);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:  " + ex.Message, "Error On Process");
            }
        }

    }
}

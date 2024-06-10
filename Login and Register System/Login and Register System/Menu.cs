using MySql.Data.MySqlClient;
using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace Login_and_Register_System {
    public partial class Menu : UserControl {

        // Initialize Variable
        private string fullName;
        private string position;
        private double overAllSubTotal = 0;
        private double overAllTaxTotal = 0;
        private double overAllTotal = 0;

        public Menu (string fullName, string position) {
            this.fullName = fullName;
            this.position = position;

            InitializePanel();
        }

        public void setFullName(string fullName) { this.fullName = fullName; }
        public void setPosition(string position) { this.position = position; }
        public void setOverAllSubTotal (double overAllSubTotal) { this.overAllSubTotal = overAllSubTotal;  }
        public void setOverAllTaxTotal(double overAllTaxTotal) { this.overAllTaxTotal = overAllTaxTotal; }
        public void setOverAllTotal(double overAllTotal) { this.overAllTotal = overAllTotal; }
        public double getOverAllSubTotal () { return overAllSubTotal; }
        public double getOverAllTaxTotal () {  return overAllTaxTotal; }
        public double getTotal () { return overAllTotal; }

        public Menu() {
            InitializePanel();
        }

        private void InitializePanel() {
            InitializeComponent();
            itemPanel.AutoScroll = true;
            this.billingPanel.Anchor = ((AnchorStyles.Bottom | AnchorStyles.Right | AnchorStyles.Top));

            setPositionAndName();
            AdjustIconColor();
            LoadProfileImage();
        }



        public void RefreshPanel() {
            // Clear existing controls in the panel
             itemPanel.Controls.Clear();
             LoadPanelToMenu();
        }


        public void LoadPanelToMenu() {

            string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
            string selectQuery = "SELECT productID, productName, price, thumbnail FROM inventory";
            string formattedDecimal = ""; // Displays two decimal places
            int counter = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection)) {
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader()) {

                        while (reader.Read()) {
                            // Retrieve data from the database
                            string productId = reader.GetString("productID");
                            string productName = reader.GetString("productName");
                            decimal price = reader.GetDecimal("price");
                            byte[] thumbnailBytes = (byte[])reader["thumbnail"];
                            formattedDecimal = price.ToString("F2");

                            // Create an ItemHolder object for each database record
                            ItemHolder itemHold = new ItemHolder(this);
                            itemHold.prodCodeL.Text = productId;
                            itemHold.productNameL.Text = productName;
                            itemHold.priceL.Text = formattedDecimal;

                            try {
                                using (MemoryStream ms = new MemoryStream(thumbnailBytes)) {
                                    Image thumbnailImage = Image.FromStream(ms);
                                    itemHold.pictureHolder.SizeMode = PictureBoxSizeMode.Zoom;
                                    itemHold.pictureHolder.Image = thumbnailImage;
                                }
                            } catch (Exception ex) {
                                Console.WriteLine("Error: " + ex.Message);
                            }

                            itemHold.Dock = DockStyle.None; // Or adjust this based on your layout requirements
                            itemHold.Anchor = AnchorStyles.Top | AnchorStyles.Left;

                            itemHold.Margin = new Padding(0);
                            itemHold.Size = new Size(200, 250);

                            itemPanel.Controls.Add(itemHold);
                            counter++;
                        }
                    }
                }
            }
        }


        private void setPositionAndName() {
            String tempPos = "";
            if (position.Equals("Admin", StringComparison.OrdinalIgnoreCase)) {
                tempPos = "I'm an Admin";
            } else {
                tempPos = "I'm a Cashier";
            }
            positionLabel.Text = tempPos;
            fullNameLabel.Text = fullName;
        }

        public bool TopLevel { get ; internal set; }

        private void submitBtn_Click(object sender, EventArgs e) {

            if (billingPanel.Controls.Count < 0 || taxAmount.Text.Equals("0.00") || subTotalAmount.Text.Equals("0.00") || totalAmount.Text.Equals("0.00")) {
                MessageBox.Show("There are no transactions loaded.", "No Transactions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                // Add a confirmation dialog before proceeding
                DialogResult result = MessageBox.Show("Are you sure you want to submit the transaction?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
                    string selectQuery = "SELECT sales, incomeSales FROM register WHERE position = @position";
                    string positionToCheck = position;

                    try {
                        using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                            connection.Open();

                            using (MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection)) {
                                selectCommand.Parameters.AddWithValue("@position", positionToCheck);

                                using (MySqlDataReader reader = selectCommand.ExecuteReader()) {
                                    if (reader.Read()) {
                                        double sales = reader.GetDouble("sales") + overAllTotal;
                                        double incomeSales = reader.GetDouble("incomeSales") + overAllTaxTotal;

                                        reader.Close();

                                        string updateQuery = "UPDATE register SET sales = @sales, incomeSales = @incomeSales WHERE position = @position";
                                        MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection);
                                        updateCommand.Parameters.AddWithValue("@sales", sales);
                                        updateCommand.Parameters.AddWithValue("@incomeSales", incomeSales);
                                        updateCommand.Parameters.AddWithValue("@position", positionToCheck);
                                        updateCommand.ExecuteNonQuery();

                                        billingPanel.Controls.Clear();
                                        subTotalAmount.Text = "0.00";
                                        taxAmount.Text = "0.00";
                                        totalAmount.Text = "0.00";
                                        itemPanel.Controls.Clear();
                                    } else {
                                        MessageBox.Show("Position not found in the register table.");
                                    }
                                }
                            }
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("An error occurred while processing the transaction: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void searchTB__TextChanged(object sender, EventArgs e) {
            string searchTerm = searchTB.Texts.Trim().ToLower();
            int itemCount = 0;

            foreach (Control control in itemPanel.Controls) {
                if (control is ItemHolder item) {
                    bool isVisible = string.IsNullOrEmpty(searchTerm) ||
                                     item.productNameL.Text.ToLower().Contains(searchTerm);

                    item.Visible = isVisible;
                    itemCount += isVisible ? 1 : 0;
                }
            }

            // Update the count label
            searchLabel.Text = $"Search Result: {itemCount}";
        }


        private bool mouseEnter = false;
        private void refreshBtn_Click(object sender, EventArgs e) {
            RefreshPanel();
        }

        private void refreshBtn_MouseEnter(object sender, EventArgs e) {
            refreshBtn.IconColor = Color.FromArgb(101, 53, 15);
            refreshBtn.Cursor = Cursors.Hand;
            mouseEnter = true;
        }

        private void refreshBtn_MouseLeave(object sender, EventArgs e) {
            refreshBtn.IconColor = Color.Black;
            refreshBtn.Cursor = Cursors.Default;
            mouseEnter = false;
        }

        private void refreshBtn_MouseDown(object sender, MouseEventArgs e) {
            refreshBtn.IconColor = Color.FromArgb(204, 169, 118);
            refreshBtn.Cursor = Cursors.Hand;
        }

        private void refreshBtn_MouseUp(object sender, MouseEventArgs e) {
            if (mouseEnter != false)
                refreshBtn_MouseEnter(sender, e);   
            else
                refreshBtn_MouseLeave(sender, e);
        }

        private void AdjustIconColor() {
            if (position == "Admin")
                positionChar.IconColor = Color.FromArgb(241, 229, 172);
            else
                positionChar.IconColor = Color.Black;
        }


        public void LoadProfileImage() {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string selectQuery = "SELECT profile FROM register WHERE position = @position";

            try {
                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection)) {
                        connection.Open();
                        // Assuming "position" is a parameter for filtering the query
                        cmd.Parameters.AddWithValue("@position", position);

                        using (MySqlDataReader reader = cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                if (!reader.IsDBNull(0)) {
                                    byte[] imageData = (byte[])reader["profile"];
                                    DisplayImage(imageData);
                                } else {
                                    MessageBox.Show("No image found for admin.");
                                    ClearPictureBox();
                                }
                            } else {
                                MessageBox.Show("No data found for the given position.");
                                ClearPictureBox();
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }


        private void DisplayImage(byte[] imageData) {
            try {
                using (MemoryStream ms = new MemoryStream(imageData)) {
                    Image loadedImage = Image.FromStream(ms);
                    addProfilePB.Image = FitImageToPictureBox(loadedImage, addProfilePB);
                }
            } catch (Exception ex) {
                Console.WriteLine("Error displaying image: " + ex.Message);
            }
        }

        private void ClearPictureBox() {
            addProfilePB.Image = null;
            addProfilePB.IconChar = FontAwesome.Sharp.IconChar.User;
        }


        public Image FitImageToPictureBox(Image image, PictureBox pictureBox) {
            // Calculate aspect ratios
            float ratioX = (float)pictureBox.Width / image.Width;
            float ratioY = (float)pictureBox.Height / image.Height;
            float ratio = Math.Min(ratioX, ratioY);

            // Calculate new dimensions
            int newWidth = (int)(image.Width * ratio);
            int newHeight = (int)(image.Height * ratio);

            // Create a new Bitmap with the resized dimensions
            Bitmap newImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(newImage)) {
                // Set interpolation mode and draw the image with new dimensions
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return newImage;
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_and_Register_System {
    public partial class ProductModoule : Form {

        private Inventory _inventoryInstance;
        public ProductModoule() {
            initializeComponents();
        }

        public ProductModoule(Inventory inventoryInstance) {
            _inventoryInstance = inventoryInstance;
            initializeComponents();
        }

        private void initializeComponents() {
            InitializeComponent();

            topPanel.MouseDown += TopPanel_MouseDown;
            topPanel.MouseMove += TopPanel_MouseMove;
            topPanel.MouseUp += TopPanel_MouseUp;
        }


        private bool mouseEnter = false;
        private Point mouseLocation;

        private void closeBtn_MouseEnter(object sender, EventArgs e) {
            closeBtn.IconColor = Color.Red;
            closeBtn.Cursor = Cursors.Hand;
            mouseEnter = true;
        }

        private void closeBtn_MouseDown(object sender, MouseEventArgs e) {
            closeBtn.IconColor = Color.FromArgb(252, 159, 159);
            closeBtn.Cursor = Cursors.Hand;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e) {
            closeBtn.IconColor = Color.FromArgb(252, 246, 237);
            closeBtn.Cursor = Cursors.Default;
            mouseEnter = false;
        }

        private void closeBtn_MouseUp(object sender, MouseEventArgs e) {
            if (mouseEnter != false)
                closeBtn_MouseEnter(sender, e);
            else
                closeBtn_MouseLeave(sender, e);
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        // Making the mouse Draggable
        private void TopPanel_MouseDown(object sender, MouseEventArgs e) {
            mouseLocation = new Point(-e.X, -e.Y);
            topPanel.Cursor = Cursors.SizeAll;
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePos;
                topPanel.Cursor = Cursors.SizeAll;
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e) {
            topPanel.Cursor = Cursors.Default;
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the process?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                // Close the form
                this.Close();
            }
        }

        private void addImagePicBox_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Get the selected file's path
                    string imagePath = openFileDialog.FileName;

                    // Display the selected image in a PictureBox
                    addImagePicBox.SizeMode = PictureBoxSizeMode.Zoom; // Adjust the image size mode as needed
                    addImagePicBox.Image = new Bitmap(imagePath);

                    // Set the PictureBox properties
                    addImagePicBox.Width = 100; // Set your desired width
                    addImagePicBox.Height = 100; // Set your desired height
                    addImagePicBox.BorderStyle = BorderStyle.FixedSingle; // Set the border style if desired

                    // Add the PictureBox to your form's controls
                    this.Controls.Add(addImagePicBox);

                    // Optionally, position the PictureBox on your form
                    addImagePicBox.Location = new Point(162, 223); // Set your desired location
                } catch (Exception ex) {
                    MessageBox.Show("Error: Could not load the image - " + ex.Message);
                }
            }
        }

        private void saveProdBtn_Click(object sender, EventArgs e) {
            try {
                // MySQL connection string
                // Check if all textboxes and picture box have data
                if (string.IsNullOrEmpty(prodCodeTB.Texts) || string.IsNullOrEmpty(prodNameTB.Texts) ||
                    string.IsNullOrEmpty(priceTB.Texts) || string.IsNullOrEmpty(quantityTB.Texts) ||
                    addImagePicBox.Image == null) {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";

                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    connection.Open();

                    // Insert query to add data to the database
                    string query = "INSERT INTO inventory (productID, productName, price, quantity, total, thumbnail) " +
                                   "VALUES (@productID, @productName, @price, @quantity, @total, @thumbnail)";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Assign parameter values from text boxes
                    double priceAmount;
                    if (!double.TryParse(priceTB.Texts, out priceAmount)) {
                        MessageBox.Show("Please enter a valid price.");
                        return;
                    }

                    int quantity;
                    if (!int.TryParse(quantityTB.Texts, out quantity)) {
                        MessageBox.Show("Please enter a valid quantity.");
                        return;
                    }

                    // Then calculate the total amount
                    double totalAmount = priceAmount * quantity;


                    command.Parameters.AddWithValue("@productID", prodCodeTB.Texts);
                    command.Parameters.AddWithValue("@productName", prodNameTB.Texts);
                    command.Parameters.AddWithValue("@price", priceAmount);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@total", totalAmount);

                    // Convert PictureBox image to compressed and resized byte array
                    if (addImagePicBox.Image != null) {
                        Image originalImage = addImagePicBox.Image;
                        byte[] compressedImageData = CompressAndResizeImage(originalImage, 800, 600); // Adjust max width and height as needed

                        try {
                            command.Parameters.AddWithValue("@thumbnail", compressedImageData); 
                        } catch (Exception ex) {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    } else {
                        MessageBox.Show("Please select an image.");
                    }

                    // Execute the insertion query
                    command.ExecuteNonQuery();
                    MessageBox.Show("Product saved successfully!");
                    

                    // Refresh Data
                    RefreshTable();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updateProdBtn_Click(object sender, EventArgs e) {
            try {
                // Check if all textboxes and picture box have data
                if (string.IsNullOrEmpty(prodCodeTB.Texts) || string.IsNullOrEmpty(prodNameTB.Texts) ||
                    string.IsNullOrEmpty(priceTB.Texts) || string.IsNullOrEmpty(quantityTB.Texts) ||
                    addImagePicBox.Image == null) {
                    MessageBox.Show("Please fill all fields.");
                    return;
                }

                string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    connection.Open();

                    // Update query to modify existing data in the database
                    string query = "UPDATE inventory SET productName = @productName, " +
                                   "price = @price, quantity = @quantity, total = @total, thumbnail = @thumbnail " +
                                   "WHERE productID = @productID";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    double priceAmount;
                    if (!double.TryParse(priceTB.Texts, out priceAmount)) {
                        MessageBox.Show("Please enter a valid price.");
                        return;
                    }

                    int quantity;
                    if (!int.TryParse(quantityTB.Texts, out quantity)) {
                        MessageBox.Show("Please enter a valid quantity.");
                        return;
                    }

                    double totalAmount = priceAmount * quantity;

                    command.Parameters.AddWithValue("@productName", prodNameTB.Texts);
                    command.Parameters.AddWithValue("@price", priceAmount);
                    command.Parameters.AddWithValue("@quantity", quantity);
                    command.Parameters.AddWithValue("@total", totalAmount);
                    command.Parameters.AddWithValue("@productID", prodCodeTB.Texts);

                    // Convert PictureBox image to compressed and resized byte array
                    if (addImagePicBox.Image != null) {
                        Image originalImage = addImagePicBox.Image;
                        byte[] compressedImageData = CompressAndResizeImage(originalImage, 800, 600); // Adjust max width and height as needed

                        command.Parameters.AddWithValue("@thumbnail", compressedImageData);
                    } else {
                        MessageBox.Show("Please select an image.");
                        return;
                    }

                    // Execute the update query
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0) {
                        MessageBox.Show("Product updated successfully!");
                    } else {
                        MessageBox.Show("No product found with the specified ID.");
                    }

                    // Refresh Data
                    RefreshTable();
                    this.Close();
                }
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RefreshTable() {
            // Clear input data if needed
            prodCodeTB.Texts = "";
            prodNameTB.Texts = "";
            priceTB.Texts = "";
            quantityTB.Texts = "";
            addImagePicBox.Image = null;
            addImagePicBox.IconChar = FontAwesome.Sharp.IconChar.Add;
            addImagePicBox.IconSize = 65;

            // Trigger Refresh if needed
            _inventoryInstance.RefreshInventoryData();
        }


        private byte[] CompressAndResizeImage(Image image, int maxWidth, int maxHeight) {
            using (var stream = new MemoryStream()) {
                int newWidth, newHeight;
                if (image.Width > maxWidth || image.Height > maxHeight) {
                    double aspectRatio = (double)image.Width / image.Height;

                    if (aspectRatio > 1) {
                        newWidth = maxWidth;
                        newHeight = (int)(maxWidth / aspectRatio);
                    } else {
                        newHeight = maxHeight;
                        newWidth = (int)(maxHeight * aspectRatio);
                    }
                } else {
                    newWidth = image.Width;
                    newHeight = image.Height;
                }

                using (var newImage = new Bitmap(newWidth, newHeight)) {
                    using (var graphics = Graphics.FromImage(newImage)) {
                        graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                        graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                        graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(image, 0, 0, newWidth, newHeight);
                    }
                    newImage.Save(stream, ImageFormat.Jpeg); // Change format if needed
                    return stream.ToArray();
                }
            }
        }

    }
}
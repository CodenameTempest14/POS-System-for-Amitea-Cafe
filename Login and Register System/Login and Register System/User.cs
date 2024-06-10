using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.IO;

namespace Login_and_Register_System {
    public partial class User : UserControl {
        private string position;
        private string tempPos;
        protected string fullName;
        private Timer timer;
        public User() {
            InitializeComponent();
        }

        public User(string position, string fullName) {
            this.position = position;
            this.fullName = fullName;
            InitializeComponent();

            LoadRegisterDataFromDatabase();


            // Initialize and start the timer
            timer = new Timer();
            timer.Interval = 1000; // Update time every second
            timer.Tick += Timer_Tick;
            timer.Start();

            LoadProfileImage();
            LabelAdmin();
        }

        private void Timer_Tick(object sender, EventArgs e) {
            timerLabel.Text = DateTime.Now.ToString("hh:mm:ss tt");
            dateLabel.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        public string getPosition() { return tempPos; }


        public bool TopLevel { get; internal set; }

        private void userInfoDG_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (userInfoDG.Columns[e.ColumnIndex].Name == "Edit" && e.RowIndex >= 0) {
                int rowIndex = e.RowIndex; // Get the row index of the clicked cell

                // Assuming the columns for position, name, incomeSales, and totalSales are at indexes 0, 1, 2, and 3 respectively
                tempPos = userInfoDG.Rows[rowIndex].Cells[0].Value?.ToString();
                string name = userInfoDG.Rows[rowIndex].Cells[1].Value?.ToString();
                double incomeSales = Convert.ToDouble(userInfoDG.Rows[rowIndex].Cells[2].Value?.ToString());
                double totalSales = Convert.ToDouble(userInfoDG.Rows[rowIndex].Cells[3].Value?.ToString());

                // Now, retrieve additional information from the database based on position
                string selectQuery = "SELECT email, username, password, profile, phoneNum FROM register WHERE position = @position";

                UserProfile userP = new UserProfile(this);
                userP.nameL.Text = name;
                userP.positionLabel.Text = tempPos;
                userP.incomeSalesL.Text = incomeSales.ToString("F2");
                userP.totalSalesL.Text = totalSales.ToString("F2");

                string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    connection.Open();
                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@position", tempPos);

                    using (MySqlDataReader reader = selectCommand.ExecuteReader()) {
                        if (reader.Read()) {
                            string email = reader["email"].ToString();
                            string username = reader["username"].ToString();
                            string password = reader["password"].ToString();
                            string phoneNumber = reader["phoneNum"].ToString();
                            byte[] imageData = (byte[])reader["profile"];

                            userP.emailTB.Texts = email;
                            userP.userTB.Texts = username;
                            userP.passTB.Texts = password;
                            userP.phoneTB.Texts = phoneNumber;

                            if (imageData != null && imageData.Length > 0) {
                                using (MemoryStream ms = new MemoryStream(imageData)) {
                                    try {
                                        userP.addProfile.SizeMode = PictureBoxSizeMode.Zoom;
                                        userP.addProfile.Image = Image.FromStream(ms);
                                    } catch (ArgumentException ex) {
                                        // Handle the exception (e.g., log or display an error message)
                                        Console.WriteLine("Error: " + ex.Message);
                                    }
                                }
                            } else {
                                userP.addProfile.Image = null;
                            }
                        }
                    }
                }
                userP.ShowDialog();
            } else if (userInfoDG.Columns[e.ColumnIndex].Name == "Delete" && e.RowIndex >= 0) { // Logic for Deletion of user
                // Ask for confirmation before deleting the record
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes) {
                    // Perform deletion logic here


                    string userToDelete = userInfoDG.Rows[e.RowIndex].Cells[0].Value?.ToString();

                    // Perform deletion query here
                    string deleteQuery = "DELETE FROM register WHERE position = @position";

                    string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
                    using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                        connection.Open();
                        MySqlCommand deleteCommand = new MySqlCommand(deleteQuery, connection);
                        deleteCommand.Parameters.AddWithValue("@position", userToDelete);
                        deleteCommand.ExecuteNonQuery();
                    }

                    // Refresh or update the DataGridView after deletion if needed
                    LoadRegisterDataFromDatabase();
                }
            }
        }


        public void RefreshData() {
            LoadRegisterDataFromDatabase();
        }

        private void LoadRegisterDataFromDatabase() {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string query = "SELECT position, fullName, sales, incomeSales FROM register WHERE position != 'Admin'";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                using (MySqlCommand cmd = new MySqlCommand(query, connection)) {
                    try {
                        connection.Open();
                        DataTable dataTable = new DataTable();
                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(dataTable);

                        // Clear existing rows in the DataGridView
                        userInfoDG.Rows.Clear();

                        // Populate DataGridView with fetched data
                        foreach (DataRow row in dataTable.Rows) {
                            userInfoDG.Rows.Add(
                                row["position"],           // Position
                                row["fullName"],           // Cashier's name
                                row["incomeSales"],        // Profit / Income sales
                                row["sales"]               // Total Sales
                            );
                        }
                    } catch (Exception ex) {
                        // Handle exception (e.g., show error message)
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
        }

        private void adminProfile_Click(object sender, EventArgs e) {
            // Open file dialog to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Read the selected image file
                    string imagePath = openFileDialog.FileName;
                    byte[] imageBytes = File.ReadAllBytes(imagePath);

                    // Compress the image (optional)
                    byte[] compressedImageBytes = CompressImage(imageBytes);

                    // Save the compressed image to the database
                    SaveImageToDatabase(compressedImageBytes);

                } catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        // Function to compress the image (using a simple example)
        public byte[] CompressImage(byte[] imageBytes) {
            // Create a MemoryStream from the image bytes
            using (MemoryStream ms = new MemoryStream(imageBytes)) {
                // Create an Image from the MemoryStream
                using (Image image = Image.FromStream(ms)) {
                    // Define the desired width and height for the compressed image
                    int maxWidth = 800;
                    int maxHeight = 600;

                    // Calculate new dimensions while maintaining the aspect ratio
                    int newWidth, newHeight;
                    if (image.Width > image.Height) {
                        newWidth = maxWidth;
                        newHeight = (int)((float)image.Height / image.Width * maxWidth);
                    } else {
                        newHeight = maxHeight;
                        newWidth = (int)((float)image.Width / image.Height * maxHeight);
                    }

                    // Create a new bitmap with the new dimensions
                    using (Bitmap newImage = new Bitmap(newWidth, newHeight)) {
                        using (Graphics g = Graphics.FromImage(newImage)) {
                            // Set interpolation mode and draw the image with new dimensions
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.DrawImage(image, 0, 0, newWidth, newHeight);
                        }

                        // Save the compressed image to a new MemoryStream
                        using (MemoryStream compressedStream = new MemoryStream()) {
                            newImage.Save(compressedStream, image.RawFormat);
                            // Return the compressed image bytes
                            return compressedStream.ToArray();
                        }
                    }
                }
            }
        }

        // Function to save the image to the database
        private void SaveImageToDatabase(byte[] imageBytes) {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string query = "UPDATE register SET profile = @imageData WHERE position = 'Admin'";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                using (MySqlCommand cmd = new MySqlCommand(query, connection)) {
                    try {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@imageData", imageBytes);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show("Image it too large, please Find another one", "Error upon upload");
                    }
                }
            }
            LoadProfileImage();
        }

        // Function to save the image to the database and load it for display
        public void LoadProfileImage() {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string selectQuery = "SELECT profile FROM register WHERE position = 'Admin'";

            try {
                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection)) {
                        using (MySqlDataReader reader = cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                if (!reader.IsDBNull(0)) {
                                    byte[] imageData = (byte[])reader["profile"];
                                    DisplayImage(imageData);
                                } else {
                                    MessageBox.Show("No image found for admin.");
                                    adminProfile.Image = null; // Clear the PictureBox if no image found
                                }
                            }
                        }
                    }
                }
            } catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        private void DisplayImage(byte[] imageData) {
            using (MemoryStream ms = new MemoryStream(imageData)) {
                Image loadedImage = Image.FromStream(ms);
                adminProfile.Image = FitImageToPictureBox(loadedImage, adminProfile);
            }
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

        private void searchTB__TextChanged(object sender, EventArgs e) {
            searchFunction();
        }

        private void searchFunction() {
            string searchTerm = searchTB.Texts.Trim();

            string selectQuery = "SELECT position AS positionColumn, fullname AS nameCol, incomeSales AS incomeSalesCol,  sales AS totalSalesCol FROM register WHERE fullname LIKE @searchTerm";

            if (string.IsNullOrEmpty(searchTerm)) {
                LoadRegisterDataFromDatabase();
                return;
            }

            string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                connection.Open();
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@searchTerm", $"%{searchTerm}%");

                MySqlDataAdapter adapter = new MySqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Clear DataGridView content
                userInfoDG.Rows.Clear();

                // Populate DataGridView with filtered data
                foreach (DataRow row in dataTable.Rows) {
                    userInfoDG.Rows.Add(row["positionColumn"], row["nameCol"], row["incomeSalesCol"], row["totalSalesCol"]);
                }

            }
        }

        public void LabelAdmin() {
            positionLabel.Text = position;
            adminName.Text = fullName;

            string selectQuery = "SELECT email, sales, incomeSales FROM register WHERE position = @position";

            string connectionString = "server=localhost;database=posdb;uid=root;password=#Ma5052361;";
            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                connection.Open();
                MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@position", position);

                using (MySqlDataReader reader = selectCommand.ExecuteReader()) {
                    if (reader.Read()) {
                        string email = reader["email"].ToString();
                        double incomeSales = Convert.ToDouble(reader["incomeSales"].ToString());
                        double sales = Convert.ToDouble(reader["sales"].ToString());

                        emailL.Text = email;
                        incomeSalesL.Text = $"Sales: ₱ {incomeSales.ToString("F2")}";
                        salesL.Text = $"Total Sales: ₱ {sales.ToString("F2")}";
                        } 
                    }
                }
         }
     }
}

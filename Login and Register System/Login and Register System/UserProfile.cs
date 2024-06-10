using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_and_Register_System {
    public partial class UserProfile : Form {

        private User _user;
        private string position = "";
        public UserProfile(User user) {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _user = user;
            LoadProfileImage();
            position = _user.getPosition();

        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,                       // x-coordinate of upper-left corner
       int nTopRect,                        // y-coordinate of upper-left corner
       int nRightRect,                    // x-coordinate of lower-right corner
       int nBottomRect,                // y-coordinate of lower-right corner
       int nWidthEllipse,              // height of ellipse
       int nHeightEllipse              // width of ellipse
   );

        private void saveBtn_Click(object sender, EventArgs e) {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string query = "UPDATE register SET email = @email, phoneNum = @phone, username = @username, password = @password WHERE position = '" + position + "'";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                using (MySqlCommand command = new MySqlCommand(query, connection)) {

                    string password = "";

                    if (phoneTB.Texts.Length == 11) {
                        password = passTB.Texts;
                    } else {
                        MessageBox.Show("Phone numbers should be equal to 11 digits", "Error Upon Fill-up", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Assuming emailTB, phoneTB, userTB, and passTB are TextBox controls.
                    string email = emailTB.Texts;
                    string phone = phoneTB.Texts;
                    string username = userTB.Texts;


                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@phone", phone);
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try {
                        connection.Open();
                        int rowsUpdated = command.ExecuteNonQuery();
                        if (rowsUpdated > 0) {
                            // Successful update
                            MessageBox.Show("Data updated successfully!");
                        } else {
                            // No rows were affected
                            MessageBox.Show("No changes made.");
                        }
                    } catch (Exception ex) {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }

            saveBtn.Enabled = false;
            emailTB.Enabled = false;
            phoneTB.Enabled = false;
            userTB.Enabled = false;
            passTB.Enabled = false;
        }



        private void cancelBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                this.Close(); // Close the form if user confirms
            }
        }

        private void addProfile_Click(object sender, EventArgs e) {
            // Open file dialog to select an image file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                try {
                    // Read the selected image file
                    string imagePath = openFileDialog.FileName;
                    byte[] imageBytes = File.ReadAllBytes(imagePath);

                    // Compress the image (optional)
                    byte[] compressedImageBytes = _user.CompressImage(imageBytes);

                    // Save the compressed image to the database for the new user or purpose
                    SaveNewImageToDatabase(compressedImageBytes);

                } catch (Exception ex) {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void SaveNewImageToDatabase(byte[] imageBytes) {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string query = "UPDATE register SET profile = @imageData WHERE position = '" + position + "'";

            using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                using (MySqlCommand cmd = new MySqlCommand(query, connection)) {
                    try {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@imageData", imageBytes);
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                }
            }
            // Optionally load the new profile image after adding it to the database  
            LoadProfileImage();
        }

        public void LoadProfileImage() {
            string connectionString = "Server=localhost;Database=posdb;Uid=root;Pwd=#Ma5052361;";
            string selectQuery = "SELECT profile FROM register WHERE position = @Position";

            try {
                using (MySqlConnection connection = new MySqlConnection(connectionString)) {
                    connection.Open();

                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection)) {
                        cmd.Parameters.AddWithValue("@Position", position);

                        using (MySqlDataReader reader = cmd.ExecuteReader()) {
                            if (reader.Read()) {
                                if (!reader.IsDBNull(0)) {
                                    byte[] imageData = (byte[])reader["profile"];
                                    DisplayImage(imageData);
                                } else {
                                    MessageBox.Show("No image found.");
                                    addProfile.Image = null; // Clear the PictureBox if no image found
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
                addProfile.Image = _user.FitImageToPictureBox(loadedImage, addProfile);
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
            panel1.Cursor = Cursors.Hand;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
         }

         private void panel1_MouseUp(object sender, MouseEventArgs e) {
                mouseDown = false;
         }
    }
}

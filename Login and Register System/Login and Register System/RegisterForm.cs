using AnimateDemo;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_and_Register_System {
    public partial class RegisterForm : Form {

        public RegisterForm() {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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


        // Hover the form
        private bool mouseDown;
        private Point lastLocation;

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void RegisterForm_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        private void adminCB_CheckedChanged(object sender, EventArgs e) {
            if (adminCB.Checked == true) {
                cashierCB.Enabled = false;
            } else {
                cashierCB.Enabled = true;
            }
        }

        private void cashierCB_CheckedChanged(object sender, EventArgs e) {
            if (cashierCB.Checked == true) {
                adminCB.Enabled = false;
            } else {
                adminCB.Enabled = true;
            }
        }


        // Goto Login Form
        private void loginLabel_MouseEnter(object sender, EventArgs e) {
            loginLabel.ForeColor = Color.Green;
            loginLabel.Cursor = Cursors.Hand;
        }

        private void loginLabel_MouseLeave(object sender, EventArgs e) {
            loginLabel.ForeColor = Color.Black;
            loginLabel.Cursor = Cursors.Default;
        }

        private void loginLabel_MouseDown(object sender, MouseEventArgs e) {
            LoginForm loginForm = new LoginForm();
            loginLabel.ForeColor = Color.PaleVioletRed;
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        // Smoother Transition
        private void RegisterForm_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
        }

        private void submitRegister() {
            string server = "localhost";
            string uid = "root";
            string password = "#Ma5052361";
            string database = "posdb";

            try {
                string connectionString = "server=" + server + ";user=" + uid + ";database=" + database + ";password=" + password;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Check if either of the text boxes are filled on
               if (nameTB.Texts.Equals("") || emailTB.Texts.Equals("") || userTB.Texts.Equals("") || passTB.Texts.Equals("")) {
                    MessageBox.Show("Please fill in the necesarry fields on the form.", "Error Upon Regsiter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Initialize input
                string position = "";
                if (adminCB.Checked) {
                    position = "Admin";
                } else if (cashierCB.Checked) {
                    position = "Cashier";
                }

                // Check if the position already exists in the database
                string checkQuery = "SELECT COUNT(*) FROM register WHERE position = @Position";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@Position", position);

                int existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (existingCount > 0) {
                    if (position == "Cashier") {
                        int increment = 1;
                        while (existingCount > 0) {
                            string incrementedCashier = $"Cashier {increment}";
                            checkCmd.Parameters["@Position"].Value = incrementedCashier;
                            existingCount = Convert.ToInt32(checkCmd.ExecuteScalar());
                            increment++;
                        }
                        position = $"Cashier {increment - 1}";
                    } else {
                        MessageBox.Show($"{position} already exists.");
                        connection.Close();
                        return;
                    }
                }

                string full_name = nameTB.Texts;
                string email = emailTB.Texts;
                string user = userTB.Texts;
                string pass = passTB.Texts;
                byte[] placeHolder = new byte[200];

                string insertQuery = "INSERT INTO register (position, fullname, email, username, password, sales, incomeSales, phoneNum, profile) " +
                      "VALUES ('" + position + "','" + full_name + "','" + email + "','" + user + "','" + pass + "',0.00,0.00,0,'" + placeHolder +"')";
                MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                insertCmd.Parameters.AddWithValue("@Position", position);
                insertCmd.Parameters.AddWithValue("@FullName", full_name);
                insertCmd.Parameters.AddWithValue("@Email", email);
                insertCmd.Parameters.AddWithValue("@Username", user);
                insertCmd.Parameters.AddWithValue("@Password", pass);

                int exec = insertCmd.ExecuteNonQuery();

                if (exec > 0) {
                    MessageBox.Show("Data inserted Successfully");
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Close();
                } else {
                    MessageBox.Show("Failed to insert data");
                }

                connection.Close(); // Close the connection after using it
            } catch (MySqlException ex) {
                MessageBox.Show("Error: " + ex.Message);
            } catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void registerB_Click(object sender, EventArgs e) {
            submitRegister();
        }

        private void showPassBtn_Click(object sender, EventArgs e) {
            passTB.PasswordChar = !passTB.PasswordChar; // Toggle between true and false

            if (passTB.PasswordChar)
                showPassBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            else
                showPassBtn.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
        }
    }
}

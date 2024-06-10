using AnimateDemo;
using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Login_and_Register_System {
    public partial class LoginForm : Form {
        public LoginForm() {
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

        // Account Register
        private void noteL_MouseLeave(object sender, EventArgs e) {
            noteL.ForeColor = Color.Black;
            noteL.Cursor = Cursors.Default;
        }

        private void noteL_MouseEnter(object sender, EventArgs e) {
            noteL.ForeColor = Color.Green ;
            noteL.Cursor = Cursors.Hand;
        }

        private void noteL_MouseDown(object sender, MouseEventArgs e) {
            RegisterForm register = new RegisterForm();
            noteL.ForeColor = Color.PaleVioletRed;
            this.Hide();
            register.ShowDialog();
            this.Close();
        }

        // Hover the Form
        private bool mouseDown;
        private Point lastLocation;

        private void designsPanel_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
            designsPanel.Cursor = Cursors.SizeAll;
        }

        private void designsPanel_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void designsPanel_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
            designsPanel.Cursor = Cursors.Default;
        }

        private void loginPanel_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
            loginPanel.Cursor = Cursors.SizeAll;
        }

        private void loginPanel_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void loginPanel_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
            loginPanel.Cursor = Cursors.Default;
        }

        // Smoother transition
        private void LoginForm_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 500, WinAPI.BLEND);
            userTB.Focus(); // Set focus to the username textbox when the form loads
        }


        // Command to proceed to Dashboard
        
        private void AttemptLogin() {
            string server = "localhost";
            string uid = "root";
            string password = "#Ma5052361";
            string database = "posdb";

            try {
                string connectionString = "server=" + server + ";user=" + uid + ";database=" + database + ";password=" + password;
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                string username = userTB.Texts;
                string enteredPassword = passTB.Texts;

                string query = "SELECT COUNT(*) FROM register WHERE username = @Username AND password = @Password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", enteredPassword);

                int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                if (userCount > 0) {

                    // Fetch position and fullName from the database based on the logged-in username
                    string getPositionQuery = "SELECT position, fullName FROM register WHERE username = @Username";
                    MySqlCommand getPositionCmd = new MySqlCommand(getPositionQuery, connection);
                    getPositionCmd.Parameters.AddWithValue("@Username", username);
                    string position = "";
                    string fullName = "";

                    using (MySqlDataReader reader = getPositionCmd.ExecuteReader()) {
                        if (reader.Read()) {
                             position = reader["position"].ToString();
                             fullName = reader["fullName"].ToString();
           
                            Dashboard db = new Dashboard(fullName, position);
                            // Hide the User button on load if the user is not an Admin
                            if (position != "Admin") {
                                db.usersB.Hide(); 
                            }

                            this.Hide();
                            db.ShowDialog();
                            this.Close();
                        } 
                    } 
                } else {
                    System.Windows.Forms.MessageBox.Show("Incorrect username or password.\nPlease create an account.", "Error Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close(); // Close the connection after using it
            } catch (MySqlException ex) {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception ex) {
                System.Windows.Forms.MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginBtn_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(userTB.Texts) || string.IsNullOrWhiteSpace(passTB.Texts)) {
                // Show an error message
                MessageBox.Show("Please fill in the search text box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop further execution
            } else {
                AttemptLogin();
            }      
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


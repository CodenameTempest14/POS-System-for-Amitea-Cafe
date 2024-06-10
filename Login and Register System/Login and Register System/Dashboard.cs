using AltoControls;
using AnimateDemo;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Media;
using Point = System.Drawing.Point;

namespace Login_and_Register_System {

    public partial class Dashboard : Form {

        // Initialize Variable
        private string fullName;
        private string position;

        protected Menu menuForm;
        protected Inventory inventoryForm;
        protected User userForm;

        private Control currentForm = null;

        public Dashboard(string fullName, string position) {
            this.fullName = fullName;
            this.position = position;

            InitializePanel();
        }

        public string getFullName() { return fullName; }
        public string getPosition() { return position; }

        public Dashboard() {
            InitializePanel();
        }

        public void InitializePanel() {
            InitializeComponent();
            RestoreRoundedCorners();
            viewerPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;


            menuForm = new Menu(fullName, position);
            inventoryForm = new Inventory(this);
            userForm = new User(position, fullName);

            this.Resize += new EventHandler(Dashboard_Resize);
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

        // Smooth transition
        private void Dashboard_Load(object sender, EventArgs e) {
            WinAPI.AnimateWindow(this.Handle, 300, WinAPI.BLEND);

            // Load menuForm automatically when the Dashboard is opened
            ShowFormInViewerPanel(menuForm);
            menuForm.LoadProfileImage();
        }

        // Minimize the dashboard
        private void minimizeBtn_Click(object sender, EventArgs e) {
            SmoothMinimizeForm();
        }

        // Smooth minimized transition effect
        private void SmoothMinimizeForm() {
            // Animate the window minimizing effect towards the taskbar icon
            Win32.AnimateWindow(this.Handle, 200, Win32.AnimateWindowFlags.AW_BLEND | Win32.AnimateWindowFlags.AW_VER_POSITIVE | Win32.AnimateWindowFlags.AW_HIDE);

            // Minimize the form towards the taskbar icon
            Win32.ShowWindow(this.Handle, Win32.SW_MINIMIZE);
        }

        private bool isMaximized = false; // Track whether the form is maximized


        private void maximizeBtn_Click(object sender, EventArgs e) {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Minimized) {
                MaximizeForm();
            } else if (this.WindowState == FormWindowState.Maximized) {
                RestoreForm();
            }
        }

        // Exit Button
        private void exitBtn_Click(object sender, EventArgs e) {
            DialogResult result = MessageBox.Show("Are you sure you want to close the window?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                Application.Exit();
            }
        }

        private void MaximizeForm() {
            // Maximize the form first
            this.WindowState = FormWindowState.Maximized;
            isMaximized = true;

            // Disable rounding before maximizing
            this.FormBorderStyle = FormBorderStyle.None;
            Region = null;

            // Apply rounded corners after maximizing
            RestoreRoundedCorners();
        }

        private void RestoreForm() {
            // Restore the form
            this.WindowState = FormWindowState.Normal;
            isMaximized = false;

            // Enable rounded corners
            RestoreRoundedCorners();
        }

        private void RestoreRoundedCorners() {
            if (!isMaximized) {
                // Re-apply rounded corners if not maximized
                this.FormBorderStyle = FormBorderStyle.None;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
        }

        // Handle form resize event to update rounded corners
        private void Dashboard_Resize(object sender, EventArgs e) {
            if (isMaximized) {
                RestoreRoundedCorners();
            }
        }



        // Hover Mouse

        private bool mouseDown;
        private Point lastLocation;


        private void commandPanel_MouseDown_1(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
            commandPanel.Cursor = Cursors.Hand;
        }

        private void commandPanel_MouseMove_1(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void commandPanel_MouseUp_1(object sender, MouseEventArgs e) {
            mouseDown = false;
        }

        // Hover for viewer p

        private void viewerPanel_MouseDown(object sender, MouseEventArgs e) {
            mouseDown = true;
            lastLocation = e.Location;
            viewerPanel.Cursor = Cursors.Hand;
        }

        private void viewerPanel_MouseMove(object sender, MouseEventArgs e) {
            if (mouseDown) {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void viewerPanel_MouseUp(object sender, MouseEventArgs e) {
            mouseDown = false;
            viewerPanel.Cursor = Cursors.Default;
        }

        // Button's Function Section
      

        private void HandleLogout() {
            DialogResult result = System.Windows.Forms.MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                this.Hide();
                LoginForm login = new LoginForm();
                login.ShowDialog();
                this.Close();
            } else {
                // User chose not to logout
                System.Windows.Forms.MessageBox.Show("Logout has been cancelled.", "Logout Account", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ChangeButtonColors(IconButton button, System.Drawing.Color backColor, System.Drawing.Color iconColor, System.Drawing.Color foreColor) {
            button.BackColor = backColor;
            button.IconColor = iconColor;
            button.ForeColor = foreColor;
        }

        private void HandleButtonMouseEnter(IconButton button) {
            ChangeButtonColors(button, System.Drawing.Color.FromArgb(214, 160, 117), System.Drawing.Color.White, System.Drawing.Color.White);
        }

        private void HandleButtonMouseLeave(IconButton button) {
            ChangeButtonColors(button, System.Drawing.Color.White, System.Drawing.Color.DarkGray, System.Drawing.Color.DarkGray);
        }

        // Home Commands
        private void homeB_MouseEnter(object sender, EventArgs e) {
            HandleButtonMouseEnter((IconButton)sender);
            menuB.Cursor = inventoryB.Cursor =
                 usersB.Cursor = logoutB.Cursor = Cursors.Hand;
        }

        private void homeB_MouseLeave(object sender, EventArgs e) {
            HandleButtonMouseLeave((IconButton)sender);
            menuB.Cursor = inventoryB.Cursor = 
                usersB.Cursor = logoutB.Cursor = Cursors.Default;    
        }

        // Logout Button
        private void logoutB_Click(object sender, EventArgs e) {
            HandleLogout();
        }


        private void ShowFormInViewerPanel(Control formToShow) {
            if (currentForm != formToShow) {
                if (currentForm != null && viewerPanel.Controls.Contains(currentForm)) {
                    viewerPanel.Controls.Remove(currentForm);
                }

                currentForm = formToShow;

                formToShow.Dock = DockStyle.Fill;
                this.viewerPanel.Controls.Add(formToShow);
                this.viewerPanel.Tag = formToShow;
                formToShow.BringToFront();
            }
        }

        private void menuB_Click(object sender, EventArgs e) {
            ShowFormInViewerPanel(menuForm);
            menuForm.LoadProfileImage();
        }

        private void inventoryB_Click(object sender, EventArgs e) {
            ShowFormInViewerPanel(inventoryForm);
            inventoryForm.RefreshInventoryData();
        }

        private void usersB_Click(object sender, EventArgs e) {
            ShowFormInViewerPanel(userForm);
            userForm.LoadProfileImage();
            userForm.LabelAdmin();
        }
    }
}
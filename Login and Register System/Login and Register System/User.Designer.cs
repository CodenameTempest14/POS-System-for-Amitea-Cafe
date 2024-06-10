namespace Login_and_Register_System {
    partial class User {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }

                if (timer != null) {
                    timer.Stop();
                    timer.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchIcon = new FontAwesome.Sharp.IconPictureBox();
            this.searchTB = new Login_and_Register_System.RoundedTextBox();
            this.adminInfoPanel = new Login_and_Register_System.RoundedPanel();
            this.adminProfile = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.incomeSalesL = new System.Windows.Forms.Label();
            this.salesL = new System.Windows.Forms.Label();
            this.emailL = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.adminName = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.gridPanelHolder = new Login_and_Register_System.RoundedPanel();
            this.userInfoDG = new System.Windows.Forms.DataGridView();
            this.positionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeSalesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.adminInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.gridPanelHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDG)).BeginInit();
            this.SuspendLayout();
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Poppins ExtraBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(17, 19);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(414, 62);
            this.searchLabel.TabIndex = 3;
            this.searchLabel.Text = "Personal Information";
            // 
            // searchIcon
            // 
            this.searchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchIcon.BackColor = System.Drawing.Color.White;
            this.searchIcon.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchIcon.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.searchIcon.IconColor = System.Drawing.SystemColors.AppWorkspace;
            this.searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchIcon.IconSize = 20;
            this.searchIcon.Location = new System.Drawing.Point(465, 81);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(20, 20);
            this.searchIcon.TabIndex = 4;
            this.searchIcon.TabStop = false;
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.BackColor = System.Drawing.Color.White;
            this.searchTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.searchTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.searchTB.BorderRadius = 15;
            this.searchTB.BorderSize = 2;
            this.searchTB.Font = new System.Drawing.Font("Poppins", 9F);
            this.searchTB.ForeColor = System.Drawing.Color.DimGray;
            this.searchTB.Location = new System.Drawing.Point(18, 74);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Multiline = false;
            this.searchTB.Name = "searchTB";
            this.searchTB.Padding = new System.Windows.Forms.Padding(10, 7, 40, 7);
            this.searchTB.PasswordChar = false;
            this.searchTB.PlaceholderColor = System.Drawing.Color.Silver;
            this.searchTB.PlaceholderText = "Search for cashier\'s name";
            this.searchTB.Size = new System.Drawing.Size(478, 37);
            this.searchTB.TabIndex = 2;
            this.searchTB.Texts = "";
            this.searchTB.UnderlinedStyle = false;
            this.searchTB._TextChanged += new System.EventHandler(this.searchTB__TextChanged);
            // 
            // adminInfoPanel
            // 
            this.adminInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminInfoPanel.BackColor = System.Drawing.Color.White;
            this.adminInfoPanel.BackgroundColor = System.Drawing.Color.White;
            this.adminInfoPanel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.adminInfoPanel.BorderRadius = 5;
            this.adminInfoPanel.BorderSize = 0;
            this.adminInfoPanel.Controls.Add(this.adminProfile);
            this.adminInfoPanel.Controls.Add(this.iconPictureBox2);
            this.adminInfoPanel.Controls.Add(this.incomeSalesL);
            this.adminInfoPanel.Controls.Add(this.salesL);
            this.adminInfoPanel.Controls.Add(this.emailL);
            this.adminInfoPanel.Controls.Add(this.positionLabel);
            this.adminInfoPanel.Controls.Add(this.adminName);
            this.adminInfoPanel.Controls.Add(this.timerLabel);
            this.adminInfoPanel.Controls.Add(this.dateLabel);
            this.adminInfoPanel.Location = new System.Drawing.Point(518, 11);
            this.adminInfoPanel.Name = "adminInfoPanel";
            this.adminInfoPanel.Size = new System.Drawing.Size(396, 100);
            this.adminInfoPanel.TabIndex = 1;
            // 
            // adminProfile
            // 
            this.adminProfile.BackColor = System.Drawing.Color.LightGray;
            this.adminProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.adminProfile.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.adminProfile.IconColor = System.Drawing.SystemColors.ControlText;
            this.adminProfile.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.adminProfile.IconSize = 50;
            this.adminProfile.Location = new System.Drawing.Point(20, 9);
            this.adminProfile.Name = "adminProfile";
            this.adminProfile.Size = new System.Drawing.Size(60, 50);
            this.adminProfile.TabIndex = 2;
            this.adminProfile.TabStop = false;
            this.adminProfile.Click += new System.EventHandler(this.adminProfile_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox2.BackgroundImage")));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.iconPictureBox2.IconSize = 40;
            this.iconPictureBox2.Location = new System.Drawing.Point(345, 7);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(40, 40);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // incomeSalesL
            // 
            this.incomeSalesL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incomeSalesL.AutoSize = true;
            this.incomeSalesL.BackColor = System.Drawing.Color.Transparent;
            this.incomeSalesL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.incomeSalesL.Font = new System.Drawing.Font("Poppins", 9F);
            this.incomeSalesL.Location = new System.Drawing.Point(218, 51);
            this.incomeSalesL.Name = "incomeSalesL";
            this.incomeSalesL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.incomeSalesL.Size = new System.Drawing.Size(160, 22);
            this.incomeSalesL.TabIndex = 7;
            this.incomeSalesL.Text = "Income Sales: Php.100.00";
            // 
            // salesL
            // 
            this.salesL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.salesL.AutoSize = true;
            this.salesL.BackColor = System.Drawing.Color.Transparent;
            this.salesL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salesL.Font = new System.Drawing.Font("Poppins", 9F);
            this.salesL.Location = new System.Drawing.Point(90, 51);
            this.salesL.Name = "salesL";
            this.salesL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.salesL.Size = new System.Drawing.Size(112, 22);
            this.salesL.TabIndex = 6;
            this.salesL.Text = "Sales: Php.100.00";
            // 
            // emailL
            // 
            this.emailL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.emailL.AutoSize = true;
            this.emailL.BackColor = System.Drawing.Color.Transparent;
            this.emailL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emailL.Font = new System.Drawing.Font("Poppins", 9F);
            this.emailL.Location = new System.Drawing.Point(89, 32);
            this.emailL.Name = "emailL";
            this.emailL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.emailL.Size = new System.Drawing.Size(201, 22);
            this.emailL.TabIndex = 5;
            this.emailL.Text = "butayamarkwilliam@gmail.com";
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.positionLabel.AutoSize = true;
            this.positionLabel.BackColor = System.Drawing.Color.Transparent;
            this.positionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionLabel.Font = new System.Drawing.Font("Poppins", 10F);
            this.positionLabel.Location = new System.Drawing.Point(22, 58);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.positionLabel.Size = new System.Drawing.Size(56, 25);
            this.positionLabel.TabIndex = 4;
            this.positionLabel.Text = "Admin";
            // 
            // adminName
            // 
            this.adminName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminName.AutoSize = true;
            this.adminName.BackColor = System.Drawing.Color.Transparent;
            this.adminName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adminName.Font = new System.Drawing.Font("Poppins SemiBold", 15F);
            this.adminName.Location = new System.Drawing.Point(85, 6);
            this.adminName.Name = "adminName";
            this.adminName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.adminName.Size = new System.Drawing.Size(201, 36);
            this.adminName.TabIndex = 3;
            this.adminName.Text = "Mark John Butaya";
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.AutoSize = true;
            this.timerLabel.BackColor = System.Drawing.Color.Transparent;
            this.timerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timerLabel.Font = new System.Drawing.Font("Poppins SemiBold", 15F);
            this.timerLabel.Location = new System.Drawing.Point(264, 75);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.timerLabel.Size = new System.Drawing.Size(136, 36);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "02:06:25 AM";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dateLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.dateLabel.Location = new System.Drawing.Point(86, 82);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLabel.Size = new System.Drawing.Size(181, 22);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Tuesday, December 19, 2023";
            // 
            // gridPanelHolder
            // 
            this.gridPanelHolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPanelHolder.BackColor = System.Drawing.Color.White;
            this.gridPanelHolder.BackgroundColor = System.Drawing.Color.White;
            this.gridPanelHolder.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.gridPanelHolder.BorderRadius = 10;
            this.gridPanelHolder.BorderSize = 0;
            this.gridPanelHolder.Controls.Add(this.userInfoDG);
            this.gridPanelHolder.Location = new System.Drawing.Point(18, 125);
            this.gridPanelHolder.Name = "gridPanelHolder";
            this.gridPanelHolder.Size = new System.Drawing.Size(896, 382);
            this.gridPanelHolder.TabIndex = 0;
            // 
            // userInfoDG
            // 
            this.userInfoDG.AllowUserToAddRows = false;
            this.userInfoDG.AllowUserToResizeColumns = false;
            this.userInfoDG.AllowUserToResizeRows = false;
            this.userInfoDG.BackgroundColor = System.Drawing.Color.White;
            this.userInfoDG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userInfoDG.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.userInfoDG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.userInfoDG.ColumnHeadersHeight = 30;
            this.userInfoDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.userInfoDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.positionColumn,
            this.nameCol,
            this.incomeSalesCol,
            this.totalSalesCol,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 11F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(199)))), ((int)(((byte)(145)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.userInfoDG.DefaultCellStyle = dataGridViewCellStyle6;
            this.userInfoDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoDG.EnableHeadersVisualStyles = false;
            this.userInfoDG.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.userInfoDG.Location = new System.Drawing.Point(0, 0);
            this.userInfoDG.Name = "userInfoDG";
            this.userInfoDG.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 11F);
            this.userInfoDG.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.userInfoDG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.userInfoDG.Size = new System.Drawing.Size(896, 382);
            this.userInfoDG.TabIndex = 0;
            this.userInfoDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userInfoDG_CellContentClick);
            // 
            // positionColumn
            // 
            this.positionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 10F);
            this.positionColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.positionColumn.HeaderText = "Position";
            this.positionColumn.Name = "positionColumn";
            this.positionColumn.ReadOnly = true;
            this.positionColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameCol
            // 
            this.nameCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 10F);
            this.nameCol.DefaultCellStyle = dataGridViewCellStyle3;
            this.nameCol.HeaderText = "Name";
            this.nameCol.Name = "nameCol";
            this.nameCol.ReadOnly = true;
            this.nameCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // incomeSalesCol
            // 
            this.incomeSalesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.incomeSalesCol.DefaultCellStyle = dataGridViewCellStyle4;
            this.incomeSalesCol.HeaderText = "Income Sales";
            this.incomeSalesCol.Name = "incomeSalesCol";
            this.incomeSalesCol.ReadOnly = true;
            this.incomeSalesCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // totalSalesCol
            // 
            this.totalSalesCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.totalSalesCol.DefaultCellStyle = dataGridViewCellStyle5;
            this.totalSalesCol.HeaderText = "Total Sales";
            this.totalSalesCol.Name = "totalSalesCol";
            this.totalSalesCol.ReadOnly = true;
            this.totalSalesCol.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Width = 5;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Delete.HeaderText = "";
            this.Delete.Image = ((System.Drawing.Image)(resources.GetObject("Delete.Image")));
            this.Delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Delete.Width = 5;
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.adminInfoPanel);
            this.Controls.Add(this.gridPanelHolder);
            this.Name = "User";
            this.Size = new System.Drawing.Size(931, 526);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.adminInfoPanel.ResumeLayout(false);
            this.adminInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.gridPanelHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userInfoDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RoundedPanel adminInfoPanel;
        private RoundedTextBox searchTB;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label emailL;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label adminName;
        private FontAwesome.Sharp.IconPictureBox adminProfile;
        private System.Windows.Forms.Label incomeSalesL;
        private System.Windows.Forms.Label salesL;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private System.Windows.Forms.DataGridView userInfoDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeSalesCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesCol;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private RoundedPanel gridPanelHolder;
    }
}

namespace Login_and_Register_System {
    partial class Menu {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.billingPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.itemPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.userPanel = new System.Windows.Forms.Panel();
            this.userRoundedPanel = new Login_and_Register_System.RoundedPanel();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.positionChar = new FontAwesome.Sharp.IconPictureBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.addProfilePB = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.submitBtn = new AltoControls.AltoButton();
            this.totalAmount = new System.Windows.Forms.Label();
            this.pesoSign3 = new System.Windows.Forms.Label();
            this.totalL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.taxAmount = new System.Windows.Forms.Label();
            this.subTotalAmount = new System.Windows.Forms.Label();
            this.pesoSign2 = new System.Windows.Forms.Label();
            this.taxL = new System.Windows.Forms.Label();
            this.pesoSign1 = new System.Windows.Forms.Label();
            this.subTotalL = new System.Windows.Forms.Label();
            this.refreshBtn = new FontAwesome.Sharp.IconButton();
            this.searchTB = new Login_and_Register_System.RoundedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.userPanel.SuspendLayout();
            this.userRoundedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProfilePB)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // billingPanel
            // 
            this.billingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.billingPanel.AutoScroll = true;
            this.billingPanel.BackColor = System.Drawing.Color.White;
            this.billingPanel.Location = new System.Drawing.Point(792, 90);
            this.billingPanel.Name = "billingPanel";
            this.billingPanel.Size = new System.Drawing.Size(213, 445);
            this.billingPanel.TabIndex = 0;
            // 
            // itemPanel
            // 
            this.itemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemPanel.AutoScroll = true;
            this.itemPanel.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.itemPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.itemPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("itemPanel.BackgroundImage")));
            this.itemPanel.Location = new System.Drawing.Point(0, 91);
            this.itemPanel.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.itemPanel.Name = "itemPanel";
            this.itemPanel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.itemPanel.Size = new System.Drawing.Size(791, 635);
            this.itemPanel.TabIndex = 1;
            this.itemPanel.TabStop = true;
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.BackColor = System.Drawing.Color.Transparent;
            this.chooseLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseLabel.Font = new System.Drawing.Font("Poppins", 20F, System.Drawing.FontStyle.Bold);
            this.chooseLabel.Location = new System.Drawing.Point(13, 27);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(223, 48);
            this.chooseLabel.TabIndex = 2;
            this.chooseLabel.Text = "Choose | Menu";
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Transparent;
            this.searchLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.Gray;
            this.searchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchLabel.Location = new System.Drawing.Point(665, 66);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(101, 22);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "Search Results: ";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconPictureBox1.IconColor = System.Drawing.Color.DarkGray;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(686, 32);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // userPanel
            // 
            this.userPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.userPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userPanel.BackgroundImage")));
            this.userPanel.Controls.Add(this.userRoundedPanel);
            this.userPanel.Controls.Add(this.label2);
            this.userPanel.Location = new System.Drawing.Point(791, 1);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(219, 88);
            this.userPanel.TabIndex = 5;
            // 
            // userRoundedPanel
            // 
            this.userRoundedPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userRoundedPanel.BackColor = System.Drawing.Color.White;
            this.userRoundedPanel.BackgroundColor = System.Drawing.Color.White;
            this.userRoundedPanel.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.userRoundedPanel.BorderRadius = 15;
            this.userRoundedPanel.BorderSize = 0;
            this.userRoundedPanel.Controls.Add(this.fullNameLabel);
            this.userRoundedPanel.Controls.Add(this.positionChar);
            this.userRoundedPanel.Controls.Add(this.positionLabel);
            this.userRoundedPanel.Controls.Add(this.addProfilePB);
            this.userRoundedPanel.Location = new System.Drawing.Point(3, 8);
            this.userRoundedPanel.Name = "userRoundedPanel";
            this.userRoundedPanel.Size = new System.Drawing.Size(213, 54);
            this.userRoundedPanel.TabIndex = 0;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fullNameLabel.Location = new System.Drawing.Point(68, 27);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(131, 23);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "Mark John Butaya";
            // 
            // positionChar
            // 
            this.positionChar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.positionChar.BackColor = System.Drawing.Color.White;
            this.positionChar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(172)))));
            this.positionChar.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.positionChar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(229)))), ((int)(((byte)(172)))));
            this.positionChar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.positionChar.IconSize = 20;
            this.positionChar.Location = new System.Drawing.Point(147, 9);
            this.positionChar.Name = "positionChar";
            this.positionChar.Size = new System.Drawing.Size(20, 20);
            this.positionChar.TabIndex = 2;
            this.positionChar.TabStop = false;
            // 
            // positionLabel
            // 
            this.positionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.positionLabel.Location = new System.Drawing.Point(68, 13);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(80, 19);
            this.positionLabel.TabIndex = 1;
            this.positionLabel.Text = "I\'m an Admin";
            // 
            // addProfilePB
            // 
            this.addProfilePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addProfilePB.BackColor = System.Drawing.Color.White;
            this.addProfilePB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addProfilePB.IconChar = FontAwesome.Sharp.IconChar.User;
            this.addProfilePB.IconColor = System.Drawing.SystemColors.ControlText;
            this.addProfilePB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addProfilePB.IconSize = 45;
            this.addProfilePB.Location = new System.Drawing.Point(15, 8);
            this.addProfilePB.Name = "addProfilePB";
            this.addProfilePB.Size = new System.Drawing.Size(45, 45);
            this.addProfilePB.TabIndex = 0;
            this.addProfilePB.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "TRANSACTIONS";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.submitBtn);
            this.panel1.Controls.Add(this.totalAmount);
            this.panel1.Controls.Add(this.pesoSign3);
            this.panel1.Controls.Add(this.totalL);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.taxAmount);
            this.panel1.Controls.Add(this.subTotalAmount);
            this.panel1.Controls.Add(this.pesoSign2);
            this.panel1.Controls.Add(this.taxL);
            this.panel1.Controls.Add(this.pesoSign1);
            this.panel1.Controls.Add(this.subTotalL);
            this.panel1.Location = new System.Drawing.Point(792, 533);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(213, 191);
            this.panel1.TabIndex = 6;
            // 
            // submitBtn
            // 
            this.submitBtn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(87)))), ((int)(((byte)(33)))));
            this.submitBtn.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            this.submitBtn.BackColor = System.Drawing.Color.Transparent;
            this.submitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submitBtn.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.submitBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.submitBtn.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            this.submitBtn.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            this.submitBtn.Location = new System.Drawing.Point(21, 123);
            this.submitBtn.MaximumSize = new System.Drawing.Size(178, 43);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Radius = 5;
            this.submitBtn.Size = new System.Drawing.Size(178, 37);
            this.submitBtn.Stroke = false;
            this.submitBtn.StrokeColor = System.Drawing.Color.Gray;
            this.submitBtn.TabIndex = 10;
            this.submitBtn.Text = "Submit Transaction";
            this.submitBtn.Transparency = false;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // totalAmount
            // 
            this.totalAmount.AutoSize = true;
            this.totalAmount.Font = new System.Drawing.Font("Poppins", 9F);
            this.totalAmount.Location = new System.Drawing.Point(151, 77);
            this.totalAmount.Name = "totalAmount";
            this.totalAmount.Size = new System.Drawing.Size(37, 22);
            this.totalAmount.TabIndex = 9;
            this.totalAmount.Text = "0.00";
            // 
            // pesoSign3
            // 
            this.pesoSign3.AutoSize = true;
            this.pesoSign3.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.pesoSign3.Location = new System.Drawing.Point(129, 78);
            this.pesoSign3.Name = "pesoSign3";
            this.pesoSign3.Size = new System.Drawing.Size(19, 22);
            this.pesoSign3.TabIndex = 8;
            this.pesoSign3.Text = "₱";
            // 
            // totalL
            // 
            this.totalL.AutoSize = true;
            this.totalL.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.totalL.Location = new System.Drawing.Point(13, 77);
            this.totalL.Name = "totalL";
            this.totalL.Size = new System.Drawing.Size(41, 22);
            this.totalL.TabIndex = 7;
            this.totalL.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 8F);
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(10, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "------------------------------------";
            // 
            // taxAmount
            // 
            this.taxAmount.AutoSize = true;
            this.taxAmount.Font = new System.Drawing.Font("Poppins", 9F);
            this.taxAmount.Location = new System.Drawing.Point(151, 31);
            this.taxAmount.Name = "taxAmount";
            this.taxAmount.Size = new System.Drawing.Size(37, 22);
            this.taxAmount.TabIndex = 5;
            this.taxAmount.Text = "0.00";
            // 
            // subTotalAmount
            // 
            this.subTotalAmount.AutoSize = true;
            this.subTotalAmount.Font = new System.Drawing.Font("Poppins", 9F);
            this.subTotalAmount.Location = new System.Drawing.Point(151, 9);
            this.subTotalAmount.Name = "subTotalAmount";
            this.subTotalAmount.Size = new System.Drawing.Size(37, 22);
            this.subTotalAmount.TabIndex = 4;
            this.subTotalAmount.Text = "0.00";
            // 
            // pesoSign2
            // 
            this.pesoSign2.AutoSize = true;
            this.pesoSign2.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.pesoSign2.ForeColor = System.Drawing.Color.DimGray;
            this.pesoSign2.Location = new System.Drawing.Point(129, 31);
            this.pesoSign2.Name = "pesoSign2";
            this.pesoSign2.Size = new System.Drawing.Size(19, 22);
            this.pesoSign2.TabIndex = 3;
            this.pesoSign2.Text = "₱";
            // 
            // taxL
            // 
            this.taxL.AutoSize = true;
            this.taxL.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.taxL.ForeColor = System.Drawing.Color.DimGray;
            this.taxL.Location = new System.Drawing.Point(13, 31);
            this.taxL.Name = "taxL";
            this.taxL.Size = new System.Drawing.Size(68, 22);
            this.taxL.TabIndex = 2;
            this.taxL.Text = "Tax (10%)";
            // 
            // pesoSign1
            // 
            this.pesoSign1.AutoSize = true;
            this.pesoSign1.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.pesoSign1.Location = new System.Drawing.Point(129, 12);
            this.pesoSign1.Name = "pesoSign1";
            this.pesoSign1.Size = new System.Drawing.Size(19, 22);
            this.pesoSign1.TabIndex = 1;
            this.pesoSign1.Text = "₱";
            // 
            // subTotalL
            // 
            this.subTotalL.AutoSize = true;
            this.subTotalL.Font = new System.Drawing.Font("Poppins SemiBold", 9F);
            this.subTotalL.Location = new System.Drawing.Point(13, 9);
            this.subTotalL.Name = "subTotalL";
            this.subTotalL.Size = new System.Drawing.Size(62, 22);
            this.subTotalL.TabIndex = 0;
            this.subTotalL.Text = "Subtotal";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatAppearance.BorderSize = 0;
            this.refreshBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.refreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshBtn.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.refreshBtn.IconColor = System.Drawing.Color.Black;
            this.refreshBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.refreshBtn.IconSize = 30;
            this.refreshBtn.Location = new System.Drawing.Point(729, 25);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(40, 40);
            this.refreshBtn.TabIndex = 7;
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            this.refreshBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.refreshBtn_MouseDown);
            this.refreshBtn.MouseEnter += new System.EventHandler(this.refreshBtn_MouseEnter);
            this.refreshBtn.MouseLeave += new System.EventHandler(this.refreshBtn_MouseLeave);
            this.refreshBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.refreshBtn_MouseUp);
            // 
            // searchTB
            // 
            this.searchTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTB.BackColor = System.Drawing.Color.White;
            this.searchTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.searchTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.searchTB.BorderRadius = 10;
            this.searchTB.BorderSize = 2;
            this.searchTB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTB.ForeColor = System.Drawing.Color.Black;
            this.searchTB.Location = new System.Drawing.Point(233, 27);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Multiline = false;
            this.searchTB.Name = "searchTB";
            this.searchTB.Padding = new System.Windows.Forms.Padding(10, 7, 35, 5);
            this.searchTB.PasswordChar = false;
            this.searchTB.PlaceholderColor = System.Drawing.Color.LightGray;
            this.searchTB.PlaceholderText = "Search for product name";
            this.searchTB.Size = new System.Drawing.Size(487, 35);
            this.searchTB.TabIndex = 3;
            this.searchTB.Texts = "";
            this.searchTB.UnderlinedStyle = false;
            this.searchTB._TextChanged += new System.EventHandler(this.searchTB__TextChanged);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.billingPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userPanel);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.itemPanel);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1010, 725);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.userRoundedPanel.ResumeLayout(false);
            this.userRoundedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.positionChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProfilePB)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label chooseLabel;
        private RoundedTextBox searchTB;
        private System.Windows.Forms.Label searchLabel;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label fullNameLabel;
        private FontAwesome.Sharp.IconPictureBox positionChar;
        private System.Windows.Forms.Label positionLabel;
        private FontAwesome.Sharp.IconPictureBox addProfilePB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pesoSign1;
        private System.Windows.Forms.Label subTotalL;
        private System.Windows.Forms.Label pesoSign2;
        private System.Windows.Forms.Label taxL;
        private System.Windows.Forms.Label totalL;
        private System.Windows.Forms.Label label1;
        private AltoControls.AltoButton submitBtn;
        private System.Windows.Forms.Label pesoSign3;
        public System.Windows.Forms.FlowLayoutPanel itemPanel;
        public System.Windows.Forms.FlowLayoutPanel billingPanel;
        public System.Windows.Forms.Label subTotalAmount;
        public System.Windows.Forms.Label taxAmount;
        public System.Windows.Forms.Label totalAmount;
        public RoundedPanel userRoundedPanel;
        private FontAwesome.Sharp.IconButton refreshBtn;
    }
}

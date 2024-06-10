namespace Login_and_Register_System {
    partial class Dashboard {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.commandPanel = new System.Windows.Forms.Panel();
            this.logoutB = new FontAwesome.Sharp.IconButton();
            this.usersB = new FontAwesome.Sharp.IconButton();
            this.inventoryB = new FontAwesome.Sharp.IconButton();
            this.menuB = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoPB = new FontAwesome.Sharp.IconPictureBox();
            this.viewerPanel = new System.Windows.Forms.Panel();
            this.minimizeBtn = new AltoControls.AltoButton();
            this.maximizeBtn = new AltoControls.AltoButton();
            this.exitBtn = new AltoControls.AltoButton();
            this.commandPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            this.SuspendLayout();
            // 
            // commandPanel
            // 
            this.commandPanel.Controls.Add(this.logoutB);
            this.commandPanel.Controls.Add(this.usersB);
            this.commandPanel.Controls.Add(this.inventoryB);
            this.commandPanel.Controls.Add(this.menuB);
            this.commandPanel.Controls.Add(this.panel1);
            this.commandPanel.Controls.Add(this.logoPB);
            this.commandPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.commandPanel.Location = new System.Drawing.Point(0, 0);
            this.commandPanel.Name = "commandPanel";
            this.commandPanel.Size = new System.Drawing.Size(91, 726);
            this.commandPanel.TabIndex = 1;
            this.commandPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.commandPanel_MouseDown_1);
            this.commandPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.commandPanel_MouseMove_1);
            this.commandPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.commandPanel_MouseUp_1);
            // 
            // logoutB
            // 
            this.logoutB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutB.FlatAppearance.BorderSize = 0;
            this.logoutB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutB.ForeColor = System.Drawing.Color.Gray;
            this.logoutB.IconChar = FontAwesome.Sharp.IconChar.MailReply;
            this.logoutB.IconColor = System.Drawing.Color.DarkGray;
            this.logoutB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoutB.IconSize = 40;
            this.logoutB.Location = new System.Drawing.Point(15, 653);
            this.logoutB.Name = "logoutB";
            this.logoutB.Size = new System.Drawing.Size(65, 65);
            this.logoutB.TabIndex = 17;
            this.logoutB.Text = "Logout";
            this.logoutB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutB.UseVisualStyleBackColor = true;
            this.logoutB.Click += new System.EventHandler(this.logoutB_Click);
            this.logoutB.MouseEnter += new System.EventHandler(this.homeB_MouseEnter);
            this.logoutB.MouseLeave += new System.EventHandler(this.homeB_MouseLeave);
            // 
            // usersB
            // 
            this.usersB.FlatAppearance.BorderSize = 0;
            this.usersB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersB.ForeColor = System.Drawing.Color.Gray;
            this.usersB.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.usersB.IconColor = System.Drawing.Color.DarkGray;
            this.usersB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usersB.IconSize = 40;
            this.usersB.Location = new System.Drawing.Point(15, 264);
            this.usersB.Name = "usersB";
            this.usersB.Size = new System.Drawing.Size(65, 65);
            this.usersB.TabIndex = 16;
            this.usersB.Text = "Users";
            this.usersB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.usersB.UseVisualStyleBackColor = true;
            this.usersB.Click += new System.EventHandler(this.usersB_Click);
            this.usersB.MouseEnter += new System.EventHandler(this.homeB_MouseEnter);
            this.usersB.MouseLeave += new System.EventHandler(this.homeB_MouseLeave);
            // 
            // inventoryB
            // 
            this.inventoryB.FlatAppearance.BorderSize = 0;
            this.inventoryB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventoryB.Font = new System.Drawing.Font("Poppins", 8F);
            this.inventoryB.ForeColor = System.Drawing.Color.Gray;
            this.inventoryB.IconChar = FontAwesome.Sharp.IconChar.Box;
            this.inventoryB.IconColor = System.Drawing.Color.DarkGray;
            this.inventoryB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.inventoryB.IconSize = 40;
            this.inventoryB.Location = new System.Drawing.Point(12, 189);
            this.inventoryB.Name = "inventoryB";
            this.inventoryB.Size = new System.Drawing.Size(70, 65);
            this.inventoryB.TabIndex = 15;
            this.inventoryB.Text = "Inventory";
            this.inventoryB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.inventoryB.UseVisualStyleBackColor = true;
            this.inventoryB.Click += new System.EventHandler(this.inventoryB_Click);
            this.inventoryB.MouseEnter += new System.EventHandler(this.homeB_MouseEnter);
            this.inventoryB.MouseLeave += new System.EventHandler(this.homeB_MouseLeave);
            // 
            // menuB
            // 
            this.menuB.FlatAppearance.BorderSize = 0;
            this.menuB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuB.ForeColor = System.Drawing.Color.Gray;
            this.menuB.IconChar = FontAwesome.Sharp.IconChar.BellConcierge;
            this.menuB.IconColor = System.Drawing.Color.DarkGray;
            this.menuB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuB.IconSize = 40;
            this.menuB.Location = new System.Drawing.Point(15, 114);
            this.menuB.Name = "menuB";
            this.menuB.Size = new System.Drawing.Size(65, 65);
            this.menuB.TabIndex = 14;
            this.menuB.Text = "Menu";
            this.menuB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.menuB.UseVisualStyleBackColor = true;
            this.menuB.Click += new System.EventHandler(this.menuB_Click);
            this.menuB.MouseEnter += new System.EventHandler(this.homeB_MouseEnter);
            this.menuB.MouseLeave += new System.EventHandler(this.homeB_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(91, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(713, 562);
            this.panel1.TabIndex = 3;
            // 
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.White;
            this.logoPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPB.BackgroundImage")));
            this.logoPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoPB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoPB.IconChar = FontAwesome.Sharp.IconChar.None;
            this.logoPB.IconColor = System.Drawing.SystemColors.ControlText;
            this.logoPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoPB.IconSize = 70;
            this.logoPB.Location = new System.Drawing.Point(12, 12);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(70, 70);
            this.logoPB.TabIndex = 0;
            this.logoPB.TabStop = false;
            // 
            // viewerPanel
            // 
            this.viewerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.viewerPanel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewerPanel.Location = new System.Drawing.Point(93, 22);
            this.viewerPanel.Name = "viewerPanel";
            this.viewerPanel.Size = new System.Drawing.Size(980, 704);
            this.viewerPanel.TabIndex = 2;
            this.viewerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewerPanel_MouseDown);
            this.viewerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewerPanel_MouseMove);
            this.viewerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.viewerPanel_MouseUp);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Active1 = System.Drawing.Color.PapayaWhip;
            this.minimizeBtn.Active2 = System.Drawing.Color.Goldenrod;
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.minimizeBtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.minimizeBtn.ForeColor = System.Drawing.Color.Black;
            this.minimizeBtn.Inactive1 = System.Drawing.Color.Goldenrod;
            this.minimizeBtn.Inactive2 = System.Drawing.Color.Goldenrod;
            this.minimizeBtn.Location = new System.Drawing.Point(983, 1);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Radius = 10;
            this.minimizeBtn.Size = new System.Drawing.Size(20, 20);
            this.minimizeBtn.Stroke = false;
            this.minimizeBtn.StrokeColor = System.Drawing.Color.Gray;
            this.minimizeBtn.TabIndex = 3;
            this.minimizeBtn.Transparency = false;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // maximizeBtn
            // 
            this.maximizeBtn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.maximizeBtn.Active2 = System.Drawing.Color.SeaGreen;
            this.maximizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maximizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.maximizeBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.maximizeBtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.maximizeBtn.ForeColor = System.Drawing.Color.Black;
            this.maximizeBtn.Inactive1 = System.Drawing.Color.SeaGreen;
            this.maximizeBtn.Inactive2 = System.Drawing.Color.SeaGreen;
            this.maximizeBtn.Location = new System.Drawing.Point(1009, 1);
            this.maximizeBtn.Name = "maximizeBtn";
            this.maximizeBtn.Radius = 10;
            this.maximizeBtn.Size = new System.Drawing.Size(20, 20);
            this.maximizeBtn.Stroke = false;
            this.maximizeBtn.StrokeColor = System.Drawing.Color.Gray;
            this.maximizeBtn.TabIndex = 4;
            this.maximizeBtn.Transparency = false;
            this.maximizeBtn.Click += new System.EventHandler(this.maximizeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitBtn.Active2 = System.Drawing.Color.Crimson;
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.exitBtn.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.exitBtn.ForeColor = System.Drawing.Color.Black;
            this.exitBtn.Inactive1 = System.Drawing.Color.Crimson;
            this.exitBtn.Inactive2 = System.Drawing.Color.Crimson;
            this.exitBtn.Location = new System.Drawing.Point(1035, 1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Radius = 10;
            this.exitBtn.Size = new System.Drawing.Size(20, 20);
            this.exitBtn.Stroke = false;
            this.exitBtn.StrokeColor = System.Drawing.Color.Gray;
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Transparency = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 726);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.maximizeBtn);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.viewerPanel);
            this.Controls.Add(this.commandPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.commandPanel_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.commandPanel_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.commandPanel_MouseUp_1);
            this.commandPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel commandPanel;
        private FontAwesome.Sharp.IconPictureBox logoPB;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Panel viewerPanel;
        private FontAwesome.Sharp.IconButton inventoryB;
        private FontAwesome.Sharp.IconButton menuB;
        private FontAwesome.Sharp.IconButton logoutB;
        public FontAwesome.Sharp.IconButton usersB;
        private AltoControls.AltoButton minimizeBtn;
        private AltoControls.AltoButton maximizeBtn;
        private AltoControls.AltoButton exitBtn;
    }
}
namespace Login_and_Register_System {
    partial class RegisterForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.registerPanel = new System.Windows.Forms.Panel();
            this.registerB = new AltoControls.AltoButton();
            this.logoPB = new FontAwesome.Sharp.IconPictureBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierCB = new System.Windows.Forms.CheckBox();
            this.adminCB = new System.Windows.Forms.CheckBox();
            this.passwordPB = new FontAwesome.Sharp.IconPictureBox();
            this.passTB = new Login_and_Register_System.RoundedTextBox();
            this.userPB = new FontAwesome.Sharp.IconPictureBox();
            this.userTB = new Login_and_Register_System.RoundedTextBox();
            this.emailPB = new FontAwesome.Sharp.IconPictureBox();
            this.emailTB = new Login_and_Register_System.RoundedTextBox();
            this.namePB = new FontAwesome.Sharp.IconPictureBox();
            this.nameTB = new Login_and_Register_System.RoundedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.amiteaL = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.showPassBtn = new FontAwesome.Sharp.IconButton();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.White;
            this.registerPanel.Controls.Add(this.showPassBtn);
            this.registerPanel.Controls.Add(this.registerB);
            this.registerPanel.Controls.Add(this.logoPB);
            this.registerPanel.Controls.Add(this.loginLabel);
            this.registerPanel.Controls.Add(this.label2);
            this.registerPanel.Controls.Add(this.cashierCB);
            this.registerPanel.Controls.Add(this.adminCB);
            this.registerPanel.Controls.Add(this.passwordPB);
            this.registerPanel.Controls.Add(this.passTB);
            this.registerPanel.Controls.Add(this.userPB);
            this.registerPanel.Controls.Add(this.userTB);
            this.registerPanel.Controls.Add(this.emailPB);
            this.registerPanel.Controls.Add(this.emailTB);
            this.registerPanel.Controls.Add(this.namePB);
            this.registerPanel.Controls.Add(this.nameTB);
            this.registerPanel.Controls.Add(this.label1);
            this.registerPanel.Controls.Add(this.amiteaL);
            this.registerPanel.Controls.Add(this.iconPictureBox2);
            this.registerPanel.Location = new System.Drawing.Point(253, 39);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(296, 418);
            this.registerPanel.TabIndex = 0;
            // 
            // registerB
            // 
            this.registerB.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(205)))), ((int)(((byte)(170)))));
            this.registerB.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.registerB.BackColor = System.Drawing.Color.Transparent;
            this.registerB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerB.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.registerB.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerB.ForeColor = System.Drawing.Color.White;
            this.registerB.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.registerB.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.registerB.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.registerB.Location = new System.Drawing.Point(72, 367);
            this.registerB.Name = "registerB";
            this.registerB.Radius = 16;
            this.registerB.Size = new System.Drawing.Size(153, 35);
            this.registerB.Stroke = false;
            this.registerB.StrokeColor = System.Drawing.Color.Gray;
            this.registerB.TabIndex = 18;
            this.registerB.Text = "REGISTER";
            this.registerB.Transparency = false;
            this.registerB.Click += new System.EventHandler(this.registerB_Click);
            // 
            // logoPB
            // 
            this.logoPB.BackColor = System.Drawing.Color.White;
            this.logoPB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPB.BackgroundImage")));
            this.logoPB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.logoPB.IconChar = FontAwesome.Sharp.IconChar.None;
            this.logoPB.IconColor = System.Drawing.SystemColors.ControlText;
            this.logoPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.logoPB.Location = new System.Drawing.Point(137, 7);
            this.logoPB.Name = "logoPB";
            this.logoPB.Size = new System.Drawing.Size(32, 32);
            this.logoPB.TabIndex = 1;
            this.logoPB.TabStop = false;
            // 
            // loginLabel
            // 
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(120, 126);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(66, 20);
            this.loginLabel.TabIndex = 16;
            this.loginLabel.Text = "Login";
            this.loginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginLabel_MouseDown);
            this.loginLabel.MouseEnter += new System.EventHandler(this.loginLabel_MouseEnter);
            this.loginLabel.MouseLeave += new System.EventHandler(this.loginLabel_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Already have an Account?";
            // 
            // cashierCB
            // 
            this.cashierCB.AutoSize = true;
            this.cashierCB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierCB.Location = new System.Drawing.Point(160, 329);
            this.cashierCB.Name = "cashierCB";
            this.cashierCB.Size = new System.Drawing.Size(70, 23);
            this.cashierCB.TabIndex = 13;
            this.cashierCB.Text = "Cashier";
            this.cashierCB.UseVisualStyleBackColor = true;
            this.cashierCB.CheckedChanged += new System.EventHandler(this.cashierCB_CheckedChanged);
            // 
            // adminCB
            // 
            this.adminCB.AutoSize = true;
            this.adminCB.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminCB.Location = new System.Drawing.Point(76, 329);
            this.adminCB.Name = "adminCB";
            this.adminCB.Size = new System.Drawing.Size(63, 23);
            this.adminCB.TabIndex = 12;
            this.adminCB.Text = "Admin";
            this.adminCB.UseVisualStyleBackColor = true;
            this.adminCB.CheckedChanged += new System.EventHandler(this.adminCB_CheckedChanged);
            // 
            // passwordPB
            // 
            this.passwordPB.BackColor = System.Drawing.Color.Transparent;
            this.passwordPB.ForeColor = System.Drawing.Color.DimGray;
            this.passwordPB.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.passwordPB.IconColor = System.Drawing.Color.DimGray;
            this.passwordPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.passwordPB.IconSize = 26;
            this.passwordPB.Location = new System.Drawing.Point(32, 291);
            this.passwordPB.Name = "passwordPB";
            this.passwordPB.Size = new System.Drawing.Size(27, 26);
            this.passwordPB.TabIndex = 11;
            this.passwordPB.TabStop = false;
            // 
            // passTB
            // 
            this.passTB.BackColor = System.Drawing.SystemColors.Window;
            this.passTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.passTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.passTB.BorderRadius = 10;
            this.passTB.BorderSize = 2;
            this.passTB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTB.ForeColor = System.Drawing.Color.Black;
            this.passTB.Location = new System.Drawing.Point(24, 285);
            this.passTB.Margin = new System.Windows.Forms.Padding(4);
            this.passTB.Multiline = false;
            this.passTB.Name = "passTB";
            this.passTB.Padding = new System.Windows.Forms.Padding(38, 7, 35, 7);
            this.passTB.PasswordChar = true;
            this.passTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.passTB.PlaceholderText = "Password";
            this.passTB.Size = new System.Drawing.Size(249, 37);
            this.passTB.TabIndex = 10;
            this.passTB.Texts = "";
            this.passTB.UnderlinedStyle = false;
            // 
            // userPB
            // 
            this.userPB.BackColor = System.Drawing.Color.Transparent;
            this.userPB.ForeColor = System.Drawing.Color.DimGray;
            this.userPB.IconChar = FontAwesome.Sharp.IconChar.User;
            this.userPB.IconColor = System.Drawing.Color.DimGray;
            this.userPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.userPB.IconSize = 26;
            this.userPB.Location = new System.Drawing.Point(32, 246);
            this.userPB.Name = "userPB";
            this.userPB.Size = new System.Drawing.Size(27, 26);
            this.userPB.TabIndex = 9;
            this.userPB.TabStop = false;
            // 
            // userTB
            // 
            this.userTB.BackColor = System.Drawing.SystemColors.Window;
            this.userTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.userTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.userTB.BorderRadius = 10;
            this.userTB.BorderSize = 2;
            this.userTB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTB.ForeColor = System.Drawing.Color.Black;
            this.userTB.Location = new System.Drawing.Point(24, 240);
            this.userTB.Margin = new System.Windows.Forms.Padding(4);
            this.userTB.Multiline = false;
            this.userTB.Name = "userTB";
            this.userTB.Padding = new System.Windows.Forms.Padding(38, 7, 10, 7);
            this.userTB.PasswordChar = false;
            this.userTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.userTB.PlaceholderText = "Username";
            this.userTB.Size = new System.Drawing.Size(249, 37);
            this.userTB.TabIndex = 8;
            this.userTB.Texts = "";
            this.userTB.UnderlinedStyle = false;
            // 
            // emailPB
            // 
            this.emailPB.BackColor = System.Drawing.Color.Transparent;
            this.emailPB.ForeColor = System.Drawing.Color.DimGray;
            this.emailPB.IconChar = FontAwesome.Sharp.IconChar.Envelope;
            this.emailPB.IconColor = System.Drawing.Color.DimGray;
            this.emailPB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.emailPB.IconSize = 26;
            this.emailPB.Location = new System.Drawing.Point(32, 201);
            this.emailPB.Name = "emailPB";
            this.emailPB.Size = new System.Drawing.Size(27, 26);
            this.emailPB.TabIndex = 7;
            this.emailPB.TabStop = false;
            // 
            // emailTB
            // 
            this.emailTB.BackColor = System.Drawing.SystemColors.Window;
            this.emailTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.emailTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.emailTB.BorderRadius = 10;
            this.emailTB.BorderSize = 2;
            this.emailTB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTB.ForeColor = System.Drawing.Color.Black;
            this.emailTB.Location = new System.Drawing.Point(24, 195);
            this.emailTB.Margin = new System.Windows.Forms.Padding(4);
            this.emailTB.Multiline = false;
            this.emailTB.Name = "emailTB";
            this.emailTB.Padding = new System.Windows.Forms.Padding(38, 7, 10, 7);
            this.emailTB.PasswordChar = false;
            this.emailTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.emailTB.PlaceholderText = "Email";
            this.emailTB.Size = new System.Drawing.Size(249, 37);
            this.emailTB.TabIndex = 6;
            this.emailTB.Texts = "";
            this.emailTB.UnderlinedStyle = false;
            // 
            // namePB
            // 
            this.namePB.BackColor = System.Drawing.Color.Transparent;
            this.namePB.ForeColor = System.Drawing.Color.DimGray;
            this.namePB.IconChar = FontAwesome.Sharp.IconChar.IdCard;
            this.namePB.IconColor = System.Drawing.Color.DimGray;
            this.namePB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.namePB.IconSize = 26;
            this.namePB.Location = new System.Drawing.Point(32, 155);
            this.namePB.Name = "namePB";
            this.namePB.Size = new System.Drawing.Size(27, 26);
            this.namePB.TabIndex = 5;
            this.namePB.TabStop = false;
            // 
            // nameTB
            // 
            this.nameTB.BackColor = System.Drawing.SystemColors.Window;
            this.nameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.nameTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(216)))));
            this.nameTB.BorderRadius = 10;
            this.nameTB.BorderSize = 2;
            this.nameTB.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTB.ForeColor = System.Drawing.Color.Black;
            this.nameTB.Location = new System.Drawing.Point(24, 149);
            this.nameTB.Margin = new System.Windows.Forms.Padding(4);
            this.nameTB.Multiline = false;
            this.nameTB.Name = "nameTB";
            this.nameTB.Padding = new System.Windows.Forms.Padding(38, 7, 10, 7);
            this.nameTB.PasswordChar = false;
            this.nameTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nameTB.PlaceholderText = "Full Name";
            this.nameTB.Size = new System.Drawing.Size(249, 37);
            this.nameTB.TabIndex = 4;
            this.nameTB.Texts = "";
            this.nameTB.UnderlinedStyle = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "REGISTRATION FORM";
            // 
            // amiteaL
            // 
            this.amiteaL.BackColor = System.Drawing.Color.Transparent;
            this.amiteaL.Font = new System.Drawing.Font("Poppins SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amiteaL.Location = new System.Drawing.Point(48, 41);
            this.amiteaL.Name = "amiteaL";
            this.amiteaL.Size = new System.Drawing.Size(210, 37);
            this.amiteaL.TabIndex = 0;
            this.amiteaL.Text = "amitea cebu";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox2.BackgroundImage")));
            this.iconPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 33;
            this.iconPictureBox2.Location = new System.Drawing.Point(51, 53);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(195, 33);
            this.iconPictureBox2.TabIndex = 2;
            this.iconPictureBox2.TabStop = false;
            // 
            // showPassBtn
            // 
            this.showPassBtn.BackColor = System.Drawing.Color.Transparent;
            this.showPassBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassBtn.FlatAppearance.BorderSize = 0;
            this.showPassBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.showPassBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.showPassBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showPassBtn.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.showPassBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.showPassBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.showPassBtn.IconSize = 23;
            this.showPassBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.showPassBtn.Location = new System.Drawing.Point(240, 291);
            this.showPassBtn.Name = "showPassBtn";
            this.showPassBtn.Size = new System.Drawing.Size(25, 25);
            this.showPassBtn.TabIndex = 19;
            this.showPassBtn.UseVisualStyleBackColor = false;
            this.showPassBtn.Click += new System.EventHandler(this.showPassBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(235)))), ((int)(((byte)(221)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 511);
            this.Controls.Add(this.registerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Amitea - Register Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseUp);
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.namePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.Label amiteaL;
        private FontAwesome.Sharp.IconPictureBox logoPB;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label1;
        private RoundedTextBox nameTB;
        private FontAwesome.Sharp.IconPictureBox namePB;
        private FontAwesome.Sharp.IconPictureBox passwordPB;
        private RoundedTextBox passTB;
        private FontAwesome.Sharp.IconPictureBox userPB;
        private RoundedTextBox userTB;
        private FontAwesome.Sharp.IconPictureBox emailPB;
        private RoundedTextBox emailTB;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cashierCB;
        private System.Windows.Forms.CheckBox adminCB;
        private AltoControls.AltoButton registerB;
        private FontAwesome.Sharp.IconButton showPassBtn;
    }
}
namespace Login_and_Register_System {
    partial class ProductModoule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductModoule));
            this.topPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addImagePicBox = new FontAwesome.Sharp.IconPictureBox();
            this.saveProdBtn = new AltoControls.AltoButton();
            this.updateProdBtn = new AltoControls.AltoButton();
            this.cancelBtn = new AltoControls.AltoButton();
            this.quantityTB = new Login_and_Register_System.RoundedTextBox();
            this.priceTB = new Login_and_Register_System.RoundedTextBox();
            this.prodNameTB = new Login_and_Register_System.RoundedTextBox();
            this.prodCodeTB = new Login_and_Register_System.RoundedTextBox();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addImagePicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Controls.Add(this.iconPictureBox1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(603, 36);
            this.topPanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(237)))));
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 30;
            this.closeBtn.Location = new System.Drawing.Point(571, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(29, 33);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseDown);
            this.closeBtn.MouseEnter += new System.EventHandler(this.closeBtn_MouseEnter);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            this.closeBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseUp);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.iconPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iconPictureBox1.BackgroundImage")));
            this.iconPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(3, 1);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Module";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label2.Location = new System.Drawing.Point(40, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label3.Location = new System.Drawing.Point(39, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label4.Location = new System.Drawing.Point(104, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label5.Location = new System.Drawing.Point(350, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Quantity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label6.Location = new System.Drawing.Point(26, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Add Image Here:";
            // 
            // addImagePicBox
            // 
            this.addImagePicBox.BackColor = System.Drawing.Color.White;
            this.addImagePicBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addImagePicBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.addImagePicBox.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.addImagePicBox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.addImagePicBox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addImagePicBox.IconSize = 100;
            this.addImagePicBox.Location = new System.Drawing.Point(162, 223);
            this.addImagePicBox.Name = "addImagePicBox";
            this.addImagePicBox.Size = new System.Drawing.Size(100, 100);
            this.addImagePicBox.TabIndex = 10;
            this.addImagePicBox.TabStop = false;
            this.addImagePicBox.Click += new System.EventHandler(this.addImagePicBox_Click);
            // 
            // saveProdBtn
            // 
            this.saveProdBtn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.saveProdBtn.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.saveProdBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveProdBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveProdBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.saveProdBtn.ForeColor = System.Drawing.Color.White;
            this.saveProdBtn.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.saveProdBtn.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.saveProdBtn.Location = new System.Drawing.Point(89, 341);
            this.saveProdBtn.Name = "saveProdBtn";
            this.saveProdBtn.Radius = 10;
            this.saveProdBtn.Size = new System.Drawing.Size(133, 41);
            this.saveProdBtn.Stroke = false;
            this.saveProdBtn.StrokeColor = System.Drawing.Color.Gray;
            this.saveProdBtn.TabIndex = 11;
            this.saveProdBtn.Text = "SAVE";
            this.saveProdBtn.Transparency = false;
            this.saveProdBtn.Click += new System.EventHandler(this.saveProdBtn_Click);
            // 
            // updateProdBtn
            // 
            this.updateProdBtn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.updateProdBtn.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.updateProdBtn.BackColor = System.Drawing.Color.Transparent;
            this.updateProdBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.updateProdBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.updateProdBtn.ForeColor = System.Drawing.Color.White;
            this.updateProdBtn.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.updateProdBtn.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.updateProdBtn.Location = new System.Drawing.Point(245, 341);
            this.updateProdBtn.Name = "updateProdBtn";
            this.updateProdBtn.Radius = 10;
            this.updateProdBtn.Size = new System.Drawing.Size(133, 41);
            this.updateProdBtn.Stroke = false;
            this.updateProdBtn.StrokeColor = System.Drawing.Color.Gray;
            this.updateProdBtn.TabIndex = 12;
            this.updateProdBtn.Text = "UPDATE";
            this.updateProdBtn.Transparency = false;
            this.updateProdBtn.Click += new System.EventHandler(this.updateProdBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Active1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(248)))), ((int)(((byte)(237)))));
            this.cancelBtn.Active2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.cancelBtn.BackColor = System.Drawing.Color.Transparent;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cancelBtn.Font = new System.Drawing.Font("Poppins SemiBold", 12F);
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Inactive1 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.cancelBtn.Inactive2 = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(187)))), ((int)(((byte)(143)))));
            this.cancelBtn.Location = new System.Drawing.Point(399, 341);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Radius = 10;
            this.cancelBtn.Size = new System.Drawing.Size(133, 41);
            this.cancelBtn.Stroke = false;
            this.cancelBtn.StrokeColor = System.Drawing.Color.Gray;
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "CANCEL";
            this.cancelBtn.Transparency = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // quantityTB
            // 
            this.quantityTB.BackColor = System.Drawing.SystemColors.Window;
            this.quantityTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.quantityTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(220)))));
            this.quantityTB.BorderRadius = 10;
            this.quantityTB.BorderSize = 2;
            this.quantityTB.Font = new System.Drawing.Font("Poppins", 12F);
            this.quantityTB.ForeColor = System.Drawing.Color.Black;
            this.quantityTB.Location = new System.Drawing.Point(446, 172);
            this.quantityTB.Margin = new System.Windows.Forms.Padding(4);
            this.quantityTB.Multiline = false;
            this.quantityTB.Name = "quantityTB";
            this.quantityTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.quantityTB.PasswordChar = false;
            this.quantityTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.quantityTB.PlaceholderText = "";
            this.quantityTB.Size = new System.Drawing.Size(113, 43);
            this.quantityTB.TabIndex = 8;
            this.quantityTB.Texts = "";
            this.quantityTB.UnderlinedStyle = false;
            // 
            // priceTB
            // 
            this.priceTB.BackColor = System.Drawing.SystemColors.Window;
            this.priceTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.priceTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(220)))));
            this.priceTB.BorderRadius = 10;
            this.priceTB.BorderSize = 2;
            this.priceTB.Font = new System.Drawing.Font("Poppins", 12F);
            this.priceTB.ForeColor = System.Drawing.Color.Black;
            this.priceTB.Location = new System.Drawing.Point(162, 172);
            this.priceTB.Margin = new System.Windows.Forms.Padding(4);
            this.priceTB.Multiline = false;
            this.priceTB.Name = "priceTB";
            this.priceTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.priceTB.PasswordChar = false;
            this.priceTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.priceTB.PlaceholderText = "";
            this.priceTB.Size = new System.Drawing.Size(167, 43);
            this.priceTB.TabIndex = 5;
            this.priceTB.Texts = "";
            this.priceTB.UnderlinedStyle = false;
            // 
            // prodNameTB
            // 
            this.prodNameTB.BackColor = System.Drawing.SystemColors.Window;
            this.prodNameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.prodNameTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(220)))));
            this.prodNameTB.BorderRadius = 10;
            this.prodNameTB.BorderSize = 2;
            this.prodNameTB.Font = new System.Drawing.Font("Poppins", 12F);
            this.prodNameTB.ForeColor = System.Drawing.Color.Black;
            this.prodNameTB.Location = new System.Drawing.Point(162, 121);
            this.prodNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.prodNameTB.Multiline = false;
            this.prodNameTB.Name = "prodNameTB";
            this.prodNameTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodNameTB.PasswordChar = false;
            this.prodNameTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodNameTB.PlaceholderText = "";
            this.prodNameTB.Size = new System.Drawing.Size(397, 43);
            this.prodNameTB.TabIndex = 3;
            this.prodNameTB.Texts = "";
            this.prodNameTB.UnderlinedStyle = false;
            // 
            // prodCodeTB
            // 
            this.prodCodeTB.BackColor = System.Drawing.SystemColors.Window;
            this.prodCodeTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(126)))), ((int)(((byte)(86)))));
            this.prodCodeTB.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(246)))), ((int)(((byte)(220)))));
            this.prodCodeTB.BorderRadius = 10;
            this.prodCodeTB.BorderSize = 2;
            this.prodCodeTB.Font = new System.Drawing.Font("Poppins", 12F);
            this.prodCodeTB.ForeColor = System.Drawing.Color.Black;
            this.prodCodeTB.Location = new System.Drawing.Point(162, 70);
            this.prodCodeTB.Margin = new System.Windows.Forms.Padding(4);
            this.prodCodeTB.Multiline = false;
            this.prodCodeTB.Name = "prodCodeTB";
            this.prodCodeTB.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.prodCodeTB.PasswordChar = false;
            this.prodCodeTB.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.prodCodeTB.PlaceholderText = "";
            this.prodCodeTB.Size = new System.Drawing.Size(397, 43);
            this.prodCodeTB.TabIndex = 1;
            this.prodCodeTB.Texts = "";
            this.prodCodeTB.UnderlinedStyle = false;
            // 
            // ProductModoule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(246)))), ((int)(((byte)(237)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 409);
            this.ControlBox = false;
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.updateProdBtn);
            this.Controls.Add(this.saveProdBtn);
            this.Controls.Add(this.addImagePicBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.quantityTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.priceTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prodCodeTB);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductModoule";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductModoule";
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addImagePicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private AltoControls.AltoButton cancelBtn;
        public RoundedTextBox prodCodeTB;
        public RoundedTextBox prodNameTB;
        public RoundedTextBox priceTB;
        public RoundedTextBox quantityTB;
        public FontAwesome.Sharp.IconPictureBox addImagePicBox;
        public AltoControls.AltoButton saveProdBtn;
        public AltoControls.AltoButton updateProdBtn;
    }
}
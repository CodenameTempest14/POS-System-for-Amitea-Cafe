namespace Login_and_Register_System {
    partial class Inventory {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            this.searchIcon = new FontAwesome.Sharp.IconPictureBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new FontAwesome.Sharp.IconButton();
            this.searchTB = new Login_and_Register_System.RoundedTextBox();
            this.roundedPanel1 = new Login_and_Register_System.RoundedPanel();
            this.dataPanel = new System.Windows.Forms.DataGridView();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).BeginInit();
            this.roundedPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // searchIcon
            // 
            this.searchIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchIcon.BackColor = System.Drawing.Color.White;
            this.searchIcon.ForeColor = System.Drawing.Color.DarkGray;
            this.searchIcon.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.searchIcon.IconColor = System.Drawing.Color.DarkGray;
            this.searchIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchIcon.IconSize = 25;
            this.searchIcon.Location = new System.Drawing.Point(570, 21);
            this.searchIcon.Name = "searchIcon";
            this.searchIcon.Size = new System.Drawing.Size(25, 25);
            this.searchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.searchIcon.TabIndex = 7;
            this.searchIcon.TabStop = false;
            // 
            // searchLabel
            // 
            this.searchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.Gray;
            this.searchLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchLabel.Location = new System.Drawing.Point(615, 24);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(101, 22);
            this.searchLabel.TabIndex = 5;
            this.searchLabel.Text = "Search Results: ";
            this.searchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(24, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "STOCK INVENTORY ITEM | Amitea Cebu Items List\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addBtn
            // 
            this.addBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBtn.BackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addBtn.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.addBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            this.addBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addBtn.IconSize = 35;
            this.addBtn.Location = new System.Drawing.Point(859, 36);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(40, 40);
            this.addBtn.TabIndex = 13;
            this.addBtn.TabStop = false;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            this.addBtn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseDown);
            this.addBtn.MouseEnter += new System.EventHandler(this.addBtn_MouseEnter);
            this.addBtn.MouseLeave += new System.EventHandler(this.addBtn_MouseLeave);
            this.addBtn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.addBtn_MouseUp);
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
            this.searchTB.Location = new System.Drawing.Point(24, 15);
            this.searchTB.Margin = new System.Windows.Forms.Padding(4);
            this.searchTB.Multiline = false;
            this.searchTB.Name = "searchTB";
            this.searchTB.Padding = new System.Windows.Forms.Padding(10, 7, 35, 5);
            this.searchTB.PasswordChar = false;
            this.searchTB.PlaceholderColor = System.Drawing.Color.LightGray;
            this.searchTB.PlaceholderText = "Search for product code or name";
            this.searchTB.Size = new System.Drawing.Size(578, 35);
            this.searchTB.TabIndex = 6;
            this.searchTB.Texts = "";
            this.searchTB.UnderlinedStyle = false;
            this.searchTB._TextChanged += new System.EventHandler(this.searchTB__TextChanged);
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.roundedPanel1.BackColor = System.Drawing.Color.White;
            this.roundedPanel1.BackgroundColor = System.Drawing.Color.White;
            this.roundedPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.roundedPanel1.BorderRadius = 15;
            this.roundedPanel1.BorderSize = 2;
            this.roundedPanel1.Controls.Add(this.dataPanel);
            this.roundedPanel1.Location = new System.Drawing.Point(24, 79);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(875, 429);
            this.roundedPanel1.TabIndex = 12;
            // 
            // dataPanel
            // 
            this.dataPanel.AllowUserToAddRows = false;
            this.dataPanel.AllowUserToResizeColumns = false;
            this.dataPanel.AllowUserToResizeRows = false;
            this.dataPanel.BackgroundColor = System.Drawing.Color.White;
            this.dataPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataPanel.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(53)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(208)))), ((int)(((byte)(169)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPanel.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataPanel.ColumnHeadersHeight = 35;
            this.dataPanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataPanel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productCode,
            this.productName,
            this.productPrice,
            this.productQuantity,
            this.productTotal,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Bisque;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataPanel.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.EnableHeadersVisualStyles = false;
            this.dataPanel.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(163)))), ((int)(((byte)(127)))));
            this.dataPanel.Location = new System.Drawing.Point(0, 0);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Poppins", 12F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataPanel.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataPanel.RowHeadersVisible = false;
            this.dataPanel.RowHeadersWidth = 40;
            this.dataPanel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Poppins", 11F);
            this.dataPanel.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataPanel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataPanel.Size = new System.Drawing.Size(875, 429);
            this.dataPanel.TabIndex = 0;
            this.dataPanel.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataPanel_CellContentClick);
            // 
            // productCode
            // 
            this.productCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.productCode.DefaultCellStyle = dataGridViewCellStyle2;
            this.productCode.HeaderText = "Product Code";
            this.productCode.Name = "productCode";
            this.productCode.ReadOnly = true;
            this.productCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productName
            // 
            this.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.productName.DefaultCellStyle = dataGridViewCellStyle3;
            this.productName.HeaderText = "Product Name";
            this.productName.Name = "productName";
            this.productName.ReadOnly = true;
            this.productName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productPrice
            // 
            this.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.productPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.productPrice.HeaderText = "Price";
            this.productPrice.Name = "productPrice";
            this.productPrice.ReadOnly = true;
            this.productPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productQuantity
            // 
            this.productQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 10F);
            this.productQuantity.DefaultCellStyle = dataGridViewCellStyle5;
            this.productQuantity.HeaderText = "Quantity";
            this.productQuantity.Name = "productQuantity";
            this.productQuantity.ReadOnly = true;
            this.productQuantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // productTotal
            // 
            this.productTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Poppins", 10F);
            dataGridViewCellStyle6.Format = "N2";
            dataGridViewCellStyle6.NullValue = null;
            this.productTotal.DefaultCellStyle = dataGridViewCellStyle6;
            this.productTotal.HeaderText = "Total";
            this.productTotal.Name = "productTotal";
            this.productTotal.ReadOnly = true;
            this.productTotal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            // Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.searchIcon);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.label1);
            this.Name = "Inventory";
            this.Size = new System.Drawing.Size(931, 526);
            ((System.ComponentModel.ISupportInitialize)(this.searchIcon)).EndInit();
            this.roundedPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox searchIcon;
        private System.Windows.Forms.Label searchLabel;
        private RoundedTextBox searchTB;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton addBtn;
        private RoundedPanel roundedPanel1;
        private System.Windows.Forms.DataGridView dataPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTotal;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
    }
}

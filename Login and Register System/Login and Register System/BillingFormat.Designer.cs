namespace Login_and_Register_System
{
    partial class BillingFormat
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillingFormat));
            this.priceLabel = new System.Windows.Forms.Label();
            this.moodLabel = new System.Windows.Forms.Label();
            this.sugarLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productLabel = new AltoControls.AltoSlidingLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityL = new System.Windows.Forms.Label();
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.BackColor = System.Drawing.Color.Transparent;
            this.priceLabel.Font = new System.Drawing.Font("Poppins", 10F);
            this.priceLabel.Location = new System.Drawing.Point(87, 29);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(55, 25);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "105.00";
            // 
            // moodLabel
            // 
            this.moodLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.moodLabel.AutoSize = true;
            this.moodLabel.Font = new System.Drawing.Font("Poppins", 10F);
            this.moodLabel.Location = new System.Drawing.Point(54, 47);
            this.moodLabel.Name = "moodLabel";
            this.moodLabel.Size = new System.Drawing.Size(36, 25);
            this.moodLabel.TabIndex = 3;
            this.moodLabel.Text = "Hot";
            // 
            // sugarLabel
            // 
            this.sugarLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sugarLabel.AutoSize = true;
            this.sugarLabel.Font = new System.Drawing.Font("Poppins", 10F);
            this.sugarLabel.Location = new System.Drawing.Point(97, 47);
            this.sugarLabel.Name = "sugarLabel";
            this.sugarLabel.Size = new System.Drawing.Size(45, 25);
            this.sugarLabel.TabIndex = 6;
            this.sugarLabel.Text = "100%";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(7, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // productLabel
            // 
            this.productLabel.Font = new System.Drawing.Font("Poppins SemiBold", 10F);
            this.productLabel.Location = new System.Drawing.Point(56, 15);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(126, 20);
            this.productLabel.Slide = false;
            this.productLabel.TabIndex = 8;
            this.productLabel.Text = "Product Label";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F);
            this.label1.Location = new System.Drawing.Point(58, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "₱";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 10F);
            this.label2.Location = new System.Drawing.Point(152, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "#";
            // 
            // quantityL
            // 
            this.quantityL.AutoSize = true;
            this.quantityL.BackColor = System.Drawing.Color.Transparent;
            this.quantityL.Font = new System.Drawing.Font("Poppins", 10F);
            this.quantityL.Location = new System.Drawing.Point(177, 33);
            this.quantityL.Name = "quantityL";
            this.quantityL.Size = new System.Drawing.Size(16, 25);
            this.quantityL.TabIndex = 11;
            this.quantityL.Text = "1";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeBtn.IconColor = System.Drawing.Color.Black;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 20;
            this.closeBtn.Location = new System.Drawing.Point(184, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(26, 25);
            this.closeBtn.TabIndex = 12;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // BillingFormat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.quantityL);
            this.Controls.Add(this.sugarLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.moodLabel);
            this.Controls.Add(this.productLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "BillingFormat";
            this.Size = new System.Drawing.Size(222, 78);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label priceLabel;
        public System.Windows.Forms.Label moodLabel;
        public System.Windows.Forms.Label sugarLabel;
        public AltoControls.AltoSlidingLabel productLabel;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label quantityL;
        private FontAwesome.Sharp.IconButton closeBtn;
        private System.Windows.Forms.Label label2;
    }
}

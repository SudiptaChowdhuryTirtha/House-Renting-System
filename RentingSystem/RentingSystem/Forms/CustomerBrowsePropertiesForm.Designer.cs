namespace RentingSystem.Forms
{
    partial class CustomerBrowsePropertiesForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvProperties = new System.Windows.Forms.DataGridView();
            this.txtSearchCity = new System.Windows.Forms.TextBox();
            this.txtSearchMinPrice = new System.Windows.Forms.TextBox();
            this.txtSearchMaxPrice = new System.Windows.Forms.TextBox();
            this.txtSearchBedrooms = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnSaveProperty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.Text = "City";

            this.txtSearchCity.Location = new System.Drawing.Point(80, 17);
            this.txtSearchCity.Name = "txtSearchCity";
            this.txtSearchCity.Size = new System.Drawing.Size(120, 20);
            this.txtSearchCity.TabIndex = 1;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 20);
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.Text = "Min Price";

            this.txtSearchMinPrice.Location = new System.Drawing.Point(280, 17);
            this.txtSearchMinPrice.Name = "txtSearchMinPrice";
            this.txtSearchMinPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSearchMinPrice.TabIndex = 3;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 20);
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.Text = "Max Price";

            this.txtSearchMaxPrice.Location = new System.Drawing.Point(460, 17);
            this.txtSearchMaxPrice.Name = "txtSearchMaxPrice";
            this.txtSearchMaxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSearchMaxPrice.TabIndex = 5;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(580, 20);
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.Text = "Bedrooms";

            this.txtSearchBedrooms.Location = new System.Drawing.Point(645, 17);
            this.txtSearchBedrooms.Name = "txtSearchBedrooms";
            this.txtSearchBedrooms.Size = new System.Drawing.Size(60, 20);
            this.txtSearchBedrooms.TabIndex = 7;

            this.btnSearch.Location = new System.Drawing.Point(725, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 26);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Location = new System.Drawing.Point(20, 50);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.ReadOnly = true;
            this.dgvProperties.Size = new System.Drawing.Size(960, 250);
            this.dgvProperties.TabIndex = 9;
            this.dgvProperties.SelectionChanged += new System.EventHandler(this.dgvProperties_SelectionChanged);

            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 310);
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.Text = "Property Details";

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 320);
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.Text = "Property ID";

            this.txtPropertyID.Location = new System.Drawing.Point(100, 317);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(100, 20);
            this.txtPropertyID.TabIndex = 11;

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 320);
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.Text = "Title";

            this.txtTitle.Location = new System.Drawing.Point(280, 317);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(250, 20);
            this.txtTitle.TabIndex = 13;

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 355);
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.Text = "Address";

            this.txtAddress.Location = new System.Drawing.Point(100, 352);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(430, 20);
            this.txtAddress.TabIndex = 15;

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 390);
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.Text = "Price";

            this.txtPrice.Location = new System.Drawing.Point(100, 387);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 17;

            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(220, 390);
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.Text = "Bedrooms";

            this.txtBedrooms.Location = new System.Drawing.Point(280, 387);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.ReadOnly = true;
            this.txtBedrooms.Size = new System.Drawing.Size(100, 20);
            this.txtBedrooms.TabIndex = 19;

            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(400, 390);
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.Text = "Bathrooms";

            this.txtBathrooms.Location = new System.Drawing.Point(460, 387);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.ReadOnly = true;
            this.txtBathrooms.Size = new System.Drawing.Size(100, 20);
            this.txtBathrooms.TabIndex = 21;

            this.btnViewDetails.Location = new System.Drawing.Point(100, 430);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(150, 30);
            this.btnViewDetails.TabIndex = 22;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);

            this.btnSaveProperty.Location = new System.Drawing.Point(280, 430);
            this.btnSaveProperty.Name = "btnSaveProperty";
            this.btnSaveProperty.Size = new System.Drawing.Size(150, 30);
            this.btnSaveProperty.TabIndex = 23;
            this.btnSaveProperty.Text = "Save Property";
            this.btnSaveProperty.UseVisualStyleBackColor = true;
            this.btnSaveProperty.Click += new System.EventHandler(this.btnSaveProperty_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnSaveProperty);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.txtBathrooms);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBedrooms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvProperties);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchBedrooms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSearchMaxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSearchMinPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearchCity);
            this.Controls.Add(this.label1);
            this.Name = "CustomerBrowsePropertiesForm";
            this.Text = "CustomerBrowsePropertiesForm";
            this.Load += new System.EventHandler(this.CustomerBrowsePropertiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.TextBox txtSearchCity;
        private System.Windows.Forms.TextBox txtSearchMinPrice;
        private System.Windows.Forms.TextBox txtSearchMaxPrice;
        private System.Windows.Forms.TextBox txtSearchBedrooms;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnSaveProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}
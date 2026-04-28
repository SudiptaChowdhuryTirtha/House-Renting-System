namespace RentingSystem.Forms
{
    partial class AdminManagePropertiesForm
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
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLandlordName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.btnDeleteProperty = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).BeginInit();
            this.SuspendLayout();

            this.dgvProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProperties.Location = new System.Drawing.Point(20, 20);
            this.dgvProperties.Name = "dgvProperties";
            this.dgvProperties.ReadOnly = true;
            this.dgvProperties.Size = new System.Drawing.Size(860, 250);
            this.dgvProperties.TabIndex = 0;
            this.dgvProperties.SelectionChanged += new System.EventHandler(this.dgvProperties_SelectionChanged);

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 293);
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.Text = "Property ID";

            this.txtPropertyID.Location = new System.Drawing.Point(150, 290);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(200, 20);
            this.txtPropertyID.TabIndex = 1;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 328);
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.Text = "Title";

            this.txtTitle.Location = new System.Drawing.Point(150, 325);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(200, 20);
            this.txtTitle.TabIndex = 2;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 363);
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.Text = "Address";

            this.txtAddress.Location = new System.Drawing.Point(150, 360);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(200, 20);
            this.txtAddress.TabIndex = 3;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 293);
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.Text = "Landlord Name";

            this.txtLandlordName.Location = new System.Drawing.Point(600, 290);
            this.txtLandlordName.Name = "txtLandlordName";
            this.txtLandlordName.ReadOnly = true;
            this.txtLandlordName.Size = new System.Drawing.Size(200, 20);
            this.txtLandlordName.TabIndex = 4;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 328);
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.Text = "Price";

            this.txtPrice.Location = new System.Drawing.Point(600, 325);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(200, 20);
            this.txtPrice.TabIndex = 5;

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 398);
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.Text = "Reason (Delete)";

            this.txtReason.Location = new System.Drawing.Point(150, 395);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(650, 80);
            this.txtReason.TabIndex = 6;

            this.btnDeleteProperty.BackColor = System.Drawing.Color.Red;
            this.btnDeleteProperty.ForeColor = System.Drawing.Color.White;
            this.btnDeleteProperty.Location = new System.Drawing.Point(150, 480);
            this.btnDeleteProperty.Name = "btnDeleteProperty";
            this.btnDeleteProperty.Size = new System.Drawing.Size(200, 30);
            this.btnDeleteProperty.TabIndex = 7;
            this.btnDeleteProperty.Text = "Delete Property";
            this.btnDeleteProperty.UseVisualStyleBackColor = false;
            this.btnDeleteProperty.Click += new System.EventHandler(this.btnDeleteProperty_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtReason);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLandlordName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.dgvProperties);
            this.Controls.Add(this.btnDeleteProperty);
            this.Name = "AdminManagePropertiesForm";
            this.Text = "AdminManagePropertiesForm";
            this.Load += new System.EventHandler(this.AdminManagePropertiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLandlordName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Button btnDeleteProperty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
namespace RentingSystem.Forms
{
    partial class CustomerSavedPropertiesForm
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
            this.dgvSavedProperties = new System.Windows.Forms.DataGridView();
            this.txtPropertyID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavedProperties)).BeginInit();
            this.SuspendLayout();

            this.dgvSavedProperties.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSavedProperties.Location = new System.Drawing.Point(20, 20);
            this.dgvSavedProperties.Name = "dgvSavedProperties";
            this.dgvSavedProperties.ReadOnly = true;
            this.dgvSavedProperties.Size = new System.Drawing.Size(860, 250);
            this.dgvSavedProperties.TabIndex = 0;
            this.dgvSavedProperties.SelectionChanged += new System.EventHandler(this.dgvSavedProperties_SelectionChanged);

            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 270);
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.Text = "Property Info";

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 293);
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.Text = "Property ID";

            this.txtPropertyID.Location = new System.Drawing.Point(100, 287);
            this.txtPropertyID.Name = "txtPropertyID";
            this.txtPropertyID.ReadOnly = true;
            this.txtPropertyID.Size = new System.Drawing.Size(200, 20);
            this.txtPropertyID.TabIndex = 2;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 325);
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.Text = "Title";

            this.txtTitle.Location = new System.Drawing.Point(100, 322);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(300, 20);
            this.txtTitle.TabIndex = 4;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 360);
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.Text = "Address";

            this.txtAddress.Location = new System.Drawing.Point(100, 357);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.TabIndex = 6;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 290);
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.Text = "Price";

            this.txtPrice.Location = new System.Drawing.Point(530, 287);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(150, 20);
            this.txtPrice.TabIndex = 8;

            this.btnViewDetails.Location = new System.Drawing.Point(100, 400);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(150, 30);
            this.btnViewDetails.TabIndex = 9;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);

            this.btnRemove.Location = new System.Drawing.Point(280, 400);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(150, 30);
            this.btnRemove.TabIndex = 10;
            this.btnRemove.Text = "Remove from Saved";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvSavedProperties);
            this.Name = "CustomerSavedPropertiesForm";
            this.Text = "CustomerSavedPropertiesForm";
            this.Load += new System.EventHandler(this.CustomerSavedPropertiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSavedProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvSavedProperties;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
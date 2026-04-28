namespace RentingSystem.Forms
{
    partial class LandlordMyPropertiesForm
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
            this.chkIsAvailable = new System.Windows.Forms.CheckBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label4.Location = new System.Drawing.Point(20, 395);
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.Text = "Availability";

            this.chkIsAvailable.AutoSize = true;
            this.chkIsAvailable.Location = new System.Drawing.Point(150, 395);
            this.chkIsAvailable.Name = "chkIsAvailable";
            this.chkIsAvailable.Size = new System.Drawing.Size(94, 17);
            this.chkIsAvailable.TabIndex = 4;
            this.chkIsAvailable.Text = "Mark Available";
            this.chkIsAvailable.UseVisualStyleBackColor = true;

            this.btnUpdateStatus.Location = new System.Drawing.Point(150, 420);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(200, 30);
            this.btnUpdateStatus.TabIndex = 5;
            this.btnUpdateStatus.Text = "Update Status";
            this.btnUpdateStatus.UseVisualStyleBackColor = true;
            this.btnUpdateStatus.Click += new System.EventHandler(this.btnUpdateStatus_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkIsAvailable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPropertyID);
            this.Controls.Add(this.dgvProperties);
            this.Controls.Add(this.btnUpdateStatus);
            this.Name = "LandlordMyPropertiesForm";
            this.Text = "LandlordMyPropertiesForm";
            this.Load += new System.EventHandler(this.LandlordMyPropertiesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProperties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dgvProperties;
        private System.Windows.Forms.TextBox txtPropertyID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.CheckBox chkIsAvailable;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
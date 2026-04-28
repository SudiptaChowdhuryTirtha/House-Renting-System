namespace RentingSystem.Forms
{
    partial class AdminDashboard
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
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalLandlords = new System.Windows.Forms.Label();
            this.lblAvailableProperties = new System.Windows.Forms.Label();
            this.lblRentedProperties = new System.Windows.Forms.Label();
            this.lblDeletedProperties = new System.Windows.Forms.Label();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageProperties = new System.Windows.Forms.Button();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 60);
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.Text = "Total Customers";

            this.lblTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalCustomers.Location = new System.Drawing.Point(50, 80);
            this.lblTotalCustomers.Size = new System.Drawing.Size(150, 100);
            this.lblTotalCustomers.Text = "0";
            this.lblTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 60);
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.Text = "Total Landlords";

            this.lblTotalLandlords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalLandlords.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblTotalLandlords.Location = new System.Drawing.Point(250, 80);
            this.lblTotalLandlords.Size = new System.Drawing.Size(150, 100);
            this.lblTotalLandlords.Text = "0";
            this.lblTotalLandlords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 60);
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.Text = "Available Properties";

            this.lblAvailableProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAvailableProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblAvailableProperties.Location = new System.Drawing.Point(450, 80);
            this.lblAvailableProperties.Size = new System.Drawing.Size(150, 100);
            this.lblAvailableProperties.Text = "0";
            this.lblAvailableProperties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(650, 60);
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.Text = "Rented Properties";

            this.lblRentedProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRentedProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblRentedProperties.Location = new System.Drawing.Point(650, 80);
            this.lblRentedProperties.Size = new System.Drawing.Size(150, 100);
            this.lblRentedProperties.Text = "0";
            this.lblRentedProperties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(850, 60);
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.Text = "Deleted Properties";

            this.lblDeletedProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeletedProperties.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblDeletedProperties.Location = new System.Drawing.Point(850, 80);
            this.lblDeletedProperties.Size = new System.Drawing.Size(150, 100);
            this.lblDeletedProperties.Text = "0";
            this.lblDeletedProperties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.btnManageUsers.Location = new System.Drawing.Point(50, 220);
            this.btnManageUsers.Size = new System.Drawing.Size(150, 40);
            this.btnManageUsers.Text = "Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = true;
            this.btnManageUsers.Click += new System.EventHandler(this.btnManageUsers_Click);

            this.btnManageProperties.Location = new System.Drawing.Point(250, 220);
            this.btnManageProperties.Size = new System.Drawing.Size(150, 40);
            this.btnManageProperties.Text = "Review Properties";
            this.btnManageProperties.UseVisualStyleBackColor = true;
            this.btnManageProperties.Click += new System.EventHandler(this.btnManageProperties_Click);

            this.btnViewLogs.Location = new System.Drawing.Point(450, 220);
            this.btnViewLogs.Size = new System.Drawing.Size(150, 40);
            this.btnViewLogs.Text = "View Action Logs";
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);

            this.btnLogout.Location = new System.Drawing.Point(650, 220);
            this.btnLogout.Size = new System.Drawing.Size(150, 40);
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 300);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDeletedProperties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRentedProperties);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAvailableProperties);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalLandlords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalCustomers);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnViewLogs);
            this.Controls.Add(this.btnManageProperties);
            this.Controls.Add(this.btnManageUsers);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalLandlords;
        private System.Windows.Forms.Label lblAvailableProperties;
        private System.Windows.Forms.Label lblRentedProperties;
        private System.Windows.Forms.Label lblDeletedProperties;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Button btnManageProperties;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
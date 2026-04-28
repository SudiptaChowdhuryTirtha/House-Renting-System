namespace RentingSystem.Forms
{
    partial class CustomerDashboard
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
            this.btnBrowseProperties = new System.Windows.Forms.Button();
            this.btnSavedProperties = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Customer Dashboard";

            this.btnBrowseProperties.Location = new System.Drawing.Point(50, 100);
            this.btnBrowseProperties.Name = "btnBrowseProperties";
            this.btnBrowseProperties.Size = new System.Drawing.Size(200, 50);
            this.btnBrowseProperties.TabIndex = 0;
            this.btnBrowseProperties.Text = "Browse Properties";
            this.btnBrowseProperties.UseVisualStyleBackColor = true;
            this.btnBrowseProperties.Click += new System.EventHandler(this.btnBrowseProperties_Click);

            this.btnSavedProperties.Location = new System.Drawing.Point(300, 100);
            this.btnSavedProperties.Name = "btnSavedProperties";
            this.btnSavedProperties.Size = new System.Drawing.Size(200, 50);
            this.btnSavedProperties.TabIndex = 1;
            this.btnSavedProperties.Text = "Saved Properties";
            this.btnSavedProperties.UseVisualStyleBackColor = true;
            this.btnSavedProperties.Click += new System.EventHandler(this.btnSavedProperties_Click);

            this.btnMessages.Location = new System.Drawing.Point(550, 100);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(200, 50);
            this.btnMessages.TabIndex = 2;
            this.btnMessages.Text = "Chat with Landlord";
            this.btnMessages.UseVisualStyleBackColor = true;
            this.btnMessages.Click += new System.EventHandler(this.btnMessages_Click);

            this.btnLogout.Location = new System.Drawing.Point(800, 100);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 200);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnMessages);
            this.Controls.Add(this.btnSavedProperties);
            this.Controls.Add(this.btnBrowseProperties);
            this.Name = "CustomerDashboard";
            this.Text = "CustomerDashboard";
            this.Load += new System.EventHandler(this.CustomerDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnBrowseProperties;
        private System.Windows.Forms.Button btnSavedProperties;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}
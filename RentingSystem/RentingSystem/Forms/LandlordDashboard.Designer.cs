namespace RentingSystem.Forms
{
    partial class LandlordDashboard
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
            this.btnPostProperty = new System.Windows.Forms.Button();
            this.btnMyProperties = new System.Windows.Forms.Button();
            this.btnMessages = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(50, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Landlord Dashboard";

            this.btnPostProperty.Location = new System.Drawing.Point(50, 100);
            this.btnPostProperty.Name = "btnPostProperty";
            this.btnPostProperty.Size = new System.Drawing.Size(200, 50);
            this.btnPostProperty.TabIndex = 0;
            this.btnPostProperty.Text = "Post New Property";
            this.btnPostProperty.UseVisualStyleBackColor = true;
            this.btnPostProperty.Click += new System.EventHandler(this.btnPostProperty_Click);

            this.btnMyProperties.Location = new System.Drawing.Point(300, 100);
            this.btnMyProperties.Name = "btnMyProperties";
            this.btnMyProperties.Size = new System.Drawing.Size(200, 50);
            this.btnMyProperties.TabIndex = 1;
            this.btnMyProperties.Text = "My Properties";
            this.btnMyProperties.UseVisualStyleBackColor = true;
            this.btnMyProperties.Click += new System.EventHandler(this.btnMyProperties_Click);

            this.btnMessages.Location = new System.Drawing.Point(550, 100);
            this.btnMessages.Name = "btnMessages";
            this.btnMessages.Size = new System.Drawing.Size(200, 50);
            this.btnMessages.TabIndex = 2;
            this.btnMessages.Text = "Messages";
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
            this.Controls.Add(this.btnMyProperties);
            this.Controls.Add(this.btnPostProperty);
            this.Name = "LandlordDashboard";
            this.Text = "LandlordDashboard";
            this.Load += new System.EventHandler(this.LandlordDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnPostProperty;
        private System.Windows.Forms.Button btnMyProperties;
        private System.Windows.Forms.Button btnMessages;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label1;
    }
}
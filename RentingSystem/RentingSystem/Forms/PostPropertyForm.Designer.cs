namespace RentingSystem.Forms
{
    partial class PostPropertyForm
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtBedrooms = new System.Windows.Forms.TextBox();
            this.txtBathrooms = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
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
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.Text = "Title";

            this.txtTitle.Location = new System.Drawing.Point(150, 50);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(250, 20);
            this.txtTitle.TabIndex = 0;

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.Text = "Description";

            this.txtDescription.Location = new System.Drawing.Point(150, 90);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(250, 60);
            this.txtDescription.TabIndex = 1;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 163);
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.Text = "Address";

            this.txtAddress.Location = new System.Drawing.Point(150, 160);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(250, 20);
            this.txtAddress.TabIndex = 2;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 193);
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.Text = "City";

            this.txtCity.Location = new System.Drawing.Point(150, 190);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(250, 20);
            this.txtCity.TabIndex = 3;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 223);
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.Text = "Price";

            this.txtPrice.Location = new System.Drawing.Point(150, 220);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(250, 20);
            this.txtPrice.TabIndex = 4;

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 253);
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.Text = "Bedrooms";

            this.txtBedrooms.Location = new System.Drawing.Point(150, 250);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.Size = new System.Drawing.Size(250, 20);
            this.txtBedrooms.TabIndex = 5;

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 283);
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.Text = "Bathrooms";

            this.txtBathrooms.Location = new System.Drawing.Point(150, 280);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.Size = new System.Drawing.Size(250, 20);
            this.txtBathrooms.TabIndex = 6;

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(50, 313);
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.Text = "Area";

            this.txtArea.Location = new System.Drawing.Point(150, 310);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(250, 20);
            this.txtArea.TabIndex = 7;

            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 343);
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.Text = "Latitude";

            this.txtLatitude.Location = new System.Drawing.Point(150, 340);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(250, 20);
            this.txtLatitude.TabIndex = 8;

            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 373);
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.Text = "Longitude";

            this.txtLongitude.Location = new System.Drawing.Point(150, 370);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(250, 20);
            this.txtLongitude.TabIndex = 9;

            this.btnPost.Location = new System.Drawing.Point(150, 410);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(250, 30);
            this.btnPost.TabIndex = 10;
            this.btnPost.Text = "Post Property";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 460);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBathrooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBedrooms);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtTitle);
            this.Name = "PostPropertyForm";
            this.Text = "PostPropertyForm";
            this.Load += new System.EventHandler(this.PostPropertyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtBedrooms;
        private System.Windows.Forms.TextBox txtBathrooms;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.Button btnPost;
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
    }
}
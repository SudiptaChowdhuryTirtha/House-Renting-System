namespace RentingSystem.Forms
{
    partial class CustomerPropertyDetailsForm
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
            this.txtLandlordName = new System.Windows.Forms.TextBox();
            this.txtLandlordPhone = new System.Windows.Forms.TextBox();
            this.txtLandlordEmail = new System.Windows.Forms.TextBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMapInfo = new System.Windows.Forms.Label();
            this.btnSendMessage = new System.Windows.Forms.Button();
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
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.Text = "Property Info";

            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 60);
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.Text = "Title";

            this.txtTitle.Location = new System.Drawing.Point(120, 57);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(300, 20);
            this.txtTitle.TabIndex = 2;

            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.Text = "Description";

            this.txtDescription.Location = new System.Drawing.Point(120, 92);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(750, 60);
            this.txtDescription.TabIndex = 4;

            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 165);
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.Text = "Address";

            this.txtAddress.Location = new System.Drawing.Point(120, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(300, 20);
            this.txtAddress.TabIndex = 6;

            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 165);
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.Text = "City";

            this.txtCity.Location = new System.Drawing.Point(550, 162);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(150, 20);
            this.txtCity.TabIndex = 8;

            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 200);
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.Text = "Price";

            this.txtPrice.Location = new System.Drawing.Point(120, 197);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 10;

            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(240, 200);
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.Text = "Bedrooms";

            this.txtBedrooms.Location = new System.Drawing.Point(320, 197);
            this.txtBedrooms.Name = "txtBedrooms";
            this.txtBedrooms.ReadOnly = true;
            this.txtBedrooms.Size = new System.Drawing.Size(100, 20);
            this.txtBedrooms.TabIndex = 12;

            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(450, 200);
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.Text = "Bathrooms";

            this.txtBathrooms.Location = new System.Drawing.Point(550, 197);
            this.txtBathrooms.Name = "txtBathrooms";
            this.txtBathrooms.ReadOnly = true;
            this.txtBathrooms.Size = new System.Drawing.Size(100, 20);
            this.txtBathrooms.TabIndex = 14;

            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 235);
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.Text = "Area";

            this.txtArea.Location = new System.Drawing.Point(120, 232);
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 16;

            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 270);
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.Text = "Latitude";

            this.txtLatitude.Location = new System.Drawing.Point(120, 267);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.ReadOnly = true;
            this.txtLatitude.Size = new System.Drawing.Size(150, 20);
            this.txtLatitude.TabIndex = 18;

            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 270);
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.Text = "Longitude";

            this.txtLongitude.Location = new System.Drawing.Point(380, 267);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.ReadOnly = true;
            this.txtLongitude.Size = new System.Drawing.Size(150, 20);
            this.txtLongitude.TabIndex = 20;

            this.lblMapInfo.AutoSize = true;
            this.lblMapInfo.Location = new System.Drawing.Point(20, 300);
            this.lblMapInfo.Size = new System.Drawing.Size(63, 13);
            this.lblMapInfo.Text = "Map would display here";

            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(20, 340);
            this.label12.Size = new System.Drawing.Size(123, 20);
            this.label12.Text = "Landlord Info";

            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 380);
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.Text = "Name";

            this.txtLandlordName.Location = new System.Drawing.Point(120, 377);
            this.txtLandlordName.Name = "txtLandlordName";
            this.txtLandlordName.ReadOnly = true;
            this.txtLandlordName.Size = new System.Drawing.Size(300, 20);
            this.txtLandlordName.TabIndex = 24;

            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 415);
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.Text = "Phone";

            this.txtLandlordPhone.Location = new System.Drawing.Point(120, 412);
            this.txtLandlordPhone.Name = "txtLandlordPhone";
            this.txtLandlordPhone.ReadOnly = true;
            this.txtLandlordPhone.Size = new System.Drawing.Size(300, 20);
            this.txtLandlordPhone.TabIndex = 26;

            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 450);
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.Text = "Email";

            this.txtLandlordEmail.Location = new System.Drawing.Point(120, 447);
            this.txtLandlordEmail.Name = "txtLandlordEmail";
            this.txtLandlordEmail.ReadOnly = true;
            this.txtLandlordEmail.Size = new System.Drawing.Size(300, 20);
            this.txtLandlordEmail.TabIndex = 28;

            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(20, 490);
            this.label16.Size = new System.Drawing.Size(114, 20);
            this.label16.Text = "Send Message";

            this.txtMessage.Location = new System.Drawing.Point(20, 525);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(850, 100);
            this.txtMessage.TabIndex = 30;

            this.btnSendMessage.Location = new System.Drawing.Point(20, 635);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(850, 30);
            this.btnSendMessage.TabIndex = 31;
            this.btnSendMessage.Text = "Send Message to Landlord";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnSendMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtLandlordEmail);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtLandlordPhone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtLandlordName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblMapInfo);
            this.Controls.Add(this.txtLongitude);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLatitude);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBathrooms);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBedrooms);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CustomerPropertyDetailsForm";
            this.Text = "CustomerPropertyDetailsForm";
            this.Load += new System.EventHandler(this.CustomerPropertyDetailsForm_Load);
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
        private System.Windows.Forms.TextBox txtLandlordName;
        private System.Windows.Forms.TextBox txtLandlordPhone;
        private System.Windows.Forms.TextBox txtLandlordEmail;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMapInfo;
        private System.Windows.Forms.Button btnSendMessage;
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
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}
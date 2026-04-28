using RentingSystem.DataAccess;
using RentingSystem.Helpers;
using RentingSystem.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace RentingSystem.Forms
{
    public partial class PostPropertyForm : Form
    {
        public PostPropertyForm()
        {
            InitializeComponent();
        }

        private void PostPropertyForm_Load(object sender, EventArgs e)
        {
            this.Text = "Post New Property";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string description = txtDescription.Text.Trim();
            string address = txtAddress.Text.Trim();
            string city = txtCity.Text.Trim();
            string priceStr = txtPrice.Text.Trim();
            string bedroomsStr = txtBedrooms.Text.Trim();
            string bathroomsStr = txtBathrooms.Text.Trim();
            string areaStr = txtArea.Text.Trim();
            string latitudeStr = txtLatitude.Text.Trim();
            string longitudeStr = txtLongitude.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(priceStr))
            {
                MessageBox.Show("Please fill all required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Property property = new Property
                {
                    LandlordID = CurrentUser.UserID,
                    Title = title,
                    Description = description,
                    Address = address,
                    City = city,
                    Price = decimal.Parse(priceStr),
                    Bedrooms = string.IsNullOrEmpty(bedroomsStr) ? 0 : int.Parse(bedroomsStr),
                    Bathrooms = string.IsNullOrEmpty(bathroomsStr) ? 0 : int.Parse(bathroomsStr),
                    Area = string.IsNullOrEmpty(areaStr) ? 0 : int.Parse(areaStr),
                    Latitude = string.IsNullOrEmpty(latitudeStr) ? 0 : double.Parse(latitudeStr),
                    Longitude = string.IsNullOrEmpty(longitudeStr) ? 0 : double.Parse(longitudeStr),
                    IsAvailable = true
                };

                bool result = PropertyDAL.AddProperty(property);

                if (result)
                {
                    int propertyID = PropertyDAL.GetLastPropertyID();
                    MessageBox.Show("Property posted successfully! Property ID: " + propertyID, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to post property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using RentingSystem.DataAccess;
using RentingSystem.Helpers;
using RentingSystem.Models;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace RentingSystem.Forms
{
    public partial class CustomerPropertyDetailsForm : Form
    {
        private int propertyID;

        public CustomerPropertyDetailsForm(int propertyID)
        {
            InitializeComponent();
            this.propertyID = propertyID;
        }

        private void CustomerPropertyDetailsForm_Load(object sender, EventArgs e)
        {
            this.Text = "Property Details";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(900, 700);
            LoadPropertyDetails();
            LoadLandlordInfo();
        }

        private void LoadPropertyDetails()
        {
            try
            {
                Property property = PropertyDAL.GetPropertyByID(propertyID);

                if (property != null)
                {
                    txtTitle.Text = property.Title;
                    txtDescription.Text = property.Description;
                    txtAddress.Text = property.Address;
                    txtCity.Text = property.City;
                    txtPrice.Text = property.Price.ToString();
                    txtBedrooms.Text = property.Bedrooms.ToString();
                    txtBathrooms.Text = property.Bathrooms.ToString();
                    txtArea.Text = property.Area.ToString();
                    txtLatitude.Text = property.Latitude.ToString();
                    txtLongitude.Text = property.Longitude.ToString();

                    lblMapInfo.Text = "Location: " + property.Latitude + ", " + property.Longitude;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading property details: " + ex.Message);
            }
        }

        private void LoadLandlordInfo()
        {
            try
            {
                Property property = PropertyDAL.GetPropertyByID(propertyID);
                User landlord = UserDAL.GetUserByID(property.LandlordID);

                if (landlord != null)
                {
                    txtLandlordName.Text = landlord.FullName;
                    txtLandlordPhone.Text = landlord.Phone;
                    txtLandlordEmail.Text = landlord.Email;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading landlord info: " + ex.Message);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            Property property = PropertyDAL.GetPropertyByID(propertyID);
            string messageText = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(messageText))
            {
                MessageBox.Show("Please enter a message", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Models.Message message = new Models.Message
                {
                    SenderID = CurrentUser.UserID,
                    ReceiverID = property.LandlordID,
                    PropertyID = propertyID,
                    MessageText = messageText
                };

                bool result = MessageDAL.SendMessage(message);

                if (result)
                {
                    MessageBox.Show("Message sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMessage.Clear();
                }
                else
                {
                    MessageBox.Show("Failed to send message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
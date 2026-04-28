using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class CustomerBrowsePropertiesForm : Form
    {
        public CustomerBrowsePropertiesForm()
        {
            InitializeComponent();
        }

        private void CustomerBrowsePropertiesForm_Load(object sender, EventArgs e)
        {
            this.Text = "Browse Properties";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(1000, 600);
            LoadProperties();
        }

        private void LoadProperties()
        {
            try
            {
                DataTable dt = PropertyDAL.GetAvailableProperties();
                dgvProperties.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading properties: " + ex.Message);
            }
        }

        private void dgvProperties_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProperties.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvProperties.SelectedRows[0];
                int propertyID = (int)row.Cells["PropertyID"].Value;

                txtPropertyID.Text = propertyID.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
                txtBedrooms.Text = row.Cells["Bedrooms"].Value.ToString();
                txtBathrooms.Text = row.Cells["Bathrooms"].Value.ToString();

                bool isSaved = SavedPostDAL.IsPropertySaved(CurrentUser.UserID, propertyID);
                btnSaveProperty.Text = isSaved ? "Remove from Saved" : "Save Property";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string city = txtSearchCity.Text.Trim();
            string minPriceStr = txtSearchMinPrice.Text.Trim();
            string maxPriceStr = txtSearchMaxPrice.Text.Trim();
            string bedroomsStr = txtSearchBedrooms.Text.Trim();

            try
            {
                decimal? minPrice = string.IsNullOrEmpty(minPriceStr) ? (decimal?)null : decimal.Parse(minPriceStr);
                decimal? maxPrice = string.IsNullOrEmpty(maxPriceStr) ? (decimal?)null : decimal.Parse(maxPriceStr);
                int? bedrooms = string.IsNullOrEmpty(bedroomsStr) ? (int?)null : int.Parse(bedroomsStr);

                DataTable dt = PropertyDAL.SearchProperties(city, minPrice, maxPrice, bedrooms);
                dgvProperties.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching properties: " + ex.Message);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPropertyID.Text))
            {
                MessageBox.Show("Please select a property", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int propertyID = int.Parse(txtPropertyID.Text);
            CustomerPropertyDetailsForm form = new CustomerPropertyDetailsForm(propertyID);
            form.ShowDialog();
            LoadProperties();
        }

        private void btnSaveProperty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPropertyID.Text))
            {
                MessageBox.Show("Please select a property", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int propertyID = int.Parse(txtPropertyID.Text);

            try
            {
                bool isSaved = SavedPostDAL.IsPropertySaved(CurrentUser.UserID, propertyID);

                if (isSaved)
                {
                    SavedPostDAL.RemoveSavedProperty(CurrentUser.UserID, propertyID);
                    MessageBox.Show("Property removed from saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SavedPostDAL.SaveProperty(CurrentUser.UserID, propertyID);
                    MessageBox.Show("Property saved successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadProperties();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
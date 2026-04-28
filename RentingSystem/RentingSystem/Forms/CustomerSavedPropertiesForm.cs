using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class CustomerSavedPropertiesForm : Form
    {
        public CustomerSavedPropertiesForm()
        {
            InitializeComponent();
        }

        private void CustomerSavedPropertiesForm_Load(object sender, EventArgs e)
        {
            this.Text = "Saved Properties";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(900, 500);
            LoadSavedProperties();
        }

        private void LoadSavedProperties()
        {
            try
            {
                DataTable dt = SavedPostDAL.GetSavedProperties(CurrentUser.UserID);
                dgvSavedProperties.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading saved properties: " + ex.Message);
            }
        }

        private void dgvSavedProperties_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSavedProperties.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSavedProperties.SelectedRows[0];
                txtPropertyID.Text = row.Cells["PropertyID"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
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
            LoadSavedProperties();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPropertyID.Text))
            {
                MessageBox.Show("Please select a property", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int propertyID = int.Parse(txtPropertyID.Text);

            try
            {
                bool result = SavedPostDAL.RemoveSavedProperty(CurrentUser.UserID, propertyID);

                if (result)
                {
                    MessageBox.Show("Property removed from saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSavedProperties();
                }
                else
                {
                    MessageBox.Show("Failed to remove property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
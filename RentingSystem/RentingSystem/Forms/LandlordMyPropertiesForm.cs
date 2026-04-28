using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class LandlordMyPropertiesForm : Form
    {
        public LandlordMyPropertiesForm()
        {
            InitializeComponent();
        }

        private void LandlordMyPropertiesForm_Load(object sender, EventArgs e)
        {
            this.Text = "My Properties";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(900, 500);
            LoadProperties();
        }

        private void LoadProperties()
        {
            try
            {
                DataTable dt = PropertyDAL.GetPropertiesByLandlord(CurrentUser.UserID);
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
                txtPropertyID.Text = row.Cells["PropertyID"].Value.ToString();
                txtTitle.Text = row.Cells["Title"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                bool isAvailable = (bool)row.Cells["IsAvailable"].Value;
                chkIsAvailable.Checked = isAvailable;
            }
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPropertyID.Text))
            {
                MessageBox.Show("Please select a property", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int propertyID = int.Parse(txtPropertyID.Text);
            bool isAvailable = chkIsAvailable.Checked;

            try
            {
                bool result = PropertyDAL.UpdatePropertyAvailability(propertyID, isAvailable);

                if (result)
                {
                    MessageBox.Show("Property status updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProperties();
                }
                else
                {
                    MessageBox.Show("Failed to update property status", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class AdminManagePropertiesForm : Form
    {
        public AdminManagePropertiesForm()
        {
            InitializeComponent();
        }

        private void AdminManagePropertiesForm_Load(object sender, EventArgs e)
        {
            this.Text = "Review Properties";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(900, 550);
            LoadProperties();
        }

        private void LoadProperties()
        {
            try
            {
                DataTable dt = AdminDAL.GetAllPropertiesForReview();
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
                txtLandlordName.Text = row.Cells["FullName"].Value.ToString();
                txtPrice.Text = row.Cells["Price"].Value.ToString();
            }
        }

        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPropertyID.Text))
            {
                MessageBox.Show("Please select a property to delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int propertyID = int.Parse(txtPropertyID.Text);
            string reason = txtReason.Text.Trim();

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please enter reason for deletion", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this property?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool deleteResult = PropertyDAL.DeleteProperty(propertyID, reason);
                    AdminDAL.LogAdminAction(CurrentUser.UserID, null, propertyID, "DeleteProperty", reason);

                    if (deleteResult)
                    {
                        MessageBox.Show("Property deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProperties();
                        txtReason.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete property", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
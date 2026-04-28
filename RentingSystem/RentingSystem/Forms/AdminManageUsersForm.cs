using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class AdminManageUsersForm : Form
    {
        public AdminManageUsersForm()
        {
            InitializeComponent();
        }

        private void AdminManageUsersForm_Load(object sender, EventArgs e)
        {
            this.Text = "Manage Users";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 500);
            LoadUsers();
        }

        private void LoadUsers()
        {
            try
            {
                DataTable dt = UserDAL.GetAllUsers();
                dgvUsers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading users: " + ex.Message);
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvUsers.SelectedRows[0];
                txtUserID.Text = row.Cells["UserID"].Value.ToString();
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                txtRole.Text = row.Cells["Role"].Value.ToString();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserID.Text))
            {
                MessageBox.Show("Please select a user to delete", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = int.Parse(txtUserID.Text);
            string reason = txtReason.Text.Trim();

            if (string.IsNullOrEmpty(reason))
            {
                MessageBox.Show("Please enter reason for deletion", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool deleteResult = UserDAL.DeleteUser(userID);
                    AdminDAL.LogAdminAction(CurrentUser.UserID, userID, null, "DeleteUser", reason);

                    if (deleteResult)
                    {
                        MessageBox.Show("User deleted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                        txtReason.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
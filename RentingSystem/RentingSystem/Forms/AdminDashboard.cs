using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Admin Dashboard - " + CurrentUser.FullName;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
            LoadDashboard();
        }

        private void LoadDashboard()
        {
            try
            {
                DataTable dtStats = AdminDAL.GetDashboardStats();
                if (dtStats.Rows.Count > 0)
                {
                    lblTotalCustomers.Text = dtStats.Rows[0]["TotalCustomers"].ToString();
                    lblTotalLandlords.Text = dtStats.Rows[0]["TotalLandlords"].ToString();
                    lblAvailableProperties.Text = dtStats.Rows[0]["AvailableProperties"].ToString();
                    lblRentedProperties.Text = dtStats.Rows[0]["RentedProperties"].ToString();
                    lblDeletedProperties.Text = dtStats.Rows[0]["DeletedProperties"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard: " + ex.Message);
            }
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            AdminManageUsersForm form = new AdminManageUsersForm();
            form.ShowDialog();
        }

        private void btnManageProperties_Click(object sender, EventArgs e)
        {
            AdminManagePropertiesForm form = new AdminManagePropertiesForm();
            form.ShowDialog();
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            AdminLogsForm form = new AdminLogsForm();
            form.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }
    }
}
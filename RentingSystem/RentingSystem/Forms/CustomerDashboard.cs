using System;
using System.Windows.Forms;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class CustomerDashboard : Form
    {
        public CustomerDashboard()
        {
            InitializeComponent();
        }

        private void CustomerDashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Customer Dashboard - " + CurrentUser.FullName;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnBrowseProperties_Click(object sender, EventArgs e)
        {
            CustomerBrowsePropertiesForm form = new CustomerBrowsePropertiesForm();
            form.ShowDialog();
        }

        private void btnSavedProperties_Click(object sender, EventArgs e)
        {
            CustomerSavedPropertiesForm form = new CustomerSavedPropertiesForm();
            form.ShowDialog();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            CustomerChatForm form = new CustomerChatForm();
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
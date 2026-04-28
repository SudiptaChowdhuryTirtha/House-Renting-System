using System;
using System.Windows.Forms;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class LandlordDashboard : Form
    {
        public LandlordDashboard()
        {
            InitializeComponent();
        }

        private void LandlordDashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Landlord Dashboard - " + CurrentUser.FullName;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnPostProperty_Click(object sender, EventArgs e)
        {
            PostPropertyForm form = new PostPropertyForm();
            form.ShowDialog();
        }

        private void btnMyProperties_Click(object sender, EventArgs e)
        {
            LandlordMyPropertiesForm form = new LandlordMyPropertiesForm();
            form.ShowDialog();
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            LandlordMessagesForm form = new LandlordMessagesForm();
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
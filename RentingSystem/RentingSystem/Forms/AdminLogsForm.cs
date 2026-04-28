using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;

namespace RentingSystem.Forms
{
    public partial class AdminLogsForm : Form
    {
        public AdminLogsForm()
        {
            InitializeComponent();
        }

        private void AdminLogsForm_Load(object sender, EventArgs e)
        {
            this.Text = "Admin Action Logs";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 500);
            LoadLogs();
        }

        private void LoadLogs()
        {
            try
            {
                DataTable dt = AdminDAL.GetAdminActionLogs();
                dgvLogs.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading logs: " + ex.Message);
            }
        }
    }
}
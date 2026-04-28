using System;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Models;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Text = "Renting System - Login";
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter username and password", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User user = UserDAL.Login(username, password);

                if (user != null)
                {
                    CurrentUser.UserID = user.UserID;
                    CurrentUser.Username = user.Username;
                    CurrentUser.FullName = user.FullName;
                    CurrentUser.Role = user.Role;
                    CurrentUser.Email = user.Email;
                    CurrentUser.Phone = user.Phone;

                    if (user.Role == "Admin")
                    {
                        AdminDashboard dashboard = new AdminDashboard();
                        dashboard.Show();
                    }
                    else if (user.Role == "Landlord")
                    {
                        LandlordDashboard dashboard = new LandlordDashboard();
                        dashboard.Show();
                    }
                    else if (user.Role == "Customer")
                    {
                        CustomerDashboard dashboard = new CustomerDashboard();
                        dashboard.Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
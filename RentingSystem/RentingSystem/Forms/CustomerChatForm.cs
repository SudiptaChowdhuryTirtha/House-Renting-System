using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Models;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class CustomerChatForm : Form
    {
        private int selectedLandlordID = 0;

        public CustomerChatForm()
        {
            InitializeComponent();
        }

        private void CustomerChatForm_Load(object sender, EventArgs e)
        {
            this.Text = "Chat with Landlord";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(800, 600);
            LoadLandlordsFromMessages();
        }

        private void LoadLandlordsFromMessages()
        {
            try
            {
                DataTable dt = MessageDAL.GetUnreadMessages(CurrentUser.UserID);
                dgvLandlords.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading conversations: " + ex.Message);
            }
        }

        private void dgvLandlords_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLandlords.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLandlords.SelectedRows[0];
                selectedLandlordID = (int)row.Cells["SenderID"].Value;
                LoadConversation();
            }
        }

        private void LoadConversation()
        {
            try
            {
                DataTable dt = MessageDAL.GetMessageConversation(CurrentUser.UserID, selectedLandlordID);
                dgvConversation.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading conversation: " + ex.Message);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            if (selectedLandlordID == 0)
            {
                MessageBox.Show("Please select a landlord to chat with", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string messageText = txtMessage.Text.Trim();

            if (string.IsNullOrEmpty(messageText))
            {
                MessageBox.Show("Please enter a message", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Models.Message message = new Models.Message
                {
                    SenderID = CurrentUser.UserID,
                    ReceiverID = selectedLandlordID,
                    PropertyID = 0,
                    MessageText = messageText
                };

                bool result = MessageDAL.SendMessage(message);

                if (result)
                {
                    txtMessage.Clear();
                    LoadConversation();
                }
                else
                {
                    MessageBox.Show("Failed to send message", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
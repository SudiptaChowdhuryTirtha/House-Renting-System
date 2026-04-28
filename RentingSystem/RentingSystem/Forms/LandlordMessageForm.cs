using System;
using System.Data;
using System.Windows.Forms;
using RentingSystem.DataAccess;
using RentingSystem.Models;
using RentingSystem.Helpers;

namespace RentingSystem.Forms
{
    public partial class LandlordMessagesForm : Form
    {
        public LandlordMessagesForm()
        {
            InitializeComponent();
        }

        private void LandlordMessagesForm_Load(object sender, EventArgs e)
        {
            this.Text = "Messages";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Size = new System.Drawing.Size(700, 500);
            LoadUnreadMessages();
        }

        private void LoadUnreadMessages()
        {
            try
            {
                DataTable dt = MessageDAL.GetUnreadMessages(CurrentUser.UserID);
                dgvMessages.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading messages: " + ex.Message);
            }
        }

        private void dgvMessages_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMessages.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMessages.SelectedRows[0];
                txtSenderID.Text = row.Cells["SenderID"].Value.ToString();
                txtMessageText.Text = row.Cells["MessageText"].Value.ToString();
                int messageID = (int)row.Cells["MessageID"].Value;
                MessageDAL.MarkAsRead(messageID);
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenderID.Text) || string.IsNullOrEmpty(txtReply.Text))
            {
                MessageBox.Show("Please select a message and enter reply", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int senderID = int.Parse(txtSenderID.Text);
            string replyText = txtReply.Text.Trim();

            try
            {
                Models.Message message = new Models.Message
                {
                    SenderID = CurrentUser.UserID,
                    ReceiverID = senderID,
                    PropertyID = 0,
                    MessageText = replyText
                };

                bool result = MessageDAL.SendMessage(message);

                if (result)
                {
                    MessageBox.Show("Reply sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtReply.Clear();
                    LoadUnreadMessages();
                }
                else
                {
                    MessageBox.Show("Failed to send reply", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
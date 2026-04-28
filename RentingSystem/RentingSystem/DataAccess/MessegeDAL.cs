using System;
using System.Data;
using System.Data.SqlClient;
using RentingSystem.Models;

namespace RentingSystem.DataAccess
{
    public class MessageDAL
    {
        public static bool SendMessage(Message message)
        {
            string query = "INSERT INTO Messages (SenderID, ReceiverID, PropertyID, MessageText, IsRead) " +
                          "VALUES (@senderid, @receiverid, @propertyid, @messagetext, 0)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@senderid", message.SenderID),
                new SqlParameter("@receiverid", message.ReceiverID),
                new SqlParameter("@propertyid", message.PropertyID),
                new SqlParameter("@messagetext", message.MessageText)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static DataTable GetMessageConversation(int userID1, int userID2)
        {
            string query = "SELECT m.MessageID, m.SenderID, m.ReceiverID, u.FullName, m.MessageText, m.SentDate, m.IsRead " +
                          "FROM Messages m " +
                          "INNER JOIN Users u ON m.SenderID = u.UserID " +
                          "WHERE (m.SenderID = @user1 AND m.ReceiverID = @user2) OR (m.SenderID = @user2 AND m.ReceiverID = @user1) " +
                          "ORDER BY m.SentDate ASC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@user1", userID1),
                new SqlParameter("@user2", userID2)
            };

            return DatabaseHelper.ExecuteReader(query, parameters);
        }

        public static DataTable GetUnreadMessages(int userID)
        {
            string query = "SELECT m.MessageID, m.SenderID, u.FullName, m.MessageText, m.SentDate " +
                          "FROM Messages m " +
                          "INNER JOIN Users u ON m.SenderID = u.UserID " +
                          "WHERE m.ReceiverID = @userid AND m.IsRead = 0 " +
                          "ORDER BY m.SentDate DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userid", userID)
            };

            return DatabaseHelper.ExecuteReader(query, parameters);
        }

        public static bool MarkAsRead(int messageID)
        {
            string query = "UPDATE Messages SET IsRead = 1 WHERE MessageID = @messageid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@messageid", messageID)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }
    }
}
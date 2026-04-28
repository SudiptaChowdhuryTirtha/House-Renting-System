using System;
using System.Data;
using System.Data.SqlClient;

namespace RentingSystem.DataAccess
{
    public class AdminDAL
    {
        public static DataTable GetAllPropertiesForReview()
        {
            string query = "SELECT p.PropertyID, p.LandlordID, u.FullName, p.Title, p.Address, p.Price, p.CreatedDate, p.IsAvailable, p.IsDeleted " +
                          "FROM Properties p " +
                          "INNER JOIN Users u ON p.LandlordID = u.UserID " +
                          "ORDER BY p.CreatedDate DESC";

            return DatabaseHelper.ExecuteReader(query);
        }

        public static DataTable GetDashboardStats()
        {
            string query = "SELECT " +
                          "(SELECT COUNT(*) FROM Users WHERE Role = 'Customer') as TotalCustomers, " +
                          "(SELECT COUNT(*) FROM Users WHERE Role = 'Landlord') as TotalLandlords, " +
                          "(SELECT COUNT(*) FROM Properties WHERE IsAvailable = 1 AND IsDeleted = 0) as AvailableProperties, " +
                          "(SELECT COUNT(*) FROM Properties WHERE IsAvailable = 0 AND IsDeleted = 0) as RentedProperties, " +
                          "(SELECT COUNT(*) FROM Properties WHERE IsDeleted = 1) as DeletedProperties";

            return DatabaseHelper.ExecuteReader(query);
        }

        public static bool LogAdminAction(int adminID, int? targetUserID, int? targetPropertyID, string actionType, string reason)
        {
            string query = "INSERT INTO AdminActions (AdminID, TargetUserID, TargetPropertyID, ActionType, Reason) " +
                          "VALUES (@adminid, @targetuserid, @targetpropertyid, @actiontype, @reason)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@adminid", adminID),
                new SqlParameter("@targetuserid", targetUserID ?? (object)DBNull.Value),
                new SqlParameter("@targetpropertyid", targetPropertyID ?? (object)DBNull.Value),
                new SqlParameter("@actiontype", actionType),
                new SqlParameter("@reason", reason ?? (object)DBNull.Value)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static DataTable GetAdminActionLogs()
        {
            string query = "SELECT a.ActionID, u.FullName, a.ActionType, a.Reason, a.ActionDate " +
                          "FROM AdminActions a " +
                          "INNER JOIN Users u ON a.AdminID = u.UserID " +
                          "ORDER BY a.ActionDate DESC";

            return DatabaseHelper.ExecuteReader(query);
        }
    }
}
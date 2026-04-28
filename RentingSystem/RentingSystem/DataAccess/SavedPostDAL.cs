using System;
using System.Data;
using System.Data.SqlClient;

namespace RentingSystem.DataAccess
{
    public class SavedPostDAL
    {
        public static bool SaveProperty(int customerID, int propertyID)
        {
            string query = "INSERT INTO SavedPosts (CustomerID, PropertyID) VALUES (@customerid, @propertyid)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerid", customerID),
                new SqlParameter("@propertyid", propertyID)
            };

            try
            {
                int result = DatabaseHelper.ExecuteQuery(query, parameters);
                return result > 0;
            }
            catch
            {
                return false;
            }
        }

        public static bool RemoveSavedProperty(int customerID, int propertyID)
        {
            string query = "DELETE FROM SavedPosts WHERE CustomerID = @customerid AND PropertyID = @propertyid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerid", customerID),
                new SqlParameter("@propertyid", propertyID)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static DataTable GetSavedProperties(int customerID)
        {
            string query = "SELECT p.PropertyID, p.LandlordID, p.Title, p.Description, p.Address, p.City, p.Latitude, p.Longitude, p.Price, p.Bedrooms, p.Bathrooms, p.Area, p.CreatedDate, p.IsAvailable, sp.SaveDate " +
                          "FROM SavedPosts sp " +
                          "INNER JOIN Properties p ON sp.PropertyID = p.PropertyID " +
                          "WHERE sp.CustomerID = @customerid AND p.IsDeleted = 0 " +
                          "ORDER BY sp.SaveDate DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerid", customerID)
            };

            return DatabaseHelper.ExecuteReader(query, parameters);
        }

        public static bool IsPropertySaved(int customerID, int propertyID)
        {
            string query = "SELECT COUNT(*) FROM SavedPosts WHERE CustomerID = @customerid AND PropertyID = @propertyid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@customerid", customerID),
                new SqlParameter("@propertyid", propertyID)
            };

            int count = (int)DatabaseHelper.ExecuteScalar(query, parameters);
            return count > 0;
        }
    }
}
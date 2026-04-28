using System;
using System.Data;
using System.Data.SqlClient;

namespace RentingSystem.DataAccess
{
    public class PropertyImageDAL
    {
        public static bool AddImage(int propertyID, string imagePath)
        {
            string query = "INSERT INTO PropertyImages (PropertyID, ImagePath) VALUES (@propertyid, @imagepath)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@propertyid", propertyID),
                new SqlParameter("@imagepath", imagePath)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static DataTable GetPropertyImages(int propertyID)
        {
            string query = "SELECT ImageID, PropertyID, ImagePath, UploadDate FROM PropertyImages WHERE PropertyID = @propertyid ORDER BY UploadDate DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@propertyid", propertyID)
            };

            return DatabaseHelper.ExecuteReader(query, parameters);
        }

        public static bool DeleteImage(int imageID)
        {
            string query = "DELETE FROM PropertyImages WHERE ImageID = @imageid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@imageid", imageID)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }
    }
}
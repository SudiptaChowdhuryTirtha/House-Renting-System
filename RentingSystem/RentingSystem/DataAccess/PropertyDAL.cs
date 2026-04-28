using System;
using System.Data;
using System.Data.SqlClient;
using RentingSystem.Models;

namespace RentingSystem.DataAccess
{
    public class PropertyDAL
    {
        public static bool AddProperty(Property property)
        {
            string query = "INSERT INTO Properties (LandlordID, Title, Description, Address, City, Latitude, Longitude, Price, Bedrooms, Bathrooms, Area, IsAvailable) " +
                          "VALUES (@landlordid, @title, @description, @address, @city, @latitude, @longitude, @price, @bedrooms, @bathrooms, @area, 1)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@landlordid", property.LandlordID),
                new SqlParameter("@title", property.Title),
                new SqlParameter("@description", property.Description ?? (object)DBNull.Value),
                new SqlParameter("@address", property.Address),
                new SqlParameter("@city", property.City ?? (object)DBNull.Value),
                new SqlParameter("@latitude", property.Latitude),
                new SqlParameter("@longitude", property.Longitude),
                new SqlParameter("@price", property.Price),
                new SqlParameter("@bedrooms", property.Bedrooms),
                new SqlParameter("@bathrooms", property.Bathrooms),
                new SqlParameter("@area", property.Area)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static int GetLastPropertyID()
        {
            string query = "SELECT TOP 1 PropertyID FROM Properties ORDER BY PropertyID DESC";
            object result = DatabaseHelper.ExecuteScalar(query);
            return result != null ? (int)result : 0;
        }

        public static DataTable GetAvailableProperties()
        {
            string query = "SELECT PropertyID, LandlordID, Title, Description, Address, City, Latitude, Longitude, Price, Bedrooms, Bathrooms, Area, CreatedDate, IsAvailable " +
                          "FROM Properties WHERE IsAvailable = 1 AND IsDeleted = 0 ORDER BY CreatedDate DESC";
            return DatabaseHelper.ExecuteReader(query);
        }

        public static DataTable GetPropertiesByLandlord(int landlordID)
        {
            string query = "SELECT PropertyID, LandlordID, Title, Description, Address, City, Latitude, Longitude, Price, Bedrooms, Bathrooms, Area, CreatedDate, IsAvailable, IsDeleted " +
                          "FROM Properties WHERE LandlordID = @landlordid AND IsDeleted = 0 ORDER BY CreatedDate DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@landlordid", landlordID)
            };

            return DatabaseHelper.ExecuteReader(query, parameters);
        }

        public static Property GetPropertyByID(int propertyID)
        {
            string query = "SELECT * FROM Properties WHERE PropertyID = @propertyid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@propertyid", propertyID)
            };

            DataTable dt = DatabaseHelper.ExecuteReader(query, parameters);

            if (dt.Rows.Count > 0)
            {
                Property property = new Property
                {
                    PropertyID = (int)dt.Rows[0]["PropertyID"],
                    LandlordID = (int)dt.Rows[0]["LandlordID"],
                    Title = dt.Rows[0]["Title"].ToString(),
                    Description = dt.Rows[0]["Description"].ToString(),
                    Address = dt.Rows[0]["Address"].ToString(),
                    City = dt.Rows[0]["City"].ToString(),
                    Latitude = (double)dt.Rows[0]["Latitude"],
                    Longitude = (double)dt.Rows[0]["Longitude"],
                    Price = (decimal)dt.Rows[0]["Price"],
                    Bedrooms = (int)dt.Rows[0]["Bedrooms"],
                    Bathrooms = (int)dt.Rows[0]["Bathrooms"],
                    Area = (int)dt.Rows[0]["Area"],
                    CreatedDate = (DateTime)dt.Rows[0]["CreatedDate"],
                    IsAvailable = (bool)dt.Rows[0]["IsAvailable"],
                    IsDeleted = (bool)dt.Rows[0]["IsDeleted"]
                };
                return property;
            }
            return null;
        }

        public static bool UpdatePropertyAvailability(int propertyID, bool isAvailable)
        {
            string query = "UPDATE Properties SET IsAvailable = @available WHERE PropertyID = @propertyid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@available", isAvailable),
                new SqlParameter("@propertyid", propertyID)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static bool DeleteProperty(int propertyID, string reason)
        {
            string query = "UPDATE Properties SET IsDeleted = 1, DeletedReason = @reason WHERE PropertyID = @propertyid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@reason", reason),
                new SqlParameter("@propertyid", propertyID)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static DataTable SearchProperties(string city, decimal? minPrice, decimal? maxPrice, int? bedrooms)
        {
            string query = "SELECT PropertyID, LandlordID, Title, Description, Address, City, Latitude, Longitude, Price, Bedrooms, Bathrooms, Area, CreatedDate, IsAvailable " +
                          "FROM Properties WHERE IsAvailable = 1 AND IsDeleted = 0";

            if (!string.IsNullOrEmpty(city))
                query += " AND City LIKE '%" + city + "%'";
            if (minPrice.HasValue)
                query += " AND Price >= " + minPrice.Value;
            if (maxPrice.HasValue)
                query += " AND Price <= " + maxPrice.Value;
            if (bedrooms.HasValue)
                query += " AND Bedrooms >= " + bedrooms.Value;

            query += " ORDER BY CreatedDate DESC";
            return DatabaseHelper.ExecuteReader(query);
        }
    }
}
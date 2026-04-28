using System;
using System.Data;
using System.Data.SqlClient;
using RentingSystem.Models;

namespace RentingSystem.DataAccess
{
    public class UserDAL
    {
        public static User Login(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password AND IsActive = 1";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable dt = DatabaseHelper.ExecuteReader(query, parameters);

            if (dt.Rows.Count > 0)
            {
                User user = new User
                {
                    UserID = (int)dt.Rows[0]["UserID"],
                    Username = dt.Rows[0]["Username"].ToString(),
                    Email = dt.Rows[0]["Email"].ToString(),
                    FullName = dt.Rows[0]["FullName"].ToString(),
                    Phone = dt.Rows[0]["Phone"].ToString(),
                    Role = dt.Rows[0]["Role"].ToString(),
                    IsActive = (bool)dt.Rows[0]["IsActive"],
                    CreatedDate = (DateTime)dt.Rows[0]["CreatedDate"]
                };
                return user;
            }
            return null;
        }

        public static bool Register(User user)
        {
            string query = "INSERT INTO Users (Username, Password, Email, FullName, Phone, Role, IsActive) VALUES (@username, @password, @email, @fullname, @phone, @role, 1)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", user.Username),
                new SqlParameter("@password", user.Password),
                new SqlParameter("@email", user.Email),
                new SqlParameter("@fullname", user.FullName),
                new SqlParameter("@phone", user.Phone),
                new SqlParameter("@role", user.Role)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static User GetUserByID(int userID)
        {
            string query = "SELECT * FROM Users WHERE UserID = @userid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userid", userID)
            };

            DataTable dt = DatabaseHelper.ExecuteReader(query, parameters);

            if (dt.Rows.Count > 0)
            {
                User user = new User
                {
                    UserID = (int)dt.Rows[0]["UserID"],
                    Username = dt.Rows[0]["Username"].ToString(),
                    Email = dt.Rows[0]["Email"].ToString(),
                    FullName = dt.Rows[0]["FullName"].ToString(),
                    Phone = dt.Rows[0]["Phone"].ToString(),
                    Role = dt.Rows[0]["Role"].ToString(),
                    IsActive = (bool)dt.Rows[0]["IsActive"],
                    CreatedDate = (DateTime)dt.Rows[0]["CreatedDate"]
                };
                return user;
            }
            return null;
        }

        public static DataTable GetAllUsers()
        {
            string query = "SELECT UserID, Username, Email, FullName, Phone, Role, CreatedDate, IsActive FROM Users";
            return DatabaseHelper.ExecuteReader(query);
        }

        public static bool DeleteUser(int userID)
        {
            string query = "UPDATE Users SET IsActive = 0 WHERE UserID = @userid";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@userid", userID)
            };

            int result = DatabaseHelper.ExecuteQuery(query, parameters);
            return result > 0;
        }

        public static bool UsernameExists(string username)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE Username = @username";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@username", username)
            };

            int count = (int)DatabaseHelper.ExecuteScalar(query, parameters);
            return count > 0;
        }
    }
}
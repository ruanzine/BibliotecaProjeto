using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookStatisticsService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public int GetTotalBooksCount(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Books WHERE LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public int GetTotalTitlesCount(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Titles WHERE LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public int GetTotalAuthorsCount(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Authors WHERE LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public int GetTotalClassificationsCount(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Classifications WHERE LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        public int GetBooksCountByCondition(string condition, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Books WHERE Condition = @condition AND LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@condition", condition);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);

                    return (int)cmd.ExecuteScalar();
                }
            }
        }
    }
}

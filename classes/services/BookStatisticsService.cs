using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookStatisticsService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        /// <summary>
        /// Gets the total count of books for a specified library.
        /// </summary>
        /// <param name="libraryID">The ID of the library.</param>
        /// <returns>The total count of books.</returns>
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

        /// <summary>
        /// Gets the total count of titles for a specified library.
        /// </summary>
        /// <param name="libraryID">The ID of the library.</param>
        /// <returns>The total count of titles.</returns>
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

        /// <summary>
        /// Gets the total count of authors for a specified library.
        /// </summary>
        /// <param name="libraryID">The ID of the library.</param>
        /// <returns>The total count of authors.</returns>
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

        /// <summary>
        /// Gets the total count of classifications for a specified library.
        /// </summary>
        /// <param name="libraryID">The ID of the library.</param>
        /// <returns>The total count of classifications.</returns>
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

        /// <summary>
        /// Gets the count of books by condition for a specified library.
        /// </summary>
        /// <param name="condition">The condition of the books.</param>
        /// <param name="libraryID">The ID of the library.</param>
        /// <returns>The count of books by condition.</returns>
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

        public DataTable GetBooksAddedByDate(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"
                                    SELECT DeliveryDate AS Date, COUNT(*) AS Count
                                    FROM Books
                                    WHERE LibraryID = @libraryID
                                    GROUP BY DeliveryDate
                                    ORDER BY DeliveryDate";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

    }
}

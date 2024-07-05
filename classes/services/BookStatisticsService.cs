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
        /// <summary>
         /// Gets the count of books added by title in a specific year and month.
         /// </summary>
         /// <param name="libraryID">The ID of the library.</param>
         /// <param name="year">The selected year.</param>
         /// <param name="month">The selected month (0 for all months).</param>
         /// <returns>A DataTable with the titles and the count of books added.</returns>
        public DataTable GetBooksAddedByTitle(int libraryID, int year, int month)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT T.TitleName AS Título, COUNT(*) AS [Nº Exemplares]
                    FROM Books B
                    INNER JOIN Titles T ON B.TitleID = T.ID
                    WHERE B.LibraryID = @libraryID
                    AND YEAR(B.DeliveryDate) = @year
                    AND (@month = 0 OR MONTH(B.DeliveryDate) = @month)
                    GROUP BY T.TitleName
                    ORDER BY T.TitleName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        /// <summary>
        /// Gets the count of books added in a specific year and month.
        /// </summary>
        public int GetBooksCountByDate(int libraryID, int year, int month)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT COUNT(*)
                    FROM Books
                    WHERE LibraryID = @libraryID
                    AND YEAR(DeliveryDate) = @year
                    AND (@month = 0 OR MONTH(DeliveryDate) = @month)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Gets the count of authors in a specific year and month.
        /// </summary>
        public int GetAuthorsCountByDate(int libraryID, int year, int month)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT COUNT(DISTINCT A.ID)
                    FROM Books B
                    INNER JOIN Authors A ON B.AuthorID = A.ID
                    WHERE B.LibraryID = @libraryID
                    AND YEAR(B.DeliveryDate) = @year
                    AND (@month = 0 OR MONTH(B.DeliveryDate) = @month)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Gets the count of classifications in a specific year and month.
        /// </summary>
        public int GetClassificationsCountByDate(int libraryID, int year, int month)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT COUNT(DISTINCT C.ID)
                    FROM Books B
                    INNER JOIN Classifications C ON B.ClassificationID = C.ID
                    WHERE B.LibraryID = @libraryID
                    AND YEAR(B.DeliveryDate) = @year
                    AND (@month = 0 OR MONTH(B.DeliveryDate) = @month)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Gets the count of books acquired by offers in a specific year and month.
        /// </summary>
        public int GetOffersCountByDate(int libraryID, int year, int month)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT COUNT(*)
                    FROM Books
                    WHERE LibraryID = @libraryID
                    AND AcquisitionMethod = 'Oferta'
                    AND YEAR(DeliveryDate) = @year
                    AND (@month = 0 OR MONTH(DeliveryDate) = @month)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

        /// <summary>
        /// Gets the count of books acquired by purchases in a specific year and month.
        /// </summary>
        public int GetPurchasesCountByDate(int libraryID, int year, int month)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"
                    SELECT COUNT(*)
                    FROM Books
                    WHERE LibraryID = @libraryID
                    AND AcquisitionMethod = 'Compra'
                    AND YEAR(DeliveryDate) = @year
                    AND (@month = 0 OR MONTH(DeliveryDate) = @month)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    cmd.Parameters.AddWithValue("@year", year);
                    cmd.Parameters.AddWithValue("@month", month);
                    return (int)cmd.ExecuteScalar();
                }
            }
        }

    }
}

using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookGeneralListingService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public DataTable GetAllBooks(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                 T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                 B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                 B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                 FROM Books B
                                 INNER JOIN Authors A ON B.AuthorID = A.ID
                                 INNER JOIN Classifications C ON B.ClassificationID = C.ID
                                 INNER JOIN Titles T ON B.TitleID = T.ID
                                 WHERE B.LibraryID = @libraryID
                                 ORDER BY B.RegistrationNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllAuthors(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT A.Name AS [Autor]
                                 FROM Authors A
                                 INNER JOIN Books B ON B.AuthorID = A.ID
                                 WHERE A.LibraryID = @libraryID
                                 ORDER BY A.Name";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllTitles(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT T.TitleName AS [Título]
                                 FROM Titles T
                                 INNER JOIN Books B ON B.TitleID = T.ID
                                 WHERE T.LibraryID = @libraryID
                                 ORDER BY T.TitleName";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllClassifications(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT C.Classification AS [Cota]
                                 FROM Classifications C
                                 INNER JOIN Books B ON B.ClassificationID = C.ID
                                 WHERE C.LibraryID = @libraryID
                                 ORDER BY C.Classification";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllConditions(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT B.Condition AS [Estado]
                                 FROM Books B
                                 WHERE B.LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetBooksByTitle(string title, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                 T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                 B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                 B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                 FROM Books B
                                 INNER JOIN Authors A ON B.AuthorID = A.ID
                                 INNER JOIN Classifications C ON B.ClassificationID = C.ID
                                 INNER JOIN Titles T ON B.TitleID = T.ID
                                 WHERE T.TitleName = @title AND B.LibraryID = @libraryID
                                 ORDER BY B.RegistrationNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetBooksByAuthor(string author, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                 T.TitleName AS [Título], A.Name AS [Autor], C.Classification AS [Cota], 
                                 B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                 B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                 FROM Books B
                                 INNER JOIN Authors A ON B.AuthorID = A.ID
                                 INNER JOIN Classifications C ON B.ClassificationID = C.ID
                                 INNER JOIN Titles T ON B.TitleID = T.ID
                                 WHERE A.Name = @author AND B.LibraryID = @libraryID
                                 ORDER BY B.RegistrationNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetBooksByClassification(string classification, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                 T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                 B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                 B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                 FROM Books B
                                 INNER JOIN Authors A ON B.AuthorID = A.ID
                                 INNER JOIN Classifications C ON B.ClassificationID = C.ID
                                 INNER JOIN Titles T ON B.TitleID = T.ID
                                 WHERE C.Classification = @classification AND B.LibraryID = @libraryID
                                 ORDER BY B.RegistrationNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@classification", classification);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetBooksByCondition(string condition, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                 T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                 B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                 B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                 FROM Books B
                                 INNER JOIN Authors A ON B.AuthorID = A.ID
                                 INNER JOIN Classifications C ON B.ClassificationID = C.ID
                                 INNER JOIN Titles T ON B.TitleID = T.ID
                                 WHERE B.Condition = @condition AND B.LibraryID = @libraryID
                                 ORDER BY B.RegistrationNumber";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@condition", condition);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }
    }
}

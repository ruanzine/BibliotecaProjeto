using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookSearchService
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

        public DataTable GetBooksByRegsiterNumber(int numeroRegistro, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE B.RegistrationNumber = @ID AND B.LibraryID = @LibraryID
                                     ORDER BY B.RegistrationNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", numeroRegistro);
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }

        public DataTable GetBooksByAuthor(string autor, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE A.Name LIKE @autor AND B.LibraryID = @LibraryID
                                     ORDER BY B.RegistrationNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@autor", autor + "%");
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }

        public DataTable GetBooksByTitle(string titulo, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE T.TitleName LIKE @titulo AND B.LibraryID = @LibraryID
                                     ORDER BY B.RegistrationNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo + "%");
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }

        public DataTable GetBooksByClassification(string classification, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE C.Classification LIKE @classification AND B.LibraryID = @LibraryID
                                     ORDER BY B.RegistrationNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@classification", classification + "%");
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }

        public DataTable GetBooksByCondition(string condition, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE B.Condition LIKE @condition AND B.LibraryID = @LibraryID
                                     ORDER BY B.RegistrationNumber";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@condition", condition + "%");
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }

        // Printing methods

        public DataTable GetBooksByAuthor_Printing(string autor, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE A.Name LIKE @Autor AND B.LibraryID = @LibraryID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Autor", autor + "%");
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros por autor: " + ex.Message);
            }
        }

        public DataTable GetBooksByTitle_Printing(string titulo, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE T.TitleName LIKE @Titulo AND B.LibraryID = @LibraryID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", titulo + "%");
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros por título: " + ex.Message);
            }
        }

        public DataTable GetBooksByClassification_Printing(string classification, int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                     T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                     B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                     B.VolumeNumber AS [Nº. Vol], B.Condition AS [Estado], B.Observations AS [Observações]
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE C.Classification LIKE @Classification AND B.LibraryID = @LibraryID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Classification", classification + "%");
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(reader);
                            return dt;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros por cota: " + ex.Message);
            }
        }
    }
}

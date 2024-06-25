using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookGeneralListingService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public DataTable GetAllBooks()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], 
                                 T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, 
                                 L.Aquisicao AS [Aquisição], L.Editora AS [Editora], 
                                 L.NumVolume AS [Nº de Volume], L.Estado, L.Observacoes AS [Observações]
                                 FROM Livros L
                                 INNER JOIN Autores A ON L.AutorID = A.ID
                                 INNER JOIN Cotas C ON L.CotaID = C.ID
                                 INNER JOIN Titulos T ON L.TituloID = T.ID
                                 ORDER BY L.ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        // Similar methods for authors, titles, and cotas
        public DataTable GetAllAuthors()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT Nome AS [Autor] FROM Autores ORDER BY Nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllTitles()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT TituloNome AS [Título] FROM Titulos ORDER BY TituloNome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetAllCotas()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT Cota FROM Cotas ORDER BY Cota";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        // Methods to get distinct values for secondary combobox
        public DataTable GetDistinctAuthors()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT A.Nome AS Autor
                                 FROM Livros L
                                 INNER JOIN Autores A ON L.AutorID = A.ID
                                 ORDER BY A.Nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetDistinctTitles()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT T.TituloNome AS Título
                                 FROM Livros L
                                 INNER JOIN Titulos T ON L.TituloID = T.ID
                                 ORDER BY T.TituloNome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetDistinctCotas()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT C.Cota
                                 FROM Livros L
                                 INNER JOIN Cotas C ON L.CotaID = C.ID
                                 ORDER BY C.Cota";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
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

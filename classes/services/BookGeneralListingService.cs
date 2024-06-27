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

        public DataTable GetAllAuthors()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT A.Nome AS Autor
                         FROM Autores A
                         INNER JOIN Livros L ON L.AutorID = A.ID
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


        public DataTable GetAllTitles()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT T.TituloNome AS Título
                                 FROM Titulos T
                                 INNER JOIN Livros L ON L.TituloID = T.ID
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

        public DataTable GetAllCotas()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT DISTINCT C.Cota
                         FROM Cotas C
                         INNER JOIN Livros L ON L.CotaID = C.ID
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

        public DataTable GetAllEstados()
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT Estado FROM Livros";
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

        public DataTable GetBooksByTitle(string title)
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
                         WHERE T.TituloNome = @title
                         ORDER BY L.ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@title", title);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }

        }
        public DataTable GetBooksByAuthor(string author)
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
                         WHERE A.Nome = @autor
                         ORDER BY L.ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@autor", author);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }


        public DataTable GetBooksByCota(string cota)
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
                         WHERE C.Cota = @cota
                         ORDER BY L.ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@cota", cota);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        return dt;
                    }
                }
            }
        }

        public DataTable GetBooksByEstado(string estado)
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
                         WHERE L.Estado = @estado
                         ORDER BY L.ID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@estado", estado);
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

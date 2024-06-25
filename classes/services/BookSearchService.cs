using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookSearchService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public DataTable GetBooksByNumeroRegistro(int numeroRegistro)
        {
            try
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
                                     WHERE L.ID = @ID
                                     ORDER BY L.ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ID", numeroRegistro);

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

        public DataTable GetBooksByAutor(string autor)
        {
            try
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
                                     WHERE A.Nome LIKE @autor
                                     ORDER BY L.ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@autor", autor + "%");

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

        public DataTable GetBooksByTitulo(string titulo)
        {
            try
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
                                     WHERE T.TituloNome LIKE @titulo
                                     ORDER BY L.ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@titulo", titulo + "%");

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

        public DataTable GetBooksByCota(string cota)
        {
            try
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
                                     WHERE C.Cota LIKE @cota
                                     ORDER BY L.ID";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cota", cota + "%");

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

        public DataTable GetBooksByAutor_Printing(string autor)
        {
            try
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
                                     WHERE A.Nome LIKE @Autor";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Autor", autor + "%");

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

        public DataTable GetBooksByTitulo_Printing(string titulo)
        {
            try
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
                                     WHERE T.TituloNome LIKE @Titulo";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", titulo + "%");

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

        public DataTable GetBooksByCota_Printing(string cota)
        {
            try
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
                                     WHERE C.Cota LIKE @Cota";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Cota", cota + "%");

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

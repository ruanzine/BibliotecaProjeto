using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.classes
{

    public class RegistoLivro : MainForm
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        
        public DataTable GetBooksByDate_Listing(DateTime dataDe, DateTime dataAte, int page, int itemsPerPage)
        {
            int offset = (page - 1) * itemsPerPage;
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], " +
                                                    "       T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, " +
                                                    "       L.Aquisicao AS [Aquisição], L.Editora AS [Editora], " +
                                                    "       L.NumVolume AS [Nº de Volume], L.Observacoes AS [Observações], L.Estado " +
                                                    "FROM Livros L " +
                                                    "INNER JOIN Titulos T ON T.ID = L.TituloID " +
                                                    "INNER JOIN Cotas C ON C.ID = L.CotaID " +
                                                    "INNER JOIN Autores A ON A.ID = L.AutorID " +
                                                    "WHERE L.DataDeEntrega BETWEEN @DataDe AND @DataAte " +
                                                    "ORDER BY L.DataDeEntrega " +
                                                    "OFFSET @Offset ROWS FETCH NEXT @ItemsPerPage ROWS ONLY", conn);
                command.Parameters.AddWithValue("@DataDe", dataDe);
                command.Parameters.AddWithValue("@DataAte", dataAte);
                command.Parameters.AddWithValue("@Offset", offset);
                command.Parameters.AddWithValue("@ItemsPerPage", itemsPerPage);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
        }

        public int GetBooksCountByDate(DateTime dataDe, DateTime dataAte)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Livros WHERE DataDeEntrega BETWEEN @DataDe AND @DataAte", conn);
                command.Parameters.AddWithValue("@DataDe", dataDe);
                command.Parameters.AddWithValue("@DataAte", dataAte);
                int totalCount = (int)command.ExecuteScalar();
                conn.Close();
                return totalCount;
            }
        }

        public DataTable GetAllBooksByDate(DateTime dataDe, DateTime dataAte)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], " +
                                                     "       T.TituloNome AS [Título], A.Nome AS Autor, C.Cota, " +
                                                     "       L.Aquisicao AS [Aquisição], L.Editora AS [Editora], " +
                                                     "       L.NumVolume AS [Nº de Volume], L.Estado, L.Observacoes AS [Observações]" +
                                                     "FROM Livros L " +
                                                     "INNER JOIN Titulos T ON T.ID = L.TituloID " +
                                                     "INNER JOIN Cotas C ON C.ID = L.CotaID " +
                                                     "INNER JOIN Autores A ON A.ID = L.AutorID " +
                                                     "WHERE L.DataDeEntrega BETWEEN @DataDe AND @DataAte " +
                                                     "ORDER BY L.DataDeEntrega", conn);
                command.Parameters.AddWithValue("@DataDe", dataDe);
                command.Parameters.AddWithValue("@DataAte", dataAte);
                SqlDataReader reader = command.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                conn.Close();

                return dataTable;
            }
        }

        public int GetTotalNRegCount(string searchText)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM
                        (SELECT L.ID
                         FROM Livros L
                         INNER JOIN Autores A ON L.AutorID = A.ID
                         INNER JOIN Cotas C ON L.CotaID = C.ID
                         INNER JOIN Titulos T ON L.TituloID = T.ID
                         WHERE L.ID LIKE @ID) AS CountResult";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@ID", searchText);

                int totalCount = (int)command.ExecuteScalar();
                conn.Close();

                return totalCount;
            }
        }
        public int GetTotalTitlesCount(string searchText)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM
                        (SELECT L.ID
                         FROM Livros L
                         INNER JOIN Autores A ON L.AutorID = A.ID
                         INNER JOIN Cotas C ON L.CotaID = C.ID
                         INNER JOIN Titulos T ON L.TituloID = T.ID
                         WHERE T.TituloNome LIKE @titulo) AS CountResult";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@titulo", $"{searchText}%");

                int totalCount = (int)command.ExecuteScalar();
                conn.Close();

                return totalCount;
            }
        }
        public int GetTotalAuthorsCount(string searchText)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM
                        (SELECT L.ID
                         FROM Livros L
                         INNER JOIN Autores A ON L.AutorID = A.ID
                         INNER JOIN Cotas C ON L.CotaID = C.ID
                         INNER JOIN Titulos T ON L.TituloID = T.ID
                         WHERE A.Nome LIKE @autor) AS CountResult";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@autor", $"{searchText}%");

                int totalCount = (int)command.ExecuteScalar();
                conn.Close();

                return totalCount;
            }
        }
        public int GetTotalCotasCount(string searchText)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT COUNT(*) FROM
                        (SELECT L.ID
                         FROM Livros L
                         INNER JOIN Autores A ON L.AutorID = A.ID
                         INNER JOIN Cotas C ON L.CotaID = C.ID
                         INNER JOIN Titulos T ON L.TituloID = T.ID
                         WHERE C.Cota LIKE @cota) AS CountResult";

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@cota", $"{searchText}%");

                int totalCount = (int)command.ExecuteScalar();
                conn.Close();

                return totalCount;
            }
        }

        public int GetTotalExemplares()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Livros";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting total exemplares: " + ex.Message);
            }
        }

        public int GetTotalAutores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Autores WHERE Nome <> '-'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting total autores: " + ex.Message);
            }
        }

        public int GetTotalCotas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Cotas WHERE Cota <> '-'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting total autores: " + ex.Message);
            }
        }

        public int GetTotalTitulos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = "SELECT COUNT(*) FROM Titulos WHERE TituloNome <> '-'";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error while getting total autores: " + ex.Message);
            }
        }

        public DataTable GetAllBooks_Printing()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT L.ID AS [Nº], L.DataDeEntrega AS [Data de Entrada], 
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
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter todos os livros: " + ex.Message);
            }
        }


    }
}

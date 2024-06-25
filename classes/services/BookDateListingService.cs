using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookDateListingService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

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
    }
}
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.services
{
    public class BookDateListingService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public DataTable GetAllBooksByDate(DateTime dateFrom, DateTime dateTo, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = @"SELECT B.RegistrationNumber AS [Nº], B.DeliveryDate AS [Data de Entrada], 
                                 T.TitleName AS [Título], A.Name AS Autor, C.Classification AS [Cota], 
                                 B.AcquisitionMethod AS [Aquisição], B.Publisher AS [Editora], 
                                 B.VolumeNumber AS [Nº de Volume], B.Condition AS [Estado], B.Observations AS [Observações]
                                 FROM Books B
                                 INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                 INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                 INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                 WHERE B.DeliveryDate BETWEEN @DateFrom AND @DateTo
                                 AND B.LibraryID = @LibraryID
                                 ORDER BY B.DeliveryDate";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@DateFrom", dateFrom);
                    command.Parameters.AddWithValue("@DateTo", dateTo);
                    command.Parameters.AddWithValue("@LibraryID", libraryID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        DataTable dataTable = new DataTable();
                        dataTable.Load(reader);
                        return dataTable;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.classes.services
{
    public class LibraryService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public Dictionary<string, int> GetLibraries()
        {
            var libraries = new Dictionary<string, int>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Name FROM Libraries";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("ID"));
                            string name = reader.GetString(reader.GetOrdinal("Name"));
                            libraries.Add(name, id);
                        }
                    }
                }
            }

            return libraries;
        }
    }
}

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.classes
{

    public class Livro
    {
        public int NumeroRegistro { get; set; }
        public DateTime DataEntrada { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Cota { get; set; }
        public string Aquisicao { get; set; }
        public string Editora { get; set; }
        public string NumeroVolume { get; set; }
        public string Observacoes { get; set; }
        public string Estado { get; set; }
    }

    public class RegistoLivro : MainForm
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public void SaveData(int nRegisto, DateTime dataEntrega, string titulo, string autor, string cota, string nVolume, string aquisicao, string editora, string observacoes, string estado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand("SaveData", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@id", nRegisto);
                        cmd.Parameters.AddWithValue("@dataEntrega", dataEntrega);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        cmd.Parameters.AddWithValue("@NumVolume", nVolume);
                        cmd.Parameters.AddWithValue("@cota", cota);
                        cmd.Parameters.AddWithValue("@aquisicao", aquisicao);
                        cmd.Parameters.AddWithValue("@editora", editora);
                        cmd.Parameters.AddWithValue("@observacoes", observacoes);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GetOrCreateEntityId(SqlConnection conn, string tableName, string columnName, string value)
        {
            string query = $"SELECT ID FROM {tableName} WHERE {columnName} = @value";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@value", value);

                object result = cmd.ExecuteScalar();
                if (result != null) // Entidade já existe, recuperar o ID
                {
                    return (int)result;
                }
                else // Entidade não existe, criar uma nova entrada e obter o ID
                {
                    cmd.CommandText = $"INSERT INTO {tableName} ({columnName}) VALUES (@value); SELECT SCOPE_IDENTITY();";
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
        public int GetNextRegistrationNumber()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string query = "SELECT MAX(ID) + 1 FROM Livros";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        return 1; // Se não houver registros, retorna 1 como próximo número de registro
                    }
                }
            }
        }


        public string GetId(string idRegisto)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT MAX(ID) + 1
                            FROM Livros";


                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        idRegisto = cmd.ExecuteScalar().ToString();
                        return idRegisto;
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }



    }
}

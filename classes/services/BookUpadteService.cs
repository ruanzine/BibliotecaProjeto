using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace BIBLIOTECA_PROJETO.classes.services
{
    public class BookUpdateService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        /// <summary>
        /// Updates the information of a book in the database.
        /// </summary>
        /// <param name="numeroRegistro">The registration number of the book.</param>
        /// <param name="dataEntrega">The delivery date of the book.</param>
        /// <param name="titulo">The title of the book.</param>
        /// <param name="autor">The author of the book.</param>
        /// <param name="cota">The call number of the book.</param>
        /// <param name="aquisicao">The acquisition type of the book.</param>
        /// <param name="editora">The publisher of the book.</param>
        /// <param name="numeroVolume">The volume number of the book.</param>
        /// <param name="observacoes">The observations of the book.</param>
        /// <param name="estado">The status of the book.</param>
        /// <exception cref="SqlException">Thrown when an error occurs while updating the book in the database.</exception>
        public void UpdateBook(int numeroRegistro, DateTime dataEntrega, string titulo, string autor, string cota, string aquisicao, string editora, string numeroVolume, string observacoes, string estado)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE Livros SET
                                DataDeEntrega = @dataEntrega,
                                TituloID = (SELECT ID FROM Titulos WHERE TituloNome = @titulo),
                                AutorID = (SELECT ID FROM Autores WHERE Nome = @autor),
                                CotaID = (SELECT ID FROM Cotas WHERE Cota = @cota),
                                Aquisicao = @aquisicao,
                                Editora = @editora,
                                NumVolume = @numeroVolume,
                                Observacoes = @observacoes,
                                Estado = @estado
                                WHERE ID = @numeroRegistro";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@dataEntrega", dataEntrega);
                        cmd.Parameters.AddWithValue("@titulo", titulo);
                        cmd.Parameters.AddWithValue("@autor", autor);
                        cmd.Parameters.AddWithValue("@cota", cota);
                        cmd.Parameters.AddWithValue("@aquisicao", aquisicao);
                        cmd.Parameters.AddWithValue("@editora", editora);
                        cmd.Parameters.AddWithValue("@numeroVolume", numeroVolume);
                        cmd.Parameters.AddWithValue("@observacoes", observacoes);
                        cmd.Parameters.AddWithValue("@estado", estado);
                        cmd.Parameters.AddWithValue("@numeroRegistro", numeroRegistro);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao atualizar o registro: " + ex.Message);
            }
        }

        public void DeleteBook(int numeroRegistro)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Livros WHERE ID = @NumeroRegistro", conn);
                command.Parameters.AddWithValue("@NumeroRegistro", numeroRegistro);
                command.ExecuteNonQuery();
                conn.Close();
            }
        }


        public bool IsRegistrationNumberExists(int registrationNumber)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Livros WHERE ID = @id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", registrationNumber);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public int GetAuthorID(string authorName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Autores WHERE Nome = @Nome";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", authorName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result;
                    else
                        return -1;
                }
            }
        }

        public int CreateAuthor(string authorName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Autores (Nome) VALUES (@Nome); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", authorName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Erro ao criar autor.");
                }
            }
        }

        public int GetCotaID(string cotaName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Cotas WHERE Cota = @Cota";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cota", cotaName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result;
                    else
                        return -1;
                }
            }
        }

        public int CreateCota(string cotaName)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Cotas (Cota) VALUES (@Cota); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Cota", cotaName);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Erro ao criar cota.");
                }
            }
        }

        /// <summary>
        /// Retrieves a list of books from the database for editing purposes.
        /// </summary>
        /// <returns>A list of books.</returns>
        /// <exception cref="SqlException">Thrown when an error occurs while retrieving the books from the database.</exception>
        public List<Livro> GetBooks_Edit()
        {
            try
            {
                List<Livro> livros = new List<Livro>();
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    string query = @"SELECT L.ID AS NumeroRegistro, L.DataDeEntrega, T.TituloNome AS Titulo, A.Nome AS Autor, C.Cota, L.Aquisicao, L.Editora, L.NumVolume AS NumeroVolume, L.Observacoes, L.Estado
                            FROM Livros L
                            INNER JOIN Autores A ON L.AutorID = A.ID
                            INNER JOIN Cotas C ON L.CotaID = C.ID
                            INNER JOIN Titulos T ON L.TituloID = T.ID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Livro livro = new Livro
                                {
                                    NumeroRegistro = reader.GetInt32(reader.GetOrdinal("NumeroRegistro")),
                                    DataEntrada = reader.GetDateTime(reader.GetOrdinal("DataDeEntrega")),
                                    Titulo = reader.GetString(reader.GetOrdinal("Titulo")),
                                    Autor = reader.GetString(reader.GetOrdinal("Autor")),
                                    Cota = reader.GetString(reader.GetOrdinal("Cota")),
                                    Aquisicao = reader.GetString(reader.GetOrdinal("Aquisicao")),
                                    Editora = reader.GetString(reader.GetOrdinal("Editora")),
                                    NumeroVolume = reader.GetString(reader.GetOrdinal("NumeroVolume")),
                                    Observacoes = reader.GetString(reader.GetOrdinal("Observacoes")),
                                    Estado = reader.GetString(reader.GetOrdinal("Estado"))
                                };
                                livros.Add(livro);
                            }
                        }
                    }
                }
                return livros;
            }
            catch (SqlException ex)
            {
                throw new Exception("Ocorreu um erro ao obter os livros: " + ex.Message);
            }
        }

    }
}
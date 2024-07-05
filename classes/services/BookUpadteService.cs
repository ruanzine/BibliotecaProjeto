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
        /// <param name="registrationNumber">The registration number of the book.</param>
        /// <param name="deliveryDate">The delivery date of the book.</param>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="classification">The classification of the book.</param>
        /// <param name="acquisitionMethod">The acquisition method of the book.</param>
        /// <param name="publisher">The publisher of the book.</param>
        /// <param name="volumeNumber">The volume number of the book.</param>
        /// <param name="observations">The observations about the book.</param>
        /// <param name="condition">The condition of the book.</param>
        /// <param name="libraryID">The ID of the library.</param>
        /// <exception cref="SqlException">Thrown when an error occurs while updating the book in the database.</exception>
        public void UpdateBook(int registrationNumber, DateTime deliveryDate, string title, string author, string classification, string acquisitionMethod, string publisher, string volumeNumber, string observations, string condition, int libraryID)
        {
            try
            {
                int authorID = GetAuthorID(author, libraryID);
                if (authorID == -1)
                    authorID = CreateAuthor(author, libraryID);

                int classificationID = GetClassificationID(classification, libraryID);
                if (classificationID == -1)
                    classificationID = CreateClassification(classification, libraryID);

                int titleID = GetTitleID(title, libraryID);
                if (titleID == -1)
                    titleID = CreateTitle(title, libraryID);

                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("UPDATE Books SET DeliveryDate = @deliveryDate, TitleID = @titleID, AuthorID = @authorID, ClassificationID = @classificationID, VolumeNumber = @volumeNumber, AcquisitionMethod = @acquisitionMethod, Publisher = @publisher, Observations = @observations, Condition = @condition WHERE RegistrationNumber = @id AND LibraryID = @libraryID", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", registrationNumber);
                        cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                        cmd.Parameters.AddWithValue("@titleID", titleID);
                        cmd.Parameters.AddWithValue("@AuthorID", authorID);
                        cmd.Parameters.AddWithValue("@classificationID", classificationID);
                        cmd.Parameters.AddWithValue("@volumeNumber", volumeNumber);
                        cmd.Parameters.AddWithValue("@acquisitionMethod", acquisitionMethod);
                        cmd.Parameters.AddWithValue("@publisher", publisher);
                        cmd.Parameters.AddWithValue("@observations", observations);
                        cmd.Parameters.AddWithValue("@condition", condition);
                        cmd.Parameters.AddWithValue("@libraryID", libraryID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while updating the book data: " + ex.Message);
            }
        }

        public void DeleteBook(int registrationNumber, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM Books WHERE RegistrationNumber = @registrationNumber AND LibraryID = @libraryID", conn);
                command.Parameters.AddWithValue("@registrationNumber", registrationNumber);
                command.Parameters.AddWithValue("@libraryID", libraryID);
                command.ExecuteNonQuery();

                // Clean up orphan records
                CleanOrphanRecords(conn, libraryID);
            }
        }


        public bool IsRegistrationNumberExists(int registrationNumber, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Books WHERE RegistrationNumber = @registrationNumber AND LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@registrationNumber", registrationNumber);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public int GetAuthorID(string authorName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Authors WHERE Name = @Name AND LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", authorName);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (int)result : -1;
                }
            }
        }

        public int CreateAuthor(string authorName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Authors (Name, LibraryID) VALUES (@Name, @libraryID); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", authorName);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : throw new Exception("Error creating author.");
                }
            }
        }

        public int GetClassificationID(string classificationName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Classifications WHERE Classification = @Classification AND LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Classification", classificationName);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (int)result : -1;
                }
            }
        }

        public int CreateClassification(string classificationName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Classifications (Classification, LibraryID) VALUES (@Classification, @libraryID); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Classification", classificationName);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : throw new Exception("Error creating classification.");
                }
            }
        }

        public int GetTitleID(string titleName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Titles WHERE TitleName = @Title AND LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", titleName);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? (int)result : -1;
                }
            }
        }

        public int CreateTitle(string titleName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Titles (TitleName, LibraryID) VALUES (@Title, @libraryID); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", titleName);
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : throw new Exception("Error creating title.");
                }
            }
        }

        /// <summary>
        /// Retrieves a list of books from the database for editing purposes.
        /// </summary>
        /// <returns>A list of books.</returns>
        /// <exception cref="SqlException">Thrown when an error occurs while retrieving the books from the database.</exception>
        public List<Livro> GetBooks_Edit(int libraryID)
        {
            try
            {
                List<Livro> livros = new List<Livro>();
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    string query = @"SELECT B.RegistrationNumber AS RegistrationNumber, B.DeliveryDate, T.TitleName AS Title, A.Name AS Author, C.Classification, B.AcquisitionMethod, B.Publisher, B.VolumeNumber, B.Observations, B.Condition
                                     FROM Books B
                                     INNER JOIN Authors A ON B.AuthorID = A.ID AND B.LibraryID = A.LibraryID
                                     INNER JOIN Classifications C ON B.ClassificationID = C.ID AND B.LibraryID = C.LibraryID
                                     INNER JOIN Titles T ON B.TitleID = T.ID AND B.LibraryID = T.LibraryID
                                     WHERE B.LibraryID = @libraryID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@libraryID", libraryID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Livro livro = new Livro
                                {
                                    RegistrationNumber = reader.GetInt32(reader.GetOrdinal("RegistrationNumber")),
                                    DeliveryDate = reader.GetDateTime(reader.GetOrdinal("DeliveryDate")),
                                    Title = reader.GetString(reader.GetOrdinal("Title")),
                                    Author = reader.GetString(reader.GetOrdinal("Author")),
                                    Classification = reader.GetString(reader.GetOrdinal("Classification")),
                                    AcquisitionMethod = reader.GetString(reader.GetOrdinal("AcquisitionMethod")),
                                    Publisher = reader.GetString(reader.GetOrdinal("Publisher")),
                                    VolumeNumber = reader.GetString(reader.GetOrdinal("VolumeNumber")),
                                    Observations = reader.GetString(reader.GetOrdinal("Observations")),
                                    Condition = reader.GetString(reader.GetOrdinal("Condition"))
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
                throw new Exception("An error occurred while retrieving the books: " + ex.Message);
            }
        }

        private void CleanOrphanRecords(SqlConnection conn, int libraryID)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = conn;

                // Clean orphan authors
                cmd.CommandText = @"
                DELETE FROM Authors
                WHERE LibraryID = @libraryID
                AND ID NOT IN (SELECT AuthorID FROM Books WHERE LibraryID = @libraryID)";
                cmd.Parameters.AddWithValue("@libraryID", libraryID);
                cmd.ExecuteNonQuery();

                // Clean orphan titles
                cmd.CommandText = @"
                DELETE FROM Titles
                WHERE LibraryID = @libraryID
                AND ID NOT IN (SELECT TitleID FROM Books WHERE LibraryID = @libraryID)";
                cmd.ExecuteNonQuery();

                // Clean orphan classifications
                cmd.CommandText = @"
                DELETE FROM Classifications
                WHERE LibraryID = @libraryID
                AND ID NOT IN (SELECT ClassificationID FROM Books WHERE LibraryID = @libraryID)";
                cmd.ExecuteNonQuery();
            }
        }



    }
}

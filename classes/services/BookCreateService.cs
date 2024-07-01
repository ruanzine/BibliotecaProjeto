using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.classes.services
{
    public class BookCreateService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public void SaveData(int registrationNumber, DateTime deliveryDate, string title, string author, string classification, string volumeNumber, string acquisitionMethod, string publisher, string observations, string condition, int libraryID)
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
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Books (ID, DeliveryDate, TitleID, AuthorID, ClassificationID, VolumeNumber, AcquisitionMethod, Publisher, Observations, Condition, LibraryID) VALUES (@id, @deliveryDate, @titleID, @authorID, @classificationID, @volumeNumber, @acquisitionMethod, @publisher, @observations, @condition, @libraryID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@id", registrationNumber);
                        cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                        cmd.Parameters.AddWithValue("@titleID", titleID);
                        cmd.Parameters.AddWithValue("@authorID", authorID);
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
                MessageBox.Show("An error occurred while saving the data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool IsRegistrationNumberExists(int registrationNumber, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Books WHERE ID = @id AND LibraryID = @LibraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", registrationNumber);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public int GetNextRegistrationNumber()
        {
            int nextRegistrationNumber = 1;
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Books ORDER BY ID ASC ";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int currentRegistrationNumber = reader.GetInt32(reader.GetOrdinal("ID"));
                            if (currentRegistrationNumber == nextRegistrationNumber)
                                nextRegistrationNumber++;
                            else
                                break;
                        }
                    }
                }
            }
            return nextRegistrationNumber;
        }

        public int GetAuthorID(string authorName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Authors WHERE Name = @Name AND LibraryID = @LibraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", authorName);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result;
                    else
                        return -1;
                }
            }
        }

        public int CreateAuthor(string authorName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Authors (Name, LibraryID) VALUES (@Name, @LibraryID); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", authorName);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Error creating author.");
                }
            }
        }

        public int GetClassificationID(string classificationName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Classifications WHERE Classification = @Classification AND LibraryID = @LibraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Classification", classificationName);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result;
                    else
                        return -1;
                }
            }
        }

        public int CreateClassification(string classificationName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Classifications (Classification, LibraryID) VALUES (@Classification, @LibraryID); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Classification", classificationName);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Error creating classification.");
                }
            }
        }

        public int GetTitleID(string titleName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ID FROM Titles WHERE TitleName = @Title AND LibraryID = @LibraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", titleName);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return (int)result;
                    else
                        return -1;
                }
            }
        }

        public int CreateTitle(string titleName, int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Titles (TitleName, LibraryID) VALUES (@Title, @LibraryID); SELECT SCOPE_IDENTITY()";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", titleName);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                        return Convert.ToInt32(result);
                    else
                        throw new Exception("Error creating title.");
                }
            }
        }

        public string GetNextId(int libraryID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    string query = "SELECT MAX(ID) + 1 FROM Books WHERE LibraryID = @LibraryID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LibraryID", libraryID);
                        object result = cmd.ExecuteScalar();
                        return result != null ? result.ToString() : "1";
                    }
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("An error occurred while fetching the next book ID: " + ex.Message);
            }
        }

        public List<string> GetTitlesBySearch(string searchText, int libraryID)
        {
            List<string> titles = new List<string>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT TitleName FROM Titles WHERE TitleName LIKE @searchText + '%' AND LibraryID = @LibraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", searchText);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            titles.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return titles;
        }

        public List<string> GetAuthorsBySearch(string searchText, int libraryID)
        {
            List<string> authors = new List<string>();
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT Name FROM Authors WHERE Name LIKE @searchText + '%' AND LibraryID = @LibraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@searchText", searchText);
                    cmd.Parameters.AddWithValue("@LibraryID", libraryID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            authors.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return authors;
        }
    }
}

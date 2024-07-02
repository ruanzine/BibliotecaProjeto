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

        public void SaveData(DateTime deliveryDate, string title, string author, string classification, string volumeNumber, string acquisitionMethod, string publisher, string observations, string condition, int libraryID)
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

                int registrationNumber = GetNextRegistrationNumber(libraryID);

                using (SqlConnection conn = new SqlConnection(this.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Books (LibraryID, RegistrationNumber, DeliveryDate, TitleID, AuthorID, ClassificationID, VolumeNumber, AcquisitionMethod, Publisher, Observations, Condition) VALUES (@libraryID, @registrationNumber, @deliveryDate, @titleID, @authorID, @classificationID, @volumeNumber, @acquisitionMethod, @publisher, @observations, @condition)", conn))
                    {
                        cmd.Parameters.AddWithValue("@libraryID", libraryID);
                        cmd.Parameters.AddWithValue("@registrationNumber", registrationNumber);
                        cmd.Parameters.AddWithValue("@deliveryDate", deliveryDate);
                        cmd.Parameters.AddWithValue("@titleID", titleID);
                        cmd.Parameters.AddWithValue("@authorID", authorID);
                        cmd.Parameters.AddWithValue("@classificationID", classificationID);
                        cmd.Parameters.AddWithValue("@volumeNumber", volumeNumber);
                        cmd.Parameters.AddWithValue("@acquisitionMethod", acquisitionMethod);
                        cmd.Parameters.AddWithValue("@publisher", publisher);
                        cmd.Parameters.AddWithValue("@observations", observations);
                        cmd.Parameters.AddWithValue("@condition", condition);

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

        public int GetNextRegistrationNumber(int libraryID)
        {
            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                conn.Open();
                string query = "SELECT ISNULL(MAX(RegistrationNumber), 0) + 1 FROM Books WHERE LibraryID = @libraryID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@libraryID", libraryID);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
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
                    return result != null ? (int)result : -1;
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
                    return Convert.ToInt32(cmd.ExecuteScalar());
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
                    return result != null ? (int)result : -1;
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
                    return Convert.ToInt32(cmd.ExecuteScalar());
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
                    return result != null ? (int)result : -1;
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
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
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

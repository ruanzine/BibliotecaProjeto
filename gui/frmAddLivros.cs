using BIBLIOTECA_PROJETO.classes.services;
using BIBLIOTECA_PROJETO.controls;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    /// <summary>
    /// Represents a form for adding new books to the library.
    /// </summary>
    public partial class frmAddLivros : Form
    {
        MainForm mainForm = new MainForm();
        private BookCreateService createService = new BookCreateService();
        private string id;
        private ListBox listBoxSuggestionsTitle;
        private ListBox listBoxSuggestionsAuthor;
        private int libraryID;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddLivros"/> class.
        /// </summary>
        public frmAddLivros(int selectedLibraryID) // Pass the library ID in the constructor
        {
            InitializeComponent();
            mainForm.AddControlBounds(this.pnlAddLivros);
            InitializeSuggestionListBoxes();
            this.libraryID = selectedLibraryID; // Store the library ID
        }

        #region Initialization

        /// <summary>
        /// Initializes the suggestion ListBox controls for Title and Author.
        /// </summary>
        private void InitializeSuggestionListBoxes()
        {
            int maxHeight = 100; // Define the maximum height for the ListBox
            int itemHeight = 30; // Define the item height
            Font itemFont = new Font("Arial", 12); // Define the item font

            // Initialize ListBox for Title suggestions
            listBoxSuggestionsTitle = new ListBox
            {
                Visible = false,
                DrawMode = DrawMode.OwnerDrawFixed,
                IntegralHeight = false,
                ItemHeight = itemHeight,
                Font = itemFont,
                MaximumSize = new Size(txtTitulo.Width, maxHeight) // Set the maximum height
            };
            listBoxSuggestionsTitle.MouseClick += listBoxSuggestionsTitle_MouseClick;
            listBoxSuggestionsTitle.DrawItem += listBoxSuggestions_DrawItem;
            this.Controls.Add(listBoxSuggestionsTitle);

            // Initialize ListBox for Author suggestions
            listBoxSuggestionsAuthor = new ListBox
            {
                Visible = false,
                DrawMode = DrawMode.OwnerDrawFixed,
                IntegralHeight = false,
                ItemHeight = itemHeight,
                Font = itemFont,
                MaximumSize = new Size(txtAutor.Width, maxHeight) // Set the maximum height
            };
            listBoxSuggestionsAuthor.MouseClick += listBoxSuggestionsAuthor_MouseClick;
            listBoxSuggestionsAuthor.DrawItem += listBoxSuggestions_DrawItem;
            this.Controls.Add(listBoxSuggestionsAuthor);
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the Load event of the form to initialize components and event handlers.
        /// </summary>
        private void frmAddLivros_Load(object sender, EventArgs e)
        {
            GetNRegisto();
            txtTitulo._TextChanged += txtTitulo_TextChanged;
            txtAutor._TextChanged += txtAutor_TextChanged;
        }

        /// <summary>
        /// Handles the TextChanged event of the Title TextBox to show suggestions.
        /// </summary>
        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            // Use lambda expression to pass the correct delegate
            ShowSuggestions(txtTitulo, listBoxSuggestionsTitle, searchText => createService.GetTitlesBySearch(searchText, this.libraryID));
        }

        /// <summary>
        /// Handles the TextChanged event of the Author TextBox to show suggestions.
        /// </summary>
        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            // Use lambda expression to pass the correct delegate
            ShowSuggestions(txtAutor, listBoxSuggestionsAuthor, searchText => createService.GetAuthorsBySearch(searchText, this.libraryID));
        }

        /// <summary>
        /// Handles the MouseClick event of the Title suggestion ListBox to select a suggestion.
        /// </summary>
        private void listBoxSuggestionsTitle_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsTitle, txtTitulo);
        }

        /// <summary>
        /// Handles the MouseClick event of the Author suggestion ListBox to select a suggestion.
        /// </summary>
        private void listBoxSuggestionsAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsAuthor, txtAutor);
        }

        /// <summary>
        /// Handles the DrawItem event of the suggestion ListBox to customize item drawing.
        /// </summary>
        private void listBoxSuggestions_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;

            // Determine the color
            Color backgroundColor = ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                ? Color.LightGray
                : listBox.BackColor;

            // Draw the background
            e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            // Draw the text
            e.Graphics.DrawString(listBox.Items[e.Index].ToString(), e.Font, new SolidBrush(listBox.ForeColor), e.Bounds);

            // Draw the focus rectangle if the mouse is over an item
            e.DrawFocusRectangle();
        }

        /// <summary>
        /// Handles the Click event of the Save button to save the book data.
        /// </summary>
        private void bttSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        /// <summary>
        /// Handles the Click event of the Clear button to clear the form fields.
        /// </summary>
        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        /// <summary>
        /// Handles the KeyPress event of the DeliveryDate TextBox to validate date input.
        /// </summary>
        private void txtDataEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPressForDate(e);
        }

        /// <summary>
        /// Handles the KeyPress event of the RegistrationNumber TextBox to validate numeric input.
        /// </summary>
        private void txtNRegisto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPressForNumber(e);
        }

        /// <summary>
        /// Handles the Resize event of the form to resize controls.
        /// </summary>
        private void pnlAddLivros_Resize(object sender, EventArgs e)
        {
            mainForm.ResizeControls(pnlAddLivros);
        }

        #endregion

        #region Helper Methods

        /// <summary>
        /// Shows suggestions in the ListBox based on the input in the TextBox.
        /// </summary>
        /// <param name="textBox">The TextBox containing the input text.</param>
        /// <param name="listBox">The ListBox to display suggestions.</param>
        /// <param name="getSuggestions">The function to get suggestions based on the input text.</param>
        private void ShowSuggestions(UC_textbox textBox, ListBox listBox, Func<string, List<string>> getSuggestions)
        {
            string searchText = textBox.Texts.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                listBox.Visible = false;
                return;
            }

            List<string> suggestions = getSuggestions(searchText);
            if (suggestions.Count > 0)
            {
                listBox.Items.Clear();
                listBox.Items.AddRange(suggestions.ToArray());
                listBox.Visible = true;

                // Calculate and set the height
                int requiredHeight = Math.Min(listBox.ItemHeight * suggestions.Count, listBox.MaximumSize.Height);
                listBox.Height = requiredHeight;

                // Adjust position
                Point textBoxLocation = textBox.PointToScreen(Point.Empty);
                Point parentLocation = this.PointToScreen(Point.Empty);
                listBox.Location = new Point(textBoxLocation.X - parentLocation.X, textBoxLocation.Y - parentLocation.Y + textBox.Height);

                listBox.Width = textBox.Width;
                listBox.BringToFront();
            }
            else
            {
                listBox.Visible = false;
            }
        }

        /// <summary>
        /// Selects a suggestion from the ListBox and sets it in the TextBox.
        /// </summary>
        /// <param name="listBox">The ListBox containing the suggestions.</param>
        /// <param name="textBox">The TextBox to set the selected suggestion.</param>
        private void SelectSuggestion(ListBox listBox, UC_textbox textBox)
        {
            if (listBox.SelectedItem != null)
            {
                textBox.Texts = listBox.SelectedItem.ToString();
                listBox.Visible = false;
            }
        }

        /// <summary>
        /// Validates the KeyPress event for date input to allow only digits, slash, and control characters.
        /// </summary>
        /// <param name="e">The KeyPressEventArgs instance containing the event data.</param>
        private void ValidateKeyPressForDate(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Validates the KeyPress event for numeric input to allow only digits and control characters.
        /// </summary>
        /// <param name="e">The KeyPressEventArgs instance containing the event data.</param>
        private void ValidateKeyPressForNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            MainForm form = new MainForm();
            this.KeyPress += form.MainForm_KeyPress;
        }

        /// <summary>
        /// Gets the next registration number for the book.
        /// </summary>
        private void GetNRegisto()
        {
            try
            {
                txtNRegisto.Texts = createService.GetNextId(this.libraryID).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while getting the next registration number from the database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Saves the book data entered in the form.
        /// </summary>
        private void SaveData()
        {
            if (!ValidateFormFields()) return;

            DateTime deliveryDate = DateTime.ParseExact(txtDataEntrega.Texts.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int registrationNumber = int.Parse(txtNRegisto.Texts.Trim());
            string title = txtTitulo.Texts.Trim();
            string author = txtAutor.Texts.Trim();
            string classification = txtCota.Texts.Trim();
            string volumeNumber = txtNVolume.Texts.Trim();
            string acquisitionMethod = cbxAquisicao.Text;
            string publisher = txtEditora.Texts.Trim();
            string observations = txtObservacoes.Texts.Trim();
            string condition = cbxEstado.Text;

            if (createService.IsRegistrationNumberExists(registrationNumber, this.libraryID))
            {
                MessageBox.Show("The registration number is already in use. Please choose another number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                createService.SaveData(registrationNumber, deliveryDate, title, author, classification, volumeNumber, acquisitionMethod, publisher, observations, condition, libraryID);
                MessageBox.Show("Book successfully added.", "Success", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtNRegisto.Texts = (registrationNumber + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Failed to register the book.", "Failure", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        /// <summary>
        /// Validates the form fields before saving data.
        /// </summary>
        /// <returns>true if all fields are valid; otherwise, false.</returns>
        private bool ValidateFormFields()
        {
            return ValidateTextBox(txtNRegisto, "the book registration number") &&
                   ValidateTextBox(txtDataEntrega, "the book delivery date") &&
                   ValidateTextBox(txtTitulo, "the book title") &&
                   ValidateTextBox(txtAutor, "the book author") &&
                   ValidateTextBox(txtCota, "the book classification") &&
                   ValidateTextBox(txtNVolume, "the book volume number") &&
                   ValidateTextBox(txtEditora, "the book publisher") &&
                   ValidateComboBox(this.cbxAquisicao, "the book acquisition method") &&
                   ValidateComboBox(this.cbxEstado, "the book condition");
        }

        /// <summary>
        /// Validates a TextBox to ensure it contains a value.
        /// </summary>
        /// <param name="textBox">The TextBox to validate.</param>
        /// <param name="fieldName">The name of the field for error messages.</param>
        /// <returns>true if the TextBox contains a value; otherwise, false.</returns>
        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            string text = textBox.Texts?.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"Please enter {fieldName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox == txtDataEntrega && !DateTime.TryParseExact(text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show($"Please enter {fieldName} in the format dd/MM/yyyy.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Validates a ComboBox to ensure it contains a selected value.
        /// </summary>
        /// <param name="comboBox">The ComboBox to validate.</param>
        /// <param name="fieldName">The name of the field for error messages.</param>
        /// <returns>true if the ComboBox contains a selected value; otherwise, false.</returns>
        private bool ValidateComboBox(MetroComboBox comboBox, string fieldName)
        {
            if (comboBox.Text == "<Aquisição>" || comboBox.Text == "<Estado>")
            {
                MessageBox.Show($"Please select {fieldName}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Clears all text fields in the form.
        /// </summary>
        private void ClearText()
        {
            txtDataEntrega.Texts = "";
            txtAutor.Texts = "";
            txtTitulo.Texts = "";
            txtCota.Texts = "";
            txtNVolume.Texts = "";
            txtEditora.Texts = "";
            txtObservacoes.Texts = "";
            cbxAquisicao.Text = "<Aquisição>";
            cbxEstado.Text = "<Estado>";
        }

        #endregion
    }
}

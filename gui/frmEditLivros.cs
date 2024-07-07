using BIBLIOTECA_PROJETO.classes;
using BIBLIOTECA_PROJETO.classes.services;
using BIBLIOTECA_PROJETO.controls;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    /// <summary>
    /// Represents the form for editing book records.
    /// </summary>
    public partial class frmEditLivros : Form
    {
        MainForm mainForm = new MainForm();
        private BookUpdateService bookUpdateService = new BookUpdateService();
        public string _titulo, _autor, _cota, _editora, _obsrvacoes, _estado;
        public int _nregisto, _nvolume;
        public int libraryID;
        private ThemeColors currentThemeColors;
        private ToolTip toolTip = new ToolTip();
        private ErrorProvider errorProvider = new ErrorProvider();
        private ListBox listBoxSuggestionsTitle;
        private ListBox listBoxSuggestionsAuthor;

        private readonly Dictionary<int, ThemeColors> themeColors = new Dictionary<int, ThemeColors>
        {
            { 1, new ThemeColors(Color.FromArgb(252, 168, 183), Color.FromArgb(255, 102, 106), Color.FromArgb(64, 12, 3), Color.FromArgb(121, 57, 59), Color.FromArgb(64, 12, 3)) },
            { 2, new ThemeColors(Color.FromArgb(146, 211, 157), Color.FromArgb(71, 174, 88), Color.FromArgb(6, 54, 49), Color.FromArgb(10, 97, 69), Color.FromArgb(6, 54, 49)) },
            { 3, new ThemeColors(Color.FromArgb(151, 199, 234), Color.FromArgb(103, 166, 229), Color.FromArgb(23, 23, 55), Color.FromArgb(56, 83, 117), Color.FromArgb(33, 50, 88)) }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="frmEditLivros"/> class.
        /// </summary>
        public frmEditLivros(int selectedLibraryId)
        {
            InitializeComponent();
            mainForm.AddControlBounds(this.pnlEditLivros);
            this.libraryID = selectedLibraryId;
            InitializeSuggestionListBoxes();
            SetThemeColors();

            // Set the MaxDate of the DateTimePicker to today's date
            dtpArrivalDate.MaxDate = DateTime.Today;

            this.txtTitle._TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            this.txtAuthor._TextChanged += new System.EventHandler(this.txtAuthor_TextChanged);

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
                MaximumSize = new Size(txtTitle.Width, maxHeight) // Set the maximum height
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
                MaximumSize = new Size(txtAuthor.Width, maxHeight) // Set the maximum height
            };
            listBoxSuggestionsAuthor.MouseClick += listBoxSuggestionsAuthor_MouseClick;
            listBoxSuggestionsAuthor.DrawItem += listBoxSuggestions_DrawItem;
            this.Controls.Add(listBoxSuggestionsAuthor);
        }

        #endregion

        #region Theme Setting

        private void SetThemeColors()
        {
            if (themeColors.TryGetValue(libraryID, out currentThemeColors))
            {
                bttSave_Edit.BackColor = currentThemeColors.ButtonColor;
                bttSearchEdit.BackColor = currentThemeColors.ButtonColor;
                lblTitle.ForeColor = currentThemeColors.ButtonColor;
                pnlFormFooter.BackColor = currentThemeColors.PanelHeaderColor;
                pnlFormBody.BackColor = currentThemeColors.PanelBodyColor;
                pnlFormHeader.BackColor = currentThemeColors.PanelHeaderColor;
                pnlLineBottom.BackColor = currentThemeColors.ButtonColor;
                pnlLineTop.BackColor = currentThemeColors.ButtonColor;
                lblRegNum.ForeColor = currentThemeColors.LabelColor;
                lblArrivalDate.ForeColor = currentThemeColors.LabelColor;
                lblTitleBody.ForeColor = currentThemeColors.LabelColor;
                lblAuthor.ForeColor = currentThemeColors.LabelColor;
                lblPublisher.ForeColor = currentThemeColors.LabelColor;
                lblAcquisition.ForeColor = currentThemeColors.LabelColor;
                lblClassification.ForeColor = currentThemeColors.LabelColor;
                lblObservations.ForeColor = currentThemeColors.LabelColor;
                lblVolNum.ForeColor = currentThemeColors.LabelColor;
                lblCondition.ForeColor = currentThemeColors.LabelColor;
                gpbTop.BackColor = currentThemeColors.PanelBodyColor;
                gpbBottom.BackColor = currentThemeColors.PanelBodyColor;
                gpbMid.BackColor = currentThemeColors.PanelBodyColor;
                gpbTop.ForeColor = currentThemeColors.GroupBoxColor;
                gpbBottom.ForeColor = currentThemeColors.GroupBoxColor;
                gpbMid.ForeColor = currentThemeColors.GroupBoxColor;

                ApplyThemeToTextboxes(gpbTop);
                ApplyThemeToTextboxes(gpbBottom);
                ApplyThemeToTextboxes(gpbMid);
            }
        }

        private void ApplyThemeToTextboxes(Control parent)
        {
            foreach (UC_textbox textBox in parent.Controls.OfType<UC_textbox>())
            {
                textBox.BorderColor = currentThemeColors.LabelColor;
                textBox.BorderFocusColor = currentThemeColors.LabelColor;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the Click event of the Save button, updating the book record.
        /// </summary>
        private void bttSave_Edit_Click(object sender, EventArgs e)
        {
            if (!ValidateFormFields()) return;

            try
            {
                int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts.Trim());
                DateTime dataEntrega = dtpArrivalDate.Value;
                string titulo = this.txtTitle.Texts.Trim();
                string autor = this.txtAuthor.Texts.Trim();
                string cota = this.txtClassification.Texts.Trim();
                string aquisicao = this.cbxAcquisition.Text;
                string editora = this.txtPublisher.Texts.Trim();
                string numeroVolume = this.txtVolNum.Texts.Trim();
                string observacoes = this.txtObservations.Texts.Trim();
                string estado = this.cbxCondition.Text;

                int autorID = bookUpdateService.GetAuthorID(autor, libraryID);
                if (autorID == -1)
                    autorID = bookUpdateService.CreateAuthor(autor, libraryID);

                int cotaID = bookUpdateService.GetClassificationID(cota, libraryID);
                if (cotaID == -1)
                    cotaID = bookUpdateService.CreateClassification(cota, libraryID);

                bookUpdateService.UpdateBook(numeroRegistro, dataEntrega, titulo, autor, cota, aquisicao, editora, numeroVolume, observacoes, estado, libraryID);

                Toast.ShowToast("Registo atualizado com sucesso.");
                ClearText();
                UnableText();
                bttSave_Edit.Enabled = false;
                txtNRegisto_Edit.Enabled = true;
                txtNRegisto_Edit.Texts = "";
            }
            catch (Exception ex)
            {
                Toast.ShowToast("Ocorreu um erro ao atualizar o registro: " + ex.Message, 5000); // Show for 5 seconds
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear button, clearing the form fields.
        /// </summary>
        private void bttClear_Edit_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        /// <summary>
        /// Handles the KeyPress event for the Número de Registo textbox, ensuring only numeric input.
        /// </summary>
        private void txtNRegisto_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        /// <summary>
        /// Handles the Click event of the Search button, loading the book record for editing.
        /// </summary>
        private void bttSearchEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar")) return;

            int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts);
            UnableText();
            FillTextBoxes(numeroRegistro);
        }

        /// <summary>
        /// Handles the Click event of the Delete button, deleting the book record.
        /// </summary>
        private void bttDel_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtNRegisto_Edit, "o número de registo do exemplar")) return;

            int numeroRegistro = int.Parse(txtNRegisto_Edit.Texts.Trim());
            try
            {
                if (bookUpdateService.IsRegistrationNumberExists(numeroRegistro, libraryID))
                {
                    DialogResult result = MessageBox.Show("Tem certeza de que deseja eliminar este registo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        bookUpdateService.DeleteBook(numeroRegistro, libraryID);
                        Toast.ShowToast("Registo excluído com sucesso.");
                        ClearText();
                        UnableText();
                        bttSave_Edit.Enabled = false;
                        txtNRegisto_Edit.Enabled = true;
                    }
                }
                else
                {
                    Toast.ShowToast("O livro com este número de registo não existe.", 5000); // Show for 5 seconds
                }
            }
            catch (Exception ex)
            {
                Toast.ShowToast("Ocorreu um erro ao excluir o registro: " + ex.Message, 5000); // Show for 5 seconds
            }
        }

        /// <summary>
        /// Handles the Paint event of the form body panel.
        /// </summary>
        private void pnlFormBody_Paint(object sender, PaintEventArgs e) { }

        /// <summary>
        /// Handles the Enter event of the Author group box.
        /// </summary>
        private void gpbAutor_Edit_Enter(object sender, EventArgs e) { }

        /// <summary>
        /// Handles the TextChanged event of the Title TextBox to show suggestions.
        /// </summary>
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(txtTitle, listBoxSuggestionsTitle, searchText => bookUpdateService.GetTitlesBySearch(searchText, this.libraryID));
        }

        /// <summary>
        /// Handles the TextChanged event of the Author TextBox to show suggestions.
        /// </summary>
        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(txtAuthor, listBoxSuggestionsAuthor, searchText => bookUpdateService.GetAuthorsBySearch(searchText, this.libraryID));
        }

        /// <summary>
        /// Handles the MouseClick event of the Title suggestion ListBox to select a suggestion.
        /// </summary>
        private void listBoxSuggestionsTitle_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsTitle, txtTitle);
        }

        /// <summary>
        /// Handles the MouseClick event of the Author suggestion ListBox to select a suggestion.
        /// </summary>
        private void listBoxSuggestionsAuthor_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsAuthor, txtAuthor);
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
        /// Fills the form fields with the data of the specified book record.
        /// </summary>
        /// <param name="numeroRegistro">The registration number of the book to load.</param>
        private void FillTextBoxes(int numeroRegistro)
        {
            List<Book> livros = bookUpdateService.GetBooks_Edit(libraryID);
            Book livroSelecionado = livros.FirstOrDefault(livro => livro.RegistrationNumber == numeroRegistro);
            if (livroSelecionado != null)
            {
                this.dtpArrivalDate.Value = livroSelecionado.DeliveryDate;
                this.txtTitle.Texts = livroSelecionado.Title;
                this.txtAuthor.Texts = livroSelecionado.Author;
                this.txtClassification.Texts = livroSelecionado.Classification;
                this.cbxAcquisition.Text = livroSelecionado.AcquisitionMethod;
                this.txtPublisher.Texts = livroSelecionado.Publisher;
                this.txtVolNum.Texts = livroSelecionado.VolumeNumber;
                this.txtObservations.Texts = livroSelecionado.Observations;
                this.cbxCondition.Text = livroSelecionado.Condition;
                this.txtNRegisto_Edit.Enabled = false;
                this.EnableText();
            }
            else
            {
                Toast.ShowToast("Livro não encontrado.", 5000); // Show for 5 seconds
                this.txtNRegisto_Edit.Enabled = true;
            }
        }

        /// <summary>
        /// Validates the form fields to ensure they are correctly filled.
        /// </summary>
        /// <returns>True if all fields are valid, otherwise false.</returns>
        private bool ValidateFormFields()
        {
            return ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar") &&
                   ValidateTextBox(this.txtTitle, "o título do exemplar") &&
                   ValidateTextBox(this.txtAuthor, "o autor do exemplar") &&
                   ValidateTextBox(this.txtClassification, "a cota do exemplar") &&
                   ValidateTextBox(this.txtVolNum, "o número de volume do exemplar") &&
                   ValidateTextBox(this.txtPublisher, "a editora do exemplar") &&
                   ValidateComboBox(this.cbxAcquisition, "o método de aquisição do exemplar") &&
                   ValidateComboBox(this.cbxCondition, "o estado do exemplar");
        }

        /// <summary>
        /// Validates a textbox to ensure it contains a valid value.
        /// </summary>
        /// <param name="textBox">The textbox to validate.</param>
        /// <param name="fieldName">The name of the field for error messages.</param>
        /// <returns>True if the textbox is valid, otherwise false.</returns>
        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            string text = textBox.Texts?.Trim();
            if (string.IsNullOrEmpty(text))
            {
                ShowError($"Por favor, insira {fieldName}.", textBox);
                return false;
            }
            ClearError(textBox);
            return true;
        }

        /// <summary>
        /// Validates a combobox to ensure it contains a valid selection.
        /// </summary>
        /// <param name="comboBox">The combobox to validate.</param>
        /// <param name="fieldName">The name of the field for error messages.</param>
        /// <returns>True if the combobox is valid, otherwise false.</returns>
        private bool ValidateComboBox(MetroComboBox comboBox, string fieldName)
        {
            if (comboBox.Text == "" || comboBox.Text == "")
            {
                ShowError($"Por favor, selecione {fieldName}.", comboBox);
                return false;
            }
            ClearError(comboBox);
            return true;
        }

        /// <summary>
        /// Clears the form fields.
        /// </summary>
        private void ClearText()
        {
            this.txtAuthor.Texts = "";
            this.txtTitle.Texts = "";
            this.txtClassification.Texts = "";
            this.txtPublisher.Texts = "";
            this.txtVolNum.Texts = "";
            this.txtObservations.Texts = "";
            this.cbxCondition.SelectedIndex = -1;
            this.cbxAcquisition.SelectedIndex = -1;
        }

        /// <summary>
        /// Enables the form fields for editing.
        /// </summary>
        private void EnableText()
        {
            this.dtpArrivalDate.Enabled = true;
            this.txtAuthor.Enabled = true;
            this.txtTitle.Enabled = true;
            this.txtClassification.Enabled = true;
            this.txtPublisher.Enabled = true;
            this.cbxCondition.Enabled = true;
            this.cbxAcquisition.Enabled = true;
            this.txtVolNum.Enabled = true;
            this.txtObservations.Enabled = true;
            this.bttClear_Edit.Enabled = true;
            this.bttDel.Enabled = true;
            this.bttSave_Edit.Enabled = true;
        }

        /// <summary>
        /// Disables the form fields and clears their contents.
        /// </summary>
        private void UnableText()
        {
            this.txtNRegisto_Edit.Focus();
            this.dtpArrivalDate.Enabled = false;
            this.txtAuthor.Enabled = false;
            this.txtTitle.Enabled = false;
            this.txtClassification.Enabled = false;
            this.txtClassification.Enabled = false;
            this.txtPublisher.Enabled = false;
            this.cbxCondition.Enabled = false;
            this.cbxAcquisition.Enabled = false;
            this.txtVolNum.Enabled = false;
            this.txtObservations.Enabled = false;
            this.bttClear_Edit.Enabled = false;
            this.bttDel.Enabled = false;
            this.bttSave_Edit.Enabled = false;
            ClearText();
        }

        /// <summary>
        /// Displays an error message using an ErrorProvider.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        /// <param name="control">The control to which the error message relates.</param>
        private void ShowError(string message, Control control)
        {
            errorProvider.SetError(control, message);
        }

        /// <summary>
        /// Clears the error message from an ErrorProvider.
        /// </summary>
        /// <param name="control">The control from which to clear the error message.</param>
        private void ClearError(Control control)
        {
            errorProvider.SetError(control, "");
        }

        #endregion

        private class ThemeColors
        {
            public Color ButtonColor { get; }
            public Color PanelHeaderColor { get; }
            public Color PanelBodyColor { get; }
            public Color LabelColor { get; }
            public Color GroupBoxColor { get; }

            public ThemeColors(Color panelHeaderColor, Color panelBodyColor, Color labelColor, Color buttonColor, Color groupBoxColor)
            {
                PanelHeaderColor = panelHeaderColor;
                PanelBodyColor = panelBodyColor;
                LabelColor = labelColor;
                ButtonColor = buttonColor;
                GroupBoxColor = groupBoxColor;
            }
        }
    }
}

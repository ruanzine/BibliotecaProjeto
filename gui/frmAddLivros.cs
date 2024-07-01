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
        private LivroService livroService = new LivroService();
        private string id;
        private ListBox listBoxSuggestionsTitulo;
        private ListBox listBoxSuggestionsAutor;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmAddLivros"/> class.
        /// </summary>
        public frmAddLivros()
        {
            InitializeComponent();
            mainForm.AddControlBounds(this.pnlAddLivros);
            InitializeSuggestionListBoxes();
        }

        #region Initialization

        /// <summary>
        /// Initializes the suggestion ListBox controls for Título and Autor.
        /// </summary>
        private void InitializeSuggestionListBoxes()
        {
            int maxHeight = 100; // Define the maximum height for the ListBox
            int itemHeight = 30; // Define the item height
            Font itemFont = new Font("Arial", 12); // Define the item font

            // Initialize ListBox for Título suggestions
            listBoxSuggestionsTitulo = new ListBox
            {
                Visible = false,
                DrawMode = DrawMode.OwnerDrawFixed,
                IntegralHeight = false,
                ItemHeight = itemHeight,
                Font = itemFont,
                MaximumSize = new Size(txtTitulo.Width, maxHeight) // Set the maximum height
            };
            listBoxSuggestionsTitulo.MouseClick += listBoxSuggestionsTitulo_MouseClick;
            listBoxSuggestionsTitulo.DrawItem += listBoxSuggestions_DrawItem;
            this.Controls.Add(listBoxSuggestionsTitulo);

            // Initialize ListBox for Autor suggestions
            listBoxSuggestionsAutor = new ListBox
            {
                Visible = false,
                DrawMode = DrawMode.OwnerDrawFixed,
                IntegralHeight = false,
                ItemHeight = itemHeight,
                Font = itemFont,
                MaximumSize = new Size(txtAutor.Width, maxHeight) // Set the maximum height
            };
            listBoxSuggestionsAutor.MouseClick += listBoxSuggestionsAutor_MouseClick;
            listBoxSuggestionsAutor.DrawItem += listBoxSuggestions_DrawItem;
            this.Controls.Add(listBoxSuggestionsAutor);
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
        /// Handles the TextChanged event of the Título TextBox to show suggestions.
        /// </summary>
        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(txtTitulo, listBoxSuggestionsTitulo, livroService.GetTitlesBySearch);
        }

        /// <summary>
        /// Handles the TextChanged event of the Autor TextBox to show suggestions.
        /// </summary>
        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(txtAutor, listBoxSuggestionsAutor, livroService.GetAuthorsBySearch);
        }

        /// <summary>
        /// Handles the MouseClick event of the Título suggestion ListBox to select a suggestion.
        /// </summary>
        private void listBoxSuggestionsTitulo_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsTitulo, txtTitulo);
        }

        /// <summary>
        /// Handles the MouseClick event of the Autor suggestion ListBox to select a suggestion.
        /// </summary>
        private void listBoxSuggestionsAutor_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsAutor, txtAutor);
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
        /// Handles the KeyPress event of the DataEntrega TextBox to validate date input.
        /// </summary>
        private void txtDataEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPressForDate(e);
        }

        /// <summary>
        /// Handles the KeyPress event of the NRegisto TextBox to validate numeric input.
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
                txtNRegisto.Texts = livroService.GetId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter o ID do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Saves the book data entered in the form.
        /// </summary>
        private void SaveData()
        {
            if (!ValidateFormFields()) return;

            DateTime dataEntrega = DateTime.ParseExact(txtDataEntrega.Texts.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            int nRegisto = int.Parse(txtNRegisto.Texts.Trim());
            string titulo = txtTitulo.Texts.Trim();
            string autor = txtAutor.Texts.Trim();
            string cota = txtCota.Texts.Trim();
            string nVolume = txtNVolume.Texts.Trim();
            string aquisicao = cbxAquisicao.Text;
            string editora = txtEditora.Texts.Trim();
            string observacoes = txtObservacoes.Texts.Trim();
            string estado = cbxEstado.Text;

            if (livroService.IsRegistrationNumberExists(nRegisto))
            {
                MessageBox.Show("O número de registo já está em uso. Por favor, escolha outro número.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            livroService.GetNextRegistrationNumber();
            try
            {
                livroService.SaveData(nRegisto, dataEntrega, titulo, autor, cota, nVolume, aquisicao, editora, observacoes, estado);
                MessageBox.Show("Exemplar adicionado com êxito", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtNRegisto.Texts = (nRegisto + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível registar o manual", "Falha", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        /// <summary>
        /// Validates the form fields before saving data.
        /// </summary>
        /// <returns>true if all fields are valid; otherwise, false.</returns>
        private bool ValidateFormFields()
        {
            return ValidateTextBox(txtNRegisto, "o número de registo do exemplar") &&
                   ValidateTextBox(txtDataEntrega, "a data de entrada do exemplar") &&
                   ValidateTextBox(txtTitulo, "o título do exemplar") &&
                   ValidateTextBox(txtAutor, "o autor do exemplar") &&
                   ValidateTextBox(txtCota, "a cota do exemplar") &&
                   ValidateTextBox(txtNVolume, "o número de volume do exemplar") &&
                   ValidateTextBox(txtEditora, "a editora do exemplar") &&
                   ValidateComboBox(this.cbxAquisicao, "o método de aquisição do exemplar") &&
                   ValidateComboBox(this.cbxEstado, "o estado do exemplar");
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
                MessageBox.Show($"Por favor, introduza {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox == txtDataEntrega && !DateTime.TryParseExact(text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show($"Por favor, introduza {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

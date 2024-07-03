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
            SetThemeColors();

            // Set the MaxDate of the DateTimePicker to today's date
            dtpArrivalDate.MaxDate = DateTime.Today;
        }

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
                string titulo = this.txtTitulo_Edit.Texts.Trim();
                string autor = this.txtAutor_Edit.Texts.Trim();
                string cota = this.txtCota_Edit.Texts.Trim();
                string aquisicao = this.cbxAquisicao_Edit.Text;
                string editora = this.txtEditora_Edit.Texts.Trim();
                string numeroVolume = this.txtNVolume_Edit.Texts.Trim();
                string observacoes = this.txtObservacoes_Edit.Texts.Trim();
                string estado = this.cbxEstado_Edit.Text;

                int autorID = bookUpdateService.GetAuthorID(autor, libraryID);
                if (autorID == -1)
                    autorID = bookUpdateService.CreateAuthor(autor, libraryID);

                int cotaID = bookUpdateService.GetClassificationID(cota, libraryID);
                if (cotaID == -1)
                    cotaID = bookUpdateService.CreateClassification(cota, libraryID);

                bookUpdateService.UpdateBook(numeroRegistro, dataEntrega, titulo, autor, cota, aquisicao, editora, numeroVolume, observacoes, estado, libraryID);

                MessageBox.Show("Registo atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearText();
                UnableText();
                bttSave_Edit.Enabled = false;
                txtNRegisto_Edit.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        /// Handles the KeyPress event for the Data de Entrega textbox, ensuring valid date input.
        /// </summary>
        private void txtDataEntrega_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
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
                        MessageBox.Show("Registo excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearText();
                        UnableText();
                        bttSave_Edit.Enabled = false;
                        txtNRegisto_Edit.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("O livro com este número de registo não existe.", "Falha ao remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao excluir o registro: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        #endregion

        #region Helper Methods

        /// <summary>
        /// Fills the form fields with the data of the specified book record.
        /// </summary>
        /// <param name="numeroRegistro">The registration number of the book to load.</param>
        private void FillTextBoxes(int numeroRegistro)
        {
            List<Livro> livros = bookUpdateService.GetBooks_Edit(libraryID);
            Livro livroSelecionado = livros.FirstOrDefault(livro => livro.RegistrationNumber == numeroRegistro);
            if (livroSelecionado != null)
            {
                this.dtpArrivalDate.Value = livroSelecionado.DeliveryDate;
                this.txtTitulo_Edit.Texts = livroSelecionado.Title;
                this.txtAutor_Edit.Texts = livroSelecionado.Author;
                this.txtCota_Edit.Texts = livroSelecionado.Classification;
                this.cbxAquisicao_Edit.Text = livroSelecionado.AcquisitionMethod;
                this.txtEditora_Edit.Texts = livroSelecionado.Publisher;
                this.txtNVolume_Edit.Texts = livroSelecionado.VolumeNumber;
                this.txtObservacoes_Edit.Texts = livroSelecionado.Observations;
                this.cbxEstado_Edit.Text = livroSelecionado.Condition;
                this.txtNRegisto_Edit.Enabled = false;
                this.EnableText();
            }
            else
            {
                MessageBox.Show("Livro não encontrado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                   ValidateTextBox(this.txtTitulo_Edit, "o título do exemplar") &&
                   ValidateTextBox(this.txtAutor_Edit, "o autor do exemplar") &&
                   ValidateTextBox(this.txtCota_Edit, "a cota do exemplar") &&
                   ValidateTextBox(this.txtNVolume_Edit, "o número de volume do exemplar") &&
                   ValidateTextBox(this.txtEditora_Edit, "a editora do exemplar") &&
                   ValidateComboBox(this.cbxAquisicao_Edit, "o método de aquisição do exemplar") &&
                   ValidateComboBox(this.cbxEstado_Edit, "o estado do exemplar");
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
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            if (comboBox.Text == "<Aquisição>" || comboBox.Text == "<Estado>")
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Clears the form fields.
        /// </summary>
        private void ClearText()
        {
            this.txtAutor_Edit.Texts = "";
            this.txtTitulo_Edit.Texts = "";
            this.txtCota_Edit.Texts = "";
            this.txtEditora_Edit.Texts = "";
            this.txtNVolume_Edit.Texts = "";
            this.txtObservacoes_Edit.Texts = "";
            this.cbxEstado_Edit.SelectedIndex = -1;
            this.cbxAquisicao_Edit.SelectedIndex = -1;
        }

        /// <summary>
        /// Enables the form fields for editing.
        /// </summary>
        private void EnableText()
        {
            this.dtpArrivalDate.Enabled = true;
            this.txtAutor_Edit.Enabled = true;
            this.txtTitulo_Edit.Enabled = true;
            this.txtCota_Edit.Enabled = true;
            this.txtEditora_Edit.Enabled = true;
            this.cbxEstado_Edit.Enabled = true;
            this.cbxAquisicao_Edit.Enabled = true;
            this.txtNVolume_Edit.Enabled = true;
            this.txtObservacoes_Edit.Enabled = true;
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
            this.txtAutor_Edit.Enabled = false;
            this.txtTitulo_Edit.Enabled = false;
            this.txtCota_Edit.Enabled = false;
            this.txtEditora_Edit.Enabled = false;
            this.cbxEstado_Edit.Enabled = false;
            this.cbxAquisicao_Edit.Enabled = false;
            this.txtNVolume_Edit.Enabled = false;
            this.txtObservacoes_Edit.Enabled = false;
            this.bttClear_Edit.Enabled = false;
            this.bttDel.Enabled = false;
            this.bttSave_Edit.Enabled = false;
            ClearText();
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

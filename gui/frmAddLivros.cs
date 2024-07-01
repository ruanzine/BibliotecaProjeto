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
    public partial class frmAddLivros : Form
    {
        MainForm mainForm = new MainForm();
        private LivroService livroService = new LivroService();
        private string id;
        private ListBox listBoxSuggestionsTitulo;
        private ListBox listBoxSuggestionsAutor;

        public frmAddLivros()
        {
            InitializeComponent();
            mainForm.AddControlBounds(this.pnlAddLivros);
            InitializeSuggestionListBoxes();
        }

        #region Initialization

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

        private void frmAddLivros_Load(object sender, EventArgs e)
        {
            GetNRegisto();
            txtTitulo._TextChanged += txtTitulo_TextChanged;
            txtAutor._TextChanged += txtAutor_TextChanged;
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(txtTitulo, listBoxSuggestionsTitulo, livroService.GetTitlesBySearch);
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            ShowSuggestions(txtAutor, listBoxSuggestionsAutor, livroService.GetAuthorsBySearch);
        }

        private void listBoxSuggestionsTitulo_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsTitulo, txtTitulo);
        }

        private void listBoxSuggestionsAutor_MouseClick(object sender, MouseEventArgs e)
        {
            SelectSuggestion(listBoxSuggestionsAutor, txtAutor);
        }

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

        private void bttSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void txtDataEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPressForDate(e);
        }

        private void txtNRegisto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            ValidateKeyPressForNumber(e);
        }

        private void pnlAddLivros_Resize(object sender, EventArgs e)
        {
            mainForm.ResizeControls(pnlAddLivros);
        }

        #endregion

        #region Helper Methods

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

        private void SelectSuggestion(ListBox listBox, UC_textbox textBox)
        {
            if (listBox.SelectedItem != null)
            {
                textBox.Texts = listBox.SelectedItem.ToString();
                listBox.Visible = false;
            }
        }

        private void ValidateKeyPressForDate(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ValidateKeyPressForNumber(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            MainForm form = new MainForm();
            this.KeyPress += form.MainForm_KeyPress;
        }

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

        private bool ValidateComboBox(MetroComboBox comboBox, string fieldName)
        {
            if (comboBox.Text == "<Aquisição>" || comboBox.Text == "<Estado>")
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

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

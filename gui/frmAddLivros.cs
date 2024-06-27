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

        private void frmAddLivros_Load(object sender, EventArgs e)
        {
            GetNRegisto();
            txtTitulo._TextChanged += txtTitulo_TextChanged;
            txtAutor._TextChanged += txtAutor_TextChanged;
        }

        private void txtTitulo_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtTitulo.Texts.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                listBoxSuggestionsTitulo.Visible = false;
                return;
            }

            List<string> suggestions = livroService.GetTitlesBySearch(searchText);
            if (suggestions.Count > 0)
            {
                listBoxSuggestionsTitulo.Items.Clear();
                listBoxSuggestionsTitulo.Items.AddRange(suggestions.ToArray());
                listBoxSuggestionsTitulo.Visible = true;

                // Calculate and set the height
                int requiredHeight = Math.Min(listBoxSuggestionsTitulo.ItemHeight * suggestions.Count, listBoxSuggestionsTitulo.MaximumSize.Height);
                listBoxSuggestionsTitulo.Height = requiredHeight;

                // Adjust position
                Point textBoxLocation = txtTitulo.PointToScreen(Point.Empty);
                Point parentLocation = this.PointToScreen(Point.Empty);
                listBoxSuggestionsTitulo.Location = new Point(textBoxLocation.X - parentLocation.X, textBoxLocation.Y - parentLocation.Y + txtTitulo.Height);

                listBoxSuggestionsTitulo.Width = txtTitulo.Width;
                listBoxSuggestionsTitulo.BringToFront();
            }
            else
            {
                listBoxSuggestionsTitulo.Visible = false;
            }
        }

        private void txtAutor_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtAutor.Texts.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                listBoxSuggestionsAutor.Visible = false;
                return;
            }

            List<string> suggestions = livroService.GetAuthorsBySearch(searchText);
            if (suggestions.Count > 0)
            {
                listBoxSuggestionsAutor.Items.Clear();
                listBoxSuggestionsAutor.Items.AddRange(suggestions.ToArray());
                listBoxSuggestionsAutor.Visible = true;

                // Calculate and set the height
                int requiredHeight = Math.Min(listBoxSuggestionsAutor.ItemHeight * suggestions.Count, listBoxSuggestionsAutor.MaximumSize.Height);
                listBoxSuggestionsAutor.Height = requiredHeight;

                // Adjust position
                Point textBoxLocation = txtAutor.PointToScreen(Point.Empty);
                Point parentLocation = this.PointToScreen(Point.Empty);
                listBoxSuggestionsAutor.Location = new Point(textBoxLocation.X - parentLocation.X, textBoxLocation.Y - parentLocation.Y + txtAutor.Height);

                listBoxSuggestionsAutor.Width = txtAutor.Width;
                listBoxSuggestionsAutor.BringToFront();
            }
            else
            {
                listBoxSuggestionsAutor.Visible = false;
            }
        }

        private void listBoxSuggestionsTitulo_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxSuggestionsTitulo.SelectedItem != null)
            {
                txtTitulo.Texts = listBoxSuggestionsTitulo.SelectedItem.ToString();
                listBoxSuggestionsTitulo.Visible = false;
            }
        }

        private void listBoxSuggestionsAutor_MouseClick(object sender, MouseEventArgs e)
        {
            if (listBoxSuggestionsAutor.SelectedItem != null)
            {
                txtAutor.Texts = listBoxSuggestionsAutor.SelectedItem.ToString();
                listBoxSuggestionsAutor.Visible = false;
            }
        }

        private void listBoxSuggestions_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            ListBox listBox = sender as ListBox;

            // Determine the color
            Color backgroundColor;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                backgroundColor = Color.LightGray; // Color when item is selected/hovered
            }
            else
            {
                backgroundColor = listBox.BackColor; // Default color
            }

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

        void SaveData()
        {
            if (!ValidateTextBox(txtNRegisto, "o número de registo do exemplar") ||
                !ValidateTextBox(txtDataEntrega, "a data de entrada do exemplar") ||
                !ValidateTextBox(txtTitulo, "o título do exemplar") ||
                !ValidateTextBox(txtAutor, "o autor do exemplar") ||
                !ValidateTextBox(txtCota, "a cota do exemplar") ||
                !ValidateTextBox(txtNVolume, "o número de volume do exemplar") ||
                !ValidateTextBox(txtEditora, "a editora do exemplar") ||
                !ValidateComboBox(this.cbxAquisicao, "o método de aquisição do exemplar") ||
                !ValidateComboBox(this.cbxEstado, "o estado do exemplar")) return;

            DateTime dataEntrega = DateTime.ParseExact(txtDataEntrega.Texts.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (cbxAquisicao.Text == "" || cbxEstado.Text == "")
            {
                MessageBox.Show("Campo(s) de escolha vazio(s).", "Falha ao registar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            string text = textBox.Texts?.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"Por favor, introduza {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox == txtDataEntrega)
            {
                if (!DateTime.TryParseExact(text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, introduza {fieldName} no formato dd/mm/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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

        private void txtDataEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtNRegisto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            MainForm form = new MainForm();
            this.KeyPress += form.MainForm_KeyPress;
        }

        private void pnlAddLivros_Resize(object sender, EventArgs e) => mainForm.ResizeControls(pnlAddLivros);

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
    }
}

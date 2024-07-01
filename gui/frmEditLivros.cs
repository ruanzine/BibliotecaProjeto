using BIBLIOTECA_PROJETO.classes.services;
using BIBLIOTECA_PROJETO.classes;
using BIBLIOTECA_PROJETO.controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmEditLivros : Form
    {
        MainForm mainForm = new MainForm();
        private LivroService livroService = new LivroService();
        public string _titulo, _autor, _cota, _editora, _obsrvacoes, _estado;
        public int _nregisto, _nvolume;

        public frmEditLivros()
        {
            InitializeComponent();
            mainForm.AddControlBounds(this.pnlEditLivros);
        }

        #region Event Handlers

        private void bttSave_Edit_Click(object sender, EventArgs e)
        {
            if (!ValidateFormFields()) return;

            try
            {
                int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts.Trim());
                DateTime dataEntrega = DateTime.ParseExact(this.txtDataEntrega_Edit.Texts.Trim(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string titulo = this.txtTitulo_Edit.Texts.Trim();
                string autor = this.txtAutor_Edit.Texts.Trim();
                string cota = this.txtCota_Edit.Texts.Trim();
                string aquisicao = this.cbxAquisicao_Edit.Text;
                string editora = this.txtEditora_Edit.Texts.Trim();
                string numeroVolume = this.txtNVolume_Edit.Texts.Trim();
                string observacoes = this.txtObservacoes_Edit.Texts.Trim();
                string estado = this.cbxEstado_Edit.Text;

                int autorID = livroService.GetAuthorID(autor);
                if (autorID == -1)
                    autorID = livroService.CreateAuthor(autor);

                int cotaID = livroService.GetCotaID(cota);
                if (cotaID == -1)
                    cotaID = livroService.CreateCota(cota);

                livroService.UpdateBook(numeroRegistro, dataEntrega, titulo, autor, cota, aquisicao, editora, numeroVolume, observacoes, estado);

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

        private void bttClear_Edit_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void txtNRegisto_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDataEntrega_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void bttSearchEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar")) return;

            int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts);
            UnableText();
            FillTextBoxes(numeroRegistro);
        }

        private void bttDel_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtNRegisto_Edit, "o número de registo do exemplar")) return;

            int numeroRegistro = int.Parse(txtNRegisto_Edit.Texts.Trim());
            try
            {
                if (livroService.IsRegistrationNumberExists(numeroRegistro))
                {
                    DialogResult result = MessageBox.Show("Tem certeza de que deseja eliminar este registo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        livroService.DeleteBook(numeroRegistro);
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

        private void pnlFormBody_Paint(object sender, PaintEventArgs e) { }

        private void gpbAutor_Edit_Enter(object sender, EventArgs e) { }

        #endregion

        #region Helper Methods

        private void FillTextBoxes(int numeroRegistro)
        {
            List<Livro> livros = livroService.GetBooks_Edit();
            Livro livroSelecionado = livros.FirstOrDefault(livro => livro.NumeroRegistro == numeroRegistro);
            if (livroSelecionado != null)
            {
                this.txtDataEntrega_Edit.Texts = livroSelecionado.DataEntrada.ToString("dd/MM/yyyy");
                this.txtTitulo_Edit.Texts = livroSelecionado.Titulo;
                this.txtAutor_Edit.Texts = livroSelecionado.Autor;
                this.txtCota_Edit.Texts = livroSelecionado.Cota;
                this.cbxAquisicao_Edit.Text = livroSelecionado.Aquisicao;
                this.txtEditora_Edit.Texts = livroSelecionado.Editora;
                this.txtNVolume_Edit.Texts = livroSelecionado.NumeroVolume;
                this.txtObservacoes_Edit.Texts = livroSelecionado.Observacoes;
                this.cbxEstado_Edit.Text = livroSelecionado.Estado;
                this.txtNRegisto_Edit.Enabled = false;
                this.EnableText();
            }
            else
            {
                MessageBox.Show("Livro não encontrado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNRegisto_Edit.Enabled = true;
            }
        }

        private bool ValidateFormFields()
        {
            return ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar") &&
                   ValidateTextBox(this.txtDataEntrega_Edit, "a data de entrada do exemplar") &&
                   ValidateTextBox(this.txtTitulo_Edit, "o título do exemplar") &&
                   ValidateTextBox(this.txtAutor_Edit, "o autor do exemplar") &&
                   ValidateTextBox(this.txtCota_Edit, "a cota do exemplar") &&
                   ValidateTextBox(this.txtNVolume_Edit, "o número de volume do exemplar") &&
                   ValidateTextBox(this.txtEditora_Edit, "a editora do exemplar") &&
                   ValidateComboBox(this.cbxAquisicao_Edit, "o método de aquisição do exemplar") &&
                   ValidateComboBox(this.cbxEstado_Edit, "o estado do exemplar");
        }

        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            string text = textBox.Texts?.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox == this.txtDataEntrega_Edit && !DateTime.TryParseExact(text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
            {
                MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.txtDataEntrega_Edit.Texts = "";
            this.txtAutor_Edit.Texts = "";
            this.txtTitulo_Edit.Texts = "";
            this.txtCota_Edit.Texts = "";
            this.txtEditora_Edit.Texts = "";
            this.cbxEstado_Edit.SelectedIndex = -1;
            this.cbxAquisicao_Edit.SelectedIndex = -1;
            this.txtNVolume_Edit.Texts = "";
            this.txtObservacoes_Edit.Texts = "";
        }

        private void EnableText()
        {
            this.txtDataEntrega_Edit.Enabled = true;
            this.txtAutor_Edit.Enabled = true;
            this.txtTitulo_Edit.Enabled = true;
            this.txtCota_Edit.Enabled = true;
            this.txtEditora_Edit.Enabled = true;
            this.cbxEstado_Edit.Enabled = true;
            this.cbxAquisicao_Edit.Enabled = true;
            this.txtNVolume_Edit.Enabled = true;
            this.txtObservacoes_Edit.Enabled = true;
        }

        private void UnableText()
        {
            this.txtNRegisto_Edit.Focus();
            this.txtDataEntrega_Edit.Enabled = false;
            this.txtAutor_Edit.Enabled = false;
            this.txtTitulo_Edit.Enabled = false;
            this.txtCota_Edit.Enabled = false;
            this.txtEditora_Edit.Enabled = false;
            this.cbxEstado_Edit.Enabled = false;
            this.cbxAquisicao_Edit.Enabled = false;
            this.txtNVolume_Edit.Enabled = false;
            this.txtObservacoes_Edit.Enabled = false;
            ClearText();
        }

        #endregion
    }
}

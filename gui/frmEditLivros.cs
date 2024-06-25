using BIBLIOTECA_PROJETO.classes.services;
using BIBLIOTECA_PROJETO.classes;
using BIBLIOTECA_PROJETO.controls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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

        private void bttFilterDate_Click(object sender, EventArgs e)
        {
            if (!this.ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar"))
                return;
            int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts);
            this.UnableText();
            this.FillTextBoxes(numeroRegistro);
        }

        private void bttSave_Edit_Click(object sender, EventArgs e)
        {
            if (!this.ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar") ||
                !this.ValidateTextBox(this.txtDataEntrega_Edit, "a data de entrada do exemplar") ||
                !this.ValidateTextBox(this.txtTitulo_Edit, "o título do exemplar") ||
                !this.ValidateTextBox(this.txtAutor_Edit, "o autor do exemplar") ||
                !this.ValidateTextBox(this.txtCota_Edit, "a cota do exemplar") ||
                !this.ValidateTextBox(this.txtNVolume_Edit, "o número de volume do exemplar") ||
                !this.ValidateTextBox(this.txtEditora_Edit, "a editora do exemplar") ||
                !this.ValidateComboBox(this.cbxAquisicao_Edit, "o método de aquisição do exemplar") ||
                !this.ValidateComboBox(this.cbxEstado_Edit, "o estado do exemplar"))
                return;

            try
            {
                int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts);
                DateTime dataEntrega = DateTime.ParseExact(this.txtDataEntrega_Edit.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string titulo = this.txtTitulo_Edit.Texts;
                string autor = this.txtAutor_Edit.Texts;
                string cota = this.txtCota_Edit.Texts;
                string aquisicao = this.cbxAquisicao_Edit.Texts;
                string editora = this.txtEditora_Edit.Texts;
                string numeroVolume = this.txtNVolume_Edit.Texts;
                string observacoes = this.txtObservacoes_Edit.Texts;
                string estado = this.cbxEstado_Edit.Texts;

                int autorID = livroService.GetAuthorID(autor);
                if (autorID == -1)
                    autorID = livroService.CreateAuthor(autor);

                int cotaID = livroService.GetCotaID(cota);
                if (cotaID == -1)
                    cotaID = livroService.CreateCota(cota);

                livroService.UpdateBook(numeroRegistro, dataEntrega, titulo, autor, cota, aquisicao, editora, numeroVolume, observacoes, estado);

                MessageBox.Show("Registo atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.ClearText();
                this.UnableText();
                this.bttSave_Edit.Enabled = false;
                this.txtNRegisto_Edit.Enabled = true;
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

        private void bttDel_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtNRegisto_Edit, "o número de registo do exemplar"))
                return;
            int numeroRegistro = int.Parse(txtNRegisto_Edit.Texts);
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
                this.cbxAquisicao_Edit.Texts = livroSelecionado.Aquisicao;
                this.txtEditora_Edit.Texts = livroSelecionado.Editora;
                this.txtNVolume_Edit.Texts = livroSelecionado.NumeroVolume;
                this.txtObservacoes_Edit.Texts = livroSelecionado.Observacoes;
                this.cbxEstado_Edit.Texts = livroSelecionado.Estado;
                this.txtNRegisto_Edit.Enabled = false;
                this.EnableText();
            }
            else
            {
                MessageBox.Show("Livro não encontrado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNRegisto_Edit.Enabled = true;
            }
        }

        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (textBox == this.txtDataEntrega_Edit)
            {
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return true;
        }

        private bool ValidateComboBox(UC_ComboBox comboBox, string fieldName)
        {
            if (comboBox.Texts == "<Aquisição>" || comboBox.Texts == "<Estado>")
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
            this.cbxEstado_Edit.Texts = "<Estado>";
            this.cbxAquisicao_Edit.Texts = "<Aquisição>";
            this.txtNVolume_Edit.Texts = "";
            this.txtObservacoes_Edit.Texts = "";
        }

        private void EnableText()
        {
            this.gpbAutor_Edit.Enabled = true;
            this.gpbCota_Edit.Enabled = true;
            this.bttSave_Edit.Enabled = true;
            this.bttClear_Edit.Enabled = true;
        }

        private void UnableText()
        {
            this.gpbAutor_Edit.Enabled = false;
            this.gpbCota_Edit.Enabled = false;
            this.bttClear_Edit.Enabled = false;
        }
    }
}

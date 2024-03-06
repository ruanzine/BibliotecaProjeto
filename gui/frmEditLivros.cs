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

        public frmEditLivros()
        {
            InitializeComponent();
            mainForm.AddControlBounds(pnlEditLivros, this);

        }

        private void bttEdit_Click(object sender, EventArgs e)
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
                !this.ValidateTextBox(this.txtObservacoes_Edit, "as observações"))
                return;

            // Recuperar as informações atualizadas das textboxes
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

            try
            {
                // Criar uma instância da classe Registo_Livro
                RegistoLivro RegistoLivro = new RegistoLivro();
                // Verificar se o autor existe na base de dados

                int autorID = RegistoLivro.GetAuthorID(autor);
                if (autorID == -1)
                    // Autor não existe, criar novo autor
                    autorID = RegistoLivro.CreateAuthor(autor);

                // Verificar se a cota existe na base de dados
                int cotaID = RegistoLivro.GetCotaID(cota);
                if (cotaID == -1)
                    // Cota não existe, criar nova cota
                    cotaID = RegistoLivro.CreateCota(cota);
                // Chamar o método de atualização passando as informações atualizadas e o número de registro
                RegistoLivro.UpdateBook(numeroRegistro, dataEntrega, titulo, autor, cota, aquisicao, editora, numeroVolume, observacoes, estado);

                // Exibir uma mensagem de sucesso para o usuário
                MessageBox.Show("Registo atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar a exibição dos dados, se necessário
                // ...
                this.ClearText();
                this.UnableText();
                this.bttSave_Edit.Enabled = false;
                this.txtNRegisto_Edit.Enabled = true;

            }
            catch (Exception ex)
            {
                // Tratar a exceção e exibir uma mensagem de erro para o usuário
                MessageBox.Show("Ocorreu um erro ao atualizar o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillTextBoxes(int numeroRegistro)
        {
            RegistoLivro registoLivro = new RegistoLivro();
            List<Livro> livros = registoLivro.GetBooks_Edit();

            // Encontrar o livro com o número de registro especificado
            Livro livroSelecionado = livros.FirstOrDefault(livro => livro.NumeroRegistro == numeroRegistro);

            if (livroSelecionado != null)
            {
                // Preencher as textboxes com as informações do livro
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
                // Livro não encontrado
                MessageBox.Show("Livro não encontrado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNRegisto_Edit.Enabled = true;
            }
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
            this.gpbData_Edit.Enabled = true;
            this.gpbAutor_Edit.Enabled = true;
            this.gpbCota_Edit.Enabled = true;
            this.gpbEstado_Edit.Enabled = true;
            this.gpbAqi_Edit.Enabled = true;
            this.bttSave_Edit.Enabled = true;
            this.bttClear_Edit.Enabled = true;
        }

        private void UnableText()
        {
            this.gpbData_Edit.Enabled = false;
            this.gpbAutor_Edit.Enabled = false;
            this.gpbCota_Edit.Enabled = false;
            this.gpbEstado_Edit.Enabled = false;
            this.gpbAqi_Edit.Enabled = false;
            this.bttClear_Edit.Enabled = false;
        }

        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox == this.txtDataEntrega_Edit)
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }

        private void gpbAqi_Edit_Enter(object sender, EventArgs e)
        {

        }

        private void bttClear_Edit_Click(object sender, EventArgs e)
        {
            ClearText();
        }

        private void txtNRegisto_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDataEntrega_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e "/" (barra) e teclas de controle (Backspace, Delete, etc.)
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
                // Criar uma instância da classe Registo_Livro
                RegistoLivro RegistoLivro = new RegistoLivro();

                // Verificar se o registro existe antes de tentar excluir
                if (RegistoLivro.IsRegistrationNumberExists(numeroRegistro))
                {
                    // Chamar o método de exclusão do registro
                    RegistoLivro.DeleteBook(numeroRegistro);

                    // Exibir uma mensagem de sucesso para o usuário
                    MessageBox.Show("Registo excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpar as textboxes e desabilitá-las
                    ClearText();
                    UnableText();
                    bttSave_Edit.Enabled = false;
                    txtNRegisto_Edit.Enabled = true;
                }
                else
                {
                    // Exibir mensagem de erro informando que o registro não foi encontrado
                    MessageBox.Show("O livro com este número de registo não existe.", "Falha ao remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Tratar a exceção e exibir uma mensagem de erro para o usuário
                MessageBox.Show("Ocorreu um erro ao excluir o registro: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

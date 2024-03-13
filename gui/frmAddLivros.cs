using BIBLIOTECA_PROJETO.classes;
using BIBLIOTECA_PROJETO.controls;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmAddLivros : Form
    {
        MainForm mainForm = new MainForm();
        private string id;

        public frmAddLivros()
        {
            InitializeComponent();
            mainForm.AddControlBounds(pnlAddLivros, this);
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void GetNRegisto()
        {
            try
            {
                RegistoLivro nReg = new RegistoLivro();

                txtNRegisto.Texts = nReg.GetId(id);
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
                !ValidateTextBox(txtObservacoes, "as observações"))
            {
                return;
            }

            DateTime dataEntrega = DateTime.ParseExact(txtDataEntrega.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (cbxAquisicao.Texts == "" || cbxEstado.Texts == "") MessageBox.Show("Campo(s) de escolha vazio(s).", "Falha ao registar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int nRegisto = int.Parse(txtNRegisto.Texts);
            string titulo = txtTitulo.Texts;
            string autor = txtAutor.Texts;
            string cota = txtCota.Texts;
            string nVolume = txtNVolume.Texts;
            string aquisicao = cbxAquisicao.Texts;
            string editora = txtEditora.Texts;
            string observacoes = txtObservacoes.Texts;
            string estado = cbxEstado.Texts;

            // Chamar o método SaveData apenas se a validação for bem-sucedida
            RegistoLivro save = new RegistoLivro();
            save.GetNextRegistrationNumber();
            try
            {
                save.SaveData(nRegisto, dataEntrega, titulo, autor, cota,
                    nVolume, aquisicao, editora, observacoes, estado);
                MessageBox.Show("Exemplar adicionado com êxito", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                txtNRegisto.Texts = (nRegisto + 1).ToString();
            }
            catch
            {
                MessageBox.Show("Não foi possível registar o manual", "Falha", MessageBoxButtons.OK, MessageBoxIcon.None);
            }


        }

        bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, introduza {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Verificar se a data está no formato correto
            if (textBox == txtDataEntrega)
            {
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, introduza {fieldName} no formato dd/mm/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;

        }

        private void txtNRegisto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtDataEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e "/" (barra) e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void pnlAddLivros_Resize(object sender, EventArgs e) => mainForm.ResizeControls(pnlAddLivros);

        private void frmAddLivros_Load(object sender, EventArgs e)
        {
            GetNRegisto();

        }

        private void txtNRegisto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;

            MainForm form = new MainForm();

            this.KeyPress += form.MainForm_KeyPress;
        }

        private void txtNRegisto__TextChanged(object sender, EventArgs e)
        {
            //FAZER APARECER UM SINALZINHO VERDE AO LADO PARA DIZER QUE ESSE NÚMERO ESTÁ DISPONÍVEL
        }

        private void txtDataEntrega_TextChanged(object sender, EventArgs e)
        {

        }
    }
}







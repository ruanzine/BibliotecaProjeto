using BIBLIOTECA_PROJETO.classes.services;
using BIBLIOTECA_PROJETO.controls;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmAddLivros : Form
    {
        MainForm mainForm = new MainForm();
        private LivroService livroService = new LivroService();
        private string id;

        public frmAddLivros()
        {
            InitializeComponent();
            mainForm.AddControlBounds(this.pnlAddLivros);
        }

        private void frmAddLivros_Load(object sender, EventArgs e)
        {
            GetNRegisto();
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

            DateTime dataEntrega = DateTime.ParseExact(txtDataEntrega.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (cbxAquisicao.Texts == "" || cbxEstado.Texts == "")
            {
                MessageBox.Show("Campo(s) de escolha vazio(s).", "Falha ao registar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nRegisto = int.Parse(txtNRegisto.Texts);
            string titulo = txtTitulo.Texts;
            string autor = txtAutor.Texts;
            string cota = txtCota.Texts;
            string nVolume = txtNVolume.Texts;
            string aquisicao = cbxAquisicao.Texts;
            string editora = txtEditora.Texts;
            string observacoes = txtObservacoes.Texts;
            string estado = cbxEstado.Texts;

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
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, introduza {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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

        private bool ValidateComboBox(UC_ComboBox comboBox, string fieldName)
        {
            if (comboBox.Texts == "<Aquisição>" || comboBox.Texts == "<Estado>")
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
            cbxAquisicao.Texts = "<Aquisição>";
            cbxEstado.Texts = "<Estado>";
        }
    }
}

using BIBLIOTECA_PROJETO.classes;
using BIBLIOTECA_PROJETO.controls;
using ClosedXML.Excel;
using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmDateFromUntil : Form
    {
        private RegistoLivro Registo_Livro;
        private const int itemsPerPage = 11;
        private int currentPage = 1;
        private int totalPages = 0;

        public frmDateFromUntil()
        {
            this.InitializeComponent();
            this.Registo_Livro = new RegistoLivro();
        }

        private void bttFilterDate_Click(object sender, EventArgs e)
        {
            if (!this.ValidateTextBox(this.txtUntil, "a data de entrada do exemplar") ||
                !this.ValidateTextBox(this.txtFrom, "a data de entrada do exemplar"))
                return;

            if (!DateTime.TryParse(txtFrom.Texts, out DateTime dataDe) || !DateTime.TryParse(txtUntil.Texts, out DateTime dataAte))
            {
                MessageBox.Show("Insira datas válidas nos campos De e Até.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataDe > dataAte)
            {
                MessageBox.Show("A data inicial não pode ser maior que a data final.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Realizar a consulta no banco de dados para obter os livros dentro do intervalo de datas
                DataTable livrosPorData = this.Registo_Livro.GetBooksByDate_Listing(dataDe, dataAte, currentPage, itemsPerPage);
                int totalCount = this.Registo_Livro.GetBooksCountByDate(dataDe, dataAte);
                totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);

                // Atualizar a DataGridView com os dados do DataTable
                this.dgvDateListing.DataSource = livrosPorData;
                ResizeData();

                // Atualizar o label da paginação
                UpdatePaginationLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os livros por data: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttPrintDate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.ValidateTextBox(this.txtUntil, "a data de entrada do exemplar") ||
                    !this.ValidateTextBox(this.txtFrom, "a data de entrada do exemplar"))
                    return;

                this.Registo_Livro = new RegistoLivro();
                if (!DateTime.TryParse(txtFrom.Texts, out DateTime dataDe) || !DateTime.TryParse(txtUntil.Texts, out DateTime dataAte))
                {
                    MessageBox.Show("Insira datas válidas nos campos De e Até.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dataDe > dataAte)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obter todos os livros dentro do intervalo de datas
                DataTable allBooksByDate = this.Registo_Livro.GetAllBooksByDate(dataDe, dataAte);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Arquivo Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar arquivo Excel";
                    saveFileDialog.FileName = "nome_do_arquivo";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Planilha1");

                            // Adicionar o nome das colunas
                            for (int j = 0; j < allBooksByDate.Columns.Count; j++)
                            {
                                worksheet.Cell(1, j + 1).Value = allBooksByDate.Columns[j].ColumnName;
                            }

                            // Preencher a planilha com os dados
                            for (int i = 0; i < allBooksByDate.Rows.Count; i++)
                            {
                                for (int j = 0; j < allBooksByDate.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = allBooksByDate.Rows[i][j].ToString();
                                }
                            }

                            // Salvar o arquivo do Excel
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Arquivo exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void UpdatePaginationLabel()
        {
            lblPagination.Text = $"Página {currentPage} de {totalPages}";
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                bttFilterDate_Click(sender, e);
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                bttFilterDate_Click(sender, e);
            }
        }

        public void ResizeData()
        {
            //Header name resize
            dgvDateListing.Columns["Nº"].Width = 50; // Define a largura da coluna
            dgvDateListing.Columns["Data de Entrada"].Width = 90;
            dgvDateListing.Columns["Título"].Width = 270;
            dgvDateListing.Columns["Autor"].Width = 150;
            dgvDateListing.Columns["Cota"].Width = 130;
            dgvDateListing.Columns["Nº de Volume"].Width = 45;
            dgvDateListing.Columns["Aquisição"].Width = 75;
            dgvDateListing.Columns["Observações"].Width = 200;
            dgvDateListing.Columns["Editora"].Width = 175;
            dgvDateListing.Columns["Estado"].Width = 123;

            //Font
            dgvDateListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgvDateListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            dgvDateListing.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            dgvDateListing.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDateListing.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDateListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDateListing.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDateListing.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetRowHeight(dgvDateListing, 40);
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox == this.txtFrom)
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }

        private void txtFromUntil_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e "/" (barra) e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}

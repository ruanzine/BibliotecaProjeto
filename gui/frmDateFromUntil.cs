using BIBLIOTECA_PROJETO.services;
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
        private BookDateListingService bookDateService;
        private const int itemsPerPage = 11;
        private int currentPage = 1;
        private int totalPages = 0;
        private DataTable allData;

        public frmDateFromUntil()
        {
            this.InitializeComponent();
            this.bookDateService = new BookDateListingService();
            InitializeEventHandlers();
        }

        #region Initialization

        private void InitializeEventHandlers()
        {
            this.dgvDateListing.CellFormatting += dgvDateListing_CellFormatting;
            this.dgvDateListing.DataBindingComplete += dgvDateListing_DataBindingComplete;

        }

        #endregion

        #region Event Handlers

        private void dgvDateListing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDateListing.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                e.CellStyle.BackColor = e.Value.ToString() switch
                {
                    "Disponível" => Color.FromArgb(207, 228, 183),
                    "Indisponível" => Color.FromArgb(248, 193, 193),
                    "Perdido" => Color.FromArgb(248, 237, 195),
                    "Depósito" => Color.FromArgb(191, 175, 228),
                    "Exposição" => Color.FromArgb(199, 209, 255),
                    "Abatido" => Color.FromArgb(244, 207, 173),
                    "Consulta local" => Color.FromArgb(191, 232, 255),
                    _ => dgvDateListing.DefaultCellStyle.BackColor,
                };
            }
        }

        private void dgvDateListing_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDateListing.ClearSelection(); // Clear selection after data binding is complete
        }

        private void bttFilterDate_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtUntil, "a data de entrada do exemplar") ||
                !ValidateTextBox(txtFrom, "a data de entrada do exemplar"))
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
                LoadAllData(dataDe, dataAte);
                ResetPagination();
                FillDGV_Filter();
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
                if (!ValidateTextBox(txtUntil, "a data de entrada do exemplar") ||
                    !ValidateTextBox(txtFrom, "a data de entrada do exemplar"))
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

                DataTable allBooksByDate = bookDateService.GetAllBooksByDate(dataDe, dataAte);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Ficheiro Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar Ficheiro Excel";
                    saveFileDialog.FileName = "nome_do_ficheiro";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Planilha1");

                            for (int j = 0; j < allBooksByDate.Columns.Count; j++)
                            {
                                worksheet.Cell(1, j + 1).Value = allBooksByDate.Columns[j].ColumnName;
                            }

                            for (int i = 0; i < allBooksByDate.Rows.Count; i++)
                            {
                                for (int j = 0; j < allBooksByDate.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = allBooksByDate.Rows[i][j].ToString();
                                }
                            }

                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Ficheiro exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar o Ficheiro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                FillDGV_Filter();
            }
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV_Filter();
            }
        }

        private void txtFromUntil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        #endregion

        #region Data Loading

        private void LoadAllData(DateTime dataDe, DateTime dataAte)
        {
            allData = bookDateService.GetAllBooksByDate(dataDe, dataAte);

            int totalCount = allData.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
            UpdatePaginationLabel();

            lblAmount.Text = totalCount == 0 ? "0 registos encontrados" : $"{totalCount} registos encontrados";
        }

        private void FillDGV_Filter()
        {
            try
            {
                DataTable dt = allData.Clone();

                int startIndex = (currentPage - 1) * itemsPerPage;
                int endIndex = Math.Min(startIndex + itemsPerPage, allData.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    dt.ImportRow(allData.Rows[i]);
                }

                dgvDateListing.DataSource = dt;
                ResizeData();
                UpdatePaginationLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Pagination

        private void ResetPagination()
        {
            currentPage = 1;
            int totalCount = allData?.Rows.Count ?? 0;
            totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
            UpdatePaginationLabel();

            lblAmount.Text = totalCount == 0 ? "0 registos encontrados" : $"{totalCount} registos encontrados";
        }

        private void UpdatePaginationLabel()
        {
            lblPagination.Text = totalPages == 0 ? "Não há registos" : $"Página {currentPage} de {totalPages}";
        }

        #endregion

        #region Validation

        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox == txtFrom)
            {
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        #endregion

        #region DataGridView Methods

        public void ResizeData()
        {
            dgvDateListing.Columns["Nº"].Width = 50;
            dgvDateListing.Columns["Data de Entrada"].Width = 90;
            dgvDateListing.Columns["Título"].Width = 270;
            dgvDateListing.Columns["Autor"].Width = 150;
            dgvDateListing.Columns["Cota"].Width = 130;
            dgvDateListing.Columns["Nº de Volume"].Width = 45;
            dgvDateListing.Columns["Aquisição"].Width = 75;
            dgvDateListing.Columns["Observações"].Width = 200;
            dgvDateListing.Columns["Editora"].Width = 175;
            dgvDateListing.Columns["Estado"].Width = 123;

            dgvDateListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgvDateListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            dgvDateListing.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        #endregion
    }
}

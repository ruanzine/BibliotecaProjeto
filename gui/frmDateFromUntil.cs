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

            // Subscribe to the CellFormatting event
            this.dgvDateListing.CellFormatting += dgvDateListing_CellFormatting;
        }

        private void dgvDateListing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDateListing.Columns[e.ColumnIndex].Name == "Estado")
            {
                if (e.Value != null)
                {
                    switch (e.Value.ToString())
                    {
                        case "Disponível":
                            e.CellStyle.BackColor = Color.FromArgb(207, 228, 183);
                            break;
                        case "Abatido":
                            e.CellStyle.BackColor = Color.FromArgb(248, 193, 193);
                            break;
                        case "Perdido":
                            e.CellStyle.BackColor = Color.FromArgb(248, 237, 195);
                            break;
                        case "Depósito":
                            e.CellStyle.BackColor = Color.FromArgb(191, 175, 228);
                            break;
                        default:
                            e.CellStyle.BackColor = dgvDateListing.DefaultCellStyle.BackColor;
                            break;
                    }
                }
            }
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
                LoadAllData(dataDe, dataAte);
                FillDGV_Filter();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os livros por data: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAllData(DateTime dataDe, DateTime dataAte)
        {
            allData = this.bookDateService.GetAllBooksByDate(dataDe, dataAte);

            int totalCount = allData.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
            UpdatePaginationLabel();

            // Update the lblAmount label
            if (totalCount == 0)
            {
                lblAmount.Text = "0 registos encontrados";
            }
            else
            {
                lblAmount.Text = $"{totalCount} registos encontrados";
            }
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

                this.dgvDateListing.DataSource = dt;
                ResizeData();
                UpdatePaginationLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttPrintDate_Click(object sender, EventArgs e)
        {
            try
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

                DataTable allBooksByDate = this.bookDateService.GetAllBooksByDate(dataDe, dataAte);

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

        private void UpdatePaginationLabel()
        {
            if (totalPages == 0)
                lblPagination.Text = "Não há registos";
            else
                lblPagination.Text = $"Página {currentPage} de {totalPages}";
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

        private bool ValidateTextBox(UC_textbox textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox == this.txtFrom)
            {
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void txtFromUntil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

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
    }
}

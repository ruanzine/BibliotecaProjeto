using BIBLIOTECA_PROJETO.services;
using ClosedXML.Excel;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmFilteredListing : Form
    {
        private BookGeneralListingService bookService;
        private int currentPage = 1;
        private int totalPages = 0;
        private int itemsPerPage = 11;
        private DataTable allData;

        public frmFilteredListing()
        {
            InitializeComponent();
            this.bookService = new BookGeneralListingService();
            this.dgvFilteredListing.DataBindingComplete += dgvFilteredListing_DataBindingComplete;

            // Add event handler for the primary combobox
        }

        private void bttPrint_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Ficheiro Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar Ficheiro Excel";
                    saveFileDialog.FileName = "nome_do_ficheiro";

                    DataTable dt = allData; // Use filtered data

                    if (dt != null && dt.Rows.Count > 0)
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            using (var workbook = new XLWorkbook())
                            {
                                var worksheet = workbook.Worksheets.Add("Planilha1");

                                for (int j = 0; j < dt.Columns.Count; j++)
                                {
                                    worksheet.Cell(1, j + 1).Value = dt.Columns[j].ColumnName;
                                }

                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    for (int j = 0; j < dt.Columns.Count; j++)
                                    {
                                        worksheet.Cell(i + 2, j + 1).Value = dt.Rows[i][j].ToString();
                                    }
                                }

                                workbook.SaveAs(saveFileDialog.FileName);
                                MessageBox.Show("Ficheiro exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado para imprimir.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar o ficheiro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentPage = 1;
            LoadAllData(cbxFilter.Text);
            FillDGV_Filter();

            // Load secondary filter combobox
            LoadSecondaryFilter();
        }

        private void cbxSecondaryFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentPage = 1;
            FillDGV_Filter();
        }

        private void LoadAllData(string filter)
        {
            switch (filter)
            {
                case "Número de Registo":
                    allData = this.bookService.GetAllBooks();
                    break;
                case "Autor":
                    allData = this.bookService.GetAllAuthors();
                    break;
                case "Título":
                    allData = this.bookService.GetAllTitles();
                    break;
                case "Cota":
                    allData = this.bookService.GetAllCotas();
                    break;
                default:
                    MessageBox.Show("Filtro inválido no LoadAllData", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            int totalCount = allData.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
            UpdatePaginationLabel();
        }

        private void LoadSecondaryFilter()
        {
            string primaryFilter = cbxFilter.Text;

            switch (primaryFilter)
            {
                case "Autor":
                    cbxSecondaryFilter.DataSource = this.bookService.GetDistinctAuthors();
                    cbxSecondaryFilter.DisplayMember = "Autor";
                    break;
                case "Título":
                    cbxSecondaryFilter.DataSource = this.bookService.GetDistinctTitles();
                    cbxSecondaryFilter.DisplayMember = "Título";
                    break;
                case "Cota":
                    cbxSecondaryFilter.DataSource = this.bookService.GetDistinctCotas();
                    cbxSecondaryFilter.DisplayMember = "Cota";
                    break;
                default:
                    cbxSecondaryFilter.DataSource = null;
                    break;
            }
        }

        public void FillDGV_Filter()
        {
            try
            {
                DataTable dt = allData.Clone();
                string secondaryFilter = cbxSecondaryFilter.Text;

                // Apply secondary filter
                foreach (DataRow row in allData.Rows)
                {
                    if (string.IsNullOrEmpty(secondaryFilter) || row[cbxFilter.Text].ToString() == secondaryFilter)
                    {
                        dt.ImportRow(row);
                    }
                }

                int startIndex = (currentPage - 1) * itemsPerPage;
                int endIndex = Math.Min(startIndex + itemsPerPage, dt.Rows.Count);

                DataTable pageData = dt.Clone();
                for (int i = startIndex; i < endIndex; i++)
                {
                    pageData.ImportRow(dt.Rows[i]);
                }

                this.dgvFilteredListing.DataSource = pageData;
                SetRowHeight(dgvFilteredListing, 40);
                UpdatePaginationLabel(); // Update pagination label after filling the data grid view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os registros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows) row.Height = rowHeight;
        }

        private void UpdatePaginationLabel()
        {
            if (totalPages == 0)
                lblPagination.Text = "Não há registos";
            else
                lblPagination.Text = $"Página {currentPage} de {totalPages}";
        }

        private void bttPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV_Filter();
                UpdatePaginationLabel(); // Call UpdatePaginationLabel here
            }
        }

        private void bttNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                FillDGV_Filter();
                UpdatePaginationLabel(); // Call UpdatePaginationLabel here
            }
        }

        private void dgvFilteredListing_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            switch (cbxFilter.Text)
            {
                case "Número de Registo":
                    ResizeData();
                    break;
                case "Autor":
                    ResizeAuthor();
                    break;
                case "Título":
                    ResizeTitle();
                    break;
                case "Cota":
                    ResizeCota();
                    break;
                default:
                    MessageBox.Show("Filtro inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void ResizeAuthor()
        {
            this.dgvFilteredListing.Columns["Autor"].Width = 250;
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);
            this.SetRowHeight(this.dgvFilteredListing, 40);
        }

        public void ResizeTitle()
        {
            this.dgvFilteredListing.Columns["Título"].Width = 250;
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);
            this.SetRowHeight(this.dgvFilteredListing, 40);
        }

        public void ResizeCota()
        {
            this.dgvFilteredListing.Columns["Cota"].Width = 130;
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);
            this.SetRowHeight(this.dgvFilteredListing, 40);
        }

        public void ResizeData()
        {
            this.dgvFilteredListing.Columns["Nº"].Width = 50;
            this.dgvFilteredListing.Columns["Data de Entrada"].Width = 90;
            this.dgvFilteredListing.Columns["Título"].Width = 225;
            this.dgvFilteredListing.Columns["Autor"].Width = 150;
            this.dgvFilteredListing.Columns["Cota"].Width = 130;
            this.dgvFilteredListing.Columns["Nº de Volume"].Width = 52;
            this.dgvFilteredListing.Columns["Aquisição"].Width = 75;
            this.dgvFilteredListing.Columns["Observações"].Width = 200;
            this.dgvFilteredListing.Columns["Editora"].Width = 175;
            this.dgvFilteredListing.Columns["Estado"].Width = 123;
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);
            this.dgvFilteredListing.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvFilteredListing, 40);
        }
    }
}

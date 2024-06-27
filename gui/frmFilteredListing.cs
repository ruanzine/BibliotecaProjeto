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

            cbxFilter.SelectedIndexChanged += cbxFilter_OnSelectedIndexChanged;
            dgvFilteredListing.SelectionChanged += dgvFilteredListing_SelectionChanged;
            bttAdvanced.Click += bttAdvanced_Click;
            bttAdvanced.Enabled = false; // Initially disable the button

            // Subscribe to the CellFormatting event
            this.dgvFilteredListing.CellFormatting += dgvFilteredListing_CellFormatting;
        }

        private void dgvFilteredListing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFilteredListing.Columns[e.ColumnIndex].Name == "Estado")
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
                            e.CellStyle.BackColor = dgvFilteredListing.DefaultCellStyle.BackColor;
                            break;
                    }
                }
            }
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
            LoadAllData(cbxFilter.Text);
        }

        private void cbxSecondaryFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.currentPage = 1;
            FillDGV_Filter();
        }

        private void LoadAllData(string filter)
        {
            ClearDataGridView(dgvFilteredListing); // Clear the DataGridView before loading new data

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

            // Reset pagination
            currentPage = 1;
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

            // Fill DataGridView with new data
            FillDGV_Filter();
        }

        private void ClearDataGridView(DataGridView dgv)
        {
            // Clear the DataGridView by setting its DataSource to null
            dgv.DataSource = null;
            // Clear any manually added columns if necessary
            dgv.Columns.Clear();
        }

        public void FillDGV_Filter()
        {
            try
            {
                if (allData == null)
                {
                    return;
                }

                DataTable dt = allData.Clone();

                int startIndex = (currentPage - 1) * itemsPerPage;
                int endIndex = Math.Min(startIndex + itemsPerPage, allData.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    dt.ImportRow(allData.Rows[i]);
                }

                this.dgvFilteredListing.DataSource = dt;
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

        private void dgvFilteredListing_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFilteredListing.SelectedRows.Count > 0)
            {
                bttAdvanced.Enabled = true;
            }
            else
            {
                bttAdvanced.Enabled = false;
            }
        }

        private void bttAdvanced_Click(object sender, EventArgs e)
        {
            if (dgvFilteredListing.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFilteredListing.SelectedRows[0];
                string selectedFilter = cbxFilter.Text;
                string selectedValue = "";

                switch (selectedFilter)
                {
                    case "Título":
                        selectedValue = selectedRow.Cells["Título"].Value.ToString();
                        LoadBooksByTitle(selectedValue);
                        break;
                    case "Autor":
                        selectedValue = selectedRow.Cells["Autor"].Value.ToString();
                        LoadBooksByAuthor(selectedValue);
                        break;
                    case "Cota":
                        selectedValue = selectedRow.Cells["Cota"].Value.ToString();
                        LoadBooksByCota(selectedValue);
                        break;
                    default:
                        MessageBox.Show("Filtro inválido no bttAdvanced_Click", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                FillDGV_Filter();
            }
        }

        private void LoadBooksByTitle(string title)
        {
            allData = this.bookService.GetBooksByTitle(title);
        }

        private void LoadBooksByAuthor(string author)
        {
            allData = this.bookService.GetBooksByAuthor(author);
        }

        private void LoadBooksByCota(string cota)
        {
            allData = this.bookService.GetBooksByCota(cota);
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

        private void bttAdvanced_Click_1(object sender, EventArgs e)
        {

        }

        private void bttAdvanced_Click_2(object sender, EventArgs e)
        {

        }
    }
}

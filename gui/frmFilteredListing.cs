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
            InitializeEventHandlers();
        }

        #region Initialization

        private void InitializeEventHandlers()
        {
            this.dgvFilteredListing.DataBindingComplete += dgvFilteredListing_DataBindingComplete;
            this.dgvFilteredListing.CellFormatting += dgvFilteredListing_CellFormatting;
            this.dgvFilteredListing.DataBindingComplete += dgvFilteredListing_ClearSelection;
            this.dgvFilteredListing.SelectionChanged += dgvFilteredListing_SelectionChanged;

            this.cbxFilter.SelectedIndexChanged += cbxFilter_OnSelectedIndexChanged;
            this.bttAdvanced.Click += bttAdvanced_Click;
            this.bttAdvanced.Enabled = false; // Initially disable the button
        }

        #endregion

        #region Event Handlers

        private void dgvFilteredListing_ClearSelection(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvFilteredListing.ClearSelection();
        }

        private void dgvFilteredListing_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvFilteredListing.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
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
                    _ => dgvFilteredListing.DefaultCellStyle.BackColor,
                };
            }
        }

        private void cbxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllData(cbxFilter.Text);
        }

        private void dgvFilteredListing_SelectionChanged(object sender, EventArgs e)
        {
            bttAdvanced.Enabled = dgvFilteredListing.SelectedRows.Count > 0;
        }

        private void bttAdvanced_Click(object sender, EventArgs e)
        {
            if (dgvFilteredListing.SelectedRows.Count > 0)
            {
                string selectedFilter = cbxFilter.Text;
                DataGridViewRow selectedRow = dgvFilteredListing.SelectedRows[0];
                string selectedValue = selectedRow.Cells[selectedFilter].Value.ToString();

                LoadBooksByFilter(selectedFilter, selectedValue);

                // Reset pagination
                ResetPagination();

                FillDGV_Filter();
            }
        }

        private void bttPrint_Click(object sender, EventArgs e)
        {
            ExportDataToExcel();
        }

        private void bttPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV_Filter();
                UpdatePaginationLabel();
            }
        }

        private void bttNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                FillDGV_Filter();
                UpdatePaginationLabel();
            }
        }

        private void dgvFilteredListing_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeColumnsBasedOnFilter(cbxFilter.Text);
        }

        #endregion

        #region Data Loading

        private void LoadAllData(string filter)
        {
            ClearDataGridView(dgvFilteredListing);

            allData = filter switch
            {
                "Número de Registo" => bookService.GetAllBooks(),
                "Autor" => bookService.GetAllAuthors(),
                "Título" => bookService.GetAllTitles(),
                "Cota" => bookService.GetAllCotas(),
                "Estado" => bookService.GetAllEstados(),
                _ => throw new ArgumentException("Filtro inválido no LoadAllData"),
            };

            ResetPagination();
            FillDGV_Filter();
        }

        private void LoadBooksByFilter(string filter, string value)
        {
            allData = filter switch
            {
                "Título" => bookService.GetBooksByTitle(value),
                "Autor" => bookService.GetBooksByAuthor(value),
                "Cota" => bookService.GetBooksByCota(value),
                "Estado" => bookService.GetBooksByEstado(value),
                _ => throw new ArgumentException("Não é possível filtrar por meio do número de registo"),
            };
        }

        #endregion

        #region DataGridView Methods

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

                dgvFilteredListing.DataSource = dt;
                SetRowHeight(dgvFilteredListing, 40);
                UpdatePaginationLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os registos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = rowHeight;
            }
        }

        private void ResizeColumnsBasedOnFilter(string filter)
        {
            switch (filter)
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
                case "Estado":
                    ResizeEstado();
                    break;
                default:
                    throw new ArgumentException("Filtro inválido");
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

        #region Excel Export

        private void ExportDataToExcel()
        {
            try
            {
                using SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Ficheiro Excel|*.xlsx",
                    Title = "Salvar Ficheiro Excel",
                    FileName = "nome_do_ficheiro"
                };

                if (allData == null || allData.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro encontrado para imprimir.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using var workbook = new XLWorkbook();
                    var worksheet = workbook.Worksheets.Add("Planilha1");

                    for (int j = 0; j < allData.Columns.Count; j++)
                    {
                        worksheet.Cell(1, j + 1).Value = allData.Columns[j].ColumnName;
                    }

                    for (int i = 0; i < allData.Rows.Count; i++)
                    {
                        for (int j = 0; j < allData.Columns.Count; j++)
                        {
                            worksheet.Cell(i + 2, j + 1).Value = allData.Rows[i][j].ToString();
                        }
                    }

                    workbook.SaveAs(saveFileDialog.FileName);
                    MessageBox.Show("Ficheiro exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar o ficheiro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Resize Methods

        private void ResizeAuthor()
        {
            SetColumnProperties("Autor", 250);
        }

        private void ResizeTitle()
        {
            SetColumnProperties("Título", 250);
        }

        private void ResizeCota()
        {
            SetColumnProperties("Cota", 130);
        }

        private void ResizeEstado()
        {
            SetColumnProperties("Estado", 130);
        }

        private void ResizeData()
        {
            dgvFilteredListing.Columns["Nº"].Width = 50;
            dgvFilteredListing.Columns["Data de Entrada"].Width = 90;
            dgvFilteredListing.Columns["Título"].Width = 225;
            dgvFilteredListing.Columns["Autor"].Width = 150;
            dgvFilteredListing.Columns["Cota"].Width = 130;
            dgvFilteredListing.Columns["Nº de Volume"].Width = 52;
            dgvFilteredListing.Columns["Aquisição"].Width = 75;
            dgvFilteredListing.Columns["Observações"].Width = 200;
            dgvFilteredListing.Columns["Editora"].Width = 175;
            dgvFilteredListing.Columns["Estado"].Width = 123;

            SetDefaultCellStyle();
            AlignColumnContent();
            SetRowHeight(dgvFilteredListing, 40);
        }

        private void SetColumnProperties(string columnName, int width)
        {
            dgvFilteredListing.Columns[columnName].Width = width;
            SetDefaultCellStyle();
            SetRowHeight(dgvFilteredListing, 40);
        }

        private void SetDefaultCellStyle()
        {
            dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);
        }

        private void AlignColumnContent()
        {
            dgvFilteredListing.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion
    }
}

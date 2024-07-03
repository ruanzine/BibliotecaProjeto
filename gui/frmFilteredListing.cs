using BIBLIOTECA_PROJETO.services;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    /// <summary>
    /// Represents a form for viewing filtered listings of books.
    /// </summary>
    public partial class frmFilteredListing : Form
    {
        private BookGeneralListingService bookService;
        private int currentPage = 1;
        private int totalPages = 0;
        private int itemsPerPage = 11;
        private DataTable allData;
        private int libraryID;
        private ThemeColors currentThemeColors;

        private readonly Dictionary<int, ThemeColors> themeColors = new Dictionary<int, ThemeColors>
        {
            { 1, new ThemeColors(Color.FromArgb(252, 168, 183), Color.FromArgb(255, 102, 106), Color.FromArgb(121, 57, 59), Color.FromArgb(121, 57, 59)) },
            { 2, new ThemeColors(Color.FromArgb(146, 211, 157), Color.FromArgb(71, 174, 88), Color.FromArgb(10, 97, 69), Color.FromArgb(10, 97, 69)) },
            { 3, new ThemeColors(Color.FromArgb(151, 199, 234), Color.FromArgb(103, 166, 229), Color.FromArgb(56, 83, 117), Color.FromArgb(56, 83, 117)) }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="frmFilteredListing"/> class.
        /// </summary>
        public frmFilteredListing(int selectedLibraryId)
        {
            InitializeComponent();
            this.bookService = new BookGeneralListingService();
            InitializeEventHandlers();
            this.libraryID = selectedLibraryId;
            SetThemeColors();
            cbxFilter.SelectedIndex = 0;
        }

        #region Initialization

        /// <summary>
        /// Initializes the event handlers for the form controls.
        /// </summary>
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

        #region Theme Setting

        private void SetThemeColors()
        {
            if (themeColors.TryGetValue(libraryID, out currentThemeColors))
            {
                bttAdvanced.BackColor = currentThemeColors.ButtonColor;
                bttPrint.BackColor = currentThemeColors.ButtonColor;
                bttPreviousPage.BackColor = currentThemeColors.ButtonColor;
                bttNextPage.BackColor = currentThemeColors.ButtonColor;
                lblPagination.ForeColor = currentThemeColors.LabelColor;
                lblTitle.ForeColor = currentThemeColors.LabelColor;
                lblSubtitle.ForeColor = currentThemeColors.LabelColor;
                lblAmount.ForeColor = currentThemeColors.LabelColor;
                cbxFilter.BackColor = currentThemeColors.PanelHeaderColor;
                pnlFormHeader.BackColor = currentThemeColors.PanelHeaderColor;
                pnlFormFooter.BackColor = currentThemeColors.PanelHeaderColor;
                pnlLineTop.BackColor = currentThemeColors.LabelColor;
                pnlLineBottom.BackColor = currentThemeColors.LabelColor;
                dgvFilteredListing.BackgroundColor = currentThemeColors.PanelBodyColor;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the DataBindingComplete event of the DataGridView to clear selection after data binding is complete.
        /// </summary>
        private void dgvFilteredListing_ClearSelection(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvFilteredListing.ClearSelection();
        }

        /// <summary>
        /// Handles the CellFormatting event of the DataGridView to format cell colors based on the "Estado" column value.
        /// </summary>
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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the ComboBox to load all data based on the selected filter.
        /// </summary>
        private void cbxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllData(cbxFilter.Text);
        }

        /// <summary>
        /// Handles the SelectionChanged event of the DataGridView to enable or disable the advanced button based on the selection.
        /// </summary>
        private void dgvFilteredListing_SelectionChanged(object sender, EventArgs e)
        {
            bttAdvanced.Enabled = dgvFilteredListing.SelectedRows.Count > 0;
        }

        /// <summary>
        /// Handles the Click event of the advanced button to load books by the selected filter and value.
        /// </summary>
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

        /// <summary>
        /// Handles the Click event of the print button to export data to Excel.
        /// </summary>
        private void bttPrint_Click(object sender, EventArgs e)
        {
            ExportDataToExcel();
        }

        /// <summary>
        /// Handles the Click event of the previous page button to navigate to the previous page.
        /// </summary>
        private void bttPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV_Filter();
                UpdatePaginationLabel();
            }
        }

        /// <summary>
        /// Handles the Click event of the next page button to navigate to the next page.
        /// </summary>
        private void bttNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                FillDGV_Filter();
                UpdatePaginationLabel();
            }
        }

        /// <summary>
        /// Handles the DataBindingComplete event of the DataGridView to resize columns based on the selected filter.
        /// </summary>
        private void dgvFilteredListing_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            ResizeColumnsBasedOnFilter(cbxFilter.Text);
        }

        #endregion

        #region Data Loading

        /// <summary>
        /// Loads all data based on the specified filter.
        /// </summary>
        /// <param name="filter">The filter to apply.</param>
        private void LoadAllData(string filter)
        {
            ClearDataGridView(dgvFilteredListing);

            allData = filter switch
            {
                "Número de Registo" => bookService.GetAllBooks(libraryID),
                "Autor" => bookService.GetAllAuthors(libraryID),
                "Título" => bookService.GetAllTitles(libraryID),
                "Cota" => bookService.GetAllClassifications(libraryID),
                "Estado" => bookService.GetAllConditions(libraryID),
                _ => throw new ArgumentException("Filtro inválido no LoadAllData"),
            };

            ResetPagination();
            FillDGV_Filter();
        }

        /// <summary>
        /// Loads books based on the selected filter and value.
        /// </summary>
        /// <param name="filter">The filter to apply.</param>
        /// <param name="value">The value to filter by.</param>
        private void LoadBooksByFilter(string filter, string value)
        {
            allData = filter switch
            {
                "Título" => bookService.GetBooksByTitle(value, libraryID),
                "Autor" => bookService.GetBooksByAuthor(value, libraryID),
                "Cota" => bookService.GetBooksByClassification(value, libraryID),
                "Estado" => bookService.GetBooksByCondition(value, libraryID),
                _ => throw new ArgumentException("Não é possível filtrar por meio do número de registo"),
            };
        }

        #endregion

        #region DataGridView Methods

        /// <summary>
        /// Fills the DataGridView with filtered data.
        /// </summary>
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

        /// <summary>
        /// Clears the DataGridView.
        /// </summary>
        /// <param name="dgv">The DataGridView to clear.</param>
        private void ClearDataGridView(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Columns.Clear();
        }

        /// <summary>
        /// Sets the row height for the DataGridView.
        /// </summary>
        /// <param name="dataGridView">The DataGridView to set the row height.</param>
        /// <param name="rowHeight">The height of the rows.</param>
        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = rowHeight;
            }
        }

        /// <summary>
        /// Resizes the columns based on the selected filter.
        /// </summary>
        /// <param name="filter">The selected filter.</param>
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

        /// <summary>
        /// Resets the pagination to the first page.
        /// </summary>
        private void ResetPagination()
        {
            currentPage = 1;
            int totalCount = allData?.Rows.Count ?? 0;
            totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
            UpdatePaginationLabel();

            lblAmount.Text = totalCount == 0 ? "0 registos encontrados" : $"{totalCount} registos encontrados";
        }

        /// <summary>
        /// Updates the pagination label based on the current page and total pages.
        /// </summary>
        private void UpdatePaginationLabel()
        {
            lblPagination.Text = totalPages == 0 ? "Não há registos" : $"Página {currentPage} de {totalPages}";
        }

        #endregion

        #region Excel Export

        /// <summary>
        /// Exports the data to an Excel file.
        /// </summary>
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

        /// <summary>
        /// Resizes the columns for the "Autor" filter.
        /// </summary>
        private void ResizeAuthor()
        {
            SetColumnProperties("Autor", 250);
        }

        /// <summary>
        /// Resizes the columns for the "Título" filter.
        /// </summary>
        private void ResizeTitle()
        {
            SetColumnProperties("Título", 250);
        }

        /// <summary>
        /// Resizes the columns for the "Cota" filter.
        /// </summary>
        private void ResizeCota()
        {
            SetColumnProperties("Cota", 130);
        }

        /// <summary>
        /// Resizes the columns for the "Estado" filter.
        /// </summary>
        private void ResizeEstado()
        {
            SetColumnProperties("Estado", 130);
        }

        /// <summary>
        /// Resizes the columns for the "Número de Registo" filter.
        /// </summary>
        private void ResizeData()
        {
            dgvFilteredListing.Columns["Nº"].Width = 50;
            dgvFilteredListing.Columns["Data de Entrada"].Width = 90;
            dgvFilteredListing.Columns["Título"].Width = 225;
            dgvFilteredListing.Columns["Autor"].Width = 150;
            dgvFilteredListing.Columns["Cota"].Width = 130;
            dgvFilteredListing.Columns["Nº. Vol"].Width = 52;
            dgvFilteredListing.Columns["Aquisição"].Width = 75;
            dgvFilteredListing.Columns["Observações"].Width = 200;
            dgvFilteredListing.Columns["Editora"].Width = 175;
            dgvFilteredListing.Columns["Estado"].Width = 123;

            SetDefaultCellStyle();
            AlignColumnContent();
            SetRowHeight(dgvFilteredListing, 40);
        }

        /// <summary>
        /// Sets the column properties.
        /// </summary>
        /// <param name="columnName">The name of the column to set properties for.</param>
        /// <param name="width">The width of the column.</param>
        private void SetColumnProperties(string columnName, int width)
        {
            dgvFilteredListing.Columns[columnName].Width = width;
            SetDefaultCellStyle();
            SetRowHeight(dgvFilteredListing, 40);
        }

        /// <summary>
        /// Sets the default cell style for the DataGridView.
        /// </summary>
        private void SetDefaultCellStyle()
        {
            dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);
        }

        /// <summary>
        /// Aligns the content of specific columns to the center.
        /// </summary>
        private void AlignColumnContent()
        {
            dgvFilteredListing.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Nº. Vol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvFilteredListing.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        #endregion

        private class ThemeColors
        {
            public Color ButtonColor { get; }
            public Color PanelHeaderColor { get; }
            public Color PanelBodyColor { get; }
            public Color LabelColor { get; }
            public ThemeColors(Color panelHeaderColor, Color panelBodyColor, Color labelColor, Color buttonColor)
            {
                PanelHeaderColor = panelHeaderColor;
                PanelBodyColor = panelBodyColor;
                LabelColor = labelColor;
                ButtonColor = buttonColor;
            }
        }
    }
}

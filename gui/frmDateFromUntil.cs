using BIBLIOTECA_PROJETO.services;
using ClosedXML.Excel;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    /// <summary>
    /// Represents a form for viewing books within a specific date range.
    /// </summary>
    public partial class frmDateFromUntil : Form
    {
        private BookDateListingService bookDateService;
        private const int itemsPerPage = 11;
        private int currentPage = 1;
        private int totalPages = 0;
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
        /// Initializes a new instance of the <see cref="frmDateFromUntil"/> class.
        /// </summary>
        public frmDateFromUntil(int selectedLibraryId)
        {
            this.InitializeComponent();
            this.bookDateService = new BookDateListingService();
            InitializeEventHandlers();
            this.libraryID = selectedLibraryId;
            SetThemeColors();

            dtpUntil.MaxDate = DateTime.Today;
            dtpFrom.MaxDate = DateTime.Today;
        }

        #region Initialization

        /// <summary>
        /// Initializes the event handlers for the form controls.
        /// </summary>
        private void InitializeEventHandlers()
        {
            this.dgvDateListing.CellFormatting += dgvDateListing_CellFormatting;
            this.dgvDateListing.DataBindingComplete += dgvDateListing_DataBindingComplete;
        }

        #endregion

        #region Theme Setting

        private void SetThemeColors()
        {
            if (themeColors.TryGetValue(libraryID, out currentThemeColors))
            {
                bttFilterDate.BackColor = currentThemeColors.ButtonColor;
                bttPrintDate.BackColor = currentThemeColors.ButtonColor;
                bttPreviousPage.BackColor = currentThemeColors.ButtonColor;
                bttNextPage.BackColor = currentThemeColors.ButtonColor;
                lblPagination.ForeColor = currentThemeColors.LabelColor;
                lblAmount.ForeColor = currentThemeColors.LabelColor;
                lblTitle.ForeColor = currentThemeColors.LabelColor;
                lblFrom.ForeColor = currentThemeColors.LabelColor;
                lblUntil.ForeColor = currentThemeColors.LabelColor;
                pnlFormHeader.BackColor = currentThemeColors.PanelHeaderColor;
                pnlFormFooter.BackColor = currentThemeColors.PanelHeaderColor;
                pnlLineBottom.BackColor = currentThemeColors.LabelColor;
                pnlLineTop.BackColor = currentThemeColors.LabelColor;
                dgvDateListing.BackgroundColor = currentThemeColors.PanelBodyColor;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the CellFormatting event of the DataGridView to format cell colors based on the "Estado" column value.
        /// </summary>
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

        /// <summary>
        /// Handles the DataBindingComplete event of the DataGridView to clear selection after data binding is complete.
        /// </summary>
        private void dgvDateListing_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvDateListing.ClearSelection(); // Clear selection after data binding is complete
        }

        /// <summary>
        /// Handles the Click event of the Filter button to filter books by date range.
        /// </summary>
        private void bttFilterDate_Click(object sender, EventArgs e)
        {
            DateTime dataDe = dtpFrom.Value;
            DateTime dataAte = dtpUntil.Value;

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

        /// <summary>
        /// Handles the Click event of the Print button to export data to Excel.
        /// </summary>
        private void bttPrintDate_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dataDe = dtpFrom.Value;
                DateTime dataAte = dtpUntil.Value;

                if (dataDe > dataAte)
                {
                    MessageBox.Show("A data inicial não pode ser maior que a data final.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataTable allBooksByDate = bookDateService.GetAllBooksByDate(dataDe, dataAte, libraryID);

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

        /// <summary>
        /// Handles the Click event of the Next Page button to navigate to the next page.
        /// </summary>
        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                FillDGV_Filter();
            }
        }

        /// <summary>
        /// Handles the Click event of the Previous Page button to navigate to the previous page.
        /// </summary>
        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV_Filter();
            }
        }

        #endregion

        #region Data Loading

        /// <summary>
        /// Loads all data based on the specified date range.
        /// </summary>
        /// <param name="dataDe">The start date.</param>
        /// <param name="dataAte">The end date.</param>
        private void LoadAllData(DateTime dataDe, DateTime dataAte)
        {
            allData = bookDateService.GetAllBooksByDate(dataDe, dataAte, libraryID);

            int totalCount = allData.Rows.Count;
            totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
            UpdatePaginationLabel();

            lblAmount.Text = totalCount == 0 ? "0 registos encontrados" : $"{totalCount} registos encontrados";
        }

        /// <summary>
        /// Fills the DataGridView with filtered data.
        /// </summary>
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

        #region DataGridView Methods

        /// <summary>
        /// Resizes the DataGridView columns.
        /// </summary>
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

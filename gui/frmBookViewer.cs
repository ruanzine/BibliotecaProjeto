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
    /// Represents a form for viewing books in the library.
    /// </summary>
    public partial class frmBookViewer : Form
    {
        private BookSearchService bookService;
        MainForm mainForm = new MainForm();
        private int currentPage = 1;
        private const int itemsPerPage = 11;
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
        /// Initializes a new instance of the <see cref="frmBookViewer"/> class.
        /// </summary>
        public frmBookViewer(int selectedLibraryId)
        {
            InitializeComponent();
            this.bookService = new BookSearchService();
            InitializeEventHandlers();
            this.libraryID = selectedLibraryId;
            SetThemeColors();
        }

        #region Initialization

        /// <summary>
        /// Initializes the event handlers for the form controls.
        /// </summary>
        private void InitializeEventHandlers()
        {
            this.dgvBook.CellFormatting += dgvBook_CellFormatting;
            this.dgvBook.DataBindingComplete += dgvBook_DataBindingComplete;
            this.btnPrint_Search.Click += bttPrint_Search_Click;
            this.btnPreviousPage.Click += bttPreviousPage_Click;
            this.btnNextPage.Click += bttNextPage_Click;
            this.cbxFilter_DGV.SelectedIndexChanged += cbxFilter_DGV_OnSelectedIndexChanged;
            this.Load += frmBookViewer_Load;
        }

        #endregion

        #region Theme Setting

        private void SetThemeColors()
        {
            if (themeColors.TryGetValue(libraryID, out currentThemeColors))
            {
                btnPrint_Search.BackColor = currentThemeColors.ButtonColor;
                btnPreviousPage.BackColor = currentThemeColors.ButtonColor;
                btnNextPage.BackColor = currentThemeColors.ButtonColor;
                lblPagination.ForeColor = currentThemeColors.LabelColor;
                lblTitle.ForeColor = currentThemeColors.LabelColor;
                lblSubTitle_1.ForeColor = currentThemeColors.LabelColor;
                lblSubTitle_2.ForeColor = currentThemeColors.LabelColor;
                lblAmount.ForeColor = currentThemeColors.LabelColor;
                txtSearch_DGV.BorderColor = currentThemeColors.LabelColor;
                pnlFormHeader.BackColor = currentThemeColors.PanelHeaderColor;
                pnlFormFooter.BackColor = currentThemeColors.PanelHeaderColor;
                pnlLineBottom.BackColor = currentThemeColors.LabelColor;
                pnlLineTop.BackColor = currentThemeColors.LabelColor;
                dgvBook.BackgroundColor = currentThemeColors.PanelBodyColor;
                
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the CellFormatting event of the DataGridView to format cell colors based on the "Estado" column value.
        /// </summary>
        private void dgvBook_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvBook.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
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
                    _ => dgvBook.DefaultCellStyle.BackColor,
                };
            }
        }

        /// <summary>
        /// Handles the DataBindingComplete event of the DataGridView to clear selection after data binding is complete.
        /// </summary>
        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBook.ClearSelection(); // Clear selection after data binding is complete
        }

        /// <summary>
        /// Handles the Click event of the Print button to export data to Excel.
        /// </summary>
        private void bttPrint_Search_Click(object sender, EventArgs e)
        {
            ExportDataToExcel();
        }

        /// <summary>
        /// Handles the Click event of the Previous Page button to navigate to the previous page.
        /// </summary>
        private void bttPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV();
            }
        }

        /// <summary>
        /// Handles the Click event of the Next Page button to navigate to the next page.
        /// </summary>
        private void bttNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                FillDGV();
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the Search TextBox to reload data based on the new search text.
        /// </summary>
        private void txtSearch_DGV__TextChanged(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadAllData();
        }

        /// <summary>
        /// Handles the KeyPress event of the Search TextBox to ensure only numeric input for "Número de Registo".
        /// </summary>
        private void txtSearch_DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter_DGV.Text == "Número de Registo" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Filter ComboBox to clear and focus the Search TextBox.
        /// </summary>
        private void cbxFilter_DGV_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSearch_DGV.Texts = "";
            this.txtSearch_DGV.Focus();
        }

        /// <summary>
        /// Handles the Load event of the form to focus the Search TextBox.
        /// </summary>
        private void frmBookViewer_Load(object sender, EventArgs e)
        {
            txtSearch_DGV.Focus();
        }

        #endregion

        #region Data Loading

        /// <summary>
        /// Loads all data based on the selected filter and search text.
        /// </summary>
        private void LoadAllData()
        {
            try
            {
                string selectedOption = this.cbxFilter_DGV.Text;
                string searchText = this.txtSearch_DGV.Texts;

                allData = selectedOption switch
                {
                    "Número de Registo" => this.bookService.GetBooksByRegsiterNumber(int.Parse(searchText), libraryID),
                    "Autor" => this.bookService.GetBooksByAuthor(searchText, libraryID),
                    "Cota" => this.bookService.GetBooksByClassification(searchText, libraryID),
                    "Título" => this.bookService.GetBooksByTitle(searchText, libraryID),
                    "Estado" => this.bookService.GetBooksByCondition(searchText, libraryID),
                    _ => this.bookService.GetBooksByTitle(searchText, libraryID),
                };

                int totalCount = allData.Rows.Count;
                totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
                UpdatePaginationLabel();
                FillDGV();

                lblAmount.Text = totalCount == 0 ? "0 registos encontrados" : $"{totalCount} registos encontrados";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar todos os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region DataGridView Methods

        /// <summary>
        /// Fills the DataGridView with paginated data.
        /// </summary>
        public void FillDGV()
        {
            if (cbxFilter_DGV.Text == "Número de Registo" && !int.TryParse(this.txtSearch_DGV.Texts, out _))
            {
                this.dgvBook.DataSource = null;
                return;
            }

            try
            {
                DataTable dt = allData.Clone();

                int startIndex = (currentPage - 1) * itemsPerPage;
                int endIndex = Math.Min(startIndex + itemsPerPage, allData.Rows.Count);

                for (int i = startIndex; i < endIndex; i++)
                {
                    dt.ImportRow(allData.Rows[i]);
                }

                this.dgvBook.DataSource = dt;
                ResizeData();
                UpdatePaginationLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Resizes the DataGridView columns.
        /// </summary>
        public void ResizeData()
        {
            dgvBook.Columns["Nº"].Width = 50;
            dgvBook.Columns["Data de Entrada"].Width = 90;
            dgvBook.Columns["Título"].Width = 270;
            dgvBook.Columns["Autor"].Width = 150;
            dgvBook.Columns["Cota"].Width = 130;
            dgvBook.Columns["Nº. Vol"].Width = 45;
            dgvBook.Columns["Aquisição"].Width = 75;
            dgvBook.Columns["Observações"].Width = 200;
            dgvBook.Columns["Editora"].Width = 175;
            dgvBook.Columns["Estado"].Width = 123;

            dgvBook.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgvBook.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            dgvBook.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Nº. Vol"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            SetRowHeight(dgvBook, 40);
        }

        /// <summary>
        /// Sets the row height for the DataGridView.
        /// </summary>
        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = rowHeight;
            }
        }

        #endregion

        #region Excel Export

        /// <summary>
        /// Exports the filtered data to an Excel file.
        /// </summary>
        private void ExportDataToExcel()
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Ficheiro Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar Ficheiro Excel";
                    saveFileDialog.FileName = "nome_do_ficheiro";

                    DataTable dt = GetFilteredDataForExport();

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
                MessageBox.Show("Ocorreu um erro ao exportar o Ficheiro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gets the filtered data for export based on the selected filter and search text.
        /// </summary>
        /// <returns>A DataTable containing the filtered data.</returns>
        private DataTable GetFilteredDataForExport()
        {
            string filter = cbxFilter_DGV.Text;
            string searchText = txtSearch_DGV.Texts;

            return filter switch
            {
                "Número de Registo" => throw new InvalidOperationException("Opção de filtro não suportada para impressão."),
                "Autor" => this.bookService.GetBooksByAuthor_Printing(searchText, libraryID),
                "Título" => this.bookService.GetBooksByTitle_Printing(searchText, libraryID),
                "Cota" => this.bookService.GetBooksByClassification_Printing(searchText, libraryID),
                "Estado" => this.bookService.GetBooksByCondition(searchText, libraryID),
                _ => null,
            };
        }

        #endregion

        #region Pagination

        /// <summary>
        /// Updates the pagination label based on the current page and total pages.
        /// </summary>
        private void UpdatePaginationLabel()
        {
            lblPagination.Text = totalPages > 0 ? $"Página {currentPage} de {totalPages}" : "Não há registos";
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

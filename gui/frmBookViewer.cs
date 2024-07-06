using BIBLIOTECA_PROJETO.controls;
using BIBLIOTECA_PROJETO.services;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    /// <summary>
    /// Form for viewing books.
    /// </summary>
    public partial class frmBookViewer : Form
    {
        #region Fields

        private BookSearchService bookService;
        private ExcelExportService excelExportService;
        private int currentPage = 1;
        private const int itemsPerPage = 11;
        private int totalPages = 0;
        private DataTable allData;
        private int libraryID;
        private ThemeColors currentThemeColors;
        private ToolTip toolTip = new ToolTip();
        private ErrorProvider errorProvider = new ErrorProvider();

        private readonly Dictionary<int, ThemeColors> themeColors = new Dictionary<int, ThemeColors>
        {
            { 1, new ThemeColors(Color.FromArgb(252, 168, 183), Color.FromArgb(255, 102, 106), Color.FromArgb(121, 57, 59), Color.FromArgb(121, 57, 59)) },
            { 2, new ThemeColors(Color.FromArgb(146, 211, 157), Color.FromArgb(71, 174, 88), Color.FromArgb(10, 97, 69), Color.FromArgb(10, 97, 69)) },
            { 3, new ThemeColors(Color.FromArgb(151, 199, 234), Color.FromArgb(103, 166, 229), Color.FromArgb(56, 83, 117), Color.FromArgb(56, 83, 117)) }
        };

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="frmBookViewer"/> class.
        /// </summary>
        /// <param name="selectedLibraryId">The selected library ID.</param>
        public frmBookViewer(int selectedLibraryId)
        {
            InitializeComponent();
            this.bookService = new BookSearchService();
            this.excelExportService = new ExcelExportService();
            InitializeEventHandlers();
            this.libraryID = selectedLibraryId;
            SetThemeColors();
            cbxFilter_DGV.SelectedIndex = 1;
        }

        #endregion

        #region Initialization

        /// <summary>
        /// Initializes event handlers.
        /// </summary>
        private void InitializeEventHandlers()
        {
            this.dgvBook.CellFormatting += dgvBook_CellFormatting;
            this.dgvBook.DataBindingComplete += dgvBook_DataBindingComplete;
            this.cbxFilter_DGV.SelectedIndexChanged += cbxFilter_DGV_OnSelectedIndexChanged;
            this.txtSearch_DGV.KeyPress += txtSearch_DGV_KeyPress;
            this.Load += frmBookViewer_Load;
        }

        #endregion

        #region Theme Setting

        /// <summary>
        /// Sets the theme colors based on the selected library.
        /// </summary>
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
                txtSearch_DGV.BorderColor = currentThemeColors.LabelColor;
                txtSearch_DGV.BorderFocusColor = currentThemeColors.PanelHeaderColor;
            }
        }

        #endregion

        #region Event Handlers

        /// <summary>
        /// Handles the CellFormatting event of the dgvBook control.
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
        /// Handles the DataBindingComplete event of the dgvBook control.
        /// </summary>
        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBook.ClearSelection();
            ResizeData();
        }

        /// <summary>
        /// Handles the Click event of the btnPrint_Search button.
        /// </summary>
        private void bttPrint_Search_Click(object sender, EventArgs e)
        {
            ExportDataToExcel();
        }

        /// <summary>
        /// Handles the Click event of the btnPreviousPage button.
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
        /// Handles the Click event of the btnNextPage button.
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
        /// Handles the TextChanged event of the txtSearch_DGV textbox.
        /// </summary>
        private void txtSearch_DGV_TextChanged(object sender, EventArgs e)
        {
            if (cbxFilter_DGV.Text == "Número de Registo" && !string.IsNullOrEmpty(txtSearch_DGV.Texts) && !int.TryParse(txtSearch_DGV.Texts, out _))
            {
                ShowError("Por favor, insira um número válido para o filtro 'Número de Registo'.", txtSearch_DGV);
                return;
            }

            currentPage = 1;
            LoadAllData();
        }


        /// <summary>
        /// Handles the KeyPress event of the txtSearch_DGV textbox.
        /// </summary>
        private void txtSearch_DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter_DGV.Text == "Número de Registo" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the cbxFilter_DGV combobox.
        /// </summary>
        private void cbxFilter_DGV_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSearch_DGV.Text = "";
            this.txtSearch_DGV.Focus();
        }

        /// <summary>
        /// Handles the Load event of the frmBookViewer form.
        /// </summary>
        private void frmBookViewer_Load(object sender, EventArgs e)
        {
            txtSearch_DGV.Focus();
            LoadAllData();
        }

        #endregion

        #region Data Loading

        /// <summary>
        /// Loads all data based on the current filter and search text.
        /// </summary>
        private void LoadAllData()
        {
            try
            {
                string selectedOption = this.cbxFilter_DGV.Text;
                string searchText = this.txtSearch_DGV.Texts;

                if (selectedOption == "Número de Registo" && string.IsNullOrEmpty(searchText))
                {
                    allData = this.bookService.GetAllBooks(libraryID); // Load all books
                }
                else
                {
                    allData = selectedOption switch
                    {
                        "Número de Registo" => this.bookService.GetBooksByRegsiterNumber(int.Parse(searchText), libraryID),
                        "Autor" => this.bookService.GetBooksByAuthor(searchText, libraryID),
                        "Cota" => this.bookService.GetBooksByClassification(searchText, libraryID),
                        "Título" => this.bookService.GetBooksByTitle(searchText, libraryID),
                        "Estado" => this.bookService.GetBooksByCondition(searchText, libraryID),
                        _ => this.bookService.GetBooksByTitle(searchText, libraryID),
                    };
                }

                int totalCount = allData.Rows.Count;
                totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
                UpdatePaginationLabel();
                FillDGV();

                lblAmount.Text = totalCount == 0 ? "0 registos encontrados" : $"{totalCount} registos encontrados";
            }
            catch (Exception ex)
            {
                Toast.ShowToast("Ocorreu um erro ao carregar todos os dados: " + ex.Message, 5000); // Show for 5 seconds
            }
        }

        #endregion

        #region DataGridView Methods

        /// <summary>
        /// Fills the DataGridView with the current page data.
        /// </summary>
        public void FillDGV()
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

                this.dgvBook.DataSource = dt;
                ResizeData();
                UpdatePaginationLabel();
            }
            catch (Exception ex)
            {
                Toast.ShowToast("Ocorreu um erro ao obter os livros: " + ex.Message, 5000); // Show for 5 seconds
            }
        }

        /// <summary>
        /// Resizes the columns and rows of the DataGridView.
        /// </summary>
        public void ResizeData()
        {
            if (dgvBook.Columns.Count == 0) return;

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
        /// Sets the height of each row in the DataGridView.
        /// </summary>
        /// <param name="dataGridView">The DataGridView control.</param>
        /// <param name="rowHeight">The height to set for each row.</param>
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
                    Toast.ShowToast("Nenhum registro encontrado para imprimir.", 5000); // Show for 5 seconds
                    return;
                }

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName; // Get the file name
                    excelExportService.ExportDataToExcel(allData, "Geral", fileName);
                    Toast.ShowToast("Ficheiro exportado com sucesso!", 5000); // Show for 5 seconds
                }
            }
            catch (Exception ex)
            {
                Toast.ShowToast($"Ocorreu um erro ao exportar o ficheiro: {ex.Message}", 5000); // Show for 5 seconds
            }
        }

        #endregion

        #region Pagination

        /// <summary>
        /// Updates the pagination label.
        /// </summary>
        private void UpdatePaginationLabel()
        {
            lblPagination.Text = totalPages > 0 ? $"Página {currentPage} de {totalPages}" : "Não há registos";
        }

        #endregion

        #region Notification Methods

        /// <summary>
        /// Shows an error message for the specified control.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        /// <param name="control">The control to associate the error message with.</param>
        private void ShowError(string message, Control control)
        {
            errorProvider.SetError(control, message);
        }

        #endregion

        #region Nested Class: ThemeColors

        /// <summary>
        /// Represents the theme colors for the application.
        /// </summary>
        private class ThemeColors
        {
            /// <summary>
            /// Gets the button color.
            /// </summary>
            public Color ButtonColor { get; }

            /// <summary>
            /// Gets the panel header color.
            /// </summary>
            public Color PanelHeaderColor { get; }

            /// <summary>
            /// Gets the panel body color.
            /// </summary>
            public Color PanelBodyColor { get; }

            /// <summary>
            /// Gets the label color.
            /// </summary>
            public Color LabelColor { get; }

            /// <summary>
            /// Initializes a new instance of the <see cref="ThemeColors"/> class.
            /// </summary>
            /// <param name="panelHeaderColor">The panel header color.</param>
            /// <param name="panelBodyColor">The panel body color.</param>
            /// <param name="labelColor">The label color.</param>
            /// <param name="buttonColor">The button color.</param>
            public ThemeColors(Color panelHeaderColor, Color panelBodyColor, Color labelColor, Color buttonColor)
            {
                PanelHeaderColor = panelHeaderColor;
                PanelBodyColor = panelBodyColor;
                LabelColor = labelColor;
                ButtonColor = buttonColor;
            }
        }

        #endregion

        private void txtSearch_DGV__TextChanged(object sender, EventArgs e)
        {

        }
    }
}

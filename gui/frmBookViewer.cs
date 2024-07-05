using BIBLIOTECA_PROJETO.controls;
using BIBLIOTECA_PROJETO.services;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmBookViewer : Form
    {
        private BookSearchService bookService;
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

        public frmBookViewer(int selectedLibraryId)
        {
            InitializeComponent();
            this.bookService = new BookSearchService();
            InitializeEventHandlers();
            this.libraryID = selectedLibraryId;
            SetThemeColors();
            cbxFilter_DGV.SelectedIndex = 1;
        }

        #region Initialization

        private void InitializeEventHandlers()
        {
            this.dgvBook.CellFormatting += dgvBook_CellFormatting;
            this.dgvBook.DataBindingComplete += dgvBook_DataBindingComplete;
            this.btnPrint_Search.Click += bttPrint_Search_Click;
            this.btnPreviousPage.Click += bttPreviousPage_Click;
            this.btnNextPage.Click += bttNextPage_Click;
            this.cbxFilter_DGV.SelectedIndexChanged += cbxFilter_DGV_OnSelectedIndexChanged;
            this.txtSearch_DGV.TextChanged += txtSearch_DGV__TextChanged;
            this.txtSearch_DGV.KeyPress += txtSearch_DGV_KeyPress;
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

        private void dgvBook_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvBook.ClearSelection();
            ResizeData();
        }

        private void bttPrint_Search_Click(object sender, EventArgs e)
        {
            ExportDataToExcel();
        }

        private void bttPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV();
            }
        }

        private void bttNextPage_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                FillDGV();
            }
        }

        private void txtSearch_DGV__TextChanged(object sender, EventArgs e)
        {
            if (cbxFilter_DGV.Text == "Número de Registo" && !string.IsNullOrEmpty(txtSearch_DGV.Texts) && !int.TryParse(txtSearch_DGV.Texts, out _))
            {
                ShowError("Por favor, insira um número válido para o filtro 'Número de Registo'.", txtSearch_DGV);
                return;
            }

            currentPage = 1;
            LoadAllData();
        }

        private void txtSearch_DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter_DGV.Text == "Número de Registo" && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cbxFilter_DGV_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSearch_DGV.Texts = "";
            this.txtSearch_DGV.Focus();
        }

        private void frmBookViewer_Load(object sender, EventArgs e)
        {
            txtSearch_DGV.Focus();
            LoadAllData();
        }

        #endregion

        #region Data Loading

        private void LoadAllData()
        {
            try
            {
                string selectedOption = this.cbxFilter_DGV.Text;
                string searchText = this.txtSearch_DGV.Texts;

                if (selectedOption == "Número de Registo" && string.IsNullOrEmpty(searchText))
                {
                    allData = this.bookService.GetAllBooks(libraryID); // Carrega todos os livros
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

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = rowHeight;
            }
        }

        #endregion

        #region Excel Export

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
                                Toast.ShowToast("Ficheiro exportado com sucesso!");
                            }
                        }
                    }
                    else
                    {
                        Toast.ShowToast("Nenhum registro encontrado para imprimir.", 3000); // Show for 3 seconds
                    }
                }
            }
            catch (Exception ex)
            {
                Toast.ShowToast("Ocorreu um erro ao exportar o Ficheiro: " + ex.Message, 5000); // Show for 5 seconds
            }
        }

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
                "Estado" => this.bookService.GetBooksByCondition_Printing(searchText, libraryID),
                _ => null,
            };
        }

        #endregion

        #region Pagination

        private void UpdatePaginationLabel()
        {
            lblPagination.Text = totalPages > 0 ? $"Página {currentPage} de {totalPages}" : "Não há registos";
        }

        #endregion

        #region Notification Methods

        private void ShowToolTip(string message, Control control)
        {
            toolTip.ToolTipTitle = "Informação";
            toolTip.Show(message, control, control.Width / 2, control.Height / 2, 3000); // Show for 3 seconds
        }

        private void ShowError(string message, Control control)
        {
            errorProvider.SetError(control, message);
        }

        private void ClearError(Control control)
        {
            errorProvider.SetError(control, "");
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

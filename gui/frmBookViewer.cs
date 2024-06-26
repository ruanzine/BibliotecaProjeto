using BIBLIOTECA_PROJETO.services;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmBookViewer : Form
    {
        private BookSearchService bookService;
        MainForm mainForm = new MainForm();

        private int currentPage = 1;
        private const int itemsPerPage = 11;
        private int totalPages = 0;
        private DataTable allData;

        public frmBookViewer()
        {
            InitializeComponent();
            this.bookService = new BookSearchService();
        }

        private void bttPrint_Search_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Ficheiro Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar Ficheiro Excel";
                    saveFileDialog.FileName = "nome_do_ficheiro";

                    DataTable dt = null;
                    string filter = cbxFilter_DGV.Text;
                    string searchText = txtSearch_DGV.Texts;

                    switch (filter)
                    {
                        case "Número de Registo":
                            MessageBox.Show("Opção de filtro não suportada para impressão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                        case "Autor":
                            dt = this.bookService.GetBooksByAutor_Printing(searchText);
                            break;
                        case "Título":
                            dt = this.bookService.GetBooksByTitulo_Printing(searchText);
                            break;
                        case "Cota":
                            dt = this.bookService.GetBooksByCota_Printing(searchText);
                            break;
                        default:
                            break;
                    }

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

        public void FillDGV()
        {
            if (cbxFilter_DGV.Text == "Número de Registo")
            {
                if (!int.TryParse(this.txtSearch_DGV.Texts, out _))
                {
                    this.dgvBook.DataSource = null;
                    return;
                }
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

        private void LoadAllData()
        {
            try
            {
                string selectedOption = this.cbxFilter_DGV.Text;
                string searchText = this.txtSearch_DGV.Texts;

                switch (selectedOption)
                {
                    case "Número de Registo":
                        allData = this.bookService.GetBooksByNumeroRegistro(int.Parse(searchText));
                        break;
                    case "Autor":
                        allData = this.bookService.GetBooksByAutor(searchText);
                        break;
                    case "Cota":
                        allData = this.bookService.GetBooksByCota(searchText);
                        break;
                    case "Título":
                        allData = this.bookService.GetBooksByTitulo(searchText);
                        break;
                    default:
                        allData = this.bookService.GetBooksByTitulo(searchText);
                        break;
                }

                int totalCount = allData.Rows.Count;
                totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
                UpdatePaginationLabel();
                FillDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao carregar todos os dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResizeData()
        {
            dgvBook.Columns["Nº"].Width = 50;
            dgvBook.Columns["Data de Entrada"].Width = 90;
            dgvBook.Columns["Título"].Width = 270;
            dgvBook.Columns["Autor"].Width = 150;
            dgvBook.Columns["Cota"].Width = 130;
            dgvBook.Columns["Nº de Volume"].Width = 45;
            dgvBook.Columns["Aquisição"].Width = 75;
            dgvBook.Columns["Observações"].Width = 200;
            dgvBook.Columns["Editora"].Width = 175;
            dgvBook.Columns["Estado"].Width = 123;

            dgvBook.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11);
            dgvBook.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(30, 30, 32);

            dgvBook.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        private void UpdatePaginationLabel()
        {
            if (totalPages > 0)
                lblPagination.Text = $"Página {currentPage} de {totalPages}";
            else
                lblPagination.Text = "Não há registos";
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
            currentPage = 1;
            LoadAllData();
        }

        private void txtSearch_DGV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter_DGV.Text == "Número de Registo")
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void cbxFilter_DGV_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtSearch_DGV.Texts = "";
            this.txtSearch_DGV.Focus();
        }

        private void txtSearch_DGV_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

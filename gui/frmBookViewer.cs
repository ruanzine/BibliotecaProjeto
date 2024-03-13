using BIBLIOTECA_PROJETO.classes;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel;


namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmBookViewer : Form
    {
        private RegistoLivro Registo_Livro;
        MainForm mainForm = new MainForm();

        private int currentPage = 1;
        private int itemsPerPage = 11;
        private int totalPages = 0;


        public frmBookViewer()
        {
            InitializeComponent();
            this.Registo_Livro = new RegistoLivro();

        }

        private void bttPrint_Search_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Arquivo Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar arquivo Excel";
                    saveFileDialog.FileName = "nome_do_arquivo";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Planilha1");

                            // Adicionar o nome das colunas
                            for (int j = 0; j < dgvBook.Columns.Count; j++)
                            {
                                worksheet.Cell(1, j + 1).Value = dgvBook.Columns[j].HeaderText;
                            }

                            // Preencher a planilha com os dados da DataGridView
                            for (int i = 0; i < dgvBook.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvBook.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgvBook.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            // Salvar o arquivo do Excel
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Arquivo exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillDGV(int page, int itemsPerPage)
        {
            try
            {
                string selectedOption = this.cbxFilter_DGV.Texts;
                string searchText = this.txtSearch_DGV.Texts;

                DataTable dt;

                switch (selectedOption)
                {
                    case "Todos":
                        //MEXER NA LOGICA DISSO? 
                        // POR COMO PADRÃO O GETBOOKS BY TITULO
                        dt = this.Registo_Livro.GetBooksByTitulo(searchText, page, itemsPerPage);
                        break;
                    case "Número de Registo":
                        int numeroRegistro = int.TryParse(searchText, out int numReg) ? numReg : -1;
                        dt = this.Registo_Livro.GetBooksByNumeroRegistro(numeroRegistro, page, itemsPerPage);
                        break;
                    case "Autor":
                        dt = this.Registo_Livro.GetBooksByAutor(searchText, page, itemsPerPage);
                        break;
                    case "Título":
                        dt = this.Registo_Livro.GetBooksByTitulo(searchText, page, itemsPerPage);
                        break;
                    case "Cota":
                        dt = this.Registo_Livro.GetBooksByCota(searchText, page, itemsPerPage);
                        break;
                    case "Estado":
                        dt = this.Registo_Livro.GetBooksByEstado(searchText, page, itemsPerPage);
                        break;
                    default:
                        dt = this.Registo_Livro.GetBooksByTitulo(searchText, page, itemsPerPage);
                        break;
                }

                this.dgvBook.DataSource = dt;
                ResizeData();

                // Obter o número total de registros para calcular o número total de páginas
                int totalCount = this.Registo_Livro.GetTotalBooksCount(searchText); // Alteração aqui
                totalPages = (int)Math.Ceiling((double)totalCount / itemsPerPage);
                UpdatePaginationLabel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResizeData()
        {
            //Header name resize
            dgvBook.Columns["Nº"].Width = 50; // Define a largura da coluna
            dgvBook.Columns["Data de Entrada"].Width = 90;
            dgvBook.Columns["Título"].Width = 270;
            dgvBook.Columns["Autor"].Width = 150;
            dgvBook.Columns["Cota"].Width = 130;
            dgvBook.Columns["Nº de Volume"].Width = 45;
            dgvBook.Columns["Aquisição"].Width = 75;
            dgvBook.Columns["Observações"].Width = 200;
            dgvBook.Columns["Editora"].Width = 175;
            dgvBook.Columns["Estado"].Width = 123;

            //Font
            dgvBook.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgvBook.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            dgvBook.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            dgvBook.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvBook.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetRowHeight(dgvBook, 40);


        }
       
        private void UpdatePaginationLabel()
        {
            lblPagination.Text = $"Página {currentPage} de {totalPages}";
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = rowHeight;
            }
        }
        private void bttPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV(currentPage, itemsPerPage);
                UpdatePaginationLabel(); // Atualiza a label de paginação
            }
        }

        private void bttNextPage_Click(object sender, EventArgs e)
        {
            // Verifica se há mais itens para mostrar na próxima página
            if (dgvBook.Rows.Count >= itemsPerPage)
            {
                currentPage++;
                FillDGV(currentPage, itemsPerPage);
                UpdatePaginationLabel(); // Atualiza a label de paginação
            }
        }

        private void txtSearch_DGV__TextChanged(object sender, EventArgs e)
        {
            // Reinicia a página atual para a primeira página sempre que o texto da pesquisa for alterado
            currentPage = 1;
            this.FillDGV(currentPage, itemsPerPage);
            UpdatePaginationLabel(); // Atualiza a label de paginação
        }


    }
}
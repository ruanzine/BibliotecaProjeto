using BIBLIOTECA_PROJETO.classes;
using System;
using System.Data;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmBookViewer : Form
    {
        private RegistoLivro Registo_Livro;
        MainForm mainForm = new MainForm();

        private int currentPage = 1;
        private int itemsPerPage = 10;


        public frmBookViewer()
        {
            InitializeComponent();
        }

        private void bttSearchBook_Click(object sender, EventArgs e)
        {
            
        }

        //private void bttPrint_Search_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
        //        {
        //            saveFileDialog.Filter = "Arquivo Excel|*.xlsx";
        //            saveFileDialog.Title = "Salvar arquivo Excel";
        //            saveFileDialog.FileName = "nome_do_arquivo";

        //            if (saveFileDialog.ShowDialog() == DialogResult.OK)
        //            {
        //                using (var workbook = new XLWorkbook())
        //                {
        //                    var worksheet = workbook.Worksheets.Add("Planilha1");

        //                    // Adicionar o nome das colunas
        //                    for (int j = 0; j < dgvListagem.Columns.Count; j++)
        //                    {
        //                        worksheet.Cell(1, j + 1).Value = dgvListagem.Columns[j].HeaderText;
        //                    }

        //                    // Preencher a planilha com os dados da DataGridView
        //                    for (int i = 0; i < dgvListagem.Rows.Count; i++)
        //                    {
        //                        for (int j = 0; j < dgvListagem.Columns.Count; j++)
        //                        {
        //                            worksheet.Cell(i + 2, j + 1).Value = dgvListagem.Rows[i].Cells[j].Value.ToString();
        //                        }
        //                    }

        //                    // Salvar o arquivo do Excel
        //                    workbook.SaveAs(saveFileDialog.FileName);
        //                    MessageBox.Show("Arquivo exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Ocorreu um erro ao exportar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        public void FillDGV(int page, int itemsPerPage)
        {
            try
            {
                string selectedOption = this.cbxFilter_DGV.Text;
                string searchText = this.txtSearch_DGV.Text;

                
                DataTable dt;

                switch (selectedOption)
                {
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
                        dt = this.Registo_Livro.GetBooks(page, itemsPerPage);
                        break;
                }

                this.dgvBook.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                FillDGV(currentPage, itemsPerPage);
                UpdatePageTextBox();
            }
        }

        private void bttNextPage_Click(object sender, EventArgs e)
        {
            // Verifica se há mais itens para mostrar na próxima página
            if (dgvBook.Rows.Count >= itemsPerPage)
            {
                currentPage++;
                FillDGV(currentPage, itemsPerPage);
                UpdatePageTextBox();
            }
        }

        private void UpdatePageTextBox()
        {
            txtPageNumber.Text = currentPage.ToString();
        }


        private void pnlControls_DVG_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmBookViewer_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_DGV_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_DGV__TextChanged(object sender, EventArgs e)
        {
            this.Registo_Livro = new RegistoLivro();
            this.FillDGV(currentPage, itemsPerPage);
        }
    }
}

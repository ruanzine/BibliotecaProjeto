using BIBLIOTECA_PROJETO.classes;
using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmFilteredListing : Form
    {
        private RegistoLivro Registo_Livro;
        public frmFilteredListing()
        {
            InitializeComponent();
        }

        private void bttPrint_Click(object sender, EventArgs e)
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
                            for (int j = 0; j < dgvFilteredListing.Columns.Count; j++)
                            {
                                worksheet.Cell(1, j + 1).Value = dgvFilteredListing.Columns[j].HeaderText;
                            }

                            // Preencher a planilha com os dados da DataGridView
                            for (int i = 0; i < dgvFilteredListing.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvFilteredListing.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgvFilteredListing.Rows[i].Cells[j].Value.ToString();
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

        private void bttSearch_Click(object sender, EventArgs e)
        {
            this.Registo_Livro = new Registo_Livro();
            FillDGV();


        }

        public void FillDGV()
        {
            try
            {
                string selectedOption = this.cbxFilter.Texts;
                dgvFilteredListing.DataSource = null;

                DataTable dt = new DataTable();

                switch (selectedOption)
                {
                    case "Nº de Registo":
                        dt = this.Registo_Livro.GetAllNRegs();
                        break;
                    case "Autor":
                        dt = this.Registo_Livro.GetAllAuthors();
                        break;
                    case "Título":
                        dt = this.Registo_Livro.GetAllTitles();
                        break;
                    case "Cota":
                        dt = this.Registo_Livro.GetAllCotas();
                        break;
                    case "Estado":
                        dt = this.Registo_Livro.GetAllLost();
                        break;
                    default:
                        MessageBox.Show("Filtro inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                }

                this.dgvFilteredListing.DataSource = dt;

                if (this.cbxFilter.Texts == "Nº de Registo") // Verifica se o índice selecionado é igual a 1
                {
                    ResizeNReg();
                }
                else if (this.cbxFilter.Texts == "Título")
                {
                    ResizeTitle();
                }
                else if (this.cbxFilter.Texts == "Autor")
                {
                    ResizeAuthor();
                }
                else if (this.cbxFilter.Texts == "Cota")
                {
                    ResizeCota();
                }
                else if (this.cbxFilter.Texts == "Estado")
                {
                    ResizeState();
                }
                else
                {
                    ResizeData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResizeNReg()
        {
            //Column width
            this.dgvFilteredListing.Columns["Nº de Registo"].Width = 50;
            this.dgvFilteredListing.Columns["Título"].Width = 250;

            //Font size
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Text Allignment
            this.dgvFilteredListing.Columns["Nº de Registo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna

        }

        public void ResizeAuthor()
        {

            //Header name resize
            this.dgvFilteredListing.Columns["Autor"].Width = 250;

            //Font size and colour
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvFilteredListing.Columns["Autor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvFilteredListing, 40);
        }

        public void ResizeTitle()
        {
            //Header name resize
            this.dgvFilteredListing.Columns["Título"].Width = 250;


            //Font size and colour
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.SetRowHeight(this.dgvFilteredListing, 40);
        }

        public void ResizeCota()
        {
            this.dgvFilteredListing.Columns["Cota"].Width = 130;

            //Font size and colour
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvFilteredListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            this.SetRowHeight(this.dgvFilteredListing, 40);

        }

        public void ResizeState()
        {
            //Header name resize
            this.dgvFilteredListing.Columns["Nº de Registo"].Width = 50; // Define a largura da coluna
            this.dgvFilteredListing.Columns["Título"].Width = 250;
            this.dgvFilteredListing.Columns["Estado"].Width = 150;

            //Font size and colour
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvFilteredListing.Columns["Nº de Registo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna

            this.SetRowHeight(this.dgvFilteredListing, 40);
        }

        public void ResizeData()
        {
            //Header name resize
            this.dgvFilteredListing.Columns["Nº"].Width = 50; // Define a largura da coluna
            this.dgvFilteredListing.Columns["Data de Entrada"].Width = 90;
            this.dgvFilteredListing.Columns["Título"].Width = 225;
            this.dgvFilteredListing.Columns["Autor"].Width = 150;
            this.dgvFilteredListing.Columns["Cota"].Width = 130;
            this.dgvFilteredListing.Columns["Nº de Volume"].Width = 45;
            this.dgvFilteredListing.Columns["Aquisição"].Width = 75;
            this.dgvFilteredListing.Columns["Observações"].Width = 200;
            this.dgvFilteredListing.Columns["Editora"].Width = 175;
            this.dgvFilteredListing.Columns["Estado"].Width = 123;

            //Font size and colour
            this.dgvFilteredListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvFilteredListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvFilteredListing.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            this.dgvFilteredListing.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvFilteredListing.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvFilteredListing, 40);
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows) row.Height = rowHeight;
        }

        private void cbxFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbxFilter.Texts == "Nº de Registo")
            {
                this.rjComboBox_SelectAll.Visible = false;
            }
            if (cbxFilter.Texts == "Autor")
            {
                this.Registo_Livro = new Registo_Livro();

                // Buscar os autores na base de dados
                List<string> autores = Registo_Livro.GetAuthors_List();

                // Limpar os itens da combobox
                rjComboBox_SelectAll.Items.Clear();

                // Adicionar os autores à combobox
                rjComboBox_SelectAll.Items.AddRange(autores.ToArray());
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;


            }
            if (cbxFilter.Texts == "Cota")
            {
                this.Registo_Livro = new Registo_Livro();

                // Buscar os autores na base de dados
                List<string> cotas = Registo_Livro.GetCotas_List();

                // Limpar os itens da combobox
                rjComboBox_SelectAll.Items.Clear();

                // Adicionar os autores à combobox
                rjComboBox_SelectAll.Items.AddRange(cotas.ToArray());
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;

            }
            if (cbxFilter.Texts == "Estado")
            {
                // Preencher a combobox rjComboBox_SelectAll com a lista de estados possíveis
                rjComboBox_SelectAll.Items.Clear();
                rjComboBox_SelectAll.Items.AddRange(new string[] { "Disponível", "Indisponível", "Abatido", "Perdido", "Consulta local", "Exposição", "Depósito" });
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;
            }

            if (cbxFilter.Texts == "Título")
            {
                this.Registo_Livro = new Registo_Livro();
                // Buscar os autores na base de dados
                List<string> titulos = Registo_Livro.GetTitles_List();

                // Limpar os itens da combobox
                rjComboBox_SelectAll.Items.Clear();

                // Adicionar os autores à combobox
                rjComboBox_SelectAll.Items.AddRange(titulos.ToArray());
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;
            }
        }

        private void rjComboBox_SelectAll_OnSelectedIndexChanged(object sender, EventArgs e)
        {


            if (cbxFilter.Texts == "<Filtro Avançado>")
            {
                this.bttSearchListing.Visible = true;

            }
            else if (cbxFilter.Texts == "Título")
            {
                this.bttSearchListing.Visible = true;
                this.bttSearchListing.Enabled = false;
                this.cbxFilter.Enabled = false;

                this.Registo_Livro = new Registo_Livro();
                string tituloSelecionado = rjComboBox_SelectAll.Texts;
                // Realizar a consulta no banco de dados para obter os livros do estado selecionado
                DataTable livrosDoTitulo = Registo_Livro.GetBooksByTitle_Listing(tituloSelecionado);

                // Limpar as colunas existentes no DataGridView
                dgvFilteredListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvFilteredListing.DataSource = null;
                // Limpar as linhas existentes no DataGridView
                dgvFilteredListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvFilteredListing.Columns.Add("NumeroRegistro", "Nº de Registo");
                dgvFilteredListing.Columns.Add("Titulo", "Título");
                dgvFilteredListing.Columns.Add("Cota", "Cota");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosDoTitulo.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº de Registo"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();

                    dgvFilteredListing.Rows.Add(numeroRegistro, titulo, cota);
                }
            }
            else if (cbxFilter.Texts == "Estado")
            {
                this.bttSearchListing.Enabled = false;
                this.cbxFilter.Enabled = false;
                string estadoSelecionado = rjComboBox_SelectAll.Texts;
                this.Registo_Livro = new Registo_Livro();
                // Realizar a consulta no banco de dados para obter os livros do estado selecionado
                DataTable livrosDoEstado = Registo_Livro.GetBooksByEstado_L(estadoSelecionado);

                // Limpar as colunas existentes no DataGridView
                dgvFilteredListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvFilteredListing.DataSource = null;

                // Limpar as linhas existentes no DataGridView
                dgvFilteredListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvFilteredListing.Columns.Add("NumeroRegistro", "Nº");
                dgvFilteredListing.Columns.Add("Titulo", "Título");
                dgvFilteredListing.Columns.Add("Cota", "Cota");
                dgvFilteredListing.Columns.Add("Estado", "Estado");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosDoEstado.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();
                    string estado = row["Estado"].ToString();

                    dgvFilteredListing.Rows.Add(numeroRegistro, titulo, cota, estado);
                }
            }
            else if (cbxFilter.Texts == "Cota")
            {
                this.cbxFilter.Enabled = false;
                this.bttSearchListing.Enabled = false;
                string cotaSelecionada = rjComboBox_SelectAll.Texts;

                // Realizar a consulta no banco de dados para obter os livros do autor selecionado
                DataTable livrosCota = Registo_Livro.GetBooksByCota_Listing(cotaSelecionada);

                // Limpar as colunas existentes no DataGridView
                dgvFilteredListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvFilteredListing.DataSource = null;

                // Limpar as linhas existentes no DataGridView
                dgvFilteredListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvFilteredListing.Columns.Add("NumeroRegistro", "Nº de Registo");
                dgvFilteredListing.Columns.Add("Titulo", "Título");
                dgvFilteredListing.Columns.Add("Cota", "Cota");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosCota.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº de Registo"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();

                    dgvFilteredListing.Rows.Add(numeroRegistro, titulo, cota);
                }
            }
            else if (cbxFilter.Texts == "Autor")
            {
                this.bttSearchListing.Enabled = false;
                this.cbxFilter.Enabled = false;
                string autorSelecionado = rjComboBox_SelectAll.Texts;

                // Realizar a consulta no banco de dados para obter os livros do autor selecionado
                DataTable livrosDoAutor = Registo_Livro.GetBooksByAuthor_Listing(autorSelecionado);

                // Limpar as colunas existentes no DataGridView
                dgvFilteredListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvFilteredListing.DataSource = null;

                // Limpar as linhas existentes no DataGridView
                dgvFilteredListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvFilteredListing.Columns.Add("NumeroRegistro", "Nº de Registo");
                dgvFilteredListing.Columns.Add("Titulo", "Título");
                dgvFilteredListing.Columns.Add("Cota", "Cota");
                dgvFilteredListing.Columns.Add("Estado", "Estado");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosDoAutor.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº de Registo"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();
                    string estado = row["Estado"].ToString();

                    dgvFilteredListing.Rows.Add(numeroRegistro, titulo, cota, estado);
                }

            }
            else
            {
                this.bttSearchListing.Visible = true;

            }


        }
        private void bttBackMode_Click(object sender, EventArgs e)
        {
            // Limpar as colunas existentes no DataGridView
            this.dgvFilteredListing.Columns.Clear();

            // Definir o DataSource como null para permitir a limpeza das linhas
            this.dgvFilteredListing.DataSource = null;

            this.cbxFilter.Enabled = true;
            this.rjComboBox_SelectAll.Texts = "<Filtro Avançado>";
            this.bttSearchListing.Visible = true;
            this.bttSearchListing.Enabled = true;


        }
    }
}
}

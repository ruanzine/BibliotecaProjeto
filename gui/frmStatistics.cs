using BIBLIOTECA_PROJETO.services;
using System;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    public partial class frmStatistics : Form
    {
        private readonly BookStatisticsService _statisticsService;

        private const string Disponivel = "Disponível";
        private const string Indisponivel = "Indisponível";
        private const string Abatido = "Abatido";
        private const string Perdido = "Perdido";
        private const string ConsultaLocal = "Consulta local";
        private const string Exposicao = "Exposição";
        private const string Deposito = "Depósito";

        public frmStatistics()
        {
            InitializeComponent();
            _statisticsService = new BookStatisticsService();
            LoadStatistics();
        }

        private void LoadStatistics()
        {
            try
            {
                SetLabelText(lblTotalBooks, "Total de Livros", _statisticsService.GetTotalBooksCount());
                SetLabelText(lblTotalTitles, "Total de Títulos", _statisticsService.GetTotalTitlesCount());
                SetLabelText(lblTotalAuthors, "Total de Autores", _statisticsService.GetTotalAuthorsCount());
                SetLabelText(lblTotalCotas, "Total de Cotas", _statisticsService.GetTotalCotasCount());

                SetLabelText(lblDisponivel, Disponivel, _statisticsService.GetBooksCountByEstado(Disponivel));
                SetLabelText(lblIndisponivel, Indisponivel, _statisticsService.GetBooksCountByEstado(Indisponivel));
                SetLabelText(lblAbatido, Abatido, _statisticsService.GetBooksCountByEstado(Abatido));
                SetLabelText(lblPerdido, Perdido, _statisticsService.GetBooksCountByEstado(Perdido));
                SetLabelText(lblConsultaLocal, ConsultaLocal, _statisticsService.GetBooksCountByEstado(ConsultaLocal));
                SetLabelText(lblExposicao, Exposicao, _statisticsService.GetBooksCountByEstado(Exposicao));
                SetLabelText(lblDeposito, Deposito, _statisticsService.GetBooksCountByEstado(Deposito));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as estatísticas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally log the error if a logging system is in place
                // Logger.LogError(ex, "Erro ao carregar as estatísticas");
            }
        }

        private void SetLabelText(Label label, string labelText, int count)
        {
            label.Text = $"{labelText}: {count}";
        }
    }
}

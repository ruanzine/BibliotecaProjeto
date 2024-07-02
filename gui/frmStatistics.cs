using BIBLIOTECA_PROJETO.services;
using System;
using System.Windows.Forms;

namespace BIBLIOTECA_PROJETO.gui
{
    /// <summary>
    /// Represents a form for displaying book statistics.
    /// </summary>
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
        private int libraryID;

        /// <summary>
        /// Initializes a new instance of the <see cref="frmStatistics"/> class.
        /// </summary>
        public frmStatistics(int selectedLibraryId)
        {
            InitializeComponent();
            _statisticsService = new BookStatisticsService();
            this.libraryID = selectedLibraryId;
            LoadStatistics();
        }

        /// <summary>
        /// Loads the statistics data and updates the labels.
        /// </summary>
        private void LoadStatistics()
        {
            try
            {
                SetLabelText(lblTotalBooks, "Total de Livros", _statisticsService.GetTotalBooksCount(libraryID));
                SetLabelText(lblTotalTitles, "Total de Títulos", _statisticsService.GetTotalTitlesCount(libraryID));
                SetLabelText(lblTotalAuthors, "Total de Autores", _statisticsService.GetTotalAuthorsCount(libraryID));
                SetLabelText(lblTotalCotas, "Total de Cotas", _statisticsService.GetTotalClassificationsCount(libraryID));

                SetLabelText(lblDisponivel, Disponivel, _statisticsService.GetBooksCountByCondition(Disponivel, libraryID));
                SetLabelText(lblIndisponivel, Indisponivel, _statisticsService.GetBooksCountByCondition(Indisponivel, libraryID));
                SetLabelText(lblAbatido, Abatido, _statisticsService.GetBooksCountByCondition(Abatido, libraryID));
                SetLabelText(lblPerdido, Perdido, _statisticsService.GetBooksCountByCondition(Perdido, libraryID));
                SetLabelText(lblConsultaLocal, ConsultaLocal, _statisticsService.GetBooksCountByCondition(ConsultaLocal, libraryID));
                SetLabelText(lblExposicao, Exposicao, _statisticsService.GetBooksCountByCondition(Exposicao, libraryID));
                SetLabelText(lblDeposito, Deposito, _statisticsService.GetBooksCountByCondition(Deposito, libraryID));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar as estatísticas: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Optionally log the error if a logging system is in place
                // Logger.LogError(ex, "Erro ao carregar as estatísticas");
            }
        }

        /// <summary>
        /// Sets the text of the specified label with the given count.
        /// </summary>
        /// <param name="label">The label to set the text for.</param>
        /// <param name="labelText">The text to display before the count.</param>
        /// <param name="count">The count to display.</param>
        private void SetLabelText(Label label, string labelText, int count)
        {
            label.Text = $"{labelText}: {count}";
        }
    }
}

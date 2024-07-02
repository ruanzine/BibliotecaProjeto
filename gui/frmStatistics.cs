using BIBLIOTECA_PROJETO.services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using BIBLIOTECA_PROJETO.controls;
using System.Linq;

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
        private ThemeColors currentThemeColors;

        private readonly Dictionary<int, ThemeColors> themeColors = new Dictionary<int, ThemeColors>
        {
            { 1, new ThemeColors(Color.FromArgb(252, 168, 183), Color.FromArgb(255, 102, 106), Color.FromArgb(64, 12, 3), Color.FromArgb(121, 57, 59), Color.FromArgb(64, 12, 3)) },
            { 2, new ThemeColors(Color.FromArgb(146, 211, 157), Color.FromArgb(71, 174, 88), Color.FromArgb(6, 54, 49), Color.FromArgb(10, 97, 69), Color.FromArgb(6, 54, 49)) },
            { 3, new ThemeColors(Color.FromArgb(151, 199, 234), Color.FromArgb(103, 166, 229), Color.FromArgb(23, 23, 55), Color.FromArgb(56, 83, 117), Color.FromArgb(33, 50, 88)) }
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="frmStatistics"/> class.
        /// </summary>
        public frmStatistics(int selectedLibraryId)
        {
            InitializeComponent();
            _statisticsService = new BookStatisticsService();
            this.libraryID = selectedLibraryId;
            LoadStatistics();
            SetThemeColors();
        }

        #region Theme Setting

        private void SetThemeColors()
        {
            if (themeColors.TryGetValue(libraryID, out currentThemeColors))
            {
                ApplyThemeToTextboxes(gpbLeft);
                ApplyThemeToTextboxes(gpbRight);

                lblTitle.ForeColor = currentThemeColors.ButtonColor;
                pnlFormFooter.BackColor = currentThemeColors.PanelHeaderColor;
                pnlFormBody.BackColor = currentThemeColors.PanelBodyColor;
                pnlFormHeader.BackColor = currentThemeColors.PanelHeaderColor;
                pnlLineBottom.BackColor = currentThemeColors.ButtonColor;
                pnlLineTop.BackColor = currentThemeColors.ButtonColor;
                lblCondition.ForeColor = currentThemeColors.LabelColor;
                gpbLeft.BackColor = currentThemeColors.PanelBodyColor;
                gpbRight.BackColor = currentThemeColors.PanelBodyColor;
                gpbLeft.ForeColor = currentThemeColors.GroupBoxColor;
                gpbRight.ForeColor = currentThemeColors.GroupBoxColor;

                
            }
        }

        #endregion

        private void ApplyThemeToTextboxes(Control parent)
        {
            foreach (UC_textbox textBox in parent.Controls.OfType<UC_textbox>())
            {
                textBox.BorderColor = currentThemeColors.LabelColor;
                textBox.BorderFocusColor = currentThemeColors.LabelColor;
            }

            foreach (Label label in parent.Controls.OfType<Label>())
            {
                label.ForeColor = currentThemeColors.LabelColor;
                label.BackColor = currentThemeColors.PanelBodyColor;
            }
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
        private class ThemeColors
        {
            public Color ButtonColor { get; }
            public Color PanelHeaderColor { get; }
            public Color PanelBodyColor { get; }
            public Color LabelColor { get; }
            public Color GroupBoxColor { get; }

            public ThemeColors(Color panelHeaderColor, Color panelBodyColor, Color labelColor, Color buttonColor, Color groupBoxColor)
            {
                PanelHeaderColor = panelHeaderColor;
                PanelBodyColor = panelBodyColor;
                LabelColor = labelColor;
                ButtonColor = buttonColor;
                GroupBoxColor = groupBoxColor;
            }
        }
    }
}

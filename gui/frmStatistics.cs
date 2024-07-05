using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using BIBLIOTECA_PROJETO.services;
using BIBLIOTECA_PROJETO.controls;

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
        private int libraryID;
        private ThemeColors currentThemeColors;

        // Dicionário de cores para os temas
        private readonly Dictionary<int, ThemeColors> themeColors = new Dictionary<int, ThemeColors>
        {
            { 1, new ThemeColors(Color.FromArgb(252, 168, 183), Color.FromArgb(255, 102, 106), Color.FromArgb(64, 12, 3), Color.FromArgb(121, 57, 59), Color.FromArgb(64, 12, 3)) },
            { 2, new ThemeColors(Color.FromArgb(146, 211, 157), Color.FromArgb(71, 174, 88), Color.FromArgb(6, 54, 49), Color.FromArgb(10, 97, 69), Color.FromArgb(6, 54, 49)) },
            { 3, new ThemeColors(Color.FromArgb(151, 199, 234), Color.FromArgb(103, 166, 229), Color.FromArgb(23, 23, 55), Color.FromArgb(56, 83, 117), Color.FromArgb(33, 50, 88)) }
        };

        // Dicionário de cores vibrantes para as condições dos livros
        private readonly Dictionary<string, Color> conditionColors = new Dictionary<string, Color>
        {
            { Disponivel, Color.FromArgb(144, 238, 144) },   // Verde vibrante
            { Indisponivel, Color.FromArgb(255, 99, 71) },   // Vermelho tomate
            { Perdido, Color.FromArgb(255, 255, 102) },      // Amarelo brilhante
            { Deposito, Color.FromArgb(147, 112, 219) },     // Roxo médio
            { Exposicao, Color.FromArgb(100, 149, 237) },    // Azul centáurea
            { Abatido, Color.FromArgb(255, 165, 0) },        // Laranja
            { ConsultaLocal, Color.FromArgb(64, 224, 208) }  // Turquesa médio
        };

        public frmStatistics(int selectedLibraryId)
        {
            InitializeComponent();
            _statisticsService = new BookStatisticsService();
            this.libraryID = selectedLibraryId;
            SetThemeColors();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // Personalizar DataGridView
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatistics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatistics.MultiSelect = false;
            dgvStatistics.ReadOnly = true;

            // Personalizar o Gráfico
            chartStatistics.ChartAreas[0].AxisX.Title = "Estado";
            chartStatistics.ChartAreas[0].AxisY.Title = "Quantidade";
            chartStatistics.ChartAreas[0].AxisX.LabelStyle.Enabled = false; // Remover o texto de rótulo do eixo X
            chartStatistics.Legends.Clear(); // Limpar todas as legendas

            // Carregar dados e exibir o gráfico
            LoadBookConditionsData();
        }

        private void LoadBookConditionsData()
        {
            var conditions = new[] { Disponivel, Indisponivel, Abatido, Perdido, ConsultaLocal, Exposicao, Deposito };
            var dataTable = new DataTable();
            dataTable.Columns.Add("Estado", typeof(string));
            dataTable.Columns.Add("Quantidade", typeof(int));

            foreach (var condition in conditions)
            {
                int count = _statisticsService.GetBooksCountByCondition(condition, libraryID);
                dataTable.Rows.Add(condition, count);
            }

            dgvStatistics.DataSource = dataTable;

            // Exibir dados no gráfico
            chartStatistics.Series.Clear();

            foreach (var condition in conditions)
            {
                var series = new Series(condition)
                {
                    ChartType = SeriesChartType.Column,
                    Color = conditionColors[condition]
                };

                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["Estado"].ToString() == condition)
                    {
                        series.Points.AddXY(row["Estado"], row["Quantidade"]);
                        series.Points.Last().ToolTip = $"{row["Estado"]}: {row["Quantidade"]}";
                    }
                }

                chartStatistics.Series.Add(series);
            }

            // Adicionar a legenda
            var legend = new Legend("Legenda");
            legend.Docking = Docking.Top;
            chartStatistics.Legends.Add(legend);
        }

        private void SetThemeColors()
        {
            if (themeColors.TryGetValue(libraryID, out currentThemeColors))
            {
                lblTitle.ForeColor = currentThemeColors.ButtonColor;
                pnlFormFooter.BackColor = currentThemeColors.PanelHeaderColor;
                pnlFormBody.BackColor = currentThemeColors.PanelBodyColor;
                pnlFormHeader.BackColor = currentThemeColors.PanelHeaderColor;
                pnlLineBottom.BackColor = currentThemeColors.ButtonColor;
                pnlLineTop.BackColor = currentThemeColors.ButtonColor;
            }
        }

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

        private void pnlFormBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

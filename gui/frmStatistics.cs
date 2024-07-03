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

        private readonly Dictionary<int, ThemeColors> themeColors = new Dictionary<int, ThemeColors>
        {
            { 1, new ThemeColors(Color.FromArgb(252, 168, 183), Color.FromArgb(255, 102, 106), Color.FromArgb(64, 12, 3), Color.FromArgb(121, 57, 59), Color.FromArgb(64, 12, 3)) },
            { 2, new ThemeColors(Color.FromArgb(146, 211, 157), Color.FromArgb(71, 174, 88), Color.FromArgb(6, 54, 49), Color.FromArgb(10, 97, 69), Color.FromArgb(6, 54, 49)) },
            { 3, new ThemeColors(Color.FromArgb(151, 199, 234), Color.FromArgb(103, 166, 229), Color.FromArgb(23, 23, 55), Color.FromArgb(56, 83, 117), Color.FromArgb(33, 50, 88)) }
        };

        private readonly Dictionary<string, Color> conditionColors = new Dictionary<string, Color>
        {
            { Disponivel, Color.FromArgb(207, 228, 183) },
            { Indisponivel, Color.FromArgb(248, 193, 193) },
            { Perdido, Color.FromArgb(248, 237, 195) },
            { Deposito, Color.FromArgb(191, 175, 228) },
            { Exposicao, Color.FromArgb(199, 209, 255) },
            { Abatido, Color.FromArgb(244, 207, 173) },
            { ConsultaLocal, Color.FromArgb(191, 232, 255) }
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
            cbxChartMode.SelectedIndexChanged += CbxChartMode_SelectedIndexChanged;
            cbxChartMode.SelectedIndex = 0; // Set default mode

            // Customize DataGridView
            dgvStatistics.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStatistics.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStatistics.MultiSelect = false;
            dgvStatistics.ReadOnly = true;

            // Customize Chart
            chartStatistics.ChartAreas[0].AxisX.Title = "Category";
            chartStatistics.ChartAreas[0].AxisY.Title = "Count";
            chartStatistics.Legends.Add(new Legend("Legend"));

            LoadDataAndDisplayChart();
        }

        private void CbxChartMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataAndDisplayChart();
        }

        private void LoadDataAndDisplayChart()
        {
            string selectedMode = cbxChartMode.SelectedItem.ToString();
            if (selectedMode == "Book Conditions")
            {
                LoadBookConditionsData();
            }
            else if (selectedMode == "Books Added By Date")
            {
                LoadBooksAddedByDateData();
            }
        }

        private void LoadBookConditionsData()
        {
            var conditions = new[] { Disponivel, Indisponivel, Abatido, Perdido, ConsultaLocal, Exposicao, Deposito };
            var dataTable = new DataTable();
            dataTable.Columns.Add("Condition", typeof(string));
            dataTable.Columns.Add("Count", typeof(int));

            foreach (var condition in conditions)
            {
                int count = _statisticsService.GetBooksCountByCondition(condition, libraryID);
                dataTable.Rows.Add(condition, count);
            }

            dgvStatistics.DataSource = dataTable;

            // Display data in Chart
            chartStatistics.Series.Clear();
            var series = new Series("Book Conditions")
            {
                ChartType = SeriesChartType.Column
            };

            foreach (DataRow row in dataTable.Rows)
            {
                series.Points.AddXY(row["Condition"], row["Count"]);
                series.Points.Last().ToolTip = $"{row["Condition"]}: {row["Count"]}";

            }

            chartStatistics.Series.Add(series);
        }

        private void LoadBooksAddedByDateData()
        {
            var dataTable = _statisticsService.GetBooksAddedByDate(libraryID);
            dgvStatistics.DataSource = dataTable;

            // Display data in Chart
            chartStatistics.Series.Clear();
            var series = new Series("Books Added By Date")
            {
                ChartType = SeriesChartType.Column,
                BorderWidth = 3,
                Color = Color.Blue
            };

            foreach (DataRow row in dataTable.Rows)
            {
                series.Points.AddXY(row["Date"], row["Count"]);
                series.Points.Last().ToolTip = $"{row["Date"]}: {row["Count"]}"; ;
            }

            chartStatistics.Series.Add(series);
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
    }
}

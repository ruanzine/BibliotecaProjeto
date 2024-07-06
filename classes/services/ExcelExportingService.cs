using ClosedXML.Excel;
using System.Data;
using System.Linq;

namespace BIBLIOTECA_PROJETO.services
{
    public class ExcelExportService
    {
        public void ExportDataToExcel(DataTable data, string filter, string fileName)
        {
            using var workbook = new XLWorkbook();
            var worksheet = workbook.Worksheets.Add("Planilha1");

            // Set the header row
            for (int j = 0; j < data.Columns.Count; j++)
            {
                var cell = worksheet.Cell(1, j + 1);
                cell.Value = data.Columns[j].ColumnName;
                cell.Style.Font.Bold = true;
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
            }

            // Set the data rows
            for (int i = 0; i < data.Rows.Count; i++)
            {
                for (int j = 0; j < data.Columns.Count; j++)
                {
                    var cell = worksheet.Cell(i + 2, j + 1);
                    cell.Value = data.Rows[i][j].ToString();
                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                }
            }

            // Adjust column widths
            foreach (IXLColumn column in worksheet.ColumnsUsed())
            {
                column.AdjustToContents();
                // Set a maximum width limit
                if (column.Width > 30)
                {
                    column.Width = 30;
                }
            }

            // Add summary statistics below the table
            int summaryRowStart = data.Rows.Count + 3;
            worksheet.Cell(summaryRowStart, 3).Value = "Sumário:";
            worksheet.Cell(summaryRowStart, 3).Style.Font.Bold = true;
            worksheet.Cell(summaryRowStart, 3).Style.Font.FontSize = 14;

            bool isAdvancedView = data.Columns.Count > 1;

            if (!isAdvancedView)
            {
                switch (filter)
                {
                    case "Título":
                        AddSummary(worksheet, summaryRowStart, 3, "QUANTIDADE DE TÍTULOS:", data.Rows.Count);
                        AddDistinctSummary(worksheet, summaryRowStart + 1, 3, "QUANTIDADE DE TÍTULOS DISTINTOS:", "Título", data);
                        break;
                    case "Autor":
                        AddSummary(worksheet, summaryRowStart, 3, "QUANTIDADE DE AUTORES:", data.Rows.Count);
                        AddDistinctSummary(worksheet, summaryRowStart + 1, 3, "QUANTIDADE DE AUTORES DISTINTOS:", "Autor", data);
                        break;
                    case "Cota":
                        AddSummary(worksheet, summaryRowStart, 3, "QUANTIDADE DE CLASSIFICAÇÕES:", data.Rows.Count);
                        AddDistinctSummary(worksheet, summaryRowStart + 1, 3, "QUANTIDADE DE CLASSIFICAÇÕES DISTINTAS:", "Cota", data);
                        break;
                    default:
                        AddGeneralSummary(worksheet, summaryRowStart, 3, data);
                        break;
                }
            }
            else
            {
                AddGeneralSummary(worksheet, summaryRowStart, 3, data);
            }

            // Save the workbook
            workbook.SaveAs(fileName);
        }

        private void AddSummary(IXLWorksheet worksheet, int row, int column, string label, int value)
        {
            worksheet.Cell(row + 1, column).Value = label;
            worksheet.Cell(row + 1, column + 1).Value = value;
        }

        private void AddDistinctSummary(IXLWorksheet worksheet, int row, int column, string label, string columnName, DataTable data)
        {
            worksheet.Cell(row + 1, column).Value = label;
            worksheet.Cell(row + 1, column + 1).Value = data.AsEnumerable().Select(r => r.Field<string>(columnName)).Distinct().Count();
        }

        private void AddGeneralSummary(IXLWorksheet worksheet, int summaryRowStart, int column, DataTable data)
        {
            AddSummary(worksheet, summaryRowStart, column, "Total exemplares:", data.Rows.Count);
            AddDistinctSummary(worksheet, summaryRowStart + 1, column, "Títulos distintos:", "Título", data);
            AddDistinctSummary(worksheet, summaryRowStart + 2, column, "Autores distintos:", "Autor", data);
            AddDistinctSummary(worksheet, summaryRowStart + 3, column, "Cotas distintas:", "Cota", data);

            worksheet.Cell(summaryRowStart + 5, column).Value = "Ofertas:";
            worksheet.Cell(summaryRowStart + 5, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Aquisição") == "Oferta");

            worksheet.Cell(summaryRowStart + 6, column).Value = "Compras:";
            worksheet.Cell(summaryRowStart + 6, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Aquisição") == "Compra");

            worksheet.Cell(summaryRowStart + 7, column).Value = "Disponível:";
            worksheet.Cell(summaryRowStart + 7, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Estado") == "Disponível");

            worksheet.Cell(summaryRowStart + 8, column).Value = "Indisponível:";
            worksheet.Cell(summaryRowStart + 8, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Estado") == "Indisponível");

            worksheet.Cell(summaryRowStart + 9, column).Value = "Abatido:";
            worksheet.Cell(summaryRowStart + 9, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Estado") == "Abatido");

            worksheet.Cell(summaryRowStart + 10, column).Value = "Perdido:";
            worksheet.Cell(summaryRowStart + 10, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Estado") == "Perdido");

            worksheet.Cell(summaryRowStart + 11, column).Value = "Exposição:";
            worksheet.Cell(summaryRowStart + 11, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Estado") == "Exposição");

            worksheet.Cell(summaryRowStart + 12, column).Value = "Consulta Local:";
            worksheet.Cell(summaryRowStart + 12, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Estado") == "Consulta Local");

            worksheet.Cell(summaryRowStart + 13, column).Value = "Depósito:";
            worksheet.Cell(summaryRowStart + 13, column + 1).Value = data.AsEnumerable().Count(row => row.Field<string>("Estado") == "Depósito");
        }
    }
}

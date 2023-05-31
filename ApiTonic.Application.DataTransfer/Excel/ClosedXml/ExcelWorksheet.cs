using ApiTonic.Application.DataTransfer.Excel.Abstractions;
using ClosedXML.Excel;

namespace ApiTonic.Application.DataTransfer.Excel.ClosedXml
{
    public class ExcelWorksheet : IExcelWorksheet
    {
        private IXLWorksheet xlWorksheet;
        private IReadOnlyDictionary<string, IExcelCell> cells;

        public IExcelCell this[string cellAddress]
        {
            get
            {
                if (!cells.TryGetValue(cellAddress, out var cell))
                {
                    cell = new ExcelCell(xlWorksheet.Cell(cellAddress));
                }

                cells.Append(new KeyValuePair<string, IExcelCell>(cellAddress, cell));

                return cell;
            }
        }

        public ExcelWorksheet(IXLWorksheet worksheet)
        {
            xlWorksheet = worksheet;
            cells = new Dictionary<string, IExcelCell>();
        }
    }
}

using ApiTonic.Application.DataTransfer.Excel.Abstractions;
using ApiTonic.Application.DataTransfer.Exceptions;
using ClosedXML.Excel;

namespace ApiTonic.Application.DataTransfer.Excel.ClosedXml
{
    public class ExcelWorksheet : IExcelWorksheet
    {
        private IXLWorksheet xlWorksheet;
        private ExcelValidator excelValidator;
        private IReadOnlyDictionary<string, IExcelCell> cells;

        public IExcelCell this[string cellAddress]
        {
            get
            {
                if (!excelValidator.IsCellNameValid(cellAddress))
                {
                    throw new DataValidationException(@$"Invalid Excel cell name '{cellAddress}'");
                }

                if (!cells.TryGetValue(cellAddress, out var cell))
                {
                    cell = new ExcelCell(xlWorksheet.Cell(cellAddress));
                }

                cells.Append(new KeyValuePair<string, IExcelCell>(cellAddress, cell));

                return cell;
            }
        }

        public ExcelWorksheet(IXLWorksheet worksheet, ExcelValidator excelValidator)
        {
            xlWorksheet = worksheet;
            this.excelValidator = excelValidator;
            cells = new Dictionary<string, IExcelCell>();
        }
    }
}

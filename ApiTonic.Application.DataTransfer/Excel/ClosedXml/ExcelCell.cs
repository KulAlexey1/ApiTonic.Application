using ApiTonic.Application.DataTransfer.Excel.Abstractions;
using ClosedXML.Excel;

namespace ApiTonic.Application.DataTransfer.Excel.ClosedXml
{
    public class ExcelCell : IExcelCell
    {
        private readonly IXLCell cell;

        public string Text
        {
            get
            {
                return cell.GetText();
            }
            set
            {
                cell.Value = value;
            }
        }

        public ExcelCell(IXLCell cell)
        {
            this.cell = cell;
        }
    }
}

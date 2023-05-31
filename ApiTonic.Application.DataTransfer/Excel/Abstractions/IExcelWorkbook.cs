namespace ApiTonic.Application.DataTransfer.Excel.Abstractions
{
    public interface IExcelWorkbook
    {
        IReadOnlyDictionary<string, IExcelWorksheet> Worksheets { get; }
        IExcelWorksheet AddWorksheet(string name);
        void SaveAs(string fileName);
    }
}

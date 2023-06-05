namespace ApiTonic.Application.DataTransfer.Excel.Abstractions
{
    public interface IExcelWorkbook
    {
        IReadOnlyDictionary<string, IExcelWorksheet> Worksheets { get; }
        IExcelWorksheet AddWorksheet(string name);

        /// <returns>Base64 string</returns>
        string SaveAs();
    }
}

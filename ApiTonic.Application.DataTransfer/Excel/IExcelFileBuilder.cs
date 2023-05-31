namespace ApiTonic.Application.DataTransfer.Excel
{
    public interface IExcelFileBuilder
    {
        string BuildExcelFileUrl(string fileName, IDictionary<string, string> cellTextDict);
    }
}

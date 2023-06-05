namespace ApiTonic.Application.DataTransfer.Excel
{
    public interface IExcelFileBuilder
    {
        string BuildBase64(IDictionary<string, string> cellTextDict);
    }
}

using ApiTonic.Application.DataTransfer.Excel;

namespace ApiTonic.Application.API.Queries
{
    public class Query
    {
        public string GetExcelFileBase64(
            [Service] IExcelFileBuilder builder,
            Dictionary<string, string> cellTextDict)
        {
            return builder.BuildBase64(cellTextDict);
        }
    }
}

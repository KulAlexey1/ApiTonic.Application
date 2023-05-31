using ApiTonic.Application.DataTransfer.Excel;

namespace ApiTonic.Application.API.Queries
{
    public class Query
    {
        public string GetExcelFileUrlAsync(
            [Service] IExcelFileBuilder builder,
            string fileName,
            IDictionary<string, string> cellTextDict)
        {
            return builder.BuildExcelFileUrl(fileName, cellTextDict);
        }
    }
}

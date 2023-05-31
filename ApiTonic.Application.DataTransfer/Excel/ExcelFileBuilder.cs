using ApiTonic.Application.DataTransfer.Excel.Abstractions;

namespace ApiTonic.Application.DataTransfer.Excel
{
    public class ExcelFileBuilder : IExcelFileBuilder
    {
        private readonly IExcelWorkbook workbook;

        public ExcelFileBuilder(IExcelWorkbook workbook)
        {
            this.workbook = workbook;
        }

        public string BuildExcelFileUrl(string fileName, IDictionary<string, string> cellTextDict)
        {
            // use dict to add cells values
            //add path to store files to appSettings
            //create model for the paths
            // inject the model here
            // use path to SaveAs
            // validate fileName contains only name
            // delete th

            var worksheet = workbook.AddWorksheet("Sheet 1");
            workbook.SaveAs(fileName + ".xlsx");

            return "/TEST";
        }
    }
}

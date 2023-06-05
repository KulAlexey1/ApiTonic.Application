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

        public string BuildBase64(IDictionary<string, string> cellTextDict)
        {
            var worksheet = workbook.AddWorksheet("Sheet 1");

            foreach(var cellText in cellTextDict)
            {
                worksheet[cellText.Key].Text = cellText.Value;
            }

            return workbook.SaveAs();
        }
    }
}

using ApiTonic.Application.DataTransfer.Excel.Abstractions;
using ClosedXML.Excel;

namespace ApiTonic.Application.DataTransfer.Excel.ClosedXml
{
    public class ExcelWorkbook : IExcelWorkbook, IDisposable
    {
        private XLWorkbook xlWorkbook;
        private bool disposedValue;

        public IReadOnlyDictionary<string, IExcelWorksheet> Worksheets { get; }

        public ExcelWorkbook()
        {
            xlWorkbook = new XLWorkbook();
            Worksheets = new Dictionary<string, IExcelWorksheet>();
        }

        public IExcelWorksheet AddWorksheet(string name)
        {
            var worksheet = new ExcelWorksheet(xlWorkbook.AddWorksheet(name));

            Worksheets.Append(new KeyValuePair<string, IExcelWorksheet>(name, worksheet));

            return worksheet;
        }

        public void SaveAs(string fileName)
        {
            xlWorkbook.SaveAs(fileName);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    xlWorkbook.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~ExcelWorkbookBuilder()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

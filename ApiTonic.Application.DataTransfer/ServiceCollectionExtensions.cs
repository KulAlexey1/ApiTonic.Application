using ApiTonic.Application.DataTransfer.Excel;
using ApiTonic.Application.DataTransfer.Excel.Abstractions;
using ApiTonic.Application.DataTransfer.Excel.ClosedXml;
using Microsoft.Extensions.DependencyInjection;

namespace ApiTonic.Application.DataTransfer
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDataTransferServices(this IServiceCollection services)
        {
            services.AddScoped<IExcelWorkbook, ExcelWorkbook>();
            services.AddScoped<IExcelFileBuilder, ExcelFileBuilder>();
            services.AddScoped<ExcelValidator>();
        }
    }
}

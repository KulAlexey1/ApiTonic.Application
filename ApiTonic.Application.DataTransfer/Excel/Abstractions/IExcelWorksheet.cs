namespace ApiTonic.Application.DataTransfer.Excel.Abstractions
{
    public interface IExcelWorksheet
    {
        IExcelCell this[string cellAddress] { get; }
    }
}

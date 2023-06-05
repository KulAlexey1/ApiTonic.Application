using System.Text.RegularExpressions;

namespace ApiTonic.Application.DataTransfer.Excel
{
    public class ExcelValidator
    {
        public bool IsCellNameValid(string cellName)
        {
            return new Regex("^[A-Za-z]{1,3}[1-9]{1}[0-9]{0,5}$").IsMatch(cellName);
        }
    }
}

namespace ApiTonic.Application.DataTransfer.Exceptions
{
    public class DataValidationException : Exception
    {
        public DataValidationException(string message) : base(message)
        {
        }
    }
}

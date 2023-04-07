using System.Globalization;

namespace Inventory.API.Helpers
{
    public class AppException : Exception
    {
        public AppException() : base() { }

        public AppException(string message) : base(message) { }
        public AppException(int errorCode, string errorMessage)
        {
            this.ErrorMessage = errorMessage;
            this.ErrorCode = errorCode;
        }

        public AppException(string message, params object[] args)
            : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {
        }

        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

    }
}

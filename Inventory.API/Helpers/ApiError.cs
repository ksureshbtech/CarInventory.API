namespace Inventory.API.Helpers
{
    public class ApiError
    {

        public ApiError()
        {

        }

        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public Severity Severity { get; set; }

        public bool Success { get; set; }
    }
}

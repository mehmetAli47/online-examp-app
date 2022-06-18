namespace EsinavUygulamasi.Models.Request
{
    public class ResponseVM
    {
        public ErrorResponseVM Error { get; set; } = new ErrorResponseVM();

        public bool IsSuccess { get; set; } = false;

    }


    public class ErrorResponseVM
    {
        public string Error { get; set; }

        public string ErrorCode { get; set; }
    }
}

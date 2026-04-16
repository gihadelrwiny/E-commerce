namespace Ecomm_Api.Helper
{
    public class ResponseApi
    {
        public int statuscode;
        public string? Message { get; set; }

        public ResponseApi(int statuscode, string? message=null)
        {
            this.statuscode = statuscode;
            Message = message??getMessageFromStatuscode(statuscode); //لو مش null استخدمه   
            //طب لو null استخدم اللى بعد ??
        }
        public string getMessageFromStatuscode(int statuscode)
        {
            return statuscode switch
            {
                200 => "Done",
                400 => "BadRequest",
                401 => "UnAutherized",
                500 => "Server Error",
                _=> null,
            };
        }

   
    }
}

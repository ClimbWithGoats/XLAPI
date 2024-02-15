namespace ConsoleXLAPI.Models
{
    public class OutputMessage
    {
        public string? Date { get; set; }
        public int? ResultCode { get; set; }
        public string? Message { get; set; }
        public string? InnerMessage { get; set; }
        public string? ResultJson { get; set; }
        public string? Methods { get; set; }
        public Guid? Guid { get; set; }

        public static Task<OutputMessage> BadGuid(string guid, string Message)
        {
            return Task.FromResult(new OutputMessage()
            {
                Date = DateTime.Now.ToString("s"),
                Message = Message,
                Methods = nameof(BadGuid)
            });
        }

        public static Task<OutputMessage> ResultOk(string message, string v)
        {
            return Task.FromResult(
             new OutputMessage()
             {
                 Date = DateTime.Now.ToString("s"),
                 Message = message,
                 Methods = nameof(ResultOk)
             });
        }
    }
}
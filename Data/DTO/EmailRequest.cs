namespace Data.DTO
{
    public class EmailRequestByText
    {
        public string ToEmail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
    public class EmailRequest
    {
        public string ToEmail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
    public class EmailRequestNotify
    {
        public string ToEmail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }

}

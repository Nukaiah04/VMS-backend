namespace VMS.Models
{
    public class Authorization
    {
        public int AuthorizationId { get; set; }

        public string? UserName { get; set; }
        public string? Role { get; set; }
        public string? Permission { get; set; }
        public string? Status { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }
}
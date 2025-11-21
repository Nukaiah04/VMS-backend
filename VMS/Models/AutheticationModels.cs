namespace VMS.Models
{
    public class Authetication
    {
        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;

    }
}
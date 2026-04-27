using System.ComponentModel.DataAnnotations;

namespace VMS.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string Mobile { get; set; }
        public required string Password { get; set; }
        public required int RoleId { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedDate { get; set; } = DateTime.UtcNow;

    }
}

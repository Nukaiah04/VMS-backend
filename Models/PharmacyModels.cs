using System.ComponentModel.DataAnnotations;

namespace VMS.Models
{
    public class Pharmacy
    {
        [Key]
        public int pharmacyId { get; set; }
        public string? pharmacyName { get; set; }
        public string? pharmacyOperatorName { get; set; }
        public string? pharmacyPhoneNumber { get; set; }
        public string? password { get; set; }
        public string? status { get; set; } = "Active";
        public string? address { get; set; }
        public DateTime createdDate { get; set; } = DateTime.UtcNow;
        public DateTime updatedDate { get; set; } = DateTime.UtcNow;
    }
}
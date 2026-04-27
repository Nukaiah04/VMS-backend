using System.ComponentModel.DataAnnotations;

namespace VMS.Controllers
{
    public class Patients
    {
        [Key]
        public int PatientId { get; set; }
        public required string? FullName { get; set; }
        public required string? Phone { get; set; }
    }
}
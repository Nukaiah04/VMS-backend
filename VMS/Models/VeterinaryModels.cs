namespace VMS.Models
{
    public class Veterinary
{
    public int VetId { get; set; }
    public string? VetName { get; set; }
    public string? Qualification { get; set; }
    public int? ExperienceYears { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Email { get; set; }
    public string? ClinicName { get; set; }
    public string? Address { get; set; }
    public bool IsActive { get; set; } = true;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; } = DateTime.Now;
}
    }

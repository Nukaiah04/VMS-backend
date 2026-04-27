using System.ComponentModel.DataAnnotations;

namespace VMS.Models
{
    public class Vitals
    {
        [Key]
        public int VitalId { get; set; }
        public string? AppId { get; set; }
        public string? PersonName { get; set; }
        public string? Email { get; set; }
        public string? Moblie { get; set; }
        public string? Gender { get; set; }
        public string? Age { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? WellnessLevel { get; set; }
        public string? WellnessIndex { get; set; }
        public string? HeartRate { get; set; }
        public string? BloodPressure { get; set; }
        public string? Spo2 { get; set; }
        public string? BreathingRate { get; set; }
        public string? Hemoglobin { get; set; }
        public string? Hba1c { get; set; }
        public string? StressLevel { get; set; }
        public string? StressIndex { get; set; }
        public string? Bmi { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime Updated { get; set; } = DateTime.UtcNow;

    }
}
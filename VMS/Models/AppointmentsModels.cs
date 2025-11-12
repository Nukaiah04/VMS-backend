using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace VMS.Controllers
{

    public class Appointments
    {
        [Key]
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentDate { get; set; }
    }
}
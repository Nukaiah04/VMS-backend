using Microsoft.AspNetCore.Mvc;
using VMS.Data;

namespace VMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly ApplicationDbContext dbcontext;
        public AppointmentsController(ApplicationDbContext applicationDbContext)
        {
            dbcontext = applicationDbContext;
        }


        [HttpPost("Create")]
        public async Task<IActionResult> CreateNewAppointments([FromBody] Appointments appointment)
        {
            var Appointmentsdata = await dbcontext.Appointments.AddAsync(appointment);
            await dbcontext.SaveChangesAsync();
            return Ok(new { status = true, Message = "Appointments Onboard successfully", data = Appointmentsdata.Entity });
        }

        [HttpGet("Read")]
        public IActionResult getAppointments()
        {
            var Appointmentsdata = dbcontext.Appointments.ToList();
            return Ok(new { status = true, Message = "Appointments Onboard successfully", data = Appointmentsdata });
        }
    }
}
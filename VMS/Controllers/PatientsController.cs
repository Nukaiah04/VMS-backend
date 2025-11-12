using Microsoft.AspNetCore.Mvc;
using VMS.Controllers;
using VMS.Data;

namespace VMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class PatientsController(ApplicationDbContext applicationDbContext) : ControllerBase
    {
        private readonly ApplicationDbContext dbContext = applicationDbContext;


        [HttpPost("Create")]
        public async Task<IActionResult> InsertNewPatients([FromBody] Patients patient)
        {
            var Patientsdata = await dbContext.Patients.AddAsync(patient);
            await dbContext.SaveChangesAsync();
            return Ok(new { status = true, message = "patient onboard successfully", data = Patientsdata.Entity });
        }

        [HttpGet("Read")]
        public IActionResult getPatients()
        {
            var Patientsdata = dbContext.Patients.ToList();
            return Ok(new { status = true, message = "patient onboard successfully", data = Patientsdata });
        }


    }
 
}
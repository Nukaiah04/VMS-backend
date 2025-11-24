using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMS.Data;
using VMS.Models;

namespace VMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class HospitalController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
 
        public HospitalController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }

        [HttpPost("InsertNewHospital")]
        public async Task<IActionResult> InsertNewHospital([FromBody]Hospital hospital)
        {
            var hospitaldata = await dbContext.Hospital.AddAsync(hospital);
            await dbContext.SaveChangesAsync();             
            return Ok(new { message = "Hospital inserted successfully" } );
        } 

        
        [HttpGet("Read")]
        public async Task<IActionResult> getHospital()
        {
            var Hospitaldata = await dbContext.Hospital.ToListAsync();
            return Ok(new { status = true, message = "Hospital onboard successfully", data = Hospitaldata });
        }

    }
}
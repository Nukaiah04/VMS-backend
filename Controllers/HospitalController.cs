using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMS.Data;
using VMS.Models;

namespace VMS.Controllers
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
        public IActionResult InsertNewHospital([FromBody]Hospital hospital)
        {
            var hospitaldata = dbContext.Hospital.Add(hospital);
            dbContext.SaveChanges();             

            return Ok(new { message = "Hospital inserted successfully" } );
        } 

    }
}
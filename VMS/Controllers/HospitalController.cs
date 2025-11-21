// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using VMS.Data;
// using VMS.Models;

// namespace VMS.Controller
// {
//     [Route("api/[controller]")]
//     [ApiController]
    
//     public class HospitalController : ControllerBase
//     {
//         private readonly ApplicationDbContext dbContext;
 
//         public HospitalController(ApplicationDbContext applicationDbContext)
//         {
//             dbContext = applicationDbContext;
//         }

//         [HttpPost("InsertNewHospital")]
//         public async IActionResult InsertNewHospital([FromBody]Hospital hospital)
//         {
//             var hospitaldata = await dbContext.Hospital.AddAsync(hospital);
//             dbContext.SaveChangesAsync();             
//             return Ok(new { message = "Hospital inserted successfully" } );
//         } 

//     }
// }
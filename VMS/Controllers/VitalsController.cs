// using Microsoft.AspNetCore.Mvc;
// using VMS.Data;
// using VMS.Models;

// namespace VMS.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]

//     public class VitalsController : ControllerBase
//     {
//         private readonly ApplicationDbContext dbcontext;
//         public VitalsController(ApplicationDbContext applicationDbContext)
//         {
//             dbcontext = applicationDbContext;
//         }

//         [HttpPost("Create")]
//         public async Task<IActionResult> CreateNewVitals([FromBody] Vitals vital)
//         {
//             try
//             {
//                 var vitalData = await dbcontext.Vitals.AddAsync(vital);
//                 await dbcontext.SaveChangesAsync();
//                 return Ok(new { status = true, Message = "Vitals Saved successfully", data = vitalData.Entity });
//             }
//             catch (System.Exception ex)
//             {
//                 return StatusCode(500, new { status = false, Message = "Error occured while saving vitals", error = ex.InnerException?.Message });
//             }
//         }

//         [HttpGet("Read")]
//         public IActionResult GetVitals()
//         {
//             var vitalsData = dbcontext.Vitals.ToList();
//             return Ok(new { status = true, Message = "Vitals Onboard successfully", data = vitalsData });
//         }

//     }
    
// }
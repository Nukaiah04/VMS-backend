// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Migrations.Operations;
// using VMS.Data;
// using VMS.Models;
// namespace VMS.Controller
// {
//     [Route("api/[controller]")]
//     [ApiController]
                                                                             
//     public class PharmacyController : ControllerBase
//     {
//         private readonly ApplicationDbContext dbcontext;
//         public PharmacyController(ApplicationDbContext applicationDbContext)
//         {
//             dbcontext = applicationDbContext;
//         }

//         [HttpPost("Insertnewpharmacy")]
//         public async Task<IActionResult> CreateNewPharmacy(Pharmacy pharmacy)
//         {
//             var pharmacyData = await dbcontext.Pharmacy.AddAsync(pharmacy);
//             await dbcontext.SaveChangesAsync();
//             return Ok(new { status = true, message = "Pharamacy Onboarded successfully.", data = pharmacyData.Entity });
//         }
        
//         [HttpGet("GetAllPharmas")]
//         public IActionResult GetPharmas()
//         {
//             var pharmaData = dbcontext.Pharmacy.ToList();
//             return Ok(new { status = true, message = "Pharmacy Onboarded successfully.", data = pharmaData });  
//         }
//     }
// }  

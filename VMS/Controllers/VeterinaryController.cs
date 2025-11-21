using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMS.Data;
using VMS.Models;

namespace VMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class VeterinaryController : ControllerBase
    {
        private readonly ApplicationDbContext dbcontext;
        public VeterinaryController(ApplicationDbContext applicationDbContext)
        {
            dbcontext = applicationDbContext;

        }


        [HttpPost("Create")]
        public async Task<IActionResult> CreateVeterinary([FromBody] Veterinary veterinary)
        {
            var Data = await dbcontext.Veterinary.AddAsync(veterinary);
            await dbcontext.SaveChangesAsync();
            return Ok(new { status = true, message = "Veterinary Onboarded successfully.", data = Data.Entity});

        }
    }
    }

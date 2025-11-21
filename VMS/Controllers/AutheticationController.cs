using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMS.Data;

namespace VMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutheticationController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public AutheticationController(ApplicationDbContext dbC)
        {
            dbContext = dbC;
        }

        [HttpPost("InsertNewAuthetication")]
        public async Task<IActionResult> InsertNewAutheticationAsync([FromBody] Authetication authetication)
        {
            await dbContext.Authetication.AddAsync(authetication);  
            await dbContext.SaveChangesAsync();

            return Ok(new { message = "Authetication inserted successfully" });
        }
    }
} 
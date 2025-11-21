using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VMS.Data;
using VMS.Models;

namespace VMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthorizationController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public AuthorizationController(ApplicationDbContext dbC)
        {
            dbContext = dbC;
        }

        [HttpPost("InsertNewAuthorization")]
        public async Task<IActionResult> InsertNewAuthorization(Authorization authorization)
        {
            var authetication = await dbContext.Authorization.AddAsync(authorization);
            dbContext.SaveChanges();
            return Ok(new { message = "Authetication inserted successfully" });
        }
    }
}
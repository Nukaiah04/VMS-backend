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
        public IActionResult InsertNewAuthorization(Authorization authorization)
        {
            dbContext.Authorization.Add(authorization);
            dbContext.SaveChanges();
            return Ok(new { message = "Authetication inserted successfully" });
        }
    }
}
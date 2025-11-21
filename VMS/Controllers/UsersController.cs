using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;                    
using VMS.Data;
using VMS.Models;

namespace VMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]


    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext; 
        public UserController(ApplicationDbContext applicationDbContext)
        {
            dbContext = applicationDbContext;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> UserRegister([FromBody] Users users)
        {
            var result = await dbContext.Users.FirstOrDefaultAsync(e => e.Email == users.Email || e.Mobile == users.Mobile);
            if (result == null)
            {
                var userData = await dbContext.Users.AddAsync(users);
                await dbContext.SaveChangesAsync();
                return Ok(new { status = true, message = "Registered Successfully", data = userData.Entity });
            }
            else
            {
                if (result.Email == users.Email)
                {
                    return Conflict(new { status = false, message = "Email already registerd.Use diffrent email to create account or login with email" });

                }
                else if (result.Mobile == users.Mobile)
                {
                    return Conflict(new { status = false, message = "Mobile already registerd.Use diffrent Mobile to create account or login with Mobile" });

                }
                else
                {
                return Conflict(new { status = false, message = "successfully register" });   
                }
            }
        }
    }
}
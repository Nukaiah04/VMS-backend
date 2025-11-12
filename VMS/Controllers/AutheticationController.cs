// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;
// using VMS.Data;

// namespace VMS.Controllers
// {
//     [Route("api/[controller]")]
//     [ApiController]

//     public class AutheticationController :  ControllerBase
//     {
//         private readonly ApplicationDbContext dbContext;
//         public AutheticationController(ApplicationDbContext dbC)
//         {
//             dbContext = dbC;
//         }

//         [HttpPost("InsertNewAuthetication")]   
//         public IActionResult InsertNewAuthetication([FromBody]Authetication authetication)
//         {
//             var autheticationdata = dbContext.Authetication.Add(authetication);
//             dbContext.Savechanges();
//              return Ok(new { message = "Authetication inserted successfully" } );

//         }
//     }
// }
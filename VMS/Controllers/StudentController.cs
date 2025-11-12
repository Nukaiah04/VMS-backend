// using Microsoft.AspNetCore.Mvc;
// using VMS.Data;
// using VMS.Models;

// namespace VMS.Controller
// {
//     [Route("api/[controller]")]
//     [ApiController]

//     public class StudentController : ControllerBase
//     {
//         private readonly ApplicationDbContext dbcontext;
//         public StudentController(ApplicationDbContext applicationDbContext)
//         {
//             dbcontext = applicationDbContext;

//         }

//         [HttpPost("Insertnewstudent")]
//         public IActionResult CreateNewStudent([FromBody] Student student)
//         {
//             var studentData = dbcontext.Student.Add(student);
//             dbcontext.SaveChanges();
//             return Ok(new { status = true, message = "Student Onboarded successfully.", data = studentData.Entity });

//         }

//         [HttpGet("Getallstudent")]
//         public IActionResult GetStudent()
//         {
//             var Studentdata = dbcontext.Student.ToList();
//             return Ok(new { status = true, message = "Student onboard successfully.", data = Studentdata });
//          }
        
//     }

//     public class Students
//     {
//     }
// }
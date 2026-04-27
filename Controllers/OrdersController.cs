// using Microsoft.AspNetCore.Mvc;
// using VMS.Data;
// using VMS.Models;

// namespace VMS.Controller
// {
//     [Route("api/[controller]")]
//     [ApiController]

//     public class OrdersController : ControllerBase
//     {
//         private readonly ApplicationDbContext applicationDbContext;
//         public OrdersController(ApplicationDbContext dbContext)
//         {
//             applicationDbContext = dbContext;
//         }

//         [HttpPost("InsertNewOrders")]
//         public IActionResult InsertNewOrderscreate([FromBody] Orders orders)
//         {
//             applicationDbContext.Orders.Add(orders);
//             applicationDbContext.SaveChanges();
//             return Ok(new { });
//         }

//         [HttpGet("read")]
//         public IActionResult GetOrders()
//         {
//             var Data = applicationDbContext.Orders.ToList();
//             return Ok(new { status = true, message = "Order Onboarded successfully.", data = Data });
//         }
//     }
// }



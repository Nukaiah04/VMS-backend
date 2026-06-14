using Microsoft.AspNetCore.Mvc;
using VMS.Data;
using VMS.Models;

namespace VMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class Productcontroller : ControllerBase
    {
        private readonly ApplicationDbContext dbc;
        public Productcontroller(ApplicationDbContext applicationDbContext)
        {
            dbc = applicationDbContext;
        }

        [HttpPost("Create")]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            dbc.Product.Add(product);
            dbc.SaveChanges();
            return Ok(new { });
        }
        


    }


}


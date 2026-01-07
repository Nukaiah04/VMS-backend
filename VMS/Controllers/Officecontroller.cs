using Microsoft.AspNetCore.Mvc;
using VMS.Data;

namespace VMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfficeController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult SaveData()
        {
            return Ok(new { });
        }
// i am changing some issues
        [HttpPost("GetData")]
        public IActionResult GetData()
        {
            return Ok(new { });
        }
        
    }
}

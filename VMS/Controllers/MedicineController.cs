using Microsoft.AspNetCore.Mvc;
using VMS.Data;

namespace VMS.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {
        [HttpPost("")]
        public IActionResult SaveData()
        {
            return Ok(new { });
        }
        
    }
}
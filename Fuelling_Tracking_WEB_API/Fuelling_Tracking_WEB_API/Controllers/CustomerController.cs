using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fuelling_Tracking_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        [HttpPost("getCustomerDitail")]
        public IActionResult Customer() 
        {
            return Ok("Hello");
        
        }
    }
}

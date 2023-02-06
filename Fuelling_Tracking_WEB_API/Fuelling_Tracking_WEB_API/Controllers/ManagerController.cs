using Fuelling_Tracking_WEB_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Fuelling_Tracking_WEB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        [HttpPost]
        [Route("manager-login")]
        public IActionResult mmanagerLogin(FuleStation fuleStation)
        {
            if (fuleStation == null)
            {

                return NoContent();
            }
            {
                FuelingDbContext db = new FuelingDbContext();

                var ChackFuelStationLogin = db.FuleStations.Where(x => x.FuelStationRegCode == fuleStation.FuelStationRegCode && x.Password == fuleStation.Password).FirstOrDefault();
                if (ChackFuelStationLogin != null)
                {
                    return Ok("OtpTure");
                }
                else
                {
                    return Ok("NotFound");
                }
            }
        }
    }

    
}

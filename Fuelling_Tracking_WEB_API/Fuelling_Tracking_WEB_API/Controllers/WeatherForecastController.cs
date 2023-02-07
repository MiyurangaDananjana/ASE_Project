using Fuelling_Tracking_WEB_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Twilio.TwiML.Voice;

namespace Fuelling_Tracking_WEB_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfiguration _config; // Import the _configaration JWT

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }


        [HttpPost("authenticate")]
        public IActionResult Authentication(FuleStation fuleStation)
        {

            if (fuleStation == null)
            {
                return Ok("NotFound");
            }
            {
                FuelingDbContext db = new FuelingDbContext();

                var ChackFuelStationLogin = db.FuleStations.Where(x => x.FuelStationRegCode == fuleStation.FuelStationRegCode && x.Password == fuleStation.Password).FirstOrDefault();
                if (ChackFuelStationLogin != null)
                {
                    return Ok(new JWTService(_config).GenerateToken(
                                 ChackFuelStationLogin.Address

                               ));
                }
                else
                {
                    return Ok("NotFound");
                }
            }

           
        }
        


        [HttpGet(Name = "GetWeatherForecast")]
        [Authorize]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}

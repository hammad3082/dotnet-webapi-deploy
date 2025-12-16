using Microsoft.AspNetCore.Mvc;

namespace dotnet_webapi_deploy.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetWeather()
        {
            return Ok(new[]
            {
                new { Day = "Monday", Temp = 22 },
                new { Day = "Tuesday", Temp = 24 }
            });
        }

        [HttpGet("tip")]
        public IActionResult GetWeatherTip()
        {
            var tips = new[]
            {
                "Carry an umbrella if rain is expected.",
                "Wear light clothes on hot days.",
                "Stay hydrated during summer.",
                "Layer your clothing in unpredictable weather."
            };

            var random = new Random();
            var tip = tips[random.Next(tips.Length)];

            return Ok(new { Tip = tip });
        }
    }
}

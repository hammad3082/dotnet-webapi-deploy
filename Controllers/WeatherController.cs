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
    }
}

using Microsoft.AspNetCore.Mvc;

namespace BuilderPattern.Demo.Controllers
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
        private readonly IUser user;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IUser user)
        {
            _logger = logger;
            this.user = user;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IUser Get()
        {
            return user;
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Weather.Forecast;

namespace ProxyPattern.Demo.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{


    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherProvider _weatherProvider;

    public WeatherForecastController(ILogger<WeatherForecastController> logger,
        IWeatherProvider weatherProvider)
    {
        _logger = logger;
        _weatherProvider = weatherProvider;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return _weatherProvider.Get(4);
    }
}
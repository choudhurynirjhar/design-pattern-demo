using Weather.Forecast;

namespace ProxyPattern.Demo;

public class WeatherProviderProxy : IWeatherProvider
{
    private readonly IWeatherProvider weatherProvider;

    public WeatherProviderProxy(IWeatherProvider weatherProvider)
    {
        this.weatherProvider = weatherProvider;
    }

    public IEnumerable<WeatherForecast> Get(int totalCount)
    {
        if (totalCount < 2 || totalCount > 5)
            throw new ArgumentOutOfRangeException("totalCount", "Total count should be between two and five");
        return weatherProvider.Get(totalCount);
    }
}
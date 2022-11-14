namespace Weather.Forecast;

public interface IWeatherProvider
{
    IEnumerable<WeatherForecast> Get(int totalCount);
}
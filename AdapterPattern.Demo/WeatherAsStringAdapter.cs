namespace AdapterPattern.Demo;

internal interface IWeatherAsStringAdapter
{
    string Get();
}

internal class WeatherAsStringAdapter : IWeatherAsStringAdapter
{
    private readonly IWeatherForecastProvider weatherForecastProvider;

    public WeatherAsStringAdapter(IWeatherForecastProvider weatherForecastProvider)
    {
        this.weatherForecastProvider = weatherForecastProvider;
    }

    public string Get()
    {
        return string.Join(
            Environment.NewLine,
            weatherForecastProvider.Get().Select(w => $"{w.Date}|{w.TemperatureF}|{w.Summary}"));
    }
}
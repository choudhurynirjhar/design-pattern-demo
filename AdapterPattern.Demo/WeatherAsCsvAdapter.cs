using Csv;

namespace AdapterPattern.Demo;
internal interface IWeatherAsCsvAdapter
{
    string Get();
}

internal class WeatherAsCsvAdapter : IWeatherAsCsvAdapter
{
    private readonly IWeatherForecastProvider weatherForecastProvider;

    public WeatherAsCsvAdapter(IWeatherForecastProvider weatherForecastProvider)
    {
        this.weatherForecastProvider = weatherForecastProvider;
    }

    public string Get()
    {
        var headers = new[] { "Date", "Temp", "Summary" };
        var csv = weatherForecastProvider.Get().Select(w => new string[] { w.Date.ToString(), w.TemperatureF.ToString(), w.Summary });
        return CsvWriter.WriteToText(headers, csv);
    }

}
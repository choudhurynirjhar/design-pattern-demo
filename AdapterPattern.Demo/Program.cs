using AdapterPattern.Demo;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IWeatherForecastProvider, WeatherForecastProvider>();
builder.Services.AddSingleton<IWeatherAsStringAdapter, WeatherAsStringAdapter>();
builder.Services.AddSingleton<IWeatherAsCsvAdapter, WeatherAsCsvAdapter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/weatherforecast", ([FromServices] IWeatherAsCsvAdapter weatherAsCsvAdapter) =>
    weatherAsCsvAdapter.Get())
    .WithName("GetWeatherForecast");

app.Run();
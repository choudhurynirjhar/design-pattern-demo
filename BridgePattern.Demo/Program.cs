using BridgePattern.Demo;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<INotificationProcessor, TextNotificationProcessor>();
builder.Services.AddSingleton<INotificationSender, TextNotificationSender>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapPost("/notification", (INotificationProcessor notificationProcessor, [FromBody] string message) =>
{
    notificationProcessor.ProcessNotification(message);
    return Results.Ok();
})
.WithName("Notification");

app.Run();
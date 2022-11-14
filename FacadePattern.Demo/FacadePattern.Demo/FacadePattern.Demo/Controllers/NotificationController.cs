using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.Demo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class NotificationController : ControllerBase
{
    private readonly INotificationService notificationService;

    public NotificationController(INotificationService notificationService)
    {
        this.notificationService = notificationService;
    }

    // POST api/<NotificationController>
    [HttpPost]
    public async Task Post([FromBody] string message)
    {
        await notificationService.SendAsync(message);
    }
}
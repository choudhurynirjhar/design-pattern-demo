using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.Demo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PurchaseFacadeController : ControllerBase
{
    private readonly IInventoryService inventoryService;
    private readonly IPaymentService paymentService;
    private readonly INotificationService notificationService;

    public PurchaseFacadeController(IInventoryService inventoryService,
        IPaymentService paymentService,
        INotificationService notificationService)
    {
        this.inventoryService = inventoryService;
        this.paymentService = paymentService;
        this.notificationService = notificationService;
    }

    // POST api/<PurchaseFacadeController>
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] string item, [FromBody] double amount)
    {
        var inventories = await inventoryService.GetAsync();
        if (inventories.Any(i => i == item)) return BadRequest();

        await paymentService.PayAsync(amount, item);

        await notificationService.SendAsync($"Item: {item} purchased with amount: {amount}");

        return Ok();
    }
}
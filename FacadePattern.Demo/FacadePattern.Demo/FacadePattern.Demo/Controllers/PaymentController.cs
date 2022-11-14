using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.Demo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PaymentController : ControllerBase
{
    private readonly IPaymentService paymentService;

    public PaymentController(IPaymentService paymentService)
    {
        this.paymentService = paymentService;
    }

    // POST api/<PaymentController>
    [HttpPost]
    public async Task Post([FromBody] string item, [FromBody] double amount)
    {
        await paymentService.PayAsync(amount, item);
    }
}
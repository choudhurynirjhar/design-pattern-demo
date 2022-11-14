using Microsoft.AspNetCore.Mvc;

namespace FacadePattern.Demo.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InventoryController : ControllerBase
{
    // GET: api/<InventoryController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }
}
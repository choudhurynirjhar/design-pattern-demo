using Microsoft.AspNetCore.Mvc;

namespace PrototypePattern.Demo.Controllers;
[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUser user;

    public UserController(IUser user)
    {
        this.user = user.Clone() as IUser;
    }

    [HttpGet]
    public IUser Get() => user;
}
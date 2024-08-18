using Microsoft.AspNetCore.Mvc;

namespace PayMart.API.Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        return Ok("Ola");
    }
}

using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Clients.UseCases.GetAll;

namespace PayMart.API.Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll(
        [FromServices] IGetAllClientUseCase useCase)
    {
        try
        {
            var response = await useCase.Execute();
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
        
    }
}

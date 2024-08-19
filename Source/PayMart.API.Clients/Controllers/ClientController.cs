using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Clients.UseCases.GetAll;
using PayMart.Application.Clients.UseCases.GetID;

namespace PayMart.API.Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpGet("getAll")]
    public async Task<IActionResult> GetAll(
        [FromServices] IGetAllClientUseCase useCase)
    {
        var response = await useCase.Execute();
        return Ok(response);
    }

    [HttpGet("getID/{id}")]
    public async Task<IActionResult> GetID(int id,
    [FromServices] IGetIDClientUseCase useCase)
    {
        var response = await useCase.Execute(id);
        return Ok(response);
    }
}

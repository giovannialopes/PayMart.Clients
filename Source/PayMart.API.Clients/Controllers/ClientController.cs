using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Clients.UseCases.Delete;
using PayMart.Application.Clients.UseCases.GetAll;
using PayMart.Application.Clients.UseCases.GetID;
using PayMart.Application.Clients.UseCases.Post;
using PayMart.Application.Clients.UseCases.Update;
using PayMart.Domain.Clients.Request.Client;

namespace PayMart.API.Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetAll(
    [FromServices] IGetAllClientUseCase useCase)
    {
        var response = await useCase.Execute();
        return Ok(response);
    }

    [HttpGet]
    [Route("getID/{id}")]
    public async Task<IActionResult> GetID([FromRoute] int id,
    [FromServices] IGetIDClientUseCase useCase)
    {
        var response = await useCase.Execute(id);
        return Ok(response);
    }

    [HttpPost]
    [Route("post")]
    public async Task<IActionResult> Post(
    [FromServices] IPostClientUseCase useCase,
    [FromBody] RequestClient request)
    {
        var response = await useCase.Execute(request);
        return Ok(response);
    }

    [HttpPut]
    [Route("update/{id}")]
    public async Task<IActionResult> Update([FromRoute] int id,
    [FromServices] IUpdateClientUseCase useCase,
    [FromBody] RequestClient request)
    {
        var response = await useCase.Execute(request, id);
        return Ok(response);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> Delete([FromRoute] int id,
    [FromServices] IDeleteClientUseCase useCase)
    {
        await useCase.Execute(id);
        return Ok();
    }


}

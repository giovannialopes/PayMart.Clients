using Microsoft.AspNetCore.Mvc;
using PayMart.Application.Clients.UseCases.Delete;
using PayMart.Application.Clients.UseCases.GetAll;
using PayMart.Application.Clients.UseCases.GetID;
using PayMart.Application.Clients.UseCases.Post;
using PayMart.Application.Clients.UseCases.Update;
using PayMart.Domain.Clients.Model;

namespace PayMart.API.Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetAll(
        [FromServices] IGetAllClient services)
    {
        var response = await services.Execute();
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpGet]
    [Route("getID/{id}")]
    public async Task<IActionResult> GetID(
        [FromRoute] int id,
        [FromServices] IGetClientByID services)
    {
        var response = await services.Execute(id);
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpPost]
    [Route("post/{userID}")]
    public async Task<IActionResult> Post(
    [FromServices] IRegisterClient services,
        [FromBody] ModelClient.CreateClientRequest request)
    {
        var response = await services.Execute(request);
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpPut]
    [Route("update/{id}/{userID}")]
    public async Task<IActionResult> Update(
        [FromRoute] int id, int userID,
        [FromServices] IUpdateClient services,
        [FromBody] ModelClient.UpdateClientRequest request)
    {
        request.UpdatedBy = userID;
        var response = await services.Execute(request, id);
        if (response == null)
            return Ok("");

        return Ok(response);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> Delete(
        [FromRoute] int id,
        [FromServices] IDeleteClient services)
    {
        var response = await services.Execute(id);
        if (response == null)
            return Ok("");

        return Ok("Delete");

    }


}

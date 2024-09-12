using Microsoft.AspNetCore.Mvc;
using PayMart.Domain.Clients.Exception;
using PayMart.Domain.Clients.Model;
using PayMart.Domain.Clients.Services;

namespace PayMart.API.Clients.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClientController : ControllerBase
{
    [HttpGet]
    [Route("getAll")]
    public async Task<IActionResult> GetAll(
        [FromServices] IClientServices services)
    {
        var response = await services.GetClient();
        if (response == null)
            return Ok(ResourceExceptions.ERRO_NAO_POSSUI_CLIENT);

        return Ok(response);
    }

    [HttpGet]
    [Route("getID/{id}")]
    public async Task<IActionResult> GetID(
        [FromServices] IClientServices services,
        [FromRoute] int id)
    {
        var response = await services.GetClientById(id);
        if (response == null)
            return Ok(ResourceExceptions.ERRO_NAO_POSSUI_CLIENT);

        return Ok(response);
    }

    [HttpPost]
    [Route("post/{userId}")]
    public async Task<IActionResult> UpdateClient(
        [FromServices] IClientServices services,
        [FromRoute] int id,
        [FromRoute] int userID,
        [FromBody] ModelClient.CreateClientRequest request)
    {
        request.UserId = userID;
        var response = await services.RegisterClient(request);
        if (response == null)
            return Ok(ResourceExceptions.ERRO_NAO_POSSUI_CLIENT);

        return Ok(response);
    }


    [HttpPut]
    [Route("update/{id}/{userID}")]
    public async Task<IActionResult> UpdateClient(
        [FromServices] IClientServices services,
        [FromRoute] int id,
        [FromRoute] int userID,
        [FromBody] ModelClient.UpdateClientRequest request)
    {
        request.UpdatedBy = userID;
        var response = await services.UpdateClient(request, id);
        if (response == null)
            return Ok(ResourceExceptions.ERRO_NAO_POSSUI_CLIENT);

        return Ok(response);
    }

    [HttpDelete]
    [Route("delete/{id}")]
    public async Task<IActionResult> DeleteClient(
        [FromServices] IClientServices services,
        [FromRoute] int id)
    {
        var response = await services.DeleteClient(id);
        if (response == null)
            return Ok(ResourceExceptions.ERRO_NAO_POSSUI_CLIENT);

        return Ok(response);
    }


}

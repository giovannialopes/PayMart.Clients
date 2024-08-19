using PayMart.Domain.Clients.Request.Client;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Update;

public interface IUpdateClientUseCase
{
    Task<ResponseClient> Execute(RequestClient request, int id);
}

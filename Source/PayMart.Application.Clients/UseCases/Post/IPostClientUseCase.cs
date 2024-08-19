using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Request.Client;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Post;

public interface IPostClientUseCase
{
    Task<ResponseClient> Execute(RequestClient request);
}

using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.GetID;

public interface IGetIDClientUseCase
{
    Task<ResponseClient> Execute(int id);
}

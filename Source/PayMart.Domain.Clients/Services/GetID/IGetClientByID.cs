using PayMart.Domain.Clients.Model;

namespace PayMart.Application.Clients.UseCases.GetID;

public interface IGetClientByID
{
    Task<ModelClient.ClientResponse?> Execute(int id);
}

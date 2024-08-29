using PayMart.Domain.Clients.Model;

namespace PayMart.Application.Clients.UseCases.Update;

public interface IUpdateClient
{
    Task<ModelClient.ClientResponse?> Execute(ModelClient.UpdateClientRequest request, int id);
}

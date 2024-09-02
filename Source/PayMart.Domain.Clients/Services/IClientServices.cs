using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Model;

namespace PayMart.Domain.Clients.Services;

public interface IClientServices
{
    Task<ModelClient.ListClientResponse?> GetClient();

    Task<ModelClient.ClientResponse?> GetClientById(int id);

    Task<ModelClient.ClientResponse?> RegisterClient(ModelClient.CreateClientRequest request);

    Task<ModelClient.ClientResponse?> UpdateClient(ModelClient.UpdateClientRequest request, int id);

    Task<string?> DeleteClient(int id);
}

using PayMart.Domain.Clients.Model;

namespace PayMart.Application.Clients.UseCases.Post;

public interface IRegisterClient
{
    Task<ModelClient.ClientResponse?> Execute(ModelClient.CreateClientRequest request);
}

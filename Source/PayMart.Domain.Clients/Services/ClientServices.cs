using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Model;

namespace PayMart.Domain.Clients.Services;

public class ClientServices(IClientRepository clientRepository,
    IEmailRepository emailRepository,
    IMapper mapper) : IClientServices
{

    public async Task<ModelClient.ListClientResponse?> GetClient()
    {
        var response = await clientRepository.GetClients();
        if (response.Count != 0)
            return new ModelClient.ListClientResponse { Clients = mapper.Map<List<ModelClient.ClientResponse>>(response) };

        return default;
    }

    public async Task<ModelClient.ClientResponse?> GetClientById(int id)
    {
        var response = await clientRepository.GetClientByID(id);
        if (response != null)
        {
            return mapper.Map<ModelClient.ClientResponse>(response);
        }
        return default;
    }

    public async Task<ModelClient.ClientResponse?> RegisterClient(ModelClient.CreateClientRequest request)
    {
        var verifyEmail = await emailRepository.VerifyEmail(request.ContactEmail);
        if (verifyEmail == false)
        {
            var Client = mapper.Map<Client>(request);

            Client.CreatedBy = request.UserId;

            clientRepository.AddClient(Client);

            await clientRepository.Commit();

            return mapper.Map<ModelClient.ClientResponse>(Client);
        }
        return default;
    }

    public async Task<ModelClient.ClientResponse?> UpdateClient(ModelClient.UpdateClientRequest request, int id)
    {
        var Client = await clientRepository.GetClientByID(id);
        if (Client != null)
        {
            var response = mapper.Map(request, Client);
            response.UpdatedBy = response.UserId;
            response.UpdatedDate = DateTime.Now;

            clientRepository.UpdateClient(response!);

            await clientRepository.Commit();

            return mapper.Map<ModelClient.ClientResponse>(response);
        }
        return default;
    }

    public async Task<string?> DeleteClient(int id)
    {
        var Client = await clientRepository.GetClientByID(id);
        if (Client != null)
        {

            Client!.IsActive = false;
            Client!.DeleteBy = Client.UserId;
            Client!.DeleteDate = DateTime.Now;

            clientRepository.DeleteClient(Client!);
            await clientRepository.Commit();

            return "Deleted";
        }
        return default;
    }
}

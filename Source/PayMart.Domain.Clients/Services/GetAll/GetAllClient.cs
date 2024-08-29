using AutoMapper;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Model;


namespace PayMart.Application.Clients.UseCases.GetAll;

public class GetAllClient(IClientRepository clientRepository,
    IMapper mapper) : IGetAllClient
{
    public async Task<ModelClient.ListClientResponse?> Execute()
    {
        var response = await clientRepository.GetClients();
        if (response.Count != 0)
            return new ModelClient.ListClientResponse { Clients = mapper.Map<List< ModelClient.ClientResponse>> (response) };

        return default;
    }
}

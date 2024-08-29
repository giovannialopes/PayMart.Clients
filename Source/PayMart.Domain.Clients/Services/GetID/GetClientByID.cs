using AutoMapper;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Model;

namespace PayMart.Application.Clients.UseCases.GetID;

public class GetClientByID(IClientRepository clientRepository,
    IMapper mapper) : IGetClientByID
{
    public async Task<ModelClient.ClientResponse?> Execute(int id)
    {
        var response = await clientRepository.GetClientByID(id);
        if (response != null)
        {
            return mapper.Map<ModelClient.ClientResponse>(response);
        }
        return default;
    }
}

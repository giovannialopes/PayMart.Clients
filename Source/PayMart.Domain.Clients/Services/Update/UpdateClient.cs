using AutoMapper;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Model;

namespace PayMart.Application.Clients.UseCases.Update;

public class UpdateClient(IClientRepository clientRepository,
    IMapper mapper) : IUpdateClient
{
    public async Task<ModelClient.ClientResponse?> Execute(ModelClient.UpdateClientRequest request, int id)
    {
        var takeID = await clientRepository.GetClientByID(id);

        if (takeID != null)
        {
            var response = mapper.Map(request, takeID);
            response.UpdatedBy = response.UserId;
            response.UpdatedDate = DateTime.Now;    

            clientRepository.UpdateClient(response!);

            await clientRepository.Commit();

            return mapper.Map<ModelClient.ClientResponse>(response);
        }
        return default;
    }
}

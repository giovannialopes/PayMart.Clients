using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Repositories;

namespace PayMart.Application.Clients.UseCases.Delete;

public class DeleteClient(IClientRepository clientRepository,
    IMapper mapper) : IDeleteClient
{
    public async Task<Client?> Execute(int id)
    {
        var Client = await clientRepository.GetClientByID(id);

        if (Client != null) {

            Client!.IsActive = false;
            Client!.DeleteBy = Client.UserId;
            Client!.DeleteDate = DateTime.Now;

            clientRepository.DeleteClient(Client!);
            await clientRepository.Commit();

            return mapper.Map<Client>(Client);
        }

        return default;

    }
}

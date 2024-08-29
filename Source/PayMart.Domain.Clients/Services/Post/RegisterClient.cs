using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Model;

namespace PayMart.Application.Clients.UseCases.Post;

public class RegisterClient(IClientRepository clientRepository,
    IMapper mapper,
    IEmailRepository emailRepository) : IRegisterClient
{
    public async Task<ModelClient.ClientResponse?> Execute(ModelClient.CreateClientRequest request)
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
}



using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Repositories;

namespace PayMart.Application.Clients.UseCases.Delete;

public class DeleteClientUseCase : IDeleteClientUseCase
{
    private readonly IMapper _mapper;
    private readonly IClientRepository _clientRepository;

    public DeleteClientUseCase(IClientRepository clientRepository,
        IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<Client> Execute(int id)
    {
        var Client = await _clientRepository.GetByIDClient(id);

        if (Client != null) { 

            _clientRepository.DeleteClient(Client!);
            await _clientRepository.Commit();

            return _mapper.Map<Client>(Client);
        }

        return null;

    }
}

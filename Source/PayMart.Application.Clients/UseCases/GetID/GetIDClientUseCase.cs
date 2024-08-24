using AutoMapper;
using PayMart.Domain.Clients.Exception.ResourceExceptions;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.GetID;

public class GetIDClientUseCase : IGetIDClientUseCase
{
    private readonly IMapper _mapper;
    private readonly IClientRepository _clientRepository;

    public GetIDClientUseCase(IClientRepository clientRepository,
        IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<ResponseClient> Execute(int id)
    {
        var response = await _clientRepository.GetByIDClient(id);
        if (response != null)
        {
            return _mapper.Map<ResponseClient>(response);
        }
        return null;

    }
}

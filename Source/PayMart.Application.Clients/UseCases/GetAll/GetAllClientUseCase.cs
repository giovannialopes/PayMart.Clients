using AutoMapper;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Response.Client;
using PayMart.Domain.Clients.Response.ListOfClient;


namespace PayMart.Application.Clients.UseCases.GetAll;

public class GetAllClientUseCase : IGetAllClientUseCase
{
    private readonly IMapper _mapper;
    private readonly IClientRepository _clientRepository;

    public GetAllClientUseCase(IClientRepository clientRepository,
        IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<ResponseList> Execute()
    {
        var response = await _clientRepository.GetClients();
        if (response.Count != 0)
        {
            return new ResponseList
            {
                Clients = _mapper.Map<List<ResponseClient>>(response)
            };
        }
        return null;
    }
}

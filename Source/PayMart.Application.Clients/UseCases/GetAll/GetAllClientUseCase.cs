using AutoMapper;
using PayMart.Communication.Clients.Response.GetAll;
using PayMart.Domain.Clients.Interfaces.Clients.GetAll;


namespace PayMart.Application.Clients.UseCases.GetAll;

public class GetAllClientUseCase : IGetAllClientUseCase
{
    private readonly IGetAll _clientRepository;
    private readonly IMapper _iMapper;
    public GetAllClientUseCase(IGetAll clientRepository,
        IMapper mapper)
    {
        _clientRepository = clientRepository;
        _iMapper = mapper;
    }

    public async Task<ResponseGetAllClient> Execute()
    {
        var response = await _clientRepository.GetAll();

        return new ResponseGetAllClient
        {
            Clients = _iMapper.Map<List<ResponseListGetAllClient>>(response)
        };
    }
}

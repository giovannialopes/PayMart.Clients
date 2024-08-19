using AutoMapper;
using PayMart.Domain.Clients.Interfaces.Clients.GetAll;
using PayMart.Domain.Clients.Response.Client;
using PayMart.Domain.Clients.Response.ListOfClient;


namespace PayMart.Application.Clients.UseCases.GetAll;

public class GetAllClientUseCase : IGetAllClientUseCase
{
    private readonly IGetAll _getAll;
    private readonly IMapper _mapper;
    public GetAllClientUseCase(IGetAll getAll,
        IMapper mapper)
    {
        _getAll = getAll;
        _mapper = mapper;
    }

    public async Task<ResponseList> Execute()
    {
        var response = await _getAll.GetAll();

        return new ResponseList
        {
            Clients = _mapper.Map<List<ResponseClient>>(response)
        };
    }
}

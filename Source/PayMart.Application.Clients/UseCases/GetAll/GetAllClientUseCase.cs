using AutoMapper;
using PayMart.Communication.Clients.Response.GetAll;
using PayMart.Communication.Clients.Response.ListOfClient;
using PayMart.Domain.Clients.Interfaces.Clients.GetAll;


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

    public async Task<ResponseGetAll> Execute()
    {
        var response = await _getAll.GetAll();

        return new ResponseGetAll
        {
            Clients = _mapper.Map<List<ResponseListClient>>(response)
        };
    }
}

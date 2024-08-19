using AutoMapper;
using PayMart.Domain.Clients.Interfaces.Clients.GetID;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.GetID;

public class GetIDClientUseCase : IGetIDClientUseCase
{
    private readonly IGetID _getID;
    private readonly IMapper _mapper;

    public GetIDClientUseCase(IGetID getID,
        IMapper mapper)
    {
        _getID = getID;
        _mapper = mapper;
    }

    public async Task<ResponseClient> Execute(int id)
    {
        var response = await _getID.GetID(id);

        return _mapper.Map<ResponseClient>(response);
    }
}

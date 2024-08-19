using AutoMapper;
using Azure;
using PayMart.Domain.Clients.Interfaces.Clients.Update;
using PayMart.Domain.Clients.Interfaces.DbFunctions;
using PayMart.Domain.Clients.Request.Client;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Update;

public class UpdateClientUseCase : IUpdateClientUseCase
{
    private readonly IUpdate _update;
    private readonly ICommit _commit;
    private readonly IMapper _mapper;

    public UpdateClientUseCase(IUpdate update,
        ICommit commit,
        IMapper mapper)
    {
        _update = update;
        _commit = commit;
        _mapper = mapper;
    }

    public async Task<ResponseClient> Execute(RequestClient request, int id)
    {
        var takeID =  await _update.GetIDUpdate(id);

        var response = _mapper.Map(request, takeID);

        _update.Update(takeID);

        await _commit.Commit();

        return _mapper.Map<ResponseClient>(response);
    }
}

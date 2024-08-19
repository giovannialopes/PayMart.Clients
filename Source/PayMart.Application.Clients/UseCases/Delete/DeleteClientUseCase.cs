using AutoMapper;
using PayMart.Domain.Clients.Interfaces.Clients.Delete;
using PayMart.Domain.Clients.Interfaces.DbFunctions;

namespace PayMart.Application.Clients.UseCases.Delete;

public class DeleteClientUseCase : IDeleteClientUseCase
{
    private readonly IDelete _delete;
    private readonly ICommit _commit;
    private readonly IMapper _mapper;

    public DeleteClientUseCase(IDelete delete,
        ICommit commit,
        IMapper mapper)
    {
        _delete = delete;
        _commit = commit;
        _mapper = mapper;
    }

    public async Task Execute(int id)
    {
         await _delete.Delete(id);

        await _commit.Commit();
    }
}

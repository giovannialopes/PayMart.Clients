using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Clients.Post;
using PayMart.Domain.Clients.Interfaces.DbFunctions;
using PayMart.Domain.Clients.Request.Client;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Post;

public class PostClientUseCase : IPostClientUseCase
{
    private readonly IPost _post;
    private readonly IMapper _mapper;
    private readonly ICommit _commit;
    public PostClientUseCase(IPost post,
        IMapper mapper,
        ICommit commit)
    {
        _post = post;
        _mapper = mapper;
        _commit = commit;
    }

    public async Task<ResponseClient> Execute(RequestClient request)
    {
        var Client = _mapper.Map<Client>(request);

        await _post.AddClient(Client);

        await _commit.Commit();

        return _mapper.Map<ResponseClient>(Client);
    }
}

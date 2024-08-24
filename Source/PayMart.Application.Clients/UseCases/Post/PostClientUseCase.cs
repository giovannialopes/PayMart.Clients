using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Exception.ResourceExceptions;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Request.Client;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Post;

public class PostClientUseCase : IPostClientUseCase
{
    private readonly IMapper _mapper;
    private readonly IClientRepository _clientRepository;
    private readonly IEmailRepository _emailRepository;

    public PostClientUseCase(IClientRepository clientRepository,
        IMapper mapper,
        IEmailRepository emailRepository)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
        _emailRepository = emailRepository;
    }

    public async Task<ResponseClient> Execute(RequestClient request)
    {
        var verifyEmail = await _emailRepository.VerifyEmail(request.Email);

        if (verifyEmail == false) {

            var Client = _mapper.Map<Client>(request);

            _clientRepository.AddClient(Client);

            await _clientRepository.Commit();

            return _mapper.Map<ResponseClient>(Client);
        }
        return null;
    }
}

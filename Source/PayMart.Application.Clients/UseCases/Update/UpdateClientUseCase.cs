using AutoMapper;
using Azure;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Domain.Clients.Request.Client;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Update;

public class UpdateClientUseCase : IUpdateClientUseCase
{
    private readonly IMapper _mapper;
    private readonly IClientRepository _clientRepository;

    public UpdateClientUseCase(IClientRepository clientRepository,
        IMapper mapper)
    {
        _clientRepository = clientRepository;
        _mapper = mapper;
    }

    public async Task<ResponseClient> Execute(RequestClient request, int id)
    {
        var takeID = await _clientRepository.GetByIDClient(id);

        if (takeID != null)
        {
            var response = _mapper.Map(request, takeID);

            _clientRepository.UpdateClient(response!);

            await _clientRepository.Commit();

            return _mapper.Map<ResponseClient>(response);
        }
        return null;


    }
}

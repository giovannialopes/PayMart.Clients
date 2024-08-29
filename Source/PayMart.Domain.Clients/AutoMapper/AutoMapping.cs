using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Model;

namespace PayMart.Domain.Clients.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        EntityToResponse();
        RequestoToEntity();
    }


    private void RequestoToEntity()
    {
        CreateMap<ModelClient.CreateClientRequest, Client>();
        CreateMap<ModelClient.UpdateClientRequest, Client>();
    }

    private void EntityToResponse()
    {
        CreateMap<Client, ModelClient.ListClientResponse>();
        CreateMap<string, ModelClient.ListClientResponse>();

        CreateMap<Client, ModelClient.ClientResponse>();
        CreateMap<string, ModelClient.ClientResponse>();
    }
}



using AutoMapper;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Request.Client;
using PayMart.Domain.Clients.Response.Client;
using PayMart.Domain.Clients.Response.ListOfClient;

namespace PayMart.Application.Clients.AutoMapper;

public class AutoMapping : Profile
{
    public AutoMapping()
    {
        EntityToResponse();
        RequestoToEntity();
    }


    private void RequestoToEntity()
    {
        CreateMap<RequestClient, Client>();
    }

    private void EntityToResponse()
    {
        CreateMap<Client, ResponseList>();
        CreateMap<string, ResponseList>();

        CreateMap<Client, ResponseClient>();
        CreateMap<string, ResponseClient>();
    }
}



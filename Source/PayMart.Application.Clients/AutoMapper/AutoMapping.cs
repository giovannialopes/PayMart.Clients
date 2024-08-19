using AutoMapper;
using PayMart.Communication.Clients.Response.GetAll;
using PayMart.Communication.Clients.Response.ListOfClient;
using PayMart.Domain.Clients.Entities;

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
    }

    private void EntityToResponse()
    {
        CreateMap<Client, ResponseGetAll>();
        CreateMap<Client, ResponseListClient>();
    }
}



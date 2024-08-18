using AutoMapper;
using PayMart.Communication.Clients.Response.GetAll;
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
        CreateMap<Client, ResponseGetAllClient>();
        CreateMap<Client, ResponseListGetAllClient>();
    }
}



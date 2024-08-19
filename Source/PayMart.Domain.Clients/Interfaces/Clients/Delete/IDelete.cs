using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Domain.Clients.Interfaces.Clients.Delete;

public interface IDelete
{
    Task Delete(int id);
}

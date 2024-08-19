using PayMart.Domain.Clients.Entities;

namespace PayMart.Domain.Clients.Interfaces.Clients.GetID;

public interface IGetID
{
    Task<Client> GetID(int id);
}

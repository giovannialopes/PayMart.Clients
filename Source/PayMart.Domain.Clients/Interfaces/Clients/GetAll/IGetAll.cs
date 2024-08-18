using PayMart.Domain.Clients.Entities;

namespace PayMart.Domain.Clients.Interfaces.Clients.GetAll;

public interface IGetAll
{
    Task<List<Client>> GetAll();
}

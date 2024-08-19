using PayMart.Domain.Clients.Entities;

namespace PayMart.Domain.Clients.Interfaces.Clients.Update;

public interface IUpdate
{
    Task<Client> GetIDUpdate(int id);

    void Update(Client client);

}

using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.DbFunctions;

namespace PayMart.Domain.Clients.Interfaces.Repositories;

public interface IClientRepository : ICommit
{
    public Task<List<Client>> GetClients();
    public Task<Client?> GetByIDClient(int id);
    public void AddClient(Client client);
    public void UpdateClient(Client client);
    public void DeleteClient(Client client);

}

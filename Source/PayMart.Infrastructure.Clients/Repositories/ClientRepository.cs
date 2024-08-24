using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Infrastructure.Clients.DataAcess;

namespace PayMart.Infrastructure.Clients.Repository;

public class ClientRepository : IClientRepository

{
    private readonly DbClient _dbClient;
    public ClientRepository(DbClient dbClient) => _dbClient = dbClient;
    public async Task Commit() => await _dbClient.SaveChangesAsync();

    public async Task<List<Client>> GetClients() =>  await _dbClient.Tb_Client.AsNoTracking().Where(config => config.Enabled == 1).ToListAsync();

    public async Task<Client?> GetByIDClient(int id) => await _dbClient.Tb_Client.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id && config.Enabled == 1);

    public void AddClient(Client client) => _dbClient.Tb_Client.AddAsync(client);

    public void UpdateClient(Client client) => _dbClient.Tb_Client.Update(client);

    public void DeleteClient(Client client) => _dbClient.Tb_Client.Remove(client);

}

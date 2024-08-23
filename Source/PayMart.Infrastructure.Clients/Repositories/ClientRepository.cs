using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Clients.Delete;
using PayMart.Domain.Clients.Interfaces.Clients.GetAll;
using PayMart.Domain.Clients.Interfaces.Clients.GetID;
using PayMart.Domain.Clients.Interfaces.Clients.Post;
using PayMart.Domain.Clients.Interfaces.Clients.Update;
using PayMart.Domain.Clients.Interfaces.DbFunctions;
using PayMart.Domain.Clients.Request.Client;
using PayMart.Infrastructure.Clients.DataAcess;

namespace PayMart.Infrastructure.Clients.Repository;

public class ClientRepository :
    ICommit,
    IGetAll,
    IGetID,
    IPost,
    IUpdate,
    IDelete
{
    private readonly DbClient _dbClient;
    public ClientRepository(DbClient dbClient)
    {
        _dbClient = dbClient;
    }

    public async Task Commit() => await _dbClient.SaveChangesAsync();

    public async Task<List<Client>> GetAll() => await _dbClient.Tb_Client.AsNoTracking().ToListAsync();
    public async Task<Client?> GetID(int id) => await _dbClient.Tb_Client.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id);
    public async Task AddClient(Client client) => await _dbClient.Tb_Client.AddAsync(client);
    public async Task<Client?> GetIDUpdate(int id) => await _dbClient.Tb_Client.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id);
    public void Update(Client client) => _dbClient.Tb_Client.Update(client);

    public async Task Delete(int id)
    {
        var result = await _dbClient.Tb_Client.AsNoTracking().FirstOrDefaultAsync(config => config.Id == id && config.Enabled == 1);
        if (result != null)
        {
            result.Enabled = 0;
            _dbClient.Tb_Client.Update(result);
        }
               
    }

}

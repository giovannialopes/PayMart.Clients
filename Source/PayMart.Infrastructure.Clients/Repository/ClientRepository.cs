using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Clients.GetAll;
using PayMart.Domain.Clients.Interfaces.Clients.GetID;
using PayMart.Domain.Clients.Interfaces.DbFunctions;
using PayMart.Infrastructure.Clients.DataAcess;

namespace PayMart.Infrastructure.Clients.Repository;

public class ClientRepository :
    ICommit,
    IGetAll,
    IGetID
{
    private readonly DbClient _dbClient;
    public ClientRepository(DbClient dbClient)
    {
        _dbClient = dbClient;
    }

    public async Task Commit()
    {
        await _dbClient.SaveChangesAsync();
    }

    public async Task<List<Client>> GetAll()
    {
        return await _dbClient.Tb_Client.AsNoTracking().ToListAsync();
    }

    public async Task<Client?> GetID(int id)
    {
        return await _dbClient.Tb_Client.AsNoTracking().FirstOrDefaultAsync(config => config.ID == id);
    }
}

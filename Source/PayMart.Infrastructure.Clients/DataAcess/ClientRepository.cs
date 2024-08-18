using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Interfaces.Clients.GetAll;
using PayMart.Domain.Clients.Interfaces.DbFunctions;

namespace PayMart.Infrastructure.Clients.DataAcess;

public class ClientRepository : 
    ICommit,
    IGetAll
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
}

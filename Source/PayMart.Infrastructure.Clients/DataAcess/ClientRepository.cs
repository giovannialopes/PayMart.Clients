using PayMart.Domain.Clients.Interfaces.DbFunctions;

namespace PayMart.Infrastructure.Clients.DataAcess;

public class ClientRepository : ICommit
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
}

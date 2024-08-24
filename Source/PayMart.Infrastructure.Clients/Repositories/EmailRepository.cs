using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Infrastructure.Clients.DataAcess;

namespace PayMart.Infrastructure.Clients.Repositories;

public class EmailRepository : IEmailRepository
{
    private readonly DbClient _dbClient;
    public EmailRepository(DbClient dbClient) => _dbClient = dbClient;

    public async Task Commit() => await _dbClient.SaveChangesAsync();

    public async Task<bool?> VerifyEmail(string email) => await _dbClient.Tb_Client.AsNoTracking()
        .AnyAsync(config => config.Email == email);
}

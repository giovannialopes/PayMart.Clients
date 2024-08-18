using Microsoft.EntityFrameworkCore;
using PayMart.Domain.Clients.Entities;

namespace PayMart.Infrastructure.Clients.DataAcess;

public class DbClient : DbContext
{
    public DbClient(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Client> Tb_Client { get; set; }
}


using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Domain.Clients.Interfaces.DbFunctions;
using PayMart.Infrastructure.Clients.DataAcess;

namespace PayMart.Infrastructure.Clients.Injection;

public static class DependencyInjection
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
    }

    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICommit, ClientRepository>();

        var connectionString = configuration.GetConnectionString("Connection");
        services.AddDbContext<DbClient>(config => config.UseSqlServer(connectionString));
    }
}

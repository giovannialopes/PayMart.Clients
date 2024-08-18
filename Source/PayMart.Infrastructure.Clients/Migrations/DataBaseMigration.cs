using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Infrastructure.Clients.DataAcess;

namespace PayMart.Infrastructure.Clients.Migrations;

public class DataBaseMigration
{
    public async static Task MigrateDataBase(IServiceProvider serviceProvider)
    {
        var dbcontext = serviceProvider.GetRequiredService<DbClient>();

        await dbcontext.Database.MigrateAsync();

    }
}

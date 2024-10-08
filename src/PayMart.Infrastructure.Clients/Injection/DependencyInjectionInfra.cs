﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Domain.Clients.Interfaces.DbFunctions;
using PayMart.Domain.Clients.Interfaces.Repositories;
using PayMart.Infrastructure.Clients.DataAcess;
using PayMart.Infrastructure.Clients.Repositories;
using PayMart.Infrastructure.Clients.Repository;

namespace PayMart.Infrastructure.Clients.Injection;

public static class DependencyInjectionInfra
{
    public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        AddDbContext(services, configuration);
        AddRepositories(services);
    }

    private static void AddRepositories(IServiceCollection services)
    {
        services.AddScoped<IClientRepository, ClientRepository>();
        services.AddScoped<IEmailRepository, EmailRepository>();
    }

    private static void AddDbContext(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICommit, ClientRepository>();

        var connectionString = configuration.GetConnectionString("Connection");
        services.AddDbContext<DbClient>(config => config.UseSqlServer(connectionString));
    }
}

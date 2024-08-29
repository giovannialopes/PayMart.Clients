using Microsoft.Extensions.DependencyInjection;
using PayMart.Domain.Clients.AutoMapper;
using PayMart.Application.Clients.UseCases.Delete;
using PayMart.Application.Clients.UseCases.GetAll;
using PayMart.Application.Clients.UseCases.GetID;
using PayMart.Application.Clients.UseCases.Post;
using PayMart.Application.Clients.UseCases.Update;

namespace PayMart.Domain.Clients.Services.AInjection;

public static class DependencyInjectionServices
{
    public static void AddServices(this IServiceCollection services)
    {
        AddRepositories(services);
        AddAutoMapper(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddRepositories(IServiceCollection services)
    {
        ///Metodos Padrões
        services.AddScoped<IGetAllClient, GetAllClient>();
        services.AddScoped<IGetClientByID, GetClientByID>();
        services.AddScoped<IRegisterClient, RegisterClient>();
        services.AddScoped<IUpdateClient, UpdateClient>();
        services.AddScoped<IDeleteClient, DeleteClient>();
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PayMart.Application.Clients.AutoMapper;
using PayMart.Application.Clients.UseCases.Delete;
using PayMart.Application.Clients.UseCases.GetAll;
using PayMart.Application.Clients.UseCases.GetID;
using PayMart.Application.Clients.UseCases.Post;
using PayMart.Application.Clients.UseCases.Update;
using PayMart.Domain.Clients.Interfaces.DbFunctions;
using PayMart.Infrastructure.Clients.DataAcess;

namespace PayMart.Application.Clients.Injection;

public static class DependencyInjectionApp
{
    public static void AddApplication(this IServiceCollection services)
    {
        AddUseCases(services);
        AddAutoMapper(services);
    }

    private static void AddAutoMapper(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(AutoMapping));
    }

    private static void AddUseCases(IServiceCollection services)
    {
        ///Metodos Padrões
        services.AddScoped<IGetAllClientUseCase, GetAllClientUseCase>();
        services.AddScoped<IGetIDClientUseCase, GetIDClientUseCase>();
        services.AddScoped<IPostClientUseCase, PostClientUseCase>();
        services.AddScoped<IUpdateClientUseCase, UpdateClientUseCase>();
        services.AddScoped<IDeleteClientUseCase, DeleteClientUseCase>();
    }
}

using Microsoft.Extensions.DependencyInjection;
using PayMart.Domain.Clients.AutoMapper;

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
        services.AddScoped<IClientServices, ClientServices>();
    }
}

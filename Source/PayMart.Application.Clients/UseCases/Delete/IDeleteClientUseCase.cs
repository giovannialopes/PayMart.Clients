using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Delete;

public interface IDeleteClientUseCase
{
    Task Execute(int id);
}

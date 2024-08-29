using PayMart.Domain.Clients.Entities;

namespace PayMart.Application.Clients.UseCases.Delete;

public interface IDeleteClient
{
    Task<Client?> Execute(int id);
}

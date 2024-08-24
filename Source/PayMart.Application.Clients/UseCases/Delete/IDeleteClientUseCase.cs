using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Response.Client;

namespace PayMart.Application.Clients.UseCases.Delete;

public interface IDeleteClientUseCase
{
    Task<Client> Execute(int id);
}

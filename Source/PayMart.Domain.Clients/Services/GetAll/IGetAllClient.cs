using PayMart.Domain.Clients.Model;

namespace PayMart.Application.Clients.UseCases.GetAll;

public interface IGetAllClient
{
    Task<ModelClient.ListClientResponse?> Execute();

}

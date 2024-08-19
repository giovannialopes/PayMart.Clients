using PayMart.Communication.Clients.Response.ListOfClient;

namespace PayMart.Application.Clients.UseCases.GetID;

public interface IGetIDClientUseCase
{
    Task<ResponseListClient> Execute(int id);
}

using PayMart.Domain.Clients.Response.ListOfClient;

namespace PayMart.Application.Clients.UseCases.GetAll;

public interface IGetAllClientUseCase
{
    Task<ResponseList> Execute();

}

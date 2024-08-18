using PayMart.Communication.Clients.Response.GetAll;

namespace PayMart.Application.Clients.UseCases.GetAll;

public interface IGetAllClientUseCase
{
    Task<ResponseGetAllClient> Execute();
}

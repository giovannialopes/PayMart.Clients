using PayMart.Domain.Clients.Entities;
using PayMart.Domain.Clients.Request.Client;

namespace PayMart.Domain.Clients.Interfaces.Clients.Post;

public interface IPost
{
    Task AddClient(Client client);

}

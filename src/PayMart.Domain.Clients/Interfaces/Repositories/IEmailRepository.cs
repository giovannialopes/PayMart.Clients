namespace PayMart.Domain.Clients.Interfaces.Repositories;

public interface IEmailRepository 
{
    Task<bool?> VerifyEmail(string email);
}

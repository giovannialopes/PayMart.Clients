using System.Text.Json.Serialization;

namespace PayMart.Domain.Clients.Request.Client;

public class RequestClient
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public int Age { get; set; }
    public string Address { get; set; } = "";
    public int UserID { get; set; }
}

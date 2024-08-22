using System.Text.Json.Serialization;

namespace PayMart.Domain.Clients.Entities;

public class Client
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public int Age { get; set; } 
    public string Address { get; set; } = "";


    public int UserID { get; set; }
    [JsonIgnore]
    public int Enabled { get; set; } = 1;
}

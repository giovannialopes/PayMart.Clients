using System.Text.Json.Serialization;

namespace PayMart.Domain.Clients.Entities;

public class Client
{
    public int Id { get; set; }
    public int UserId { get; set; } 
    public string FullName { get; set; } = string.Empty;
    public string ContactEmail { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public int Age { get; set; }
    public string Address { get; set; } = string.Empty;
    public bool IsActive { get; set; } = true;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeleteDate { get; set; }
    public int CreatedBy { get; set; }
    public int UpdatedBy { get; set; }
    public int DeleteBy { get; set; }
}

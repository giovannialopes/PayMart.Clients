using System.Text.Json.Serialization;

namespace PayMart.Domain.Clients.Model;

public class ModelClient
{
    public class CreateClientRequest
    {

        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
    }

    public class UpdateClientRequest
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;

        [JsonIgnore]
        public int UpdatedBy { get; set; }

        [JsonIgnore]
        public bool IsActive { get; set; } = true;

    }

    public class ClientResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string ContactEmail { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Address { get; set; } = string.Empty;
        public bool IsActive { get; set; }
    }

    public class ListClientResponse
    {
        public List<ClientResponse> Clients { get; set; } = [];
    }
}

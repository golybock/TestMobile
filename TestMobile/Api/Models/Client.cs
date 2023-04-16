using System.Text.Json.Serialization;

namespace TestMobile.Api.Models;

public partial class Client
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("login")]
    public string? Login { get; set; }
    [JsonPropertyName("email")]
    public string? Email { get; set; }
    [JsonPropertyName("phoneNumber")]
    public string? PhoneNumber { get; set; }
    [JsonPropertyName("token")]
    public string? Token { get; set; }
    [JsonPropertyName("photoUrl")]
    public string? PhotoUrl { get; set; }
    [JsonPropertyName("organization")]
    public string? Organization { get; set; }
    [JsonPropertyName("note")]
    public string? Note { get; set; }
}

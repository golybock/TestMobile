using System.Text.Json.Serialization;

namespace TestMobile.Api.Models;

public partial class Worker
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("firstName")] public string FirstName { get; set; } = null!;
    
    [JsonPropertyName("lastName")]
    public string LastName { get; set; } = null!;
    
    [JsonPropertyName("middleName")] public string? MiddleName { get; set; }
    public int? SubdivisionId { get; set; }

    public int? DivisionId { get; set; }

    public string? Code { get; set; }
}
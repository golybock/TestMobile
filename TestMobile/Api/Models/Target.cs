using System.Text.Json.Serialization;

namespace TestMobile.Api.Models;

public partial class Target
{
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; } = null!;
}

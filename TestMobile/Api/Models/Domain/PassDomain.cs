using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace TestMobile.Api.Models.Domain;

public class PassDomain
{
    [JsonPropertyName("pass")]
    public Pass Pass { get; set; } = new Pass();
    [JsonPropertyName("status")]
    public Status Status { get; set; } = new Status();
    [JsonPropertyName("worker")]
    public Worker Worker { get; set; } = new Worker();
    [JsonPropertyName("subdivision")]
    public Subdivision Subdivision { get; set; } = new Subdivision();
    [JsonPropertyName("passType")]
    public PassType PassType { get; set; } = new PassType();
    [JsonPropertyName("target")]
    public Target Target { get; set; } = new Target();
    [JsonPropertyName("clients")]
    public List<ClientDomain>? Clients { get; set; } = new List<ClientDomain>();
    [JsonPropertyName("client")]
    public ClientDomain? Client { get; set; }
    [JsonPropertyName("attachedFiles")]
    public List<string?> AttachedFiles { get; set; } = new List<string?>();
}
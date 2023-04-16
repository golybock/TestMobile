using System;
using System.Text.Json.Serialization;

namespace TestMobile.Api.Models;

public partial class Passport
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? MiddleName { get; set; }
    [JsonIgnore]
    public DateTime? DateOfBirth { get; set; }

    public int Serial { get; set; }

    public int Number { get; set; }
    [JsonIgnore]
    public virtual Client? IdNavigation { get; set; } = null!;
}

using TestMobile.Api.Models.Blank;

namespace TestMobile.Api.Models.Domain;

public class ClientDomain
{
    public Client? Client { get; set; } = new Client();
    public Passport? Passport { get; set; } = new Passport();
    public DateBlank BirthDate { get; set; } = new DateBlank();
}
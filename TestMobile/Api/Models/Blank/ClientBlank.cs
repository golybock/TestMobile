namespace TestMobile.Api.Models.Blank;

public class ClientBlank
{
    public Client Client { get; set; } = new Client();
    public Passport Passport { get; set; } = new Passport();
    public DateBlank BirthDate { get; set; } = new DateBlank();
}
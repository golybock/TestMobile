namespace TestMobile.Api.Models.Blank;

public class PassBlank
{
    public Pass Pass { get; set; } = new Pass();
    public ClientBlank? ClientBlank { get; set; }
}
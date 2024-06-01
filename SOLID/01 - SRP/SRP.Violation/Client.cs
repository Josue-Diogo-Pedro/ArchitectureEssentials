namespace SOLID.SRP.Violation;

public class Client
{
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Cpf { get; set; }
    public DateTime InsertDate { get; set; }

    public string AddClient()
    {
        if (!Email.Contains("@")) return "Client with invalid e-mail";

        if (Cpf.Length != 11) return "Client with invalid cpf";


        return "";
    }
}

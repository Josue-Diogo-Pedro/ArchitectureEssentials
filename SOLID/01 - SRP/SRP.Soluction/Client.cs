namespace SOLID.SRP.Soluction;

public class Client
{
    public int ClientId { get; set; }
    public string Name { get; set; }
    public Email Email { get; set; }
    public Cpf Cpf { get; set; }
    public DateTime InsertDate { get; set; }

    public bool Validate() => Email.Validate() && Cpf.Validate();
}

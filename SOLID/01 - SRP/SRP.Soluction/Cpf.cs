namespace SOLID.SRP.Soluction;

public class Cpf
{
    public string Number { get; set; }

    public bool Validate() => Number.Length == 11;
}

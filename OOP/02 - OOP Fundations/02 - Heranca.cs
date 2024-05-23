namespace OOP.Fundations;

public class Employe : People
{
    public DateTime AdmissionDate { get; set; }
    public string? Register { get; set; }
}

public class Process
{
    public void Execution()
    {
        Employe employe = new()
        {
            Name = "Josué Diogo Pedro",
            BornsDate = Convert.ToDateTime("2000/11/08"),
            AdmissionDate = DateTime.Now,
            Register = "0123456"
        };

        employe.CalculateAge();
    }

}

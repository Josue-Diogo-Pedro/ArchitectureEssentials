namespace OOP.Fundations;

public class People
{
    public string? Name { get; set; }
    public DateTime BornsDate { get; set; }

    public int CalculateAge()
    {
        var actualDate = DateTime.Now;
        var age = actualDate.Year - BornsDate.Year;

        if (actualDate < BornsDate.AddYears(age)) age--;

        return age;
    }
}

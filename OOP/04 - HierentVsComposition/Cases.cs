namespace OOP.Fundations;

#region Case1

public class FisicPeople : People
{
    public string Cpf { get; set; }
}

public class FisicPeople2
{
    public People People { get; set; }
    public string Cpf { get; set; }
}

public class TestHirientComposition
{
    public TestHirientComposition()
    {
        FisicPeople peopleHirient = new()
        {
            Name = "Josué",
            BornsDate = DateTime.Now,
            Cpf = "3214564334422"
        };

        FisicPeople2 peopleComposition = new()
        {
            People = new()
            {
                Name = "Josué",
                BornsDate = DateTime.Now
            },
            Cpf = "09872525252525"
        };

        var nameHirient = peopleHirient.Name;
        var nameComposition = peopleComposition.People.Name;
    }
}

#endregion


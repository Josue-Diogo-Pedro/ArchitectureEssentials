namespace OOP.HirientVsComposition;

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

#region Case2

public interface IRepository<T>
{
    void Add(T entity);
    void Remove(T entity);
}

public interface IPeopleRepository
{
    void Add(People people);
}

public class Repository<T> : IRepository<T>
{
    public void Add(T entity)
    {
        throw new NotImplementedException();
    }

    public void Remove(T entity)
    {
        throw new NotImplementedException();
    }
}

//Use hirient
public class RepositoryHirientPeople : Repository<People>, IPeopleRepository 
{
    
}

//Use composition
public class RepositoryCompositionPeople : IPeopleRepository
{
    private readonly IRepository<People> _repository;

    public RepositoryCompositionPeople(IRepository<People> repository)
    {
        _repository = repository;
    }

    public void Add(People people)
    {
        _repository.Add(people);
    }
}

public class TestHirientComposition2
{
    public TestHirientComposition2()
    {
        var repoH = new RepositoryHirientPeople();
        repoH.Add(new People());
        repoH.Remove(new People());

        var repoC = new RepositoryCompositionPeople(new Repository<People>());
        repoC.Add(new People());
    }
}

#endregion

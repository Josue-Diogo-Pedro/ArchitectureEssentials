namespace OOP.Fundations;

public interface IRepository 
{
    void Add();
}

public class Repository : IRepository
{
    public void Add()
    {
        //add item
    }
}

public class RepositoryFake : IRepository
{
    public void Add()
    {
        //add item
    }
}

public class UseImplementation 
{
    public void Process()
    {
        var repository = new Repository();
        repository.Add();
    }
}

public class UseAbstraction { }

public class TestInterfaceImplementation { }

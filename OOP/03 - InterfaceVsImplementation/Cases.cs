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

public class RepositoryFake { }

public class UseImplementation { }

public class UseAbstraction { }

public class TestInterfaceImplementation { }

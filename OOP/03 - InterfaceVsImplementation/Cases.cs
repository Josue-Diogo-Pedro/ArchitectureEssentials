﻿namespace OOP.InterfaceVsImplementation;

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

public class UseAbstraction 
{
    private readonly IRepository _repository;
    public UseAbstraction(IRepository repository) => _repository = repository;

    public void Proccess() => _repository.Add();
}

public class TestInterfaceImplementation 
{
    public TestInterfaceImplementation()
    {
        var repoImp = new UseImplementation();
        repoImp.Process();

        var repoAbs = new UseAbstraction(new Repository());
        repoAbs.Proccess();

        var repoAbsFake = new UseAbstraction(new RepositoryFake());
        repoAbsFake.Proccess();
    }
}

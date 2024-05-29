namespace OOP.Fundations;

public abstract class Eletrodomestics
{
    private readonly string _name;
    private readonly int _volt;

    protected Eletrodomestics(string name, int volt)
    {
        _name = name;
        _volt = volt;
    }

    public abstract void On();
    public abstract void Off();
    public virtual void Test()
    {
        //test of object
    }
}

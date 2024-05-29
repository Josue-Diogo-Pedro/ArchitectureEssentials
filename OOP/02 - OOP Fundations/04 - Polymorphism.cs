namespace OOP.Fundations;

public class Polymorphism : Eletrodomestics
{
    public Polymorphism(string name, int volt) : base(name, volt) { }

    public Polymorphism() : base("Default", 220){ }

    private static void HotWater() { }

    private static void MoerGraos() { }

    public override void Off()
    {
        throw new NotImplementedException();
    }

    public override void On()
    {
        throw new NotImplementedException();
    }
}

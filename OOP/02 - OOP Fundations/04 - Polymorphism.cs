namespace OOP.Fundations;

public class Polymorphism : Eletrodomestics
{
    public Polymorphism(string name, int volt) : base(name, volt) { }

    public Polymorphism() : base("Default", 220){ }

    private static void HotWater() { }

    private static void MoerGraos() { }

    public void PrepareCoffe()
    {
        Test();
        HotWater();
        MoerGraos();
    }

    public override void Test()
    {
        //test of coffer
    }

    public override void Off()
    {
        //Verify recipient of water
    }

    public override void On()
    {
        //unhot hotter
    }
}

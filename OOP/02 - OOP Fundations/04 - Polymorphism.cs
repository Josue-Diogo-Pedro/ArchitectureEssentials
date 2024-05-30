namespace OOP.Fundations;

public class ExpressCoffer : Eletrodomestics
{
    public ExpressCoffer(string name, int volt) : base(name, volt) { }

    public ExpressCoffer() : base("Default", 220){ }

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

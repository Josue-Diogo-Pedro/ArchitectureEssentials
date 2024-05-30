namespace OOP.Fundations;

public class AutomaticCoffer
{
    public void ServerCoffe()
    {
        ExpressCoffer express = new();
        express.On();
        express.PrepareCoffe();
        express.Off();
    }
}

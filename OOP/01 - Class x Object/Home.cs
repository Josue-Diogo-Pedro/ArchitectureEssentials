namespace OOP._01___Class_x_Object;

//Define class
public class Home
{
    public int TamanhoM2 { get; set; }
    public int Andares { get; set; }
    public decimal Price { get; set; }
    public int NumeroVagas { get; set; }
}

public class Object
{
    public Object() 
    {
        Home home = new()
        {
            TamanhoM2 = 100,
            Andares = 2,
            Price = 100000,
            NumeroVagas = 3
        };
    }
    
}

namespace SOLID.LSP.Solucao;

public class Shape : Paralelogram
{
    public Shape(int height, int width) : base(height, width)
    {
        if (height != width)
            throw new ArgumentException("The two sides of shape need to be equals");
    }
}

namespace SOLID.LSP.Solucao;

public abstract class Paralelogram
{
    public int Height { get; private set; }
    public int Width { get; private set; }
    public int Area { get => Height * Width; }

    protected Paralelogram(int height, int width)
    {
        Height = height;
        Width = width;
    }
}

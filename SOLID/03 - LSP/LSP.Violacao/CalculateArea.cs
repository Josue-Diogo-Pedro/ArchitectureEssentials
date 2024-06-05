namespace SOLID.LSP.Violacao;

public class CalculateArea
{
    private static double ObtainRectangleArea(Rectangle rect) => rect.Area;

    public static void Calculate()
    {
        var shape = new Shape
        {
            Height = 10,
            Width = 5,
        };

        var area = ObtainRectangleArea(shape);
    }
}

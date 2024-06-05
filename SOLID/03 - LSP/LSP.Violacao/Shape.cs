namespace SOLID.LSP.Violacao;

public class Shape : Rectangle
{
    public override double Height 
    { 
        set => base.Height = base.Width = value; 
    }

    public override double Width 
    {
        set => base.Height = base.Width = value; 
    }
}

﻿namespace SOLID.LSP.Violacao;

public class Rectangle
{
    public virtual double Height { get; set; }
    public virtual double Width { get; set; }

    public double Area { get => Height * Width; }
}

using TestLibrary.Interfaces;

namespace TestLibrary.Models;

public class Triangle : IFigure
{
    public double Square => Math.Sqrt(SemiPerimeter * (SemiPerimeter - A) * (SemiPerimeter - B) * (SemiPerimeter - C));

    public double A { get; init; }

    public double B { get; init; }

    public double C { get; init; }

    public double SemiPerimeter => (A + B + C) / 2;

    public bool IsRectangular => A * A + B * B == C * C;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0)
            throw new ArgumentOutOfRangeException(nameof(a), "Сторона A должна должна быть больше 0");
        if (b <= 0)
            throw new ArgumentOutOfRangeException(nameof(b), "Сторона B должна должна быть больше 0");
        if (c <= 0)
            throw new ArgumentOutOfRangeException(nameof(c), "Сторона C должна должна быть больше 0");

        A = a; 
        B = b;
        C = c;
    }
}

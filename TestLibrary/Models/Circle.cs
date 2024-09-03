using TestLibrary.Interfaces;

namespace TestLibrary.Models;

public record Circle : IFigure
{
    public double Square => Math.PI * Radius * Radius;

    public double Radius { get; init; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть больше 0");

        Radius = radius;
    }
}

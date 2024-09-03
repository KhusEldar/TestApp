using TestLibrary.Models;

namespace Tests;

public class TriangleTest
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 4, 5)]
    [InlineData(3, 4.2, 8)]
    public void Triangle(double a, double b, double c)
    {
        var triangle = new Triangle(a, b, c);

        Assert.Equal(triangle.A, a);
        Assert.Equal(triangle.B, b);
        Assert.Equal(triangle.C, c);
        Assert.Equal(triangle.Square, Math.Sqrt((a + b + c) / 2 * ((a + b + c) / 2 - a)
            * ((a + b + c) / 2 - b) * ((a + b + c) / 2 - c)));
    }

    [Theory]
    [InlineData(0, 1, 1)]
    [InlineData(-3, 2, 3)]
    public void WrongTriangle(double a, double b, double c)
    {
        Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(a, b, c));
    }
}
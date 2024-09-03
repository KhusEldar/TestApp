using TestLibrary.Models;

namespace Tests;

public class CircleTest
{
    [Theory]
    [InlineData(9)]
    [InlineData(7.2)]
    public void Circle(double radius)
    {
        var circle = new Circle(radius);

        Assert.Equal(circle.Radius, radius);
        Assert.Equal(circle.Square, (Math.PI * Math.Pow(radius, 2)));
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-3)]
    public void WrongCircle(double radius)
    {
       Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }
}
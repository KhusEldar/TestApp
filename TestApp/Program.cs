using TestLibrary.Models;

double radius = 2;
var circle = new Circle(radius);
Console.WriteLine($"Circe with radius = {radius} has square = {circle.Square}");


double a = 3;
double b = 4;
double c = 5;
var triangle = new Triangle(a, b, c);
Console.WriteLine($"Triangle with a = {a}, b = {b}, c = {c} has square = {triangle.Square}. IsRectangular = {triangle.IsRectangular}");

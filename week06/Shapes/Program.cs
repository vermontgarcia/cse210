using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes Project.");

        Square square = new(12, "Red");

        square.Color = "Green";
        square.Side = 23.67;

        Rectangle rectangle = new(10, 15, "Yellow");

        Circle circle = new(4.5, "Black");

        List<Shape> shapes = [square, rectangle, circle];

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.Color);
            Console.WriteLine(shape.GetArea());
        }
    }
}
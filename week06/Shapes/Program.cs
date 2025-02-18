using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes Project.");

        Square square = new(12, "Red");

        Console.WriteLine(square.Color);
        Console.WriteLine(square.GetArea());

        square.Color = "Green";
        square.Side = 23.67;

        Console.WriteLine(square.Color);
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new(10, 15, "Yellow");

        Console.WriteLine(rectangle.Color);
        Console.WriteLine(rectangle.Width);
        Console.WriteLine(rectangle.Length);
        Console.WriteLine(rectangle.GetArea());
    }
}
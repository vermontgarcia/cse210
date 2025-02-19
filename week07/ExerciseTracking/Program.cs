using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ExerciseTracking Project.");

        Running running = new(30, 5);

        Console.WriteLine(running.GetDistance());
        Console.WriteLine(running.GetSpeed());
        Console.WriteLine(running.GetPace());
        Console.WriteLine();
        Console.WriteLine(running.GetSummary());
        Console.WriteLine();

        Cycling cycling = new(23, 18.3);

        Console.WriteLine(cycling.GetDistance());
        Console.WriteLine(cycling.GetSpeed());
        Console.WriteLine(cycling.GetPace());
        Console.WriteLine();
        Console.WriteLine(cycling.GetSummary());
        Console.WriteLine();

        Swimming swimming = new(50, 42);

        Console.WriteLine(swimming.GetDistance());
        Console.WriteLine(swimming.GetSpeed());
        Console.WriteLine(swimming.GetPace());
        Console.WriteLine();
        Console.WriteLine(swimming.GetSummary());
        Console.WriteLine();

    }
}
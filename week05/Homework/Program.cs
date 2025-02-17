using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Homework Project.");
        Console.WriteLine();

        Assignment simpleAssignment = new("Mathew West", "Physics");
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment mathAssignment = new("9.23", "25 - 35", "George Bennet", "Vectorial Calculus");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomworkList());
        Console.WriteLine();

        WritingAssignment writingAssignment = new("The complexity of international relations between nations", "Abby Waters", "Foreign Relations");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();
    }
}

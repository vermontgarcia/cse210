using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements Adding a GoalConverter Class to handle JSON serialization and deserialization expoert and import
        DisplayWelcome();
        GoalManager goalManager = new();
        goalManager.Start();
    }

    static void DisplayWelcome()
    {
        ClearScreen();
        Console.WriteLine("Welcome to EternalQuest App!");
        Console.WriteLine();
    }

    static void ClearScreen()
    {
        Console.Clear();
    }
}

using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        GoalManager goalManager = new();
        goalManager.Start();

        // // goalManager.SaveGoals("goals.json");

        // goalManager.LoadGoals("goals.json");
        // goalManager.ListGoalDetails();
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

using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements showing to the user completed goals when registering event
        // Exceeding Requirements Updating score from goal instances Adding Goals count to Player info
        // Exceeding Requirements Handeling Exceptions when no valid option entered by user
        // Exceeding Requirements Saving to file on quit
        // Exceeding Requirements Importing from a JSON File
        // Exceeding Requirements Exporting to a JSON File
        // Exceeding Requirements Loading from file on starting
        // Exceeding Requirements Adding a property to keep trac of score
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

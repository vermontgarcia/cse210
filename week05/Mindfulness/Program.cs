using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Welcome to Mindfulness Project.");

        int choice = 0;

        do
        {
            try
            {
                DisplayMenu();
                choice = int.Parse(Console.ReadLine());
                Console.Clear();
            }
            catch (FormatException)
            {
                Console.Clear();
                choice = 0;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Breathing Activity");
                    break;
                case 2:
                    Console.WriteLine("Listing Activity");
                    break;
                case 3:
                    Console.WriteLine("Reflecting Activity");
                    break;
                case 9:
                    Console.WriteLine("Goodbye, comeback soon!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Please enter a valid option");
                    break;
            }
        } while (choice != 9);
    }

    // Function to display menu
    static void DisplayMenu()
    {

        string menu = @"
1. Breathing Activity.
2. Listing Activity.
3. Reflecting Activity.

9. Quit.
";

        Console.WriteLine(menu);
        Console.Write("What would you like to do? ");
    }

    // Function to get user input
    static string GetUserEntry(string prompt)
    {
        Console.Write($"{prompt} ");
        string userInput = Console.ReadLine();
        return userInput;
    }

}